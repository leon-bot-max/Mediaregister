namespace Mediaregister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MediaTabControl = new System.Windows.Forms.TabControl();
            this.BookTitleLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.PagesLabel = new System.Windows.Forms.Label();
            this.BookTitleTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.PagesNumber = new System.Windows.Forms.NumericUpDown();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.BookTabPage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddFilmButton = new System.Windows.Forms.Button();
            this.LengthNumber = new System.Windows.Forms.NumericUpDown();
            this.DirectorTextBox = new System.Windows.Forms.TextBox();
            this.FilmTitleTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.DirectorLabel = new System.Windows.Forms.Label();
            this.FilmTitleLabel = new System.Windows.Forms.Label();
            this.MediaList = new System.Windows.Forms.ListView();
            this.MediaTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PagesNumber)).BeginInit();
            this.BookTabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // MediaTabControl
            // 
            this.MediaTabControl.Controls.Add(this.BookTabPage);
            this.MediaTabControl.Controls.Add(this.tabPage1);
            this.MediaTabControl.Location = new System.Drawing.Point(76, 57);
            this.MediaTabControl.Name = "MediaTabControl";
            this.MediaTabControl.SelectedIndex = 0;
            this.MediaTabControl.Size = new System.Drawing.Size(230, 274);
            this.MediaTabControl.TabIndex = 0;
            // 
            // BookTitleLabel
            // 
            this.BookTitleLabel.AutoSize = true;
            this.BookTitleLabel.Location = new System.Drawing.Point(19, 63);
            this.BookTitleLabel.Name = "BookTitleLabel";
            this.BookTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.BookTitleLabel.TabIndex = 0;
            this.BookTitleLabel.Text = "Titel:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(19, 93);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(55, 13);
            this.AuthorLabel.TabIndex = 1;
            this.AuthorLabel.Text = "Författare:";
            // 
            // PagesLabel
            // 
            this.PagesLabel.AutoSize = true;
            this.PagesLabel.Location = new System.Drawing.Point(19, 123);
            this.PagesLabel.Name = "PagesLabel";
            this.PagesLabel.Size = new System.Drawing.Size(34, 13);
            this.PagesLabel.TabIndex = 2;
            this.PagesLabel.Text = "Sidor:";
            // 
            // BookTitleTextBox
            // 
            this.BookTitleTextBox.Location = new System.Drawing.Point(80, 63);
            this.BookTitleTextBox.Name = "BookTitleTextBox";
            this.BookTitleTextBox.Size = new System.Drawing.Size(120, 20);
            this.BookTitleTextBox.TabIndex = 3;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(80, 93);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(120, 20);
            this.AuthorTextBox.TabIndex = 4;
            // 
            // PagesNumber
            // 
            this.PagesNumber.Location = new System.Drawing.Point(80, 123);
            this.PagesNumber.Name = "PagesNumber";
            this.PagesNumber.Size = new System.Drawing.Size(120, 20);
            this.PagesNumber.TabIndex = 5;
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(115, 199);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(75, 23);
            this.AddBookButton.TabIndex = 6;
            this.AddBookButton.Text = "Lägg till bok";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // BookTabPage
            // 
            this.BookTabPage.Controls.Add(this.AddBookButton);
            this.BookTabPage.Controls.Add(this.PagesNumber);
            this.BookTabPage.Controls.Add(this.AuthorTextBox);
            this.BookTabPage.Controls.Add(this.BookTitleTextBox);
            this.BookTabPage.Controls.Add(this.PagesLabel);
            this.BookTabPage.Controls.Add(this.AuthorLabel);
            this.BookTabPage.Controls.Add(this.BookTitleLabel);
            this.BookTabPage.Location = new System.Drawing.Point(4, 22);
            this.BookTabPage.Name = "BookTabPage";
            this.BookTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BookTabPage.Size = new System.Drawing.Size(222, 248);
            this.BookTabPage.TabIndex = 0;
            this.BookTabPage.Text = "Lägg till bok";
            this.BookTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddFilmButton);
            this.tabPage1.Controls.Add(this.LengthNumber);
            this.tabPage1.Controls.Add(this.DirectorTextBox);
            this.tabPage1.Controls.Add(this.FilmTitleTextBox);
            this.tabPage1.Controls.Add(this.LengthLabel);
            this.tabPage1.Controls.Add(this.DirectorLabel);
            this.tabPage1.Controls.Add(this.FilmTitleLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(222, 248);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Lägg till film";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddFilmButton
            // 
            this.AddFilmButton.Location = new System.Drawing.Point(115, 199);
            this.AddFilmButton.Name = "AddFilmButton";
            this.AddFilmButton.Size = new System.Drawing.Size(75, 23);
            this.AddFilmButton.TabIndex = 6;
            this.AddFilmButton.Text = "Lägg till film";
            this.AddFilmButton.UseVisualStyleBackColor = true;
            this.AddFilmButton.Click += new System.EventHandler(this.AddFilmButton_Click);
            // 
            // LengthNumber
            // 
            this.LengthNumber.Location = new System.Drawing.Point(80, 123);
            this.LengthNumber.Name = "LengthNumber";
            this.LengthNumber.Size = new System.Drawing.Size(120, 20);
            this.LengthNumber.TabIndex = 5;
            // 
            // DirectorTextBox
            // 
            this.DirectorTextBox.Location = new System.Drawing.Point(80, 93);
            this.DirectorTextBox.Name = "DirectorTextBox";
            this.DirectorTextBox.Size = new System.Drawing.Size(120, 20);
            this.DirectorTextBox.TabIndex = 4;
            // 
            // FilmTitleTextBox
            // 
            this.FilmTitleTextBox.Location = new System.Drawing.Point(80, 63);
            this.FilmTitleTextBox.Name = "FilmTitleTextBox";
            this.FilmTitleTextBox.Size = new System.Drawing.Size(120, 20);
            this.FilmTitleTextBox.TabIndex = 3;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(19, 123);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(57, 13);
            this.LengthLabel.TabIndex = 2;
            this.LengthLabel.Text = "Spellängd:";
            // 
            // DirectorLabel
            // 
            this.DirectorLabel.AutoSize = true;
            this.DirectorLabel.Location = new System.Drawing.Point(19, 93);
            this.DirectorLabel.Name = "DirectorLabel";
            this.DirectorLabel.Size = new System.Drawing.Size(51, 13);
            this.DirectorLabel.TabIndex = 1;
            this.DirectorLabel.Text = "Regissör:";
            // 
            // FilmTitleLabel
            // 
            this.FilmTitleLabel.AutoSize = true;
            this.FilmTitleLabel.Location = new System.Drawing.Point(19, 63);
            this.FilmTitleLabel.Name = "FilmTitleLabel";
            this.FilmTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.FilmTitleLabel.TabIndex = 0;
            this.FilmTitleLabel.Text = "Titel:";
            // 
            // MediaList
            // 
            this.MediaList.Location = new System.Drawing.Point(400, 79);
            this.MediaList.Name = "MediaList";
            this.MediaList.Size = new System.Drawing.Size(230, 248);
            this.MediaList.TabIndex = 1;
            this.MediaList.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MediaList);
            this.Controls.Add(this.MediaTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MediaTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PagesNumber)).EndInit();
            this.BookTabPage.ResumeLayout(false);
            this.BookTabPage.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MediaTabControl;
        private System.Windows.Forms.TabPage BookTabPage;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.NumericUpDown PagesNumber;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox BookTitleTextBox;
        private System.Windows.Forms.Label PagesLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label BookTitleLabel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button AddFilmButton;
        private System.Windows.Forms.NumericUpDown LengthNumber;
        private System.Windows.Forms.TextBox DirectorTextBox;
        private System.Windows.Forms.TextBox FilmTitleTextBox;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.Label FilmTitleLabel;
        private System.Windows.Forms.ListView MediaList;
    }
}

