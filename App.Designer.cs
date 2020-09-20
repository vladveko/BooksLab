namespace BooksLab
{
    partial class App
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Table = new System.Windows.Forms.ListView();
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Titile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsbnTB = new System.Windows.Forms.TextBox();
            this.TitleTB = new System.Windows.Forms.TextBox();
            this.AuthorTB = new System.Windows.Forms.TextBox();
            this.PublisherTB = new System.Windows.Forms.TextBox();
            this.YearTB = new System.Windows.Forms.TextBox();
            this.ISBNlabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISBN,
            this.Titile,
            this.Author,
            this.Year,
            this.Publisher,
            this.Price});
            this.Table.FullRowSelect = true;
            this.Table.GridLines = true;
            this.Table.HideSelection = false;
            this.Table.Location = new System.Drawing.Point(12, 12);
            this.Table.MultiSelect = false;
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(685, 522);
            this.Table.TabIndex = 0;
            this.Table.UseCompatibleStateImageBehavior = false;
            this.Table.View = System.Windows.Forms.View.Details;
            this.Table.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Table_ColumnClick);
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.Width = 120;
            // 
            // Titile
            // 
            this.Titile.Text = "Title";
            this.Titile.Width = 200;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 120;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            // 
            // Publisher
            // 
            this.Publisher.Text = "Publisher";
            this.Publisher.Width = 120;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // IsbnTB
            // 
            this.IsbnTB.Location = new System.Drawing.Point(758, 12);
            this.IsbnTB.MaxLength = 13;
            this.IsbnTB.Name = "IsbnTB";
            this.IsbnTB.Size = new System.Drawing.Size(201, 20);
            this.IsbnTB.TabIndex = 1;
            // 
            // TitleTB
            // 
            this.TitleTB.Location = new System.Drawing.Point(758, 38);
            this.TitleTB.Name = "TitleTB";
            this.TitleTB.Size = new System.Drawing.Size(201, 20);
            this.TitleTB.TabIndex = 2;
            // 
            // AuthorTB
            // 
            this.AuthorTB.Location = new System.Drawing.Point(758, 64);
            this.AuthorTB.Name = "AuthorTB";
            this.AuthorTB.Size = new System.Drawing.Size(201, 20);
            this.AuthorTB.TabIndex = 3;
            // 
            // PublisherTB
            // 
            this.PublisherTB.Location = new System.Drawing.Point(758, 90);
            this.PublisherTB.Name = "PublisherTB";
            this.PublisherTB.Size = new System.Drawing.Size(201, 20);
            this.PublisherTB.TabIndex = 4;
            // 
            // YearTB
            // 
            this.YearTB.Location = new System.Drawing.Point(758, 116);
            this.YearTB.MaxLength = 4;
            this.YearTB.Name = "YearTB";
            this.YearTB.Size = new System.Drawing.Size(201, 20);
            this.YearTB.TabIndex = 5;
            // 
            // ISBNlabel
            // 
            this.ISBNlabel.AutoSize = true;
            this.ISBNlabel.Location = new System.Drawing.Point(720, 15);
            this.ISBNlabel.Name = "ISBNlabel";
            this.ISBNlabel.Size = new System.Drawing.Size(32, 13);
            this.ISBNlabel.TabIndex = 6;
            this.ISBNlabel.Text = "ISBN";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(725, 41);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "Title";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(714, 67);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(38, 13);
            this.AuthorLabel.TabIndex = 8;
            this.AuthorLabel.Text = "Author";
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.Location = new System.Drawing.Point(703, 93);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(50, 13);
            this.PublisherLabel.TabIndex = 9;
            this.PublisherLabel.Text = "Publisher";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(723, 119);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 13);
            this.YearLabel.TabIndex = 10;
            this.YearLabel.Text = "Year";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(758, 142);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(201, 20);
            this.PriceTB.TabIndex = 11;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(721, 145);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 12;
            this.PriceLabel.Text = "Price";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(758, 180);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(201, 38);
            this.AddBtn.TabIndex = 13;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(758, 452);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(201, 38);
            this.LoadBtn.TabIndex = 14;
            this.LoadBtn.Text = "Upload";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(758, 496);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(201, 38);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "test.txt";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(758, 341);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(201, 38);
            this.ClearBtn.TabIndex = 16;
            this.ClearBtn.Text = "Clear Table";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(758, 297);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(201, 38);
            this.RemoveBtn.TabIndex = 17;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 544);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ISBNlabel);
            this.Controls.Add(this.YearTB);
            this.Controls.Add(this.PublisherTB);
            this.Controls.Add(this.AuthorTB);
            this.Controls.Add(this.TitleTB);
            this.Controls.Add(this.IsbnTB);
            this.Controls.Add(this.Table);
            this.Name = "App";
            this.Text = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Table;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader Titile;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Publisher;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.TextBox IsbnTB;
        private System.Windows.Forms.TextBox TitleTB;
        private System.Windows.Forms.TextBox AuthorTB;
        private System.Windows.Forms.TextBox PublisherTB;
        private System.Windows.Forms.TextBox YearTB;
        private System.Windows.Forms.Label ISBNlabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button RemoveBtn;
    }
}

