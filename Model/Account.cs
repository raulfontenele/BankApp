using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Model
{
    public class Account: IAccount
    {
        private ICliente client;
        public Account(ICliente client)
        {
            this.client = client;
        }

        public void InsertValues()
        {
            throw new NotImplementedException();
        }

        public void Investment(float value)
        {
            throw new NotImplementedException();
        }

        public void RemoveValues()
        {
            throw new NotImplementedException();
        }

        public void SetClient(ICliente client)
        {
            throw new NotImplementedException();
        }

        public void Statements()
        {
            throw new NotImplementedException();
        }

        public void TransferValues(IAccount account)
        {
            throw new NotImplementedException();
        }
    }
}
