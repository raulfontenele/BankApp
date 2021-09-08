using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Model
{
    public interface IAccount
    {
        void SetClient(ICliente client);
        void TransferValues(IAccount account);
        void Investment(float value);
        void Statements();
        void InsertValues();
        void RemoveValues();
    }
}
