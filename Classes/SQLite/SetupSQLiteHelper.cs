using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GBF_Never_Buddy.Classes.GameDataClasses.Weapon;
using static GBF_Never_Buddy.Classes.GameDataClasses;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace NeverGuildWar_Buddy.Classes.SQLite
{
    public class SetupSQLiteHelper : SQLiteHelper
    {
        public List<Job> ClassesList()
        {
            List<Job> data = new();
            string queryString =
            $"SELECT * FROM dbo.GachaCharacterList;";
            string test = $"SELECT * FROM MCJobs;";
            try
            {
                data = DBData(test);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");

            }
            return data;
        }

        public List<Job> DBData(string queryString)
        {
            List<Job> dataList = new();

            using (SqliteConnection connection = new SqliteConnection(
               GetConnectionString()))
            {
                SqliteCommand command = new SqliteCommand(
                queryString, connection);
                connection.Open();
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    AddDataToList((IDataRecord)reader, dataList);

                }
                reader.Close();
                connection.Close();
                return dataList;


            }
        }
        private void AddDataToList(IDataRecord dataRecord, List<Job> data)
        {
            string name = "";
            string image = "";
            if (dataRecord[1] is not null && dataRecord[2] != null)
            {
                name = (string)dataRecord[1];
                image = (string)dataRecord[2];

                Job job = new(name, image);
                data.Add(job);
                Debug.WriteLine($"Data is {name}");
            }

        }

        public List<SetupSpecs> GetSetupsData()
        {
            List<SetupSpecs> list = new List<SetupSpecs>();
            string queryString =
           "SELECT * FROM SetupDetails;";
            int index = 1;
            try
            {
                using (SqliteConnection connection = new SqliteConnection(
                        GetConnectionString()))
                {

                    SqliteCommand command = new SqliteCommand(
                    queryString, connection);
                    connection.Open();
                    SqliteDataReader reader;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CreateDataAddToList((IDataRecord)reader, list);
                        Debug.WriteLine($"Ran {index} times");
                        index++;
                    }
                    connection.Close();
                    return list;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");

            }
            return list;
        }

        private void CreateDataAddToList(IDataRecord dataRecord, List<SetupSpecs> list)
        {
            Debug.WriteLine("Running createAddtolist");
            for(int i = 0; i < dataRecord.FieldCount; i++)
            {
                Debug.WriteLine($"{i}: {dataRecord[i]}");
            }
            int id = 0;
            string time = "";
            TimeSpan s;
            string difficulty = "";
            string element = "";
            string revive = "NA";
            int times = -1;
            string type = "NA";
            string desc = "NA";
            try
            {
                if (dataRecord[8] is not null)
                {
                    desc = (string)dataRecord[8];
                }
            }
            catch (Exception ex) { }
            if (dataRecord[0] is not null && dataRecord[1] is not null && dataRecord[2] != null && dataRecord[3] != null)
            {
                for(int i = 0; i < dataRecord.FieldCount; i++) 
                {
                    Debug.WriteLine($"{dataRecord[i]} type: {dataRecord[i].GetType()}");
                }
                

                id = (int)(long)dataRecord[0];
                Debug.WriteLine("Got id");
                difficulty = (string)dataRecord[1];
                Debug.WriteLine("Got difficulty");
                time = (string)dataRecord[2];
                //nvarchar(16)
                Debug.WriteLine($"Got time {time}");
                element = (string)dataRecord[4];
                if (dataRecord[5] is not null && dataRecord[6] is not null)
                {
                    revive = (string)dataRecord[5];
                    times = (int)(long)dataRecord[6];

                }
                if (dataRecord[7] is not null)
                {
                    type = (string)dataRecord[7];
                }
               
                GWBattleDetails raidDetails = new(difficulty, time, element, revive, times, type, desc);
                List<string> party = TableStrData("PartyCharacter", id);
                List<string> weapon = TableStrData("PartyWeaponGrid", id);
                List<string> summons = TableStrData("PartySummons", id);
                SetupSpecs setup = new(id, party, weapon, summons, raidDetails);
                list.Add(setup);
            }
        }

        public Job JobData(string name)
        {
            Job job = new("NA", "NA");
            string queryString =
            $"SELECT * FROM MCJobs WHERE Name='{name}';";
            try
            {
                

                using (SqliteConnection connection = new SqliteConnection(
                        GetConnectionString()))
                {

                    SqliteCommand command = new SqliteCommand(
                    queryString, connection);
                    connection.Open();
                    SqliteDataReader reader;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        job = SingleDataRecord((IDataRecord)reader);
                    }
                    connection.Close();
                    return job;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");

            }
            return job;
        }

        public List<string> TableStrData(string table, int id)
        {
            List<string> data = new List<string>();
            string queryString =
            $"SELECT * FROM {table} WHERE Id={id};";
            try
            {
                using (SqliteConnection connection = new SqliteConnection(
                        GetConnectionString()))
                {

                    SqliteCommand command = new SqliteCommand(
                    queryString, connection);
                    connection.Open();
                    SqliteDataReader reader;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        AddClassDataToList((IDataRecord)reader, data);
                    }
                    connection.Close();
                    return data;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");

            }
            return data;
        }

        private Job SingleDataRecord(IDataRecord record)
        {
            string name = (string)record[1];
            string image = (string)record[2];   
            Job j = new(name,image);
            return j;
        }

        private void AddClassDataToList(IDataRecord dataRecord, List<string> data)
        {
            for(int i = 0; i < dataRecord.FieldCount; i++)
            {
                Debug.WriteLine($"{i}:{dataRecord[i]}");
            }
            //Debug.WriteLine(dataRecord.FieldCount);
            for (int i = 0; i < dataRecord.FieldCount; i++)
            {
                
                if (i != 0)
                {
                    var input = dataRecord[i];
                    if (input is TimeSpan)
                    {
                        if (i == 2)
                        {
                            TimeSpan timeSpan = (TimeSpan)dataRecord[2];
                            var output = $"{(int)timeSpan.TotalMinutes}:{timeSpan.Seconds:00}";
                            string time = output.ToString();
                            data.Add(time);
                            Debug.WriteLine($"Adding {i}:{dataRecord[i]}");
                        }
                    }
                    if (input is string)
                    {
                        Debug.WriteLine($"Adding str {i}:{dataRecord[i]}");
                        data.Add((string)dataRecord[i]);
                    }
                    if (input is long)
                    {
                        Debug.WriteLine($"Adding int {i}:{dataRecord[i]}");
                        long value = (long)dataRecord[i];
                        data.Add(value.ToString());
                    }

                }
            }
            if (dataRecord.FieldCount < 7)
            {
                //data.Add("NA");
            }

        }

           

        public int SetupsCount()
        {
            int count = 0;
            string queryString =
            "SELECT * FROM SetupDetails;";
            try
            {
                using (SqliteConnection connection = new SqliteConnection(
                        GetConnectionString()))
                {

                    SqliteCommand command = new SqliteCommand(
                    queryString, connection);
                    connection.Open();
                    SqliteDataReader reader;
                    reader = command.ExecuteReader();
                    string output = "";
                    while (reader.Read())
                    {
                        count++;
                    }
                    connection.Close();
                    return count;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");

            }
            return -1;
        }


    }

}
