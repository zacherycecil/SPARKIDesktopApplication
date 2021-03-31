using System;
using System.Windows.Forms;
using System.IO;

namespace SPARKIDesktopApp
{
    public partial class FormLoad : Form
    {
        string profileName = null;

        public FormLoad()
        {
            InitializeComponent();

            // add options to load profile dropdown
            string[] profileNames = FileUtil.GetProfileFileNames();
            foreach (string name in profileNames)
                loadComboBox.Items.Add(name);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string mode = GetModeFromCSV();
            if (mode == "Therapeutic")
            {
                var myForm = new Therapeutic();
                myForm.Show();
                ProfileData profileData = new ProfileData(profileName, FileUtil.GetTherapeuticProfileData(profileName));
                myForm.data = profileData;
                myForm.SetupForm();
                this.Hide();
            }
            else if (mode == "FES")
            {
                var myForm = new FES();
                string[] freeRunParams = FileUtil.GetFESProfileData(profileName);
                if (freeRunParams != null)
                {
                    ProfileData profileData = new ProfileData(profileName, freeRunParams[0], freeRunParams[1]);
                    myForm.data = profileData;
                    myForm.SetupForm();
                    myForm.Show();
                    this.Hide();
                }
            }
            else if (mode == "FreeRun")
            {
                var myForm = new FreeRun();
                ProfileData profileData = new ProfileData(profileName, FileUtil.GetFreeRunProfileData(profileName));
                myForm.data = profileData;
                myForm.SetupForm();
                myForm.Show();
                this.Hide();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void loadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get name of file selected
            profileName = (sender as ComboBox).Text;
            profileName = profileName.Substring(0, profileName.Length - 4);

            // if profile is chosen, enable load button
            if (profileName != null && profileName != "<none>")
                loadButton.Enabled = true;

        }

        private string GetModeFromCSV()
        {
            // read CSV values from file
            var reader = new StreamReader("Profiles/" + profileName + ".csv");
            var header = reader.ReadLine().Split(',');
            reader.Close();
            return header[0];
        }
    }
}
