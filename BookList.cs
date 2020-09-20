using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLab
{
    public class BookList
    {
        public List<Book> Books;
        

        public BookList()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new Exception("Impossible to add non-existing book.");
            }

            if (Books.Contains(book))
            {
                throw new Exception("This book already exists on the list.");
            }

            Books.Add(book);
        }

        public void RemoveBook(int index)
        {
            if (index < 0 || index > Books.Count)
            {
                throw new Exception("Impossible to remove non-existing book.");
            }

            Books.RemoveAt(index);
        }

        public void Sort(IComparer<Book> comparer)
        {
            Books.Sort(comparer);
        }
    }
}
