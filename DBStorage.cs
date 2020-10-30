using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Data.SQLite;

using System.Collections.Generic;

using System.Data;

namespace PHP_Optimizer
{
    internal class DBStorage
    {
        public static class SQLite
        {
            public static DataTable Query(string tableName, string query)
            {
                string DatabaseFile = "Database.sqlite";

                if (!File.Exists(DatabaseFile))
                {
                    SQLiteConnection.CreateFile(DatabaseFile);
                }

                try
                {
                    using (SQLiteConnection DatabaseConnection = new SQLiteConnection(string.Format("Data Source={0};Version=3;", DatabaseFile)))
                    {
                        DatabaseConnection.Open();

                        if (query.Contains("insert", StringComparison.OrdinalIgnoreCase) || query.Contains("UPDATE", StringComparison.OrdinalIgnoreCase) || query.Contains("create table", StringComparison.OrdinalIgnoreCase))
                        {
                            SQLiteCommand NewQuery = new SQLiteCommand(query, DatabaseConnection);
                            NewQuery.ExecuteNonQuery();

                            return null;
                        }
                        else if (query.Contains("select", StringComparison.OrdinalIgnoreCase))
                        {
                            using (SQLiteCommand fmd = DatabaseConnection.CreateCommand())
                            {
                                fmd.CommandText = query;
                                fmd.CommandType = CommandType.Text;
                                SQLiteDataReader r = fmd.ExecuteReader();
                                DataTable dt = new DataTable();
                                dt.Load(r);
                                return dt;
                            }
                        }
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(query);
                    return null;
                }
            }
        }
    }

    public static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }
    }
}