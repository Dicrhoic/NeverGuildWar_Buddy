using NeverGuildWar_Buddy.Classes;
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
    }
}