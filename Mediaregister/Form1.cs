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
        enum SelectViews
        {
            AllMedia, AllBooks, AllFilms
        }
        private List<Media> allMedia = new List<Media>();
        private SelectViews selectedView = SelectViews.AllMedia;

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
                allMedia.Add(new Book(title, author, nrPages));
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
                allMedia.Add(new Film(title, director, length));

            }
            UpdateList();
        }


        private void UpdateList()
        {


            string[] newstring = new string[allMedia.Count];

            for (int i = 0; i < newstring.Length; i++)
            {
                if (typeof(Book) == allMedia[i].GetType())
                {
                    newstring[i] = allMedia[i].ToString();
                }
            }
            MediaListBox.Lines = newstring;

        }

        private void ShowRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            //Sender != radiobutton
            if (rb == null)
            {
                return;
            }

            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "AllMediaRadioButton":
                        selectedView = SelectViews.AllMedia;
                        break;
                    case "AllBooksRadioButton":
                        selectedView = SelectViews.AllBooks;
                        break;
                    case "AllFilmsRadioButton":
                        selectedView = SelectViews.AllFilms;
                        break;
                    default:
                        break;
                }

                UpdateList();

            }
        }
    }
}
