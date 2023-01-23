using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GBF_Never_Buddy.Classes.GameDataClasses;
using Microsoft.Data.Sqlite;
using GBF_Never_Buddy.Classes;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Reflection;
using System.Xml.Linq;
using System.Xml;
using NeverGuildWar_Buddy.Forms;
using ProgressBar = NeverGuildWar_Buddy.Forms.ProgressBar;

namespace NeverGuildWar_Buddy.Classes.SQLite
{
    internal class SummonSQLiteHelper : SQLiteHelper
    {
        BackgroundWorker? backgroundWorker;

        public void SetBackgroundWorker(BackgroundWorker? backgroundWorker)
        {
            this.backgroundWorker = backgroundWorker;
        }

        private string UpdateTableQueryString(GameDataClasses.Summon data, int id)
        {
            string query = $"INSERT INTO [SSRSummons] ([Id], [Name], [Element], [Series], [Image], [Link]) VALUES" +
                $" ({id},'{data.name}','{data.element}','{data.series}','{data.image}','{data.link}')";
            return query;
        }
        public void UpdateDBFromXML()
        {
            string? path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string? filePath = null;
            if (path != null)
            {
                Debug.WriteLine(path);
                filePath = Path.Combine(path, @"Database\SSRSummons.xml");
                Debug.WriteLine(filePath);
                if (File.Exists(filePath))
                {
                    UpdateDataFromXML(filePath);
                }
                if (!File.Exists(filePath))
                {
                    MBHelper mB = new MBHelper();
                    string caption = $"Error Adding to DB";
                    string msg = $"File doesn't exists at {Directory.GetCurrentDirectory()}";
                    mB.ErrorMB(msg, caption);

                }
            }
        }

        private async void UpdateDataFromXML(string path)
        {
            MBHelper helper = new MBHelper();
            Stopwatch timer = Stopwatch.StartNew();
            XmlDocument doc = new XmlDocument();
            ProgressBar progressBarForm;
            progressBarForm = new();
            doc.PreserveWhitespace = true;
            int addCount = 0;
            try { doc.Load(path); }
            catch (System.IO.FileNotFoundException)
            {

            }
            XmlNode? root = doc.SelectSingleNode("summons");
            try
            {

                if (root != null)
                {
                    LockParent();
                    string header = "Adding Summon into Database";
                    progressBarForm.Text = header;
                    XmlNodeList? xnList = root.SelectNodes("summon");
                    var document = XDocument.Load(path);
                    XElement? xmlTree = document.Root;
                    //Console.Write(document.ToString());

                    string cap = $"Adding summons";
                    progressBarForm.SetCaption(cap);
                    progressBarForm.Show();
                    document.Descendants().Where(t => string.IsNullOrEmpty(t.Value)).Remove();
                    doc.Save(path);
                    int index = 1;
                    int newIndex = DataCount();
                    List<string> nameList = DataList();
                    int count = 0;

                    if (xmlTree != null && xnList != null)
                    {
                        progressBarForm.SetMinMaxProg(count, xnList.Count, 1);
                        int finalPercentage = 1;
                        Debug.WriteLine($"Size is: {newIndex}, List:{xnList.Count}, %:{finalPercentage}");
                        foreach (XmlNode xn in xnList)
                        {

                            string series = xn.Attributes["series"].Value;
                            string name = xn["name"].InnerText;
                            string element = xn["element"].InnerText;
                            string img = xn["image"].InnerText;
                            string link = xn["link"].InnerText;
                            if (!InDB(name, nameList))
                            {

                                newIndex++;
                                string nameCleaned = FormatSqlString(name);
                                GameDataClasses.Summon data = new(nameCleaned, series, element, img, link);
                                string query = UpdateTableQueryString(data, newIndex);
                                RunSQLQuery(query);
                                if (backgroundWorker != null)
                                {

                                    string caption = $"Added {data.name} to gacha character database.";

                                    count += finalPercentage;
                                    progressBarForm.SetCaption(caption);
                                    backgroundWorker.ReportProgress(count);
                                    progressBarForm.BarStepUp();
                                    await Task.Delay(50);
                                }
                                addCount++;
                                Debug.WriteLine($"Added data #{newIndex} {nameCleaned}, {element}, {img}");
                            }
                            index++;
                        }
                    }


                }
                if (backgroundWorker != null)
                {
                    backgroundWorker.ReportProgress(100);
                }
                progressBarForm.Close();
                UnlockParent();

            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("XPath could not find an item", e);
            }
            timer.Stop();
            TimeSpan timespan = timer.Elapsed;

            string time = String.Format("{0:00}:{1:00}:{2:00}", timespan.Minutes, timespan.Seconds, timespan.Milliseconds / 10);
            Debug.WriteLine($"Elapsed time for function loadXMLData(): {time}");
            string msg = $"Added {addCount} summons in {time}";
            string cap2 = $"Finished adding {addCount} summons into SSR Summons Database";
            if (addCount > 0)
            {
                helper.SuccessMB(msg, cap2);

            }


        }



        private bool InDB(string name, List<string> names)
        {

            foreach (string dataName in names)
            {
                if (dataName == name)
                {
                    return true;
                }
            }
            return false;
        }

        public int DataCount()
        {
            int count = 0;
            string queryString =
            "SELECT * FROM SSRSummons;";
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
                        count++;
                    }
                    Debug.WriteLine(output);
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

        public List<Summon> List()
        {
            List<Summon> dataList = new();
            string queryString =
            $"SELECT * FROM SSRSummons;";
            try
            {
                using (SqlConnection connection = new SqlConnection(
                        GetConnectionString()))
                {

                    Debug.WriteLine(connection.Database);
                    Debug.WriteLine(queryString);
                    SqlCommand command = new SqlCommand(
                    queryString, connection);
                    connection.Open();
                    SqlDataReader reader;
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

        public List<Summon> FilteredList()
        {
            List<Summon> dataList = new();
            string queryString =
            $"SELECT * FROM SSRSummons WHERE Series='Classic' OR Series='Premium' OR Series='Summer/Yukata'";
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

        private List<string> DataList()
        {
            string queryString =
            "SELECT * FROM SSRSummons;";
            List<string> charNames = new();
            int index = 1;
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
                    while (reader.Read())
                    {
                        UpdateDBNameList((IDataRecord)reader, charNames);
                        Debug.WriteLine($"Ran {index} times");
                        index++;
                    }
                    Debug.WriteLine(charNames.Count());
                    connection.Close();
                    return charNames;

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");

            }
            return charNames;
        }

        public List<Summon> SummonList()
        {
            List<Summon> data = new();
            string queryString =
            $"SELECT * FROM dbo.GachaCharacterList;";
            string test = $"SELECT * FROM SSRSummons WHERE Series='Classic' OR Series='Premium' OR Series='Summer/Yukata';";
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

        public List<Summon> AllSummonList()
        {
            List<Summon> data = new();
            string queryString =
            $"SELECT * FROM dbo.GachaCharacterList;";
            string test = $"SELECT * FROM SSRSummons;";
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


        public List<Summon> DBData(string queryString)
        {
            List<Summon> dataList = new();

            using (SqliteConnection connection = new SqliteConnection(
               GetConnectionString()))
            {
                Debug.WriteLine("Getting Data Test");

                Debug.WriteLine(connection.Database);
                Debug.WriteLine(queryString);
                SqliteCommand command = new SqliteCommand(
                queryString, connection);
                connection.Open();
                Debug.WriteLine("A1");
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    AddDataToList((IDataRecord)reader, dataList);

                }
                Debug.WriteLine("A2");
                reader.Close();
                connection.Close();
                Debug.WriteLine(dataList.Count);
                return dataList;


            }
        }

        public Summon QueriedSummon(string name)
        {
            List<Summon> summons = new();
            int index = 0;
            string queryString =
           $"SELECT * FROM SSRSummons WHERE Name='{name}';";
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
                    while (reader.Read())
                    {
                        AddDataToList((IDataRecord)reader, summons);
                        Debug.WriteLine($"Ran {index} times");
                        index++;
                    }
                    connection.Close();
                    Summon summon = summons[0];
                    return summon;

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");

            }
            Summon summon1 = summons[0];
            return summon1;
        }

        private void UpdateDBNameList(IDataRecord dataRecord, List<string> charNames)
        {
            string name = "";
            if (dataRecord[1] is not null && dataRecord[2] != null && dataRecord[3] != null
                && dataRecord[4] != null)
            {
                name = (string)dataRecord[1];
                Debug.WriteLine($"Adding {name} to list");
                charNames.Add(name);
            }

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
