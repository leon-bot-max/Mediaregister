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

        private List<Media> allMedia = new List<Media>();

        public Form1()
        {
            InitializeComponent();
        }


        private bool ValidateInputs(string title, string writer, int length)
        {
            if (title.Length <= 0) //Checktitle
            {
                return false;
            }
            else if (writer.Length <= 0) //Check author or director
            {
                return false;
            }
            else if (length <= 0) //Check amount pages or length
            {
                return false;
            }
            return true;  
        }

        private void SendErrorMessage(string message)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            string caption = "Error! 😎";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
        }
        private void AddBookButton_Click(object sender, EventArgs e)
        {
            //Get inputs
            string title = BookTitleTextBox.Text;
            string author = AuthorTextBox.Text;
            int nrPages = (int) PagesNumber.Value;

            if (ValidateInputs(title, author, nrPages))
            {
                allMedia.Add(new Book(title, author, nrPages));
                //reset inputs
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
            //Get inputs
            string title = FilmTitleTextBox.Text;
            string director = DirectorTextBox.Text;
            int length = (int)LengthNumber.Value;
            if (ValidateInputs(title, director, length))
            {
                allMedia.Add(new Film(title, director, length));
                //Reset inputs
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
            int index = 0; //Index in newLines

            for (int i = 0; i < newLines.Length; i++)
            {
                
                Media media = allMedia[i];

                if (AllBooksButton.Checked)
                {
                    media = allMedia[i] as Book; //null if != Book
                }
                else if (AllFilmsButton.Checked)
                {
                    media = allMedia[i] as Film; //null if != Film
                }


                if (media != null) //Check if should write
                {
                    newLines[index] = media.ToString();
                    index++;
                }
                
            }
            MediaListBox.Lines = newLines; //update lines

        }

        private void ShowRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}
