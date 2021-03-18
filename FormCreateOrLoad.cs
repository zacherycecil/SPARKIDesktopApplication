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
    public partial class FormCreateOrLoad : Form
    {
        public FormCreateOrLoad()
        {
            Directory.CreateDirectory("Profiles");
            Directory.CreateDirectory("Macros");
            Directory.CreateDirectory("Triggers");
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var myForm = new FormChooseProfileMode();
            myForm.Show();
            this.Hide();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            var myForm = new FormLoad();
            myForm.Show();
            this.Hide();
        }
    }
}
