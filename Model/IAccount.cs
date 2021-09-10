using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BankApp.Model
{
    public interface IAccount
    {
        void SetClient(ICliente client);
        uint GetAccountNumber();
        void TransferValues(IAccount account);
        void Investment(float value);
        DataTable Statements(int months);
        void InsertValues(float value);
        void RemoveValues(float value);
        float GetBalanceAvailable();
    }
}
