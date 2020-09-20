using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BooksLab
{
    public class Book : IComparable<Book>, IEquatable<Book>
    {
        private string uniqueIsbn;
        private string author;
        private string publisher;
        private string title;
        private int pYear;
        private double price;

        public string ISBN
        {
            get { return this.uniqueIsbn; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Incorrect ISBN.");
                }

                //if (true)
                //{
                //    throw new Exception("Incorrect input.");
                //}

                this.uniqueIsbn = value;
            }
        }
        public string Author
        {
            get { return this.author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Incorrect input. Author.");
                }

                this.author = value;
            }
        }
        public string Publisher
        {
            get { return this.publisher; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Incorrect input.Publisher");
                }

                this.publisher = value;
            }
        }
        public string Title
        {
            get { return this.title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Incorrect input.Title.");
                }
                this.title = value;
            }
        }
        public int PublishYear
        {
            get { return this.pYear; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Incorrect input.Year.");
                }

                this.pYear = value;
            }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public Book(string BookISBN, string BookAuthor, string BookTitle, string BookPublisher,  int Year, double BookPrice)
        {
            ISBN = BookISBN;
            Author = BookAuthor;
            Publisher = BookPublisher;
            Title = BookTitle;
            PublishYear = Year;
            Price = BookPrice;
        }

        public int CompareTo(Book other)
        {
            if (this.Title.CompareTo(other.Title) != 0)
            {
                return this.Title.CompareTo(other.Title);
            }
            else
            {
                if (this.Author.CompareTo(other.Author) != 0)
                {
                    return this.Author.CompareTo(other.Author);
                }
            }
            return 0;
        }

        public bool Equals(Book other)
        {
            if (other == null)
                return false;

            double delta = 0.001;

            return (this.uniqueIsbn == other.uniqueIsbn && 
                this.Title == other.Title && 
                this.Author == this.Author && 
                this.Publisher == other.Publisher &&
                this.PublishYear == other.PublishYear &&
                this.Price < (other.Price + delta) && this.Price > (other.Price - delta));
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Book bookObj = obj as Book;
            if (bookObj == null)
                return false;
            else
                return Equals(bookObj);
        }

        public override string ToString()
        {
            return String.Format("Title: {0}, Author: {1}, Publish Date: {2}, Publisher: {3}, Price: {4}, ISBN: {5}",
                this.Title, this.Author, this.PublishYear, this.Publisher, this.Price, this.ISBN);
        }

        public override int GetHashCode()
        {
            return this.uniqueIsbn.GetHashCode();
        }
     }
}
