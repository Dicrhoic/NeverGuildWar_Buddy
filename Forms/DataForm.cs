using GBF_Never_Buddy.Classes;
using NeverGuildWar_Buddy.Classes;
using NeverGuildWar_Buddy.Classes.SQlite;
using NeverGuildWar_Buddy.Classes.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GBF_Never_Buddy.Classes.GameDataClasses;

namespace NeverGuildWar_Buddy.Forms
{
    public partial class DataForm : Form
    {
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider seriesErrorProvider;
        private System.Windows.Forms.ErrorProvider elementErrorProvider;
        private ErrorProvider imageErrorProvider;
        private ErrorProvider linkErrorProvider;
        CharacterSQLiteHelper characterSQLHelper = new();
        SummonSQLiteHelper summonSQLHelper = new();
        List<GameDataClasses.Character>? characterList;
        List<GameDataClasses.Summon>? summonsList;
        List<string> seriesS = new List<string>();
        List<string> seriesC = new List<string>();
        List<string> names = new();

        int summonID = 0;
        int characterID = 0;
        int mode = -1;

        public DataForm()
        {
            InitializeComponent();

            nameErrorProvider = new System.Windows.Forms.ErrorProvider();
            nameErrorProvider.SetIconAlignment(textBox2, ErrorIconAlignment.MiddleRight);
            nameErrorProvider.SetIconPadding(textBox2, 2);
            nameErrorProvider.BlinkRate = 1000;
            nameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            textBox2.Validated += new System.EventHandler(name_validated);


            seriesErrorProvider = new System.Windows.Forms.ErrorProvider();
            seriesErrorProvider.SetIconAlignment(this.comboBox2, ErrorIconAlignment.MiddleRight);
            seriesErrorProvider.SetIconPadding(this.comboBox2, 2);
            seriesErrorProvider.BlinkRate = 1000;
            seriesErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            comboBox2.Validated += new System.EventHandler(series_validated);

            elementErrorProvider = new System.Windows.Forms.ErrorProvider();
            elementErrorProvider.SetIconAlignment(this.comboBox1, ErrorIconAlignment.MiddleRight);
            elementErrorProvider.SetIconPadding(this.comboBox1, 2);
            elementErrorProvider.BlinkRate = 1000;
            elementErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            comboBox1.Validated += new System.EventHandler(element_validate);

            imageErrorProvider = new System.Windows.Forms.ErrorProvider();
            imageErrorProvider.SetIconAlignment(this.textBox4, ErrorIconAlignment.MiddleRight);
            imageErrorProvider.SetIconPadding(this.textBox4, 2);
            imageErrorProvider.BlinkRate = 1000;
            imageErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            textBox4.Validated += new System.EventHandler(image_validated);

            linkErrorProvider = new System.Windows.Forms.ErrorProvider();
            linkErrorProvider.SetIconAlignment(this.textBox5, ErrorIconAlignment.MiddleRight);
            linkErrorProvider.SetIconPadding(this.textBox5, 2);
            linkErrorProvider.BlinkRate = 1000;
            linkErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            textBox5.Validated += new System.EventHandler(link_validated);


            characterList = characterSQLHelper.CharacterList();
            summonsList = summonSQLHelper.SummonList();

            string[] sc = {"Premium" , "Event", "Grand", "12 Generals", "Valentine",
                    "Summer/Yukata", "Halloween", "Holiday", "Collaboration"};
            string[] ss = { "Premium", "Summer/Yukata", "Halloween", "Holiday", "Collaboration",
                    "Xeno", "Collaboration"};
            seriesC.AddRange(sc);
            seriesS.AddRange(ss);

            summonID = summonSQLHelper.DataCount();
            characterID = characterSQLHelper.CharsCount();
        }

        private void name_validated(object sender, System.EventArgs e)
        {
            if (IsNameValid())
            {
                nameErrorProvider.SetError(textBox2, String.Empty);
            }
            else
            {
                nameErrorProvider.SetError(textBox2, "Name already exists in database.");
            }
        }

        private void element_validate(object sender, System.EventArgs e)
        {
            if (!IsElementSelected())
            {
                elementErrorProvider.SetError(comboBox2, "Element is required.");
            }
            else
            {
                elementErrorProvider.SetError(comboBox2, String.Empty);
            }
        }

        private void series_validated(object sender, System.EventArgs e)
        {
            if (!IsSeriesSelected())
            {
                seriesErrorProvider.SetError(comboBox1, "Series is required.");

            }
            else
            {
                seriesErrorProvider.SetError(comboBox1, String.Empty);
            }
        }

        private void link_validated(object sender, System.EventArgs e)
        {
            string link = textBox5.Text;
            if (!LinkIsValid(link))
            {
                linkErrorProvider.SetError(textBox5, "Link is not valid check again.");
            }
            else
            {
                linkErrorProvider.SetError(textBox5, String.Empty);
            }
        }

        private void image_validated(object sender, System.EventArgs e)
        {
            string link = textBox4.Text;
            if (!LinkIsValid(link))
            {
                imageErrorProvider.SetError(textBox4, "Link is not valid check again.");
            }
            else
            {
                imageErrorProvider.SetError(textBox4, String.Empty);
            }
        }

        private bool IsNameValid()
        {
            string name = textBox2.Text;
            foreach (string s in names)
            {
                if (s == name)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsElementSelected()
        {
            if (comboBox1.SelectedItem == null)
            {
                return false;
            }
            return true;
        }

        private bool IsSeriesSelected()
        {
            if (comboBox2.SelectedItem == null)
            {
                return false;
            }
            return true;
        }

        private bool LinkIsValid(string link)
        {
            var uriName = link;
            Uri uriResult;
            bool result = Uri.TryCreate(uriName, UriKind.Absolute, out uriResult)
                && uriResult.Scheme == Uri.UriSchemeHttps;
            return result;
        }

        private bool LinksAreValid()
        {
            string link1 = textBox4.Text;
            string link2 = textBox5.Text;
            Uri uriResult;
            bool result = Uri.TryCreate(link1, UriKind.Absolute, out uriResult)
                && uriResult.Scheme == Uri.UriSchemeHttps;
            Uri uriResult2;
            bool result2 = Uri.TryCreate(link2, UriKind.Absolute, out uriResult2)
                && uriResult2.Scheme == Uri.UriSchemeHttps;
            if (result2 == false || result == false)
            {
                return false;
            }
            return true;
        }
        private void AddData(object sender, EventArgs e)
        {
            if (!IsNameValid() || !LinksAreValid() || !IsElementSelected() || !IsSeriesSelected())
            {
                Debug.WriteLine("Error something is invalid");
                return;
            }
            else
            {
                RunSQLQuery();
                characterList = characterSQLHelper.CharacterList();
                summonsList = summonSQLHelper.SummonList();
                summonID = summonSQLHelper.DataCount();
                characterID = characterSQLHelper.CharsCount();
            }
        }

        private void RunSQLQuery()
        {
            MBHelper mB = new();
            string name = textBox2.Text;
            string element = comboBox2.Text;
            string series = comboBox1.Text;
            string image = textBox4.Text;
            string link = textBox5.Text;

            switch (mode)
            {
                case 0:
                    GameDataClasses.Character character = new(name, element, series, image, link);
                    characterID++;
                    Debug.WriteLine(characterID);
                    characterSQLHelper.AddCharacterData(character, characterID);
                    break;
                case 1:
                    GameDataClasses.Summon summon = new(name, series, element, image, link);
                    summonID++;
                    summonSQLHelper.AddSummonData(summon, summonID);
                    break;
            }
        }

    }
}
