using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phonebookProjectPractice
{
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check if the search is empty
            if (this.textSearch.Text == "")
            {
                MessageBox.Show("You must enter an ID.");
                return;
            }

            //load text file. Use AssignmentFileIO for reference if needed
            string fileSource = $@"C:\Assignments\Users\user{textSearch.Text}.txt"; //file path needed to read in the text

            //check if the file exists
            if (File.Exists(fileSource) == true)
            {
                //loads the person info to the necessary text box
                Person newPerson = new Person(); //declares a new person (has to be out here)

                List<string> lines = File.ReadAllLines(fileSource).ToList(); //reads in the text and puts it into a list

                foreach (string line in lines)
                {
                    string[] entries = line.Split(','); //splits lines in the txt file at the , into different entries

                    //splits the lines and saves each entry into newPerson

                    newPerson.Id = entries[0];
                    newPerson.FirstName = entries[1];
                    newPerson.LastName = entries[2];
                    newPerson.Phone = entries[3];
                    newPerson.Email = entries[4];
                    newPerson.Address = entries[5];
                    newPerson.Notes = entries[6];
                }

                //writes the entry from the file into the text box
                this.textID.Text = newPerson.Id;
                this.textFirstName.Text = newPerson.FirstName;
                this.textLastName.Text = newPerson.LastName;
                this.textPhone.Text = newPerson.Phone;
                this.textEmail.Text = newPerson.Email;
                this.textAddress.Text = newPerson.Address;
                this.textNotes.Text = newPerson.Notes;
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
