using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolbox
{

    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            Program.LogToFile("Launch");
            InitializeComponent();
        }


        private void settings_Click(object sender, EventArgs e)
        {

            Program.LogToFile("Open settings dialog");
            settingsForm settingsForm = new settingsForm();
            settingsForm.ShowDialog();
        }




    }
}
