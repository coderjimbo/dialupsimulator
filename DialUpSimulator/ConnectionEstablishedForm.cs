using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialUpSimulator
{
    public partial class ConnectionEstablishedForm : Form
    {
        public ConnectionEstablishedForm()
        {
            InitializeComponent();
            this.connectedTo_Label.Text = "You are connected to " + (string)Properties.Settings.Default["connectionName"] + ".";
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doNotShow_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["doNotShowConnectionEstablished"] = this.doNotShow_Checkbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void moreInfo_button_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
