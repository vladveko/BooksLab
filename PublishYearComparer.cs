using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLab
{
    public class PublishYearCompaper : IComparer<Book>
    {
        int IComparer<Book>.Compare(Book x, Book y)
        {
            if (x.PublishYear < y.PublishYear)
            {
                return 1;
            }
            else
            {
                if (x.PublishYear > y.PublishYear)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
