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

    public partial class FES : Form
    {
        public FES()
        {
            InitializeComponent();

            // Set Macro combo box
            string[] macroNames = FileUtil.GetMacroFileNames();
            foreach (string name in macroNames)
                macroCB.Items.Add(name);
            macroCB.SelectedItem = macroCB.Items[0];

            // Set trigger combo box
            string[] triggerNames = FileUtil.GetTriggerFileNames();
            foreach (string name in triggerNames)
                triggerCB.Items.Add(name);
            triggerCB.SelectedItem = triggerCB.Items[0];
        }

        public void SetProfileNameLabel(string name)
        {
            profileNameLabel.Text = name;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FormSave myForm = new FormSave();
            if (myForm.ShowDialog() == DialogResult.OK)
            {
                profileNameLabel.Text = myForm.profileName;
                FileUtil.SaveFESProfile(myForm.profileName, macroCB.Text, triggerCB.Text);
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
    }
}