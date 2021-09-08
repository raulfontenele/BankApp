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
    }
}
