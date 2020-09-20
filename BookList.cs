using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLab
{
    public class BookList
    {
        private class ISBNComparer : IComparer<Book>
        {
            int IComparer<Book>.Compare(Book x, Book y)
            {
                return String.Compare(x.ISBN, y.ISBN);
            }
        }

        private class AuthorComparer : IComparer<Book>
        {
            int IComparer<Book>.Compare(Book x, Book y)
            {
                return String.Compare(x.Author, y.Author);
            }
        }

        private class TitleComparer : IComparer<Book>
        {
            int IComparer<Book>.Compare(Book x, Book y)
            {
                return String.Compare(x.Title, y.Title);
            }
        }

        private class PublisherComparer : IComparer<Book>
        {
            int IComparer<Book>.Compare(Book x, Book y)
            {
                return String.Compare(x.Publisher, y.Publisher);
            }
        }

        private class PublishYearCompaper : IComparer<Book>
        {
            int IComparer<Book>.Compare(Book x, Book y)
            {
                if (x.PublishYear > y.PublishYear)
                {
                    return 1;
                }
                else
                {
                    if (x.PublishYear < y.PublishYear)
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

        private class PriceComparer : IComparer<Book>
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

        public static IComparer<Book> SortByISBN()
        {
            return (IComparer<Book>) new ISBNComparer();
        }

        public static IComparer<Book> SortByAuthor()
        {
            return (IComparer<Book>) new AuthorComparer();
        }

        public static IComparer<Book> SortByTitle()
        {
            return (IComparer<Book>) new TitleComparer();
        }

        public static IComparer<Book> SortByPublisher()
        {
            return (IComparer<Book>) new PublisherComparer();
        }

        public static IComparer<Book> SortByYear()
        {
            return (IComparer<Book>) new PublishYearCompaper();
        }

        public static IComparer<Book> SortByPrice()
        {
            return (IComparer<Book>) new PriceComparer();
        }

        public void Sort(IComparer<Book> comparer)
        {
            Books.Sort(comparer);
        }
    }
}
