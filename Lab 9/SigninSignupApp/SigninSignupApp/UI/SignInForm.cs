using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigninSignupApp
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.Show();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            bool check = validateUser();
            if (check)
            {
                MessageBox.Show("SignIn Successful !!", "Success");
            }
        }

        private bool validateUser()
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            return UserDL.CheckUser(userName, password);
        }
    }
}
