using System;
using System.Windows.Forms;

using BankApp.Controller;


namespace BankApp.View
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckPasswords(txBoxPassword.Text, txBoxConfPassword.Text)) throw new Exception("Password does not match");
                if (txBoxPassword.Text == "" || txBoxCPF.Text == "" || txBoxFirstName.Text == "" || txBoxLastName.Text == "") 
                    throw new Exception("Empty Fields");
                string result = new RegisterController().Register(txBoxFirstName.Text, txBoxLastName.Text, txBoxCPF.Text, txBoxPassword.Text);
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message.ToString());
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CleanFields();
            IndexController.Action("Login");
        }
        private void CleanFields()
        {
            txBoxLastName.Text = "";
            txBoxConfPassword.Text = "";
            txBoxCPF.Text = "";
            txBoxFirstName.Text = "";
            txBoxPassword.Text = "";
        }

        private void txBoxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private bool CheckPasswords(string password, string confPassword)
        {
            if (password == confPassword) return true;
            return false;
        }
    }
}
