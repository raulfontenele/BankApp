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
    public partial class AccountForm : Form
    {
        //IndexController indexController;
        public AccountForm()
        {
            InitializeComponent();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            IndexController.Action("Removal");
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            IndexController.Action("Statement");
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            IndexController.ParentForm = this;
            IndexController.PanelName = "contentPanel";
        }
    }
}
