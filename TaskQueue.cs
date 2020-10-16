using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Concurrent;

namespace BooksLab
{
    public class TaskQueue
    {
        public delegate void TaskDelegate();

        private Thread[] tasks;

        private ConcurrentQueue<TaskDelegate> taskDelegates;

        private bool isRunning;
        public TaskQueue(int TasksCount)
        {
            this.tasks = new Thread[TasksCount];
            this.taskDelegates = new ConcurrentQueue<TaskDelegate>();
            this.isRunning = true;

            for (int i = 0; i < TasksCount; i++)
            {
                Thread newThread = new Thread(this.AwaitLoop);
                this.tasks[i] = newThread;
                newThread.Start();
            }

        }

        private void AwaitLoop()
        {
            SpinWait spinWait = new SpinWait();
            TaskDelegate task;
            while (this.isRunning)
            {
                if (taskDelegates.TryDequeue(out task))
                    task.Invoke();
                else
                    spinWait.SpinOnce();
            }
        }

        public void EnqueueTask(TaskDelegate task)
        {
            taskDelegates.Enqueue(task);
        }
    }
}
