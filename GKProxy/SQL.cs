using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace GKProxy
{
    public static class Sql
    {
        private static string DBName = "database.db";
        private static string TableName = "Data";
        private static string ColumnName = "Traffic";

        private static SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBName + "; Version = 3; Compress = True; ");

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
            List<string> readDatalist = new List<string>();

            try
            {
                conn.Open();
            }
            catch
            {
                conn.Close();
                conn.Open();
            }

            SQLiteCommand sqliteCmd = conn.CreateCommand();
            sqliteCmd.CommandText = "SELECT * FROM " + table;

            var sqliteDatareader = sqliteCmd.ExecuteReader();
            while (sqliteDatareader.Read())
            {
                string myreader = sqliteDatareader.GetString(0);

                if (myreader != null)
                {
                    readDatalist.Add(myreader);
                }
            }
            conn.Close();
            return readDatalist;
        }

        public static void InsertData(string data)
        {
            SQLiteConnection connInsert = new SQLiteConnection("Data Source=" + DBName + "; Version = 3; Compress = True; ");
            connInsert.Open();
            SQLiteCommand sqliteCmd = connInsert.CreateCommand();
            sqliteCmd.CommandText = "INSERT INTO " + TableName + "(" + ColumnName + ") VALUES('" + data.Truncate(255) + "'); ";

            sqliteCmd.ExecuteNonQuery();
            connInsert.Close();
        }

        private static void SetupDatabase()
        {
            SQLiteConnection newdbConn = new SQLiteConnection("Data Source=" + DBName + "; Version = 3; New = True; Compress = True; ");
            newdbConn.Open();
            CreateTable();
            newdbConn.Close();
        }

        private static void DeleteDatabase()
        {
            if (File.Exists(DBName))
            {
                File.Delete(DBName);
            }
            else
            {
                MessageBox.Show(@"Database(" + DBName + ") to be removed not found ");
            }
        }

        private static void CreateTable()
        {
            conn.Open();
            SQLiteCommand sqliteCmd = conn.CreateCommand();

            sqliteCmd.CommandText = "CREATE TABLE  IF NOT EXISTS " + TableName + "(" + ColumnName + " VARCHAR(255))";
            sqliteCmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}

public static class StringExt
{
    public static string Truncate(this string value, int maxLength)
    {
        if (string.IsNullOrEmpty(value)) return value;
        return value.Length <= maxLength ? value : value.Substring(0, maxLength);
    }
}
