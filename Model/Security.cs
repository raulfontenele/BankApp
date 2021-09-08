using System;
using System.Security.Cryptography;
using System.Text;
using BankApp.Extensions;

namespace BankApp.Model
{
    public class Security
    {
        public string CalculateHash(HashFunctions function, string password)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(password);
            HashAlgorithm hashAlg = HashAlgorithm.Create(function.ToString());
            byte[] hashed = hashAlg.ComputeHash(byteArray);
            return Extensions.Extensions.BytesToString(hashed).Replace(" ","");
        }
    }
}
