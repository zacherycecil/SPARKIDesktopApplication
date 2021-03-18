using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPARKIDesktopApp
{
    public partial class FormSave : Form
    {
        public string profileName;

        public FormSave()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            profileName = profileNameTB.Text;
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
