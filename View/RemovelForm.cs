using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankApp.Controller;

namespace BankApp.View
{
    public partial class RemovelForm : Form
    {
        public RemovelForm()
        {
            InitializeComponent();
        }
        private void UpdateScreen()
        {
            lbBalanceValue.Text = AccountController.GetBalanceValue().ToString();
        }

        private void RemovelForm_Load(object sender, EventArgs e)
        {
            UpdateScreen();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //IMPEDIR DE DIGITAR OUTRA COISA QUE NÃO SEJA NUMERO
            float value = (float)Convert.ToDouble(txBoxValue.Text);
            if(value > 0)
            {
                AccountController.AddValueAccount(value);
                UpdateScreen();
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            float value = (float)Convert.ToDouble(txBoxValue.Text);
            if (value > 0)
            {
                AccountController.RemoveValueAccount(value);
                UpdateScreen();
            }
        }
    }
}
