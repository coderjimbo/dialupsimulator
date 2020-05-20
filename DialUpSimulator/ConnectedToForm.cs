using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialUpSimulator
{
    public partial class ConnectedToForm : Form
    {
        DateTime initialConnectedTime;
        int bytesSent = 0;
        int bytesReceived = 0;
        string connectedAtSpeed;

        Random random;

        public ConnectedToForm()
        {
            InitializeComponent();
            SetInitialValues();
        }

        private void SetInitialValues()
        {
            initialConnectedTime = DateTime.Now;
            connectedAtSpeed = Utilities.GetNetworkAdapterSpeed();
            this.Text = "Connected to " + (string)Properties.Settings.Default["connectionName"];
            connectedAt_label.Text = "Connected at " + connectedAtSpeed;
            random = new Random();
        }

        private void networkStatus_notifyIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void disconnect_button_Click(object sender, EventArgs e)
        {
            Utilities.DisableActiveNetwork();
            this.Close();
            Application.OpenForms[0].Close();
        }

        private void details_button_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("NCPA.cpl");
            startInfo.UseShellExecute = true;

            Process.Start(startInfo);
        }

        private void updateData_timer_Tick(object sender, EventArgs e)
        {
            this.duration_label.Text = "Duration: " + (DateTime.Now - initialConnectedTime).ToString(@"hh\:mm\:ss");
            
            if(random.Next(0,2) == 1)
            {
                SetBytesReceived();
                SetBytesSent();
            }

            this.networkStatus_notifyIcon.Text = this.bytesReceived + " bytes received " + this.bytesSent + " bytes sent @ " + connectedAtSpeed;
            SetTaskbarRandomConnectionIcon();
        }

        private void SetBytesSent()
        {
            this.bytesSent += random.Next(32, 128);
            this.bytesSent_label.Text = "Bytes sent: " + this.bytesSent;
        }

        private void SetBytesReceived()
        {
            this.bytesReceived += random.Next(64, 512);
            this.bytesReceived_label.Text = "Bytes received: " + this.bytesReceived;
        }

        private void SetTaskbarRandomConnectionIcon()
        {
            int randomIconNumber = random.Next(1, 5);
            switch(randomIconNumber)
            {
                case 1:
                    networkStatus_notifyIcon.Icon = Properties.Resources.ac1;
                    break;
                case 2:
                    networkStatus_notifyIcon.Icon = Properties.Resources.ac2;
                    break;
                case 3:
                    networkStatus_notifyIcon.Icon = Properties.Resources.ac3;
                    break;
                case 4:
                    networkStatus_notifyIcon.Icon = Properties.Resources.ac4;
                    break;
                default:
                    networkStatus_notifyIcon.Icon = Properties.Resources.ac1;
                    break;
            }
        }
    }
}
