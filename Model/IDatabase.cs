using System.Data;
using System.Collections.Generic;

namespace BankApp.Model
{
    interface IDatabase
    {
        void Connect();
        void Dispose();
        DataTable SearchCondition(string tableName, List<string> fields, List<string> parameters);
        DataTable SearchAll(string tableName);
        bool InsertValues(string tableName, List<string> fields, List<string> parameters);

    }
}
