using System;
using System.Data;
using System.Linq;
using BankApp.Model;

namespace BankApp.Controller
{
    public static class AccountController
    {
        private static IAccount account;

        public static void SetAccount(IAccount accountC)
        {
            account = accountC;
        }
        public static float GetBalanceValue()
        {
            return account.GetBalanceAvailable();
        }
        public static void AddValueAccount(float value)
        {
            account.InsertValues(value);
        }
        public static void RemoveValueAccount(float value)
        {
            account.RemoveValues(value);
        }
        public static DataTable GetStatements(int numMonths)
        {
            DateTime currentDatetime = DateTime.Now;
            DateTime lastDatetime = DateTime.Now.AddMonths(-numMonths);

            DataTable results = account.Statements(numMonths);

            var filteredResults = from rows in results.AsEnumerable()
                           where rows.Field<DateTime>("Register_Datetime") > lastDatetime && rows.Field<DateTime>("Register_Datetime") <= currentDatetime
                           select rows;

            return filteredResults.CopyToDataTable();
        }
    }
}
