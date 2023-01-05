using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GBF_Never_Buddy.Classes.GameDataClasses;
using Microsoft.Data.Sqlite;

namespace NeverGuildWar_Buddy.Classes.SQLite
{
    internal class SummonSQLiteHelper : SQLiteHelper
    {
        public List<Summon> List()
        {
            List<Summon> dataList = new();
            string queryString =
            $"SELECT * FROM SSRSummons;";
            try
            {
                using (SqliteConnection connection = new SqliteConnection(
                        GetConnectionString()))
                {

                    Debug.WriteLine(connection.Database);
                    Debug.WriteLine(queryString);
                    SqliteCommand command = new SqliteCommand(
                    queryString, connection);
                    connection.Open();
                    SqliteDataReader reader;
                    reader = command.ExecuteReader();
                    string output = "";
                    while (reader.Read())
                    {
                        AddDataToList((IDataRecord)reader, dataList);
                    }
                    Debug.WriteLine(output);
                    connection.Close();
                    return dataList;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");

            }
            return dataList;
        }

        private void AddDataToList(IDataRecord dataRecord, List<Summon> data)
        {
            string name = "";
            string element = "";
            string link = "";
            string series = "";
            string image = "";
            if (dataRecord[1] is not null && dataRecord[2] != null && dataRecord[3] != null
                && dataRecord[4] != null && dataRecord[5] != null)
            {
                name = (string)dataRecord[1];
                element = (string)dataRecord[2];
                series = (string)dataRecord[3];
                image = (string)dataRecord[4];
                link = (string)dataRecord[5];

                Summon summon = new(name, element, series, image, link);
                data.Add(summon);
                Debug.WriteLine($"Data is {name}, {element}, {series}");
            }

        }
    }
}
