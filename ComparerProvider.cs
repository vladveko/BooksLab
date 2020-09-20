using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLab
{
    public class ComparerProvider
    {
        private List<IComparer<Book>> comparers;

        public ComparerProvider()
        {
            this.comparers = new List<IComparer<Book>>()
            {
                new ISBNComparer(),
                new TitleComparer(),
                new AuthorComparer(),
                new PublishYearCompaper(),
                new PublisherComparer(),
                new PriceComparer()
            };
        }

        public IComparer<Book> GetComparer(int index)
        {
            return (IComparer<Book>)comparers[index];
        }
    }
}
