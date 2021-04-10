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

    public partial class Therapeutic : Form
    {
        public ProfileData data;
        public int currentElectrode;

        public BluetoothClient client = new BluetoothClient();
        public Therapeutic()
        {
            InitializeComponent();
        }

        public void SetupForm()
        {
            currentElectrode = 0;
            SetTextBoxValues();
            SetElectrodeDropdown();
            SetProfileNameLabel();
            unsavedChangesLabel.Text = "";
        }

        private void SetElectrodeDropdown()
        {
            // change dropdown
            electrodeDropdown.Items.Clear();
            foreach (Electrode e in data.electrodeList)
            {
                electrodeDropdown.Items.Add(e.name);
            }
            electrodeDropdown.SelectedItem = data.electrodeList[0].name;
        }

        private void SetTextBoxValues()
        {
            // set value fields
            freqTB.Text = data.electrodeList[currentElectrode].therapeuticValues[0] + "";
            rampingTimePulseWidthTB.Text = data.electrodeList[currentElectrode].therapeuticValues[1] + "";
            pulseWidthTB.Text = data.electrodeList[currentElectrode].therapeuticValues[2] + "";
            stimTimeTB.Text = data.electrodeList[currentElectrode].therapeuticValues[3] + "";
            rampingTimeFreqTB.Text = data.electrodeList[currentElectrode].therapeuticValues[4] + "";
            rampingTimeAmpTB.Text = data.electrodeList[currentElectrode].therapeuticValues[5] + "";
            onTimeTB.Text = data.electrodeList[currentElectrode].therapeuticValues[6] + "";
            offTimeTB.Text = data.electrodeList[currentElectrode].therapeuticValues[7] + "";
        }

        private void SetProfileNameLabel()
        {
            profileNameLabel.Text = data.profileName;
        }

        // SAVE PROFILE
        private void button1_Click(object sender, EventArgs e)
        {
            FormSave myForm = new FormSave();
            if (myForm.ShowDialog() == DialogResult.OK)
            {
                data.profileName = myForm.profileName;
                FileUtil.SaveTherapeuticProfile(data);
                SetupForm();
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
            // tell user that changes have been made
            unsavedChangesLabel.Text = "There are unsaved changes.";

            // Save properties to array
            int i = -1;
            if ((sender as TextBox) == freqTB)
                i = 0;
            else if ((sender as TextBox) == rampingTimePulseWidthTB)
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
                data.electrodeList[currentElectrode].therapeuticValues[i] = int.Parse((sender as TextBox).Text);
            }
            catch (Exception)
            {

            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            FormLoad myForm = new FormLoad();
            if (myForm.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
            }
        }   

        private void newButton_Click(object sender, EventArgs e)
        {
            FormChooseProfileMode myForm = new FormChooseProfileMode();
            if (myForm.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
            }
        }
        private void ElectrodeDropDown(object sender, EventArgs e)
        {
            bool changes = (unsavedChangesLabel.Text == "");
            
            currentElectrode = (sender as ComboBox).SelectedIndex;
            SetTextBoxValues();

            if (changes)
                unsavedChangesLabel.Text = "";
        }

        private void SyncButton(object sender, EventArgs e)
        {
            
            String address = "086698E94A11";
            BluetoothDeviceInfo btDevice = null;
            BluetoothAddress addr = new BluetoothAddress(new byte[] { 0x08, 0x66, 0x98, 0xE9, 0x4A, 0x11 });

            IReadOnlyCollection<BluetoothDeviceInfo> devices = client.DiscoverDevices();
            debugInfoLabel.Text = "Devices found: " + devices.Count;
            foreach (var device in devices)
            {
                debugInfoLabel.Text += "\n" + device.DeviceName + " " + device.DeviceAddress;
                if (device.DeviceAddress.Equals(addr))
                {
                    btDevice = device;
                    debugInfoLabel.Text += "\nFOUND SPARKI!!! maby";
                }
                debugInfoLabel.Text += "\nAddress compare: " + device.DeviceAddress + " | " + addr;
            }
            // ADDRESS: 086698E94A11
            if (btDevice != null)
            {
                debugInfoLabel.Text += "\n" + BluetoothSecurity.PairRequest(btDevice.DeviceAddress, "PIN");

                Guid service = BluetoothService.SerialPort;
                client.Connect(addr, service);
                Stream networkStream = client.GetStream();
                Thread.Sleep(1000);

                if (networkStream.CanWrite)
                {
                    byte[] buffer = { 0xFF };
                    debugInfoLabel.Text += "\n" + networkStream.BeginWrite(buffer, 0, buffer.Length, null, networkStream);
                }
            }


            // ...
            
        }

        private void Therapeutic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}