using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BooksLab
{
    public static class FileManager
    {
        public static void SaveBookList(BookList list, string path)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                foreach (Book book in list.Books)
                {
                    SaveBook(book, writer);
                }
            }
        }

        public static BookList UploadBookList(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception("Incorrect file path.");
            }

            BookList newBookList = new BookList();

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    Book newBook = UploadBook(reader);
                    newBookList.AddBook(newBook);
                }
            }
            
            return newBookList;
        }

        private static void SaveBook (Book book, BinaryWriter writer)
        {
            if (book == null)
            {
                throw new Exception("Impossible to save non-existing book.");
            }

            writer.Write(book.ISBN);
            writer.Write(book.Author);
            writer.Write(book.Title);
            writer.Write(book.Publisher);
            writer.Write(book.PublishYear);
            writer.Write(book.Price);
        }

        private static Book UploadBook(BinaryReader reader)
        {
            string isbn = reader.ReadString();
            string author = reader.ReadString();
            string title = reader.ReadString();
            string publisher = reader.ReadString();
            int year = reader.ReadInt32();
            double price = reader.ReadDouble();

            return new Book(isbn, author, title, publisher, year, price);
        }

    }
}
