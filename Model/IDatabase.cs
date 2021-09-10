using System.Data;
using System.Collections.Generic;

namespace BankApp.Model
{
    public interface IDatabase
    {
        void Connect();
        void Dispose();
        DataTable SearchCondition(string tableName, List<string> fields, List<string> parameters);
        DataTable SearchBetween(string tableName, List<string> fields, List<string> parameters);
        DataTable SearchAll(string tableName);
        bool InsertValues(string tableName, List<string> fields, List<string> parameters);
        bool UpdateValues(string tableName, List<string> fields, List<string> parameters, List<string> fieldsCondition, List<string> parametersCondition);
    }
}
