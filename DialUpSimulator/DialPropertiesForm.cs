using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialUpSimulator
{
    public partial class DialPropertiesForm : Form
    {
        public DialPropertiesForm()
        {
            InitializeComponent();
            PopulateUserPreferences();
            PopulateNetworkAdapters();
        }

        private void PopulateUserPreferences()
        {
            if (!Utilities.IsFirstRun())
            {
                this.control_device_checkbox.Checked = (bool)Properties.Settings.Default["controlDevice"];
                this.connection_name_textbox.Text = (string)Properties.Settings.Default["connectionName"];
                this.showInformational_checkBox.Checked = !(bool)Properties.Settings.Default["doNotShowConnectionEstablished"];
            }
            else
            {
                this.showInformational_checkBox.Checked = true;
            }
        }

        private void PopulateNetworkAdapters()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                device_list_combobox.Items.Add(nic.Name);
            }

            SetComboboxSelection();
        }

        private void SetComboboxSelection()
        {
            if (Properties.Settings.Default["deviceToControl"] != null && (string)Properties.Settings.Default["deviceToControl"] != "")
            {
                device_list_combobox.SelectedItem = Properties.Settings.Default["deviceToControl"];
            }
            else if (device_list_combobox.Items.Count > 0)
            {
                device_list_combobox.SelectedItem = device_list_combobox.Items[0];
            }
            else
            {
                device_list_combobox.Enabled = false;
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void connection_name_textbox_TextChanged(object sender, EventArgs e)
        {
            if(connection_name_textbox.Text.Length > 0)
            {
                ok_button.Enabled = true;
            }
            else
            {
                ok_button.Enabled = false;
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (control_device_checkbox.Checked)
            {
                var confirmOkay = MessageBox.Show("Are you sure you want to control the selected device? You will legitimately go offline right now until you \"dial-up\" or manually re-enable your network adapter.", "Warning: Disconnecting Actual Connection!", MessageBoxButtons.YesNo);

                if (confirmOkay == DialogResult.Yes)
                {
                    CloseWindow();
                    Utilities.DisableActiveNetwork();
                }
            }
            else
            {
                CloseWindow();
            }
        }

        private void CloseWindow()
        {
            SavePreferences();
            this.Close();

        }

        private void SavePreferences()
        {
            Properties.Settings.Default["hasOpenedApplication"] = true;
            Properties.Settings.Default["connectionName"] = connection_name_textbox.Text;
            Properties.Settings.Default["controlDevice"] = control_device_checkbox.Checked;
            Properties.Settings.Default["deviceToControl"] = device_list_combobox.SelectedItem;
            Properties.Settings.Default["doNotShowConnectionEstablished"] = !this.showInformational_checkBox.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
