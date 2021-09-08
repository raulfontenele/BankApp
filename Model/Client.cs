using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Model
{
    public class Client : ICliente
    {
        private string firstName;
        private string lastName;
        private string cpf;
        private uint accountNumber;

        public Client(string firstName, string lastName, string cpf, uint accountNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.cpf = cpf;
            this.accountNumber = accountNumber;
        }
        
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string CPF { get => cpf; set => cpf = value; }
        public string AccountNumber { get => AccountNumber; set => AccountNumber = value; }
    }
}
