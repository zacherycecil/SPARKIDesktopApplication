using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using InTheHand.Net.Sockets;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using InTheHand.Forms;

namespace SPARKIDesktopApp
{

    public partial class Form1 : Form
    {

        enum Mode
        {
            Therapeutic,
            FES,
            FreeRun
        }

        Mode profileMode = Mode.Therapeutic;
        static Form formTemp;
        public Electrode[] electrodes;
        public string profileName;
        public bool profileLoaded = false;
        public int currentElectrode;
        public int numElectrodes;
        public bool newProfile;

        // BlueTooth
        BluetoothClient client = new BluetoothClient();

        private static BluetoothDeviceInfo BTDevice = new BluetoothDeviceInfo(BluetoothAddress.Parse("94:21:97:60:07:C0"));
        private static NetworkStream stream = null;

        public DialogResult SaveProfilePopup(string title, string promptText)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = profileName;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            profileName = textBox.Text;
            return dialogResult;
        }
        public DialogResult LoadProfilePopup()
        {
            // Create form and controls
            Form form = new Form();
            Label label = new Label();
            ComboBox comboBox = new ComboBox();
            Button buttonCancel = new Button();

            // Save form for close when dropdown option is selected
            formTemp = form;

            form.Text = "Load Profile";
            label.Text = "Choose a profile to load:";

            comboBox.SelectedIndexChanged += (s, e) =>
            {
                // get name of file selected
                string myProfileName = (s as ComboBox).Text;
                myProfileName = myProfileName.Substring(0, myProfileName.Length - 4);
                profileName = myProfileName;

                profileLoaded = true;
                newProfile = false;

                formTemp.Close();
            };

            // getting a list of files existing in Profiles folder
            DirectoryInfo directoryInfo = new DirectoryInfo("Profiles/");
            FileInfo[] files = directoryInfo.GetFiles("*.csv");
            if (files.Length == 0)
            {
                comboBox.Items.Add("<none>");
            }
            else
                foreach (FileInfo file in files)
                    comboBox.Items.Add(file.Name);

            buttonCancel.Text = "Cancel";
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            comboBox.SetBounds(12, 36, 372, 20);
            buttonCancel.SetBounds(223, 72, 150, 23);

            label.AutoSize = true;
            comboBox.Anchor = comboBox.Anchor | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, comboBox, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.CancelButton = buttonCancel;

            if (!profileLoaded)
            {
                // close app if closed during profile select
                form.FormClosed += CloseAppOnCancel;
            }

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }
        public DialogResult ChooseModeForProfile()
        {
            profileName = "Unnamed Profile";

            // Create form and controls
            Form form = new Form();
            Label label = new Label();
            Button buttonTherapeutic = new Button();
            Button buttonFES = new Button();
            Button buttonFreeRun = new Button();

            // Save form for close when dropdown option is selected
            formTemp = form;

            // Set button size and position
            label.SetBounds(9, 20, 372, 13);
            buttonTherapeutic.SetBounds(9, 72, 75, 23);
            buttonFES.SetBounds(104, 72, 75, 23);
            buttonFreeRun.SetBounds(199, 72, 75, 23);

            // Set control text
            form.Text = "Mode Selection";
            label.Text = "Choose a mode for the profile:";
            buttonTherapeutic.Text = "Therapeutic";
            buttonFES.Text = "Functional Electrical Stimualtion";
            buttonFreeRun.Text = "Free-Run";

            label.AutoSize = true;

            form.ClientSize = new Size(283, 107);
            form.Controls.AddRange(new Control[] { label, buttonTherapeutic, buttonFES, buttonFreeRun });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            buttonTherapeutic.DialogResult = DialogResult.OK;
            buttonFES.DialogResult = DialogResult.OK;
            buttonFreeRun.DialogResult = DialogResult.OK;

            if (!profileLoaded)
            {
                // close app if closed during profile select
                form.FormClosed += CloseAppOnCancel;
            }

            // When therapeutic button is clicked
            buttonTherapeutic.Click += (s, e) => {
                profileMode = Mode.Therapeutic;
                ChooseElectrodeNumber();
            };

            // When FES button is clicked
            buttonFES.Click += (s, e) => {
                profileMode = Mode.FES;
                ChooseElectrodeNumber();
            };

            // When freerun button is clicked
            buttonFreeRun.Click += (s, e) => {
                profileMode = Mode.FreeRun;
                ChooseElectrodeNumber();
            };

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }

        public DialogResult ChooseLoadOrNew()
        {
            // Create form and controls
            Form form = new Form();
            Label label = new Label();
            Button loadButton = new Button();
            Button newButton = new Button();

            // Save form for close when dropdown option is selected
            formTemp = form;

            // Set button size and position
            label.SetBounds(9, 20, 372, 13);
            loadButton.SetBounds(9, 72, 100, 30);
            newButton.SetBounds(118, 72, 100, 30);

            // Set control text
            form.Text = "S.P.A.R.K.I. Desktop Application";
            label.Text = "Load or create a profile?";
            loadButton.Text = "Load";
            newButton.Text = "New";

            label.AutoSize = true;

            form.ClientSize = new Size(283, 107);
            form.Controls.AddRange(new Control[] { label, loadButton, newButton });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            loadButton.DialogResult = DialogResult.OK;
            newButton.DialogResult = DialogResult.OK;

            // close app if closed during profile select
            form.FormClosed += CloseAppOnCancel;

            // When New button is clicked
            newButton.Click += (s, e) => {
                ChooseModeForProfile();
            };

            // When Load button is clicked
            loadButton.Click += (s, e) => {
                LoadProfilePopup();
            };

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }
        private DialogResult ChooseElectrodeNumber()
        {
            // Create form and controls
            Form form = new Form();
            Label electrodesLabel = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();

            // Setup form
            form.Text = "Electrodes";
            form.ClientSize = new Size(283, 107);
            form.Controls.AddRange(new Control[] { electrodesLabel, textBox, buttonOk });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            formTemp = form;

            // Setup label
            electrodesLabel.Text = "How many electrodes?";
            electrodesLabel.SetBounds(9, 20, 372, 13);

            // Setup text box
            textBox.SetBounds(12, 36, 100, 20);
            buttonOk.SetBounds(118, 50, 75, 30);
            form.AcceptButton = buttonOk;

            // Setup ok button
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Text = "OK";

            if (!profileLoaded)
            {
                // close app if closed during profile select
                form.FormClosed += CloseAppOnCancel;
            }

            // Get number from textbox
            buttonOk.Click += (s, e) => {
                string[] names = new string[int.Parse(textBox.Text)];
                for (int i = 0; i < names.Length; i++)
                    names[i] = "Electrode " + (1+i);
                electrodes = GetElectrodeArray(names);
                profileMode = Mode.Therapeutic;
                profileLoaded = true;
                numElectrodes = int.Parse(textBox.Text);
                newProfile = true;
            };
            //electrodes = GetElectrodeArray(int.Parse(textBox.Text));

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }

        private void LoadProfileSelection()
        {
            currentElectrode = 0;

            // read CSV values from file and send to textboxes
            var reader = new StreamReader("Profiles/" + profileName + ".csv");
            var header = reader.ReadLine().Split(',');
            var profileModeIn = header[0];
            numElectrodes = int.Parse(header[1]);
            if (profileModeIn == "Therapeutic")
                profileMode = Mode.Therapeutic;
            else if (profileModeIn == "FES")
                profileMode = Mode.FES;
            else if (profileModeIn == "FreeRun")
                profileMode = Mode.FreeRun;

            string csvLine;
            electrodes = new Electrode[numElectrodes];
            for (int i = 0; i < numElectrodes; i++)
            {
                csvLine = reader.ReadLine();
                string[] csvValues = csvLine.Split(',');
                Electrode electrode = new Electrode(csvValues[0]);

                // set value fields
                electrode.therapeuticValues[0] = int.Parse(csvValues[1]);
                electrode.therapeuticValues[1] = int.Parse(csvValues[2]);
                electrode.therapeuticValues[2] = int.Parse(csvValues[3]);
                electrode.therapeuticValues[3] = int.Parse(csvValues[4]);
                electrode.therapeuticValues[4] = int.Parse(csvValues[5]);
                electrode.therapeuticValues[5] = int.Parse(csvValues[6]);
                electrode.therapeuticValues[6] = int.Parse(csvValues[7]);
                electrode.therapeuticValues[7] = int.Parse(csvValues[8]);

                electrodes[i] = electrode;
            }

            // close reader
            reader.Close();
        }

        private void CloseAppOnCancel(object s, FormClosedEventArgs e)
        {
            if (!profileLoaded)
                if (e.CloseReason == CloseReason.UserClosing)
                     Application.Exit();
        }

        private void SetValuesTherapeutic()
        {
            if (!newProfile)
                LoadProfileSelection();
            else
                ResetTherapeuticValues();
            SetTherapeuticValues();

            // change dropdown
            electrodeDropdown.Items.Clear();
            foreach (Electrode e in electrodes)
            {
                electrodeDropdown.Items.Add(e.name);
            }
            electrodeDropdown.SelectedItem = electrodes[0].name;

            // set label to profile name
            profileNameLabel.Text = profileName;
        }

        private void ResetTherapeuticValues()
        {
            // set value fields
            freqTB.Text = "";
            ampTB.Text = "";
            pulseWidthTB.Text = "";
            stimTimeTB.Text = "";
            rampingTimeFreqTB.Text = "";
            rampingTimeAmpTB.Text =  "";
            onTimeTB.Text = "";
            offTimeTB.Text =  "";
        }

        private void SetTherapeuticValues()
        {
            // set label to profile name
            profileNameLabel.Text = "Unnamed Profile";

            // set value fields
            freqTB.Text = electrodes[currentElectrode].therapeuticValues[0] + "";
            ampTB.Text = electrodes[currentElectrode].therapeuticValues[1] + "";
            pulseWidthTB.Text = electrodes[currentElectrode].therapeuticValues[2] + "";
            stimTimeTB.Text = electrodes[currentElectrode].therapeuticValues[3] + "";
            rampingTimeFreqTB.Text = electrodes[currentElectrode].therapeuticValues[4] + "";
            rampingTimeAmpTB.Text = electrodes[currentElectrode].therapeuticValues[5] + "";
            onTimeTB.Text = electrodes[currentElectrode].therapeuticValues[6] + "";
            offTimeTB.Text = electrodes[currentElectrode].therapeuticValues[7] + "";
        }

        public Form1()
        {
            ChooseLoadOrNew();
            if (profileLoaded)
            {
                InitializeComponent();
                SetValuesTherapeutic();
            }
        }

        // SAVE PROFILE
        private void button1_Click(object sender, EventArgs e)
        {
            CreateProfilesDirectory();

            // Create prompt and get user input for name of profile
            SaveProfilePopup("Save Profile", "Save profile as: ");
            profileNameLabel.Text = profileName;

            // Get data from profile to save to CSV
            string data = profileMode + "," + numElectrodes;
            foreach (Electrode electrode in electrodes)
            {
                data += "\n" + electrode.name;
                foreach (int val in electrode.therapeuticValues)
                    data += "," + val;
            }

            // Save data to csv file with profile name
            File.WriteAllText("Profiles/" + profileName + ".csv", data);
        }

        private void CreateProfilesDirectory()
        {
            // Create folder for profiles
            if (!Directory.Exists("Profiles"))
            {
                Directory.CreateDirectory("Profiles");
            }
        }

        private void propertyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Handle non-digit characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;

        }

        private void propertyTextBox_TextChanged(object sender, EventArgs e)
        {
            // Save properties to array
            int i = -1;
            if ((sender as TextBox) == freqTB)
                i = 0;
            else if ((sender as TextBox) == ampTB)
                i = 1;
            else if ((sender as TextBox) == pulseWidthTB)
                i = 2;
            else if ((sender as TextBox) == stimTimeTB)
                i = 3;
            else if ((sender as TextBox) == rampingTimeFreqTB)
                i = 4;
            else if ((sender as TextBox) == rampingTimeAmpTB)
                i = 5;
            else if ((sender as TextBox) == onTimeTB)
                i = 6;
            else if ((sender as TextBox) == offTimeTB)
                i = 7;
            try
            {
                electrodes[currentElectrode].therapeuticValues[i] = int.Parse((sender as TextBox).Text);
            }
            catch(Exception)
            {

            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            CreateProfilesDirectory();
            LoadProfilePopup();
        }

        private Electrode[] GetElectrodeArray(string[] names)
        {
            int i = 0;
            Electrode[] array = new Electrode[names.Length];
            foreach (string name in names)
            {
                array[i] = new Electrode(name);
                i++;
            }
            return array;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            ChooseModeForProfile();
            Console.WriteLine(Mode.Therapeutic == profileMode);
            if(profileMode == Mode.Therapeutic)
            {
                ChooseElectrodeNumber();
            }
        }
        private void ElectrodeDropDown(object sender, EventArgs e)
        {
            currentElectrode = (sender as ComboBox).SelectedIndex;
            SetTherapeuticValues();
        }

        private void SyncButton(object sender, EventArgs e)
        {
            IReadOnlyCollection<BluetoothDeviceInfo> devices = client.DiscoverDevices();
            SyncLabel.Text = "Devices found: " + devices.Count;
            foreach (var device in devices)
            {
                SyncLabel.Text += "\n" + device.DeviceName + " " + device.DeviceAddress;
            }
            //BluetoothSecurity.PairRequest(device.DeviceAddress, "PIN");
        }
    }

    public class Electrode
    {
        public int[] therapeuticValues = new int[8];
        public string name;
        public Electrode(string name)
        {
            this.name = name;
        }
    }
}