using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace GKProxy
{
    public static class SQL
    {
        private static string DBName = "database.db";
        private static string TableName = "Data";

        public static void Test()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn , TableName);
            ListToDB(MyProxy.TheProxy._list);
            //ReadData(sqlite_conn , TableName);
        }

        public static void ListToDB(List<string> list)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            foreach (string item in list)
            {
                InsertData(sqlite_conn , TableName , item);
            }
        }

        private static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=" + DBName + "; Version = 3; New = True; Compress = True; ");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sqlite_conn;
        }

        private static void CreateTable(SQLiteConnection conn, string table)
        {
                SQLiteCommand sqlite_cmd;
                string Createsql = "CREATE TABLE  IF NOT EXISTS " + table + "(Col1 VARCHAR(20))";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = Createsql;
                sqlite_cmd.ExecuteNonQuery();
        }

        private static void InsertData(SQLiteConnection conn, string table,string data )
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO " + table + "(Col1) VALUES('" + data + "'); ";
            sqlite_cmd.ExecuteNonQuery();
        }

        public static List<string> ReadData(string table)
        {
            List<string> newlist = new List<string>();
            SQLiteConnection sqlite_conn_read = new SQLiteConnection("Data Source=" + DBName + "; Version = 3; New = True; Compress = True; ");
            sqlite_conn_read.Open();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = sqlite_conn_read.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM " + table;

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                newlist.Add(myreader);
            }
            sqlite_conn_read.Close();
            return newlist;
        }
    }
}
