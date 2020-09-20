using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksLab
{
    public partial class App : Form
    {
        private BookList curBookList;

        public BookList CurrentBookList
        {
            get { return curBookList; }
            set { curBookList = value; }
        }

        public App()
        {
            InitializeComponent();
        }

        private void TableUpdate(List<Book> list, ListView listView)
        {
            listView.Items.Clear();
            foreach (Book book in list)
            {
                var lvItem = new ListViewItem(
                    new string[] { book.ISBN, book.Title, book.Author, book.PublishYear.ToString(), book.Publisher, book.Price.ToString() });
                listView.Items.Add(lvItem);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (CurrentBookList == null)
            {
                CurrentBookList = new BookList();
            }

            try
            {
                string isbn = IsbnTB.Text;
                string author = AuthorTB.Text;
                string title = TitleTB.Text;
                string publisher = PublisherTB.Text;
                int year = Convert.ToInt32(YearTB.Text);
                double price = Convert.ToDouble(PriceTB.Text);

                Book newBook = new Book(isbn, author, title, publisher, year, price);
                CurrentBookList.AddBook(newBook);

                TableUpdate(CurrentBookList.Books, Table);

                IsbnTB.Clear();
                AuthorTB.Clear();
                TitleTB.Clear();
                PublisherTB.Clear();
                YearTB.Clear();
                PriceTB.Clear();

                MessageBox.Show("New book has been added.");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;

            string path = openFile.FileName;
            try
            {
                CurrentBookList = FileManager.UploadBookList(path);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            TableUpdate(CurrentBookList.Books, Table);

            MessageBox.Show("File has been uploaded.");
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;

            string path = saveFile.FileName;
            try
            {
                FileManager.SaveBookList(CurrentBookList, path);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            MessageBox.Show("File has been saved.");
        }

        private void Table_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 0:
                    CurrentBookList.Sort(BookList.SortByISBN());
                    break;
                case 1:
                    CurrentBookList.Sort(BookList.SortByTitle());
                    break;
                case 2:
                    CurrentBookList.Sort(BookList.SortByAuthor());
                    break;
                case 3:
                    CurrentBookList.Sort(BookList.SortByYear());
                    break;
                case 4:
                    CurrentBookList.Sort(BookList.SortByPublisher());
                    break;
                case 5:
                    CurrentBookList.Sort(BookList.SortByPrice());
                    break;
            }

            TableUpdate(CurrentBookList.Books, Table);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            var indices = this.Table.SelectedIndices;

            if (indices.Count > 0)
                CurrentBookList.RemoveBook(indices[0]);

            TableUpdate(CurrentBookList.Books, this.Table);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CurrentBookList.Books.Clear();
            TableUpdate(CurrentBookList.Books, this.Table);
        }
    }
}
