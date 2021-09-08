using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Model
{
    public interface ICliente
    {
        string FirstName
        {
            set;
            get;
        }
        string LastName
        {
            set;
            get;
        }
        string CPF
        {
            set;
            get;
        }
    }
}
