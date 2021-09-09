using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.Data;

using System.Diagnostics;


using BankApp.View;
using BankApp.Model;
using BankApp.Extensions;

namespace BankApp.Controller
{
    class RegisterController
    {
        private IDatabase database;

        public string Register(string name, string lastName, string cpf, string password)
        {
            string errorMessage = "";
            try
            {
                database = new Database();
                database.Connect();

                string passwordHashed = new Security().CalculateHash(HashFunctions.SHA256, password);
                string accountNumber = GetNumberAccount().ToString();

                List<String> listFields = new List<string>() { "First_Name", "Last_Name", "CPF", "Account_Number", "Password" };
                List<String> listValues = new List<string>() { name, lastName, cpf, accountNumber, passwordHashed };
                database.InsertValues("Client", listFields, listValues);

                listFields = new List<string>() { "Account_Number", "Balance" };
                listValues = new List<string>() { accountNumber, "0" };
                database.InsertValues("ClientsBalance", listFields, listValues);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                errorMessage = e.Message.ToString();
            }
            finally
            {
                database.Dispose();
            }
            
            return errorMessage;
        }

        private int GetNumberAccount()
        {
            database = new Database();
            database.Connect();

            var data = database.SearchAll("Client");
            return data.Rows.Count + 1;
        }


    }
}
