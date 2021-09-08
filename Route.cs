using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankApp.Controller;

namespace BankApp
{
    class Route
    {
        //IndexController indexController = new IndexController();
        bool flagLogin = true;

        public void Main()
        {
            //Direcionar para a tela de login e em caso positivo, direcionar pra main
            if (!flagLogin)
            {
                //direcionar para a tela de login
            }
            else
            {
                //indexController.Action("Account");
            }
        }


    }
}
