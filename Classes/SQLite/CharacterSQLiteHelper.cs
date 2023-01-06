using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using static GBF_Never_Buddy.Classes.GameDataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using NeverGuildWar_Buddy.Classes.SQLite;
using GBF_Never_Buddy.Classes;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Reflection;
using System.Xml.Linq;
using System.Xml;
using NeverGuildWar_Buddy.Forms;
using ProgressBar = NeverGuildWar_Buddy.Forms.ProgressBar;

namespace NeverGuildWar_Buddy.Classes.SQlite
{
    internal class CharacterSQLiteHelper : SQLiteHelper
    {
        BackgroundWorker? backgroundWorker;

        public void SetBackgroundWorker(BackgroundWorker? backgroundWorker)
        {
            this.backgroundWorker = backgroundWorker;
        }

        private string UpdateCharTableQueryString(GameDataClasses.Character character, int id)
        {
            string query = $"INSERT INTO [SSRCharacters] ([Id], [Name], [Element], [Series], [Image], [Link]) VALUES" +
                $" ({id},'{character.name}','{character.element}','{character.series}','{character.image}','{character.link}')";
            return query;
        }

        public void UpdateCharDBFromXML()
        {
            string? path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string? filePath = null;
            if (path != null)
            {
                Debug.WriteLine(path);
                filePath = Path.Combine(path, @"Database\SSRCharacters.xml");
                Debug.WriteLine(filePath);
                if (File.Exists(filePath))
                {
                    UpdateCharDataFromXML(filePath);
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

        private async void UpdateCharDataFromXML(string path)
        {
            Debug.WriteLine("Hello");
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
            XmlNode? root = doc.SelectSingleNode("characters");
            try
            {

                if (root != null)
                {
                    LockParent();
                    string header = "Adding Character into Database";
                    progressBarForm.Text = header;
                    XmlNodeList? xnList = root.SelectNodes("character");
                    var document = XDocument.Load(path);
                    XElement? xmlTree = document.Root;
                    //Console.Write(document.ToString());

                    string cap = $"Adding characters";
                    progressBarForm.SetCaption(cap);
                    progressBarForm.Show();
                    document.Descendants().Where(t => string.IsNullOrEmpty(t.Value)).Remove();
                    doc.Save(path);
                    int index = 1;
                    //int newIndex = 1;
                    int newIndex = CharsCount();
                    List<string> characters = CharList();
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
                            var exists = await InCharDB(name, characters);
                            if (!exists)
                            {

                                newIndex++;
                                string nameCleaned = FormatSqlString(name);
                                GameDataClasses.Character character = new(nameCleaned, element, series, img, link);
                                string query = UpdateCharTableQueryString(character, newIndex);
                                try
                                {
                                    RunSQLQuery  (query);
                                }
                                catch (Exception ex)
                                {
                                    Debug.WriteLine($"{ ex.Message}"); 
                                }
                                if (backgroundWorker != null)
                                {

                                    string caption = $"Added {character.name} {character.series} to gacha character database.";

                                    count += finalPercentage;
                                    progressBarForm.SetCaption(caption);
                                    backgroundWorker.ReportProgress(count);
                                    progressBarForm.BarStepUp();
                                    await Task.Delay(65);
                                }
                                addCount++;
                                Debug.WriteLine($"Added character #{newIndex} {nameCleaned}, {element}, {img}");
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
            string msg = $"Added {addCount} characters in {time}";
            string cap2 = $"Finished adding {addCount} characters into Gacha Character Database";
            if (addCount > 0)
            {
                helper.SuccessMB(msg, cap2);

            }


        }



        private async Task<bool> InCharDB(string name, List<string> charNames)
        {

            foreach (string charName in charNames)
            {
                Debug.WriteLine($"Comparing {name} to {charName}");
                if (charName == name)
                {
                    await Task.Delay(1);
                    return true;
                }
            }
            return false;
        }

        public int CharsCount()
        {
            Debug.WriteLine("Getting count");
            int count = 0;
            string queryString =
            "SELECT * FROM SSRCharacters;";
            try
            {
                using (SqliteConnection connection = new SqliteConnection(
                        GetConnectionString()))
                {

                    Debug.WriteLine(connection.Database);
                    Debug.WriteLine(queryString);
                    SqliteCommand command = new SqliteCommand(
                    queryString, connection);
                    Debug.WriteLine("Command runnning");
                    try
                    {
                        Debug.WriteLine("Connection");
                        try
                        {
                            connection.Open();
                        }
                        catch(Exception ex)
                        {
                            Debug.WriteLine(ex.Message);
                        }
                        Debug.WriteLine("Reader");
                        SqliteDataReader reader;
                        reader = command.ExecuteReader();
                        string output = "";
                        while (reader.Read())
                        {
                            count++;
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                    
                    //Debug.WriteLine(output);
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

        public List<Character> DBCharData(string queryString)
        {
            List<Character> characters = new();

            using (SqliteConnection connection = new SqliteConnection(
               GetConnectionString()))
            {
                Debug.WriteLine("Getting Data Tst");

                Debug.WriteLine(connection.Database);
                Debug.WriteLine(queryString);
                SqliteCommand command = new SqliteCommand(
                queryString, connection);
                connection.Open();
                Debug.WriteLine("A1");
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string test = "";

                    AddCharacterToList((IDataRecord)reader, characters);
                }
                Debug.WriteLine("A2");
                reader.Close();
                connection.Close();
                Debug.WriteLine(characters.Count);
                return characters;


            }
            Debug.WriteLine("C");
            return characters;
        }



        public List<Character> CharacterList()
        {
            List<Character> characters = new();
            string queryString =
            $"SELECT * FROM GachaCharacters;";
            string test = $"SELECT * FROM SSRCharacters;";
            try
            {
                characters = DBCharData(test);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");

            }
            return characters;
        }

        public Character QueriedCharacter(string name)
        {
            List<Character> characters = new();
            int index = 0;
            string queryString =
           $"SELECT * FROM SSRCharacters WHERE Name='{name}';";
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
                        AddCharacterToList((IDataRecord)reader, characters);
                        Debug.WriteLine($"Ran {index} times");
                        index++;
                    }
                    connection.Close();
                    Character character = characters[0];
                    return character;

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");

            }
            Character character1 = characters[0];
            return character1;
        }

        private List<string> CharList()
        {
            string queryString =
            "SELECT * FROM SSRCharacters;";
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
                    try
                    {
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
                    }
                    catch(Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                    
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
        private void AddCharacterToList(IDataRecord dataRecord, List<Character> characters)
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

                Character character = new(name, element, series, image, link);
                characters.Add(character);
                //Debug.WriteLine($"Data is {name}, {element}, {link}");
            }

        }
    }
}
