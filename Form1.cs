using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phonebookProjectPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            registerForm register = new registerForm();
            register.MdiParent = this;
            register.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            searchForm search = new searchForm();
            search.MdiParent = this;
            search.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            aboutForm about = new aboutForm();
            about.MdiParent = this;
            about.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    toolStripButton1_Click(sender, e);
                    break;
                case Keys.F3:
                    toolStripButton2_Click(sender, e);
                    break;
                case Keys.F4:
                    toolStripButton4_Click(sender, e);
                    break;
                case Keys.Escape:
                    toolStripButton5_Click(sender, e);
                    break;
            }

        }
    }
}
