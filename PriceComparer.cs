using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BooksLab
{
    public class PriceComparer : IComparer<Book>
    {
        int IComparer<Book>.Compare(Book x, Book y)
        {
            double first, second;
            NumberStyles style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            CultureInfo culture = CultureInfo.CurrentCulture;

            double.TryParse(x.Price, style, culture, out first);
            double.TryParse(y.Price, style, culture, out second);

            return (first > second) ? 1 : -1;
        }
    }
}
