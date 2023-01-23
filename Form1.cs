using NeverGuildWar_Buddy.Classes;
using NeverGuildWar_Buddy.Classes.SQlite;
using NeverGuildWar_Buddy.Classes.SQLite;
using NeverGuildWar_Buddy.Forms;
using NeverGuildWar_Buddy.Forms.SetupForms;

namespace NeverGuildWar_Buddy
{
    public partial class HomePage : Form
    {
        FormManager formManager;
        public HomePage()
        {
            InitializeComponent();
            formManager= new FormManager(); 
            
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            formManager.LoadForm(new HomePageComponent(), mainPanel);
           
        }

        private void LoadSetupsForm(object sender, EventArgs e)
        {
            formManager.LoadForm(new SetupsViewHome(), mainPanel);
        }

        private void characterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CharacterSQLiteHelper characterSQLiteHelper = new();
            characterSQLiteHelper.ValidateDB();
            characterSQLiteHelper.UpdateCharDBFromXML();
        }

        private void SummonUpdate(object sender, EventArgs e)
        {
            SummonSQLiteHelper summonSQLiteHelper = new SummonSQLiteHelper();
            summonSQLiteHelper.ValidateDB();
            summonSQLiteHelper.UpdateDBFromXML();
        }

        private void WeaponUpdate(object sender, EventArgs e)
        {
            WeaponSQLHelper weaponSQLHelper = new WeaponSQLHelper();
            weaponSQLHelper.ValidateDB();   
            weaponSQLHelper.UpdateDBFromXML();  
        }

        private void ReturnHome(object sender, EventArgs e)
        {
            formManager.LoadForm(new HomePageComponent(), mainPanel);
        }
    }
}