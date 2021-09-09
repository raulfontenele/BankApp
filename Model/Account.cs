using System;
using System.Collections.Generic;
using System.Data;
using BankApp.Extensions;

namespace BankApp.Model
{
    public class Account: IAccount
    {
        private ICliente client;
        private IDatabase database;

        private float balance = 0;
        public Account(ICliente client, IDatabase database)
        {
            this.client = client;
            this.database = database;
            balance = GetInitialBalance();
        }

        public float GetBalanceAvailable()
        {
            return this.balance;
        }

        public void InsertValues(float value)
        {
            try
            {
                this.balance += value;
                UpdateBalanceDataBase();
                UpdateStatementDataBase(RegisterType.Insert, value);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }

        public void Investment(float value)
        {
            throw new NotImplementedException();
        }

        public void RemoveValues(float value)
        {
            try
            {
                if (value > balance) throw new Exception("Value to remove is bigger than accumulated value in account");
                this.balance -= value;
                UpdateBalanceDataBase();
                UpdateStatementDataBase(RegisterType.Remove, value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
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
        private float GetInitialBalance()
        {
            this.database.Connect();
            List<string> fields = new List<string>() { "Account_Number" };
            List<string> parameters = new List<string>() { client.AccountNumber.ToString() };
            DataTable results =  this.database.SearchCondition("ClientsBalance", fields, parameters);
            float balance = (float)Convert.ToDouble(results.Rows[0]["Balance"]);
            database.Dispose();
            return balance;
        }
        private void UpdateBalanceDataBase()
        {
            List<string> fields = new List<string>() { "Balance" };
            List<string> parameters = new List<string>() { this.balance.ToString() };
            List<string> fieldsCondition = new List<string>() { "Account_Number" };
            List<string> parametersCondition = new List<string>() { this.client.AccountNumber.ToString() };
            database.Connect();
            database.UpdateValues("ClientsBalance", fields, parameters, fieldsCondition, parametersCondition);
            database.Dispose();
        }
        private void UpdateStatementDataBase(RegisterType type, float value)
        {
            List<string> fields = new List<string>() { "Account_Number","Register_Datetime", "Register_Type", "Register_Value" };
            List<string> parameters = new List<string>() { this.client.AccountNumber.ToString(),DateTime.Now.ToString(), type.ToString(), value.ToString() };
            database.Connect();
            database.InsertValues("ClientsStatement", fields, parameters);
            database.Dispose();
        }
    }
}
