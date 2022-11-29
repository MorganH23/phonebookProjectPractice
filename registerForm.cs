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
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            gbInfo.Enabled = true;
            //change text
            textID.Enabled = true;
            textID.ResetText();
            textFirstName.Enabled = true;
            textFirstName.ResetText();
            textLastName.Enabled = true;
            textLastName.ResetText();
            textPhone.Enabled = true;
            textPhone.ResetText();
            textEmail.Enabled = true;
            textEmail.ResetText();
            textAddress.Enabled = true;
            textAddress.ResetText();
            textNotes.Enabled = true;
            textNotes.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check if the text is empty
            if (this.textID.Text == "")
            {
                MessageBox.Show("You must enter an ID.");
                return;
            }
            else if (this.textFirstName.Text == "")
            {
                MessageBox.Show("You must enter a name.");
                return;
            }
            else if (this.textLastName.Text == "")
            {
                MessageBox.Show("You must enter a last name.");
                return;
            }
            else if (this.textPhone.Text == "")
            {
                MessageBox.Show("You must enter a phone number.");
                return;
            }
            else if (this.textEmail.Text == "")
            {
                MessageBox.Show("You must enter an email.");
                return;
            }
            else if (this.textAddress.Text == "")
            {
                MessageBox.Show("You must enter an address.");
                return;
            }
            else if (this.textNotes.Text == "")
            {
                MessageBox.Show("You must enter a note.");
                return;
            }


            //save to text file. Use AssignmentFileIO for reference if needed
            string filePath = $@"C:\Assignments\Users\user{textID.Text}.txt";

            Person newPerson = new Person();

            //saves the person info to a text file using the id name

            newPerson.Id = textID.Text.ToString();
            newPerson.FirstName = textFirstName.Text.ToString();
            newPerson.LastName = textLastName.Text.ToString();
            newPerson.Phone = textPhone.Text.ToString();
            newPerson.Email = textEmail.Text.ToString();
            newPerson.Address = textAddress.Text.ToString();
            newPerson.Notes = textNotes.Text.ToString();

            System.IO.File.WriteAllText(filePath, $"{newPerson.Id},{newPerson.FirstName},{newPerson.LastName},{newPerson.Phone},{newPerson.Email},{newPerson.Address},{newPerson.Notes}");
            MessageBox.Show("Saved");

            btnNew.Enabled = true;
            btnSave.Enabled = false;
            gbInfo.Enabled = false;
            textFirstName.Enabled = false;
            textLastName.Enabled = false;
            textPhone.Enabled = false;
            textEmail.Enabled = false;
            textAddress.Enabled = false;
            textNotes.Enabled = false;
        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
