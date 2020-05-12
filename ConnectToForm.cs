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
    public partial class ConnectToForm : Form
    {
        public ConnectToForm()
        {
            InitializeComponent();
            HandleFirstRun();
        }

        private void HandleFirstRun()
        {
            if (Utilities.IsFirstRun())
            {
                var dialProperties = new DialPropertiesForm();
                dialProperties.Shown += DialProperties_Shown;
                dialProperties.FormClosed += DialProperties_FormClosed;
                dialProperties.Show();
            }
            else
            {
                InitalizeLabels();
                PopulateConnectionDetails();
            }
        }

        private void DialProperties_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DialProperties_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Utilities.IsFirstRun()) // Once the dial properties window is closed, if it's still considered the first run after a first run, that means the user hit cancel.
            {
                this.Close();
            }
            else
            {
                this.InitalizeLabels();
                this.Show();
            }
        }

        private void PopulateConnectionDetails()
        {
            this.user_name_textbox.Text = (string)Properties.Settings.Default["username"];
            this.password_textbox.Text = (string)Properties.Settings.Default["password"];
            this.phone_number_textbox.Text = (string)Properties.Settings.Default["phoneNumber"];
            this.save_password_checkbox.Checked = (bool)Properties.Settings.Default["savePassword"];
        }

        public void InitalizeLabels()
        {
            this.connection_label.Text = (string)Properties.Settings.Default["connectionName"];
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connection_textboxes_TextChanged(object sender, EventArgs e)
        {
            if (ConnectionInputFieldsCompleted())
            {
                this.connect_button.Enabled = true;
            }
            else
            {
                this.connect_button.Enabled = false;
            }
        }

        private bool ConnectionInputFieldsCompleted()
        {
            return this.password_textbox.Text.Length > 0 && this.user_name_textbox.Text.Length > 0 && this.phone_number_textbox.Text.Length > 0;
        }

        private void phone_number_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!e.KeyChar.Equals((char)Keys.Back) && !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('#') && !e.KeyChar.Equals('*') && !e.KeyChar.Equals(' '))
            {
                e.Handled = true;
            } else
            {
                e.Handled = false;
            }
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            SaveConnectionDetails();

            var connectingForm = new ConnectingForm();
            connectingForm.Show();
            this.Hide();
        }

        private void SaveConnectionDetails()
        {
            Properties.Settings.Default["username"] = this.user_name_textbox.Text;
            SetPasswordDetails();
            Properties.Settings.Default["phoneNumber"] = this.phone_number_textbox.Text;
            Properties.Settings.Default.Save();
        }

        private void SetPasswordDetails()
        {
            if (this.save_password_checkbox.Checked)
            {
                Properties.Settings.Default["password"] = this.password_textbox.Text; // Please don't save passwords like this for real applications!!!
            }
            else
            {
                Properties.Settings.Default["password"] = "";
                this.password_textbox.Text = "";
            }
            Properties.Settings.Default["savePassword"] = this.save_password_checkbox.Checked;
        }

        private void dial_props_button_Click(object sender, EventArgs e)
        {
            var dialPropsForm = new DialPropertiesForm();
            dialPropsForm.FormClosed += DialProperties_FormClosed;
            dialPropsForm.ShowDialog();
        }
    }
}
