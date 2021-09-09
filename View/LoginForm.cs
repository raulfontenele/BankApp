using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BankApp.Controller;

namespace BankApp.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void txBoxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar!= (char)Keys.Delete && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new LoginController().Validation(txBoxCPF.Text, txBoxPassword.Text);
            //string path = Directory.GetDirectoryRoot(Environment.CurrentDirectory);
            //string path = Directory.GetCurrentDirectory();


        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            IndexController.Action("Registration");
        }

        //private void txBoxCPF_TextChanged(object sender, EventArgs e)
        //{
        //    var cpf = Convert.ToUInt64(txBoxCPF.Text.Replace(".", ""));
        //    string CPFFormatado = String.Format(@"{0:\999\.999\.999\-99}", cpf);
        //    //switch (txBoxCPF.Text.Length)
        //    //{
        //    //    case 3:
        //    //    case 7:
        //    //    case 11:
        //    //        txBoxCPF.Text += ".";
        //    //        break;
        //    //    case 15:
        //    //        txBoxCPF.Text += "-";
        //    //        break;
        //    //    default:
        //    //        break;

        //    //}
        //    //var cpf = Convert.ToUInt64(txBoxCPF.Text.Replace(".",""));

        //    //string CPFFormatado = String.Format(@"{0:\999\.999\.999\-99}", cpf);
        //    //txBoxCPF.Text = CPFFormatado;
        //}
    }
}
