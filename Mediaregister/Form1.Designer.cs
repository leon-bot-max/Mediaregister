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
            this.BookTabPage = new System.Windows.Forms.TabPage();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.PagesNumber = new System.Windows.Forms.NumericUpDown();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.BookTitleTextBox = new System.Windows.Forms.TextBox();
            this.PagesLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.BookTitleLabel = new System.Windows.Forms.Label();
            this.FilmTabPage = new System.Windows.Forms.TabPage();
            this.AddFilmButton = new System.Windows.Forms.Button();
            this.LengthNumber = new System.Windows.Forms.NumericUpDown();
            this.DirectorTextBox = new System.Windows.Forms.TextBox();
            this.FilmTitleTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.DirectorLabel = new System.Windows.Forms.Label();
            this.FilmTitleLabel = new System.Windows.Forms.Label();
            this.MediaListBox = new System.Windows.Forms.TextBox();
            this.ShowButtonsGroup = new System.Windows.Forms.GroupBox();
            this.AllFilmsButton = new System.Windows.Forms.RadioButton();
            this.AllBooksButton = new System.Windows.Forms.RadioButton();
            this.AllMediaButton = new System.Windows.Forms.RadioButton();
            this.MediaTabControl.SuspendLayout();
            this.BookTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PagesNumber)).BeginInit();
            this.FilmTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNumber)).BeginInit();
            this.ShowButtonsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MediaTabControl
            // 
            this.MediaTabControl.Controls.Add(this.BookTabPage);
            this.MediaTabControl.Controls.Add(this.FilmTabPage);
            this.MediaTabControl.Location = new System.Drawing.Point(76, 57);
            this.MediaTabControl.Name = "MediaTabControl";
            this.MediaTabControl.SelectedIndex = 0;
            this.MediaTabControl.Size = new System.Drawing.Size(230, 274);
            this.MediaTabControl.TabIndex = 0;
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
            // PagesNumber
            // 
            this.PagesNumber.Location = new System.Drawing.Point(80, 123);
            this.PagesNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PagesNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PagesNumber.Name = "PagesNumber";
            this.PagesNumber.Size = new System.Drawing.Size(120, 20);
            this.PagesNumber.TabIndex = 5;
            this.PagesNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(80, 93);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(120, 20);
            this.AuthorTextBox.TabIndex = 4;
            // 
            // BookTitleTextBox
            // 
            this.BookTitleTextBox.Location = new System.Drawing.Point(80, 63);
            this.BookTitleTextBox.Name = "BookTitleTextBox";
            this.BookTitleTextBox.Size = new System.Drawing.Size(120, 20);
            this.BookTitleTextBox.TabIndex = 3;
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
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(19, 93);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(55, 13);
            this.AuthorLabel.TabIndex = 1;
            this.AuthorLabel.Text = "Författare:";
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
            // FilmTabPage
            // 
            this.FilmTabPage.Controls.Add(this.AddFilmButton);
            this.FilmTabPage.Controls.Add(this.LengthNumber);
            this.FilmTabPage.Controls.Add(this.DirectorTextBox);
            this.FilmTabPage.Controls.Add(this.FilmTitleTextBox);
            this.FilmTabPage.Controls.Add(this.LengthLabel);
            this.FilmTabPage.Controls.Add(this.DirectorLabel);
            this.FilmTabPage.Controls.Add(this.FilmTitleLabel);
            this.FilmTabPage.Location = new System.Drawing.Point(4, 22);
            this.FilmTabPage.Name = "FilmTabPage";
            this.FilmTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FilmTabPage.Size = new System.Drawing.Size(222, 248);
            this.FilmTabPage.TabIndex = 1;
            this.FilmTabPage.Text = "Lägg till film";
            this.FilmTabPage.UseVisualStyleBackColor = true;
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
            this.LengthNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.LengthNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LengthNumber.Name = "LengthNumber";
            this.LengthNumber.Size = new System.Drawing.Size(120, 20);
            this.LengthNumber.TabIndex = 5;
            this.LengthNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // MediaListBox
            // 
            this.MediaListBox.BackColor = System.Drawing.Color.White;
            this.MediaListBox.Location = new System.Drawing.Point(333, 79);
            this.MediaListBox.Multiline = true;
            this.MediaListBox.Name = "MediaListBox";
            this.MediaListBox.ReadOnly = true;
            this.MediaListBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MediaListBox.Size = new System.Drawing.Size(233, 248);
            this.MediaListBox.TabIndex = 2;
            // 
            // ShowButtonsGroup
            // 
            this.ShowButtonsGroup.Controls.Add(this.AllFilmsButton);
            this.ShowButtonsGroup.Controls.Add(this.AllBooksButton);
            this.ShowButtonsGroup.Controls.Add(this.AllMediaButton);
            this.ShowButtonsGroup.Location = new System.Drawing.Point(333, 333);
            this.ShowButtonsGroup.Name = "ShowButtonsGroup";
            this.ShowButtonsGroup.Size = new System.Drawing.Size(252, 45);
            this.ShowButtonsGroup.TabIndex = 3;
            this.ShowButtonsGroup.TabStop = false;
            this.ShowButtonsGroup.Text = "Visa";
            // 
            // AllFilmsButton
            // 
            this.AllFilmsButton.AutoSize = true;
            this.AllFilmsButton.Location = new System.Drawing.Point(199, 19);
            this.AllFilmsButton.Name = "AllFilmsButton";
            this.AllFilmsButton.Size = new System.Drawing.Size(52, 17);
            this.AllFilmsButton.TabIndex = 2;
            this.AllFilmsButton.Text = "Filmer";
            this.AllFilmsButton.UseVisualStyleBackColor = true;
            this.AllFilmsButton.CheckedChanged += new System.EventHandler(this.ShowRadioButtons_CheckedChanged);
            // 
            // AllBooksButton
            // 
            this.AllBooksButton.AutoSize = true;
            this.AllBooksButton.Location = new System.Drawing.Point(108, 19);
            this.AllBooksButton.Name = "AllBooksButton";
            this.AllBooksButton.Size = new System.Drawing.Size(59, 17);
            this.AllBooksButton.TabIndex = 1;
            this.AllBooksButton.Text = "Böcker";
            this.AllBooksButton.UseVisualStyleBackColor = true;
            this.AllBooksButton.CheckedChanged += new System.EventHandler(this.ShowRadioButtons_CheckedChanged);
            // 
            // AllMediaButton
            // 
            this.AllMediaButton.AutoSize = true;
            this.AllMediaButton.Checked = true;
            this.AllMediaButton.Location = new System.Drawing.Point(16, 19);
            this.AllMediaButton.Name = "AllMediaButton";
            this.AllMediaButton.Size = new System.Drawing.Size(42, 17);
            this.AllMediaButton.TabIndex = 0;
            this.AllMediaButton.TabStop = true;
            this.AllMediaButton.Text = "Alla";
            this.AllMediaButton.UseVisualStyleBackColor = true;
            this.AllMediaButton.CheckedChanged += new System.EventHandler(this.ShowRadioButtons_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 485);
            this.Controls.Add(this.ShowButtonsGroup);
            this.Controls.Add(this.MediaListBox);
            this.Controls.Add(this.MediaTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Mediaregister";
            this.MediaTabControl.ResumeLayout(false);
            this.BookTabPage.ResumeLayout(false);
            this.BookTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PagesNumber)).EndInit();
            this.FilmTabPage.ResumeLayout(false);
            this.FilmTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNumber)).EndInit();
            this.ShowButtonsGroup.ResumeLayout(false);
            this.ShowButtonsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TabPage FilmTabPage;
        private System.Windows.Forms.Button AddFilmButton;
        private System.Windows.Forms.NumericUpDown LengthNumber;
        private System.Windows.Forms.TextBox DirectorTextBox;
        private System.Windows.Forms.TextBox FilmTitleTextBox;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.Label FilmTitleLabel;
        private System.Windows.Forms.TextBox MediaListBox;
        private System.Windows.Forms.GroupBox ShowButtonsGroup;
        private System.Windows.Forms.RadioButton AllFilmsButton;
        private System.Windows.Forms.RadioButton AllBooksButton;
        private System.Windows.Forms.RadioButton AllMediaButton;
    }
}

