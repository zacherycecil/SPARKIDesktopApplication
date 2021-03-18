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
                myForm.profileName = profileName;
                myForm.Show();
                this.Hide();
            }
            else if (mode == "FES")
            {
                var myForm = new FES();
                myForm.SetProfileNameLabel(profileName);
                myForm.Show();
                this.Hide();
            }
            else if (mode == "FreeRun")
            {
                var myForm = new FreeRun();
                myForm.profileName = profileName;
                myForm.Show();
                this.Hide();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void loadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if profile is chosen, enable load button
            if (profileName != "<none>")
                loadButton.Enabled = true;

            // get name of file selected
            profileName = (sender as ComboBox).Text;
            profileName = profileName.Substring(0, profileName.Length - 4);
        }

        private string GetModeFromCSV()
        {
            // read CSV values from file
            var reader = new StreamReader("Profiles/" + profileName + ".csv");
            var header = reader.ReadLine().Split(',');
            return header[0];
        }
    }
}
