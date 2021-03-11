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

        /*
         *  Function for only checking string:
        private bool ValidateInputs(string title, string writer, int length)
        {
            //Check title, author or director, amount pages or length
            if (String.IsNullOrWhiteSpace(title) || String.IsNullOrWhiteSpace(writer) || length <= 0) 
            {
                return false;
            }
            return true;  
        }
        */


        /// <summary>
        /// Checks inputs and resets bad inputs
        /// </summary>
        private bool ValidateInputs(TextBox titleBox, TextBox writerBox, NumericUpDown length)
        {
            bool returnValue = true;
            //Validates and resets bad inputs
            if (String.IsNullOrWhiteSpace(titleBox.Text)) //Check title
            {
                titleBox.Text = "";
                returnValue = false;
            }
            if (String.IsNullOrWhiteSpace(writerBox.Text)) //Check author or director
            {
                writerBox.Text = "";
                returnValue = false;
            }
            if (length.Value <= 0) //Check amount pages or length
            {
                length.Value = length.Minimum;
                returnValue = false;
            }

            return returnValue;
        }

        private void SendErrorMessage(string message)
        {
            string caption = "Error!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Display the MessageBox
            MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
        }
        private void AddBookButton_Click(object sender, EventArgs e)
        {


            if (ValidateInputs(BookTitleTextBox, AuthorTextBox, PagesNumber))
            {
                //Get inputs
                string title = BookTitleTextBox.Text.Trim();
                string author = AuthorTextBox.Text.Trim();
                int nrPages = (int)PagesNumber.Value;
                //Add book
                allMedia.Add(new Book(title, author, nrPages));

                //Reset inputs
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

            if (ValidateInputs(FilmTitleTextBox, DirectorTextBox, LengthNumber))
            {
                //Get inputs
                string title = FilmTitleTextBox.Text.Trim();
                string director = DirectorTextBox.Text.Trim();
                int length = (int)LengthNumber.Value;
                //Add Film
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

            string[] newLines = new string[allMedia.Count]; //Max length = allMedia.Count
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
