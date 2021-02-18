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
            {
                return false;
            }
            else if (writer.Length <= 0)
            {
                return false;
            }
            else if (length <= 0)
            {
                return false;
            }
            return true;
        }

        private void SendErrorMessage(string message)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
        }
        private void AddBookButton_Click(object sender, EventArgs e)
        {
            string title = BookTitleTextBox.Text;
            string author = AuthorTextBox.Text;
            int nrPages = (int) PagesNumber.Value;
            if (ValidateInputs(title, author, nrPages))
            {
                allMedia.Add(new Book(title, author, nrPages));
                BookTitleTextBox.Text = "";
                AuthorTextBox.Text = "";
                PagesNumber.Value = PagesNumber.Minimum;
            }
            else
            {
                SendErrorMessage("Ogiltlig input");
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
                FilmTitleTextBox.Text = "";
                DirectorTextBox.Text = "";
                LengthNumber.Value = LengthNumber.Minimum;

            }
            else
            {
                SendErrorMessage("Ogiltlig input");
            }
            UpdateList();

        }


        private void UpdateList()
        {
            

            string[] newLines = new string[allMedia.Count];
            int index = 0; //Index in the newlines

            for (int i = 0; i < newLines.Length; i++)
            {

                Media media = allMedia[i];
                switch (selectedView)
                {
                    case SelectViews.AllBooks:
                        media = allMedia[i] as Book;
                        break;
                    case SelectViews.AllFilms:
                        media = allMedia[i] as Film;
                        break;
                    default:
                        break;
                }
                if (media != null)
                {
                    newLines[index] = media.ToString();
                    index++;
                }
                
            }
            MediaListBox.Lines = newLines;

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
                    case "AllMediaButton":
                        selectedView = SelectViews.AllMedia;
                        break;
                    case "AllBooksButton":
                        selectedView = SelectViews.AllBooks;
                        break;
                    case "AllFilmsButton":
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
