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
                    new string[] { book.ISBN, book.Title, book.Author, book.PublishYear.ToString(), book.Publisher, book.Price });
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
                int year = int.Parse(YearTB.Text);
                string price = PriceTB.Text;

                Book newBook = new Book(isbn, author, title, publisher, year, price);
                foreach (Book book in CurrentBookList.Books)
                {
                    if (newBook.ISBN == book.ISBN && !newBook.Equals(book))
                        throw new FormatException("ISBN must be unique.");
                }

                CurrentBookList.AddBook(newBook);

                if (CurrentBookList != null)
                    TableUpdate(CurrentBookList.Books, Table);

                IsbnTB.Clear();
                AuthorTB.Clear();
                TitleTB.Clear();
                PublisherTB.Clear();
                YearTB.Clear();
                PriceTB.Clear();

                MessageBox.Show("New book has been added.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ParamName);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

            if (CurrentBookList != null)
            {
                TableUpdate(CurrentBookList.Books, Table);
                MessageBox.Show("File has been uploaded.");
            }
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
            ComparerProvider provider = new ComparerProvider();
            IComparer<Book> comparer = provider.GetComparer(e.Column);
            CurrentBookList.Sort(comparer);

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
