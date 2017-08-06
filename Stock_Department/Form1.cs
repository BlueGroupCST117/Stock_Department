using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Department
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var UserName = "admin";
            var Password = "password";

            if (UserName == userNameTextBox.Text && Password == passwordTextBox.Text) 
            {
                userNameTextBox.Text = string.Empty;
              
                passwordTextBox.Text = string.Empty;
             

                MessageBox.Show("Welcome " + UserName);
                StockDepartment frm = new StockDepartment();
                frm.Show();

         }
            else
            {
                {
                    MessageBox.Show( "Incorrect Username and/or Password");
                }
            }
        }

        private void UserNameLable_Click(object sender, EventArgs e)
        {

        }
    }
}
