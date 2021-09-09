using System;
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
    }
}
