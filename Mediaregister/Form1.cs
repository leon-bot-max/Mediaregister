using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediaregister.model;

namespace Mediaregister
{
    public partial class Form1 : Form
    {

        private List<Media> allBooks = new List<Media>();
        private List<Media> allFilms = new List<Media>();

        public Form1()
        {
            InitializeComponent();
        }
        /*
        private List<Media> GetBooks()
        {
            throw new NotImplementedException();
        }
        private List<Media> GetFilms()
        {
            throw new NotImplementedException();
        }
        */

        private bool ValidateInputs(string title, string writer, int length)
        {
            if (title.Length <= 0)
                return false;
            else if (writer.Length <= 0)
                return false;
            else if (length <= 0)
                return false;
            return true;
        }


        private void AddBookButton_Click(object sender, EventArgs e)
        {
            string title = BookTitleTextBox.Text;
            string author = AuthorTextBox.Text;
            int nrPages = (int) PagesNumber.Value;
            if (ValidateInputs(title, author, nrPages))
            {
                allBooks.Add(new Book(title, author, nrPages));
            }
            UpdateList();
        }

        private void AddFilmButton_Click(object sender, EventArgs e)
        {
            string title = FilmTitleTextBox.Text;
            string director = DirectorTextBox.Text;
            int length = (int)LengthNumber.Value;
            if (ValidateInputs(title, director, length))
            {
                allFilms.Add(new Film(title, director, length));
            }
        }


        private void UpdateList()
        {
            string[] newstring = new string[allBooks.Count];

            for (int i = 0; i < allBooks.Count; i++)
            {
                newstring[i] = allBooks[i].ToString();
            }
            MediaListBox.Lines = newstring;

        }

    }
}
