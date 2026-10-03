using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Student_Mnagment_System
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (User_Name_text.Text == "Admin" && password_text.Text == "password")
            {
                Form fr_mdemy_shool = new Fr_Mdemy_School();
                fr_mdemy_shool.Show();
            }
            else
            {
                MessageBox.Show("Error password/user Name");
            }
            User_Name_text.Clear();
            password_text.Clear();
        }

        private void user_name_validate(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(User_Name_text.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(User_Name_text, "you must the user name has a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(User_Name_text, "");
            }

        }

        private void password_validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(password_text.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(password_text, "you must the password has a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(password_text, "");
            }
        }
    }
}
