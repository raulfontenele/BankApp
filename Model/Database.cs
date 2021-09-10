using System;
using System.Data.SqlServerCe;
using System.IO;
using System.Collections.Generic;
using System.Data;

namespace BankApp.Model
{
    class Database : IDatabase
    {
        private string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Database\";
        private string databaseName = "ClientsDataBase.sdf";

        private SqlCeConnection connection;

        public void Connect()
        {
            try
            {
                if (!Directory.Exists(path))
                    throw new Exception("Path of database does not exist");
                if (!File.Exists(String.Concat(path, databaseName)))
                    throw new Exception("Database does not exist");

                connection = new SqlCeConnection();
                connection.ConnectionString = @"Data Source = " + String.Concat(path, databaseName);
                connection.Open();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
        public DataTable SearchCondition(string tableName, List<string> fields, List<string> parameters)
        {
            DataTable results = new DataTable();
            try
            {
                if (fields.Count != parameters.Count) throw new Exception("Number of fields isn't the same as parameters");

                SqlCeCommand command = new SqlCeCommand();
                command.Connection = connection;

                
                string query = "SELECT * FROM " + tableName + " WHERE ";
                for (int i = 0; i < fields.Count; i++)
                {
                    query = String.Concat(query,fields[i], " = @", fields[i]);
                    if(i!= fields.Count-1) query = String.Concat(query, " AND ");
                }
                command.CommandText = query;
                for (int i = 0; i < fields.Count; i++)  command.Parameters.AddWithValue(String.Concat("@", fields[i]), parameters[i]);

                object returned = command.ExecuteReader();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(command);

                adapter.Fill(results);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            return results;
        }
        public DataTable SearchBetween(string tableName, List<string> fields, List<string> parameters)
        {
            DataTable results = new DataTable();
            try 
            { 
                SqlCeCommand command = new SqlCeCommand();
                command.Connection = connection;


                string query = "SELECT * FROM " + tableName + " WHERE (";
                for (int i = 0; i < fields.Count; i++)
                {
                    query = String.Concat(query,fields[i], " BETWEEN  @", "field",(2*i).ToString(), " AND @", "field", (2 * i + 1).ToString(), ")");
                    if (i != fields.Count - 1) query = String.Concat(query, " OR ");
                    command.Parameters.AddWithValue(String.Concat("@field", (2 * i).ToString()), parameters[2 *i]);
                    command.Parameters.AddWithValue(String.Concat("@field", (2 * i + 1).ToString()), parameters[2 * i + 1]);
                }
                command.CommandText = query;
                //for (int i = 0; i < fields.Count; i++) command.Parameters.AddWithValue(String.Concat("@", fields[i]), parameters[i]);

                object returned = command.ExecuteReader();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(command);

                adapter.Fill(results);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            return results;
        }
        public DataTable SearchAll(string tableName)
        {
            DataTable results = new DataTable();
            try
            {
                string query = "SELECT * FROM " + tableName ;
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query,connection);
                adapter.Fill(results);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            return results;
        }
        public bool InsertValues(string tableName, List<string> fields, List<string> parameters)
        {
            bool response;
            try
            {
                if (fields.Count != parameters.Count) throw new Exception("Number of fields isn't the same as parameters");

                SqlCeCommand command = new SqlCeCommand();

                string query = "INSERT INTO " + tableName + " (";
                for (int i = 0; i < fields.Count; i++)
                {
                    command.Parameters.AddWithValue(String.Concat("@", fields[i]), parameters[i]);
                    query = String.Concat(query, fields[i]);
                    if (i != fields.Count - 1) query = String.Concat(query, ", ");
                }
                query = String.Concat(query, " ) VALUES (");
                for (int i = 0; i < fields.Count; i++)
                {
                    query = String.Concat(query, "@", fields[i]);
                    if (i != fields.Count - 1) query = String.Concat(query, ", ");
                }
                query = String.Concat(query, " )");

                command.CommandText = query;
                command.Connection = connection;
                int numLines = command.ExecuteNonQuery();
                response = (numLines != 0) ? true : false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                response = false;
            }
            return response;
        }
        public bool UpdateValues(string tableName, List<string> fields, List<string> parameters, List<string> fieldsCondition, List<string> parametersCondition)
        {
            bool response;
            try
            {
                if (fields.Count != parameters.Count) throw new Exception("Number of fields isn't the same as parameters");
                if (fieldsCondition.Count != parametersCondition.Count) throw new Exception("Number of fields isn't the same as parameters");

                SqlCeCommand command = new SqlCeCommand();

                string query = "UPDATE " + tableName + " SET ";
                for (int i = 0; i < fields.Count; i++)
                {
                    command.Parameters.AddWithValue(String.Concat("@", fields[i]), parameters[i]);
                    query = String.Concat(query, fields[i], " = @", fields[i]);
                    if (i != fields.Count - 1) query = String.Concat(query, ", ");
                }
                query = String.Concat(query, " WHERE ");
                for (int i = 0; i < fieldsCondition.Count; i++)
                {
                    command.Parameters.AddWithValue(String.Concat("@", fieldsCondition[i]), parametersCondition[i]);
                    query = String.Concat(query, fieldsCondition[i], " = @", fieldsCondition[i]);
                    if (i != fields.Count - 1) query = String.Concat(query, ", ");
                }

                command.CommandText = query;
                command.Connection = connection;
                int numLines = command.ExecuteNonQuery();
                response = (numLines != 0) ? true : false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                response = false;
            }
            return response;
        }
        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
