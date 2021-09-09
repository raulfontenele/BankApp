using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

using BankApp.View;
using BankApp.Model;
using BankApp.Extensions;

namespace BankApp.Controller
{
    class LoginController
    {
        private IDatabase database = new Database();

        public string Validation(string cpfUser, string password)
        {
            try
            {
                string passwordHased = new Security().CalculateHash(HashFunctions.SHA256, password);
                List<string> fields = new List<string>() { "CPF", "Password" };
                List<string> parameters = new List<string>() { cpfUser, passwordHased };
                
                database.Connect();
                DataTable results = database.SearchCondition("Client", fields, parameters);
                database.Dispose();

                if(results.Rows.Count > 0)
                {
                    ExecuteLogin(results);
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }

            return "";

        }
        private void ExecuteLogin(DataTable clientData)
        {
            string firstName = clientData.Rows[0]["First_Name"].ToString();
            string lastName = clientData.Rows[0]["Last_Name"].ToString();
            string cpf = clientData.Rows[0]["CPF"].ToString();
            uint account_number = (uint)(Convert.ToDouble(clientData.Rows[0]["Account_Number"]));

            ICliente client = new Client(firstName, lastName, cpf, account_number);
            IAccount account = new Account(client, database);
            AccountController.SetAccount(account);
            IndexController.Action("Account");
        }

    }
}
