using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLab
{
    public class PublisherComparer : IComparer<Book>
    {
        int IComparer<Book>.Compare(Book x, Book y)
        {
            return String.Compare(x.Publisher, y.Publisher);
        }
    }
}
