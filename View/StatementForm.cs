using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BankApp.Controller;

namespace BankApp.View
{
    public partial class StatementForm : Form
    {
        public StatementForm()
        {
            InitializeComponent();
        }

        private void StatementForm_Load(object sender, EventArgs e)
        {
            UpdateScreen();
        }
        private void UpdateScreen()
        {
            lbBalanceValue.Text = AccountController.GetBalanceValue().ToString();
        }

        private void StatementForm_VisibleChanged(object sender, EventArgs e)
        {
            UpdateScreen();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable results = AccountController.GetStatements(3);
            gridStatement.DataSource = results;
            gridStatement.Columns.Remove("Account_Number");
        }
    }
}
