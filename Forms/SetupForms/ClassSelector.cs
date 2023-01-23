using NeverGuildWar_Buddy.Classes;
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
using static GBF_Never_Buddy.Classes.GameDataClasses.Weapon;
using static System.Net.Mime.MediaTypeNames;

namespace NeverGuildWar_Buddy.Forms.SetupForms
{
    public partial class ClassSelector : Form
    {
     
        SetupsHelper databaseHelper;
        PictureBox pictureBox1;
        List<Job> jobs;
        bool initialzed = false;
        string? imageURL;
        Job? selectedJob;
        SetupSQLiteHelper mcHelper = new();

        public ClassSelector(SetupsHelper databaseHelper, object sender)
        {
            InitializeComponent();
            this.databaseHelper = databaseHelper;
            pictureBox1 = (PictureBox)sender;
            jobs = mcHelper.ClassesList();
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            if (jobs != null)
            {
                var source = new AutoCompleteStringCollection();
                source.AddRange(jobs.Select(d => d.jobName).ToArray());
                searchTB.AutoCompleteCustomSource = source;
                searchTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
                searchTB.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void FindJob(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int index = FindJobIndex(searchTB.Text);
                if (index != -1 && jobs is not null)
                {
                    var job = jobs[index];
                    Debug.WriteLine(job.jobName, job.jobImage);
                    string link = job.jobImage;
                    LoadSummonImage(link);
                    selectedJob = job;

                }
            }
        }

        private void LoadSummonImage(string link)
        {
            try
            {
                jobSlotPB.Load(link);
            }
            catch (Exception ex)
            {
                MBHelper mB = new MBHelper();
                mB.ErrorMB("No internet connection", "Error loading image");
            }
   
            Debug.WriteLine($"Dimensions: {jobSlotPB.Height} W: {jobSlotPB.Width}");
            imageURL = link;
        }

        private int FindJobIndex(string searchTerm)
        {
            Debug.WriteLine($"{searchTerm} is the search term");
            int index = 0;
            if (jobs is null)
            {
                Debug.WriteLine("Error jobs is null");
            }
            if (jobs is not null)
                foreach (var job in jobs)
                {
                    Debug.WriteLine(job.jobName);
                    if (searchTerm == job.jobName)
                    {
                        return index;
                    }
                    index++;
                }
            return -1;
        }

        private void SelectedJob(object sender, EventArgs e)
        {
            if (selectedJob != null)
            {
                databaseHelper.currentJob = selectedJob;
                pictureBox1.Load(selectedJob.jobImage);
                this.Close();
            }
        }
    }
}
