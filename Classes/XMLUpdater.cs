using NeverGuildWar_Buddy.Classes.SQlite;
using NeverGuildWar_Buddy.Classes.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverGuildWar_Buddy.Classes
{
    internal class XMLUpdater
    {
        CharacterSQLiteHelper characterSQ = new CharacterSQLiteHelper();
        SummonSQLiteHelper summonSQ= new SummonSQLiteHelper();  

        public void UpdateCharacters()
        {
            characterSQ.UpdateCharDBFromXML();
        }

        public void UpdateSummons()
        {
            
        }
    }
}
