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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            this.Hide();
            signInForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            //bool check = ValidateUser();
            if (check)
            {
                string name = NameTb.Text;
                string userName = UserNameTb.Text;
                string password = PasswordTb.Text;
                string email = EmailTb.Text;
                string number = NumberTb.Text;
                string cnic = CnicTb.Text;

                User user = new User(name, userName, password, "customer", email, number, cnic);
                bool check1 = UserDL.AddUser(user);
                if (check1)
                {
                    MessageBox.Show("SignUp Successful !!", "Success");

                }
                SignInForm signInForm = new SignInForm();
                this.Hide();
                signInForm.Show();
            }
            else
            {
                MessageBox.Show("UserName Already Exists !! Please try another", "Failure");
            }
        }

        private bool ValidateUser()
        {
            string userName = UserNameTb.Text;
            return UserDL.IsValidUser(userName);
        }
    }
}
