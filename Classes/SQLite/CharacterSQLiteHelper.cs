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

namespace NeverGuildWar_Buddy.Classes.SQlite
{
    internal class CharacterSQLiteHelper : SQLiteHelper
    {
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
            string test = $"SELECT * FROM GachaCharacters;";
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
           $"SELECT * FROM GachaCharacters WHERE Name='{name}';";
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
            "SELECT * FROM GachaCharacters;";
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
