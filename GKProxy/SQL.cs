using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MyProxy;

namespace GKProxy
{
    public static class SQL
    {
        private static string DBName = "database.db";
        private static string TableName = "Data";

        static SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBName + "; Version = 3; Compress = True; ");

        public static void CreateDatabase()
        {
            if (!File.Exists(DBName))
            {
                SetupDatabase();
            }
            else
            {
                DeleteDatabase();
                SetupDatabase();
            }
        }

        public static List<string> ReadData(string table)
        {
            List<string> ReadDatalist = new List<string>();

            SQLiteDataReader sqlite_datareader = null;
            SQLiteCommand sqlite_cmd = null;

            try
            {
                conn.Open();
            }
            catch
            {
                conn.Close();
                conn.Open();
            }

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM " + table;

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);

                if (myreader != null)
                {
                    ReadDatalist.Add(myreader);
                }
            }
            conn.Close();
            return ReadDatalist;
        }

        public static void ListToDB(List<string> list)
        {
            if (list != null || list.Count != 0)
            {
                List<string> newList = new List<string>(list);

                foreach (string item in newList)
                {
                    InsertData(TableName, item);
                }
            }
        }

        private static void SetupDatabase()
        {
            SQLiteConnection Newdb_conn = new SQLiteConnection("Data Source=" + DBName + "; Version = 3; New = True; Compress = True; ");
            Newdb_conn.Open();
            CreateTable();
            Newdb_conn.Close();
        }

        private static void DeleteDatabase()
        {
            if (File.Exists(DBName))
            {
                File.Delete(DBName);
            }
            else
            {
                MessageBox.Show("Database(" + DBName + ") to be removed not found ");
            }
        }

        private static void CreateTable()
        {
            conn.Open();
            SQLiteCommand sqlite_cmd = conn.CreateCommand();

            sqlite_cmd.CommandText = "CREATE TABLE  IF NOT EXISTS " + TableName + "(Traffic VARCHAR(20))";
            sqlite_cmd.ExecuteNonQuery();
            conn.Close();
        }

        private static void InsertData(string table,string data )
        {
            SQLiteConnection connInsert = new SQLiteConnection("Data Source=" + DBName + "; Version = 3; Compress = True; ");
            connInsert.Open();
            SQLiteCommand sqlite_cmd = connInsert.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO " + table + "(Traffic) VALUES('" + data + "'); ";
            sqlite_cmd.ExecuteNonQuery();
            connInsert.Close();
        }


    }
}
