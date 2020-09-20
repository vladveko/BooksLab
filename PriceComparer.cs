using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLab
{
    public class PriceComparer : IComparer<Book>
    {
        int IComparer<Book>.Compare(Book x, Book y)
        {
            if (x.Price > y.Price)
            {
                return 1;
            }
            else
            {
                if (x.Price < y.Price)
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
