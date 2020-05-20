using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialUpSimulator
{
    public partial class ConnectedToForm : Form
    {
        DateTime initialConnectedTime;
        NetworkInterface selectedNetworkAdapter;
        Random random;

        long bytesSentWhenOpened = 0;
        long bytesSent = 0;
        long bytesReceivedWhenOpened = 0;
        long bytesReceived = 0;
        string connectedAtSpeed;

        public ConnectedToForm()
        {
            InitializeComponent();
            SetInitialValues();
            ShowNotificationBalloon();
        }

        private void SetInitialValues()
        {
            initialConnectedTime = DateTime.Now;
            random = new Random();
            SetNetworkAdapterValues();
            SetInitialByteValues();
            SetTextValues();
        }

        private void SetTextValues()
        {
            this.Text = "Connected to " + (string)Properties.Settings.Default["connectionName"];
            connectedAt_label.Text = "Connected at " + connectedAtSpeed;
        }

        private void SetNetworkAdapterValues()
        {
            selectedNetworkAdapter = Utilities.GetSelectedNetworkAdapter();
            connectedAtSpeed = Utilities.GetNetworkAdapterSpeed(selectedNetworkAdapter);
        }

        private void SetInitialByteValues()
        {
            bytesSentWhenOpened = selectedNetworkAdapter.GetIPv4Statistics().BytesSent;
            bytesReceivedWhenOpened = selectedNetworkAdapter.GetIPv4Statistics().BytesReceived;
        }

        private void ShowNotificationBalloon()
        {
            if ((bool)Properties.Settings.Default["doNotShowConnectionEstablished"] == true)
            {
                this.networkStatus_notifyIcon.ShowBalloonTip(
                    5000, 
                    (string)Properties.Settings.Default["connectionName"] + " is now connected", 
                    "Speed: " + connectedAtSpeed, 
                    ToolTipIcon.Info);
            }
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
            SetDurationText();
            SetBytesReceived();
            SetBytesSent();
            SetNotifyIconText();
            SetTaskbarRandomConnectionIcon();
        }

        private void SetDurationText()
        {
            this.duration_label.Text = "Duration: " + (DateTime.Now - initialConnectedTime).ToString(@"hh\:mm\:ss");
        }

        private void SetNotifyIconText()
        {
            this.networkStatus_notifyIcon.Text = GetValueAsBytesOrMegabytes(this.bytesReceived).ToString("N0") + " " + GetTypeOfDataBeingDisplayed().ToLower() + " received " + GetValueAsBytesOrMegabytes(this.bytesSent).ToString("N0") + " " + GetTypeOfDataBeingDisplayed().ToLower() + " sent @ " + connectedAtSpeed;
        }

        private void SetBytesSent()
        {
            this.bytesSent += (selectedNetworkAdapter.GetIPv4Statistics().BytesSent - bytesSentWhenOpened);
            this.bytesSent_label.Text = GetTypeOfDataBeingDisplayed() + " sent: " + GetValueAsBytesOrMegabytes(this.bytesSent).ToString("N0");
        }

        private void SetBytesReceived()
        {
            this.bytesReceived += (selectedNetworkAdapter.GetIPv4Statistics().BytesReceived - bytesReceivedWhenOpened);
            this.bytesReceived_label.Text = GetTypeOfDataBeingDisplayed() + " received: " + GetValueAsBytesOrMegabytes(this.bytesReceived).ToString("N0");
        }

        private string GetTypeOfDataBeingDisplayed()
        {
            if((bool)Properties.Settings.Default["showUsageAsMegabytes"])
            {
                return "Megabytes";
            }
            return "Bytes";
        }

        private long GetValueAsBytesOrMegabytes(long byteValue)
        {
            if ((bool)Properties.Settings.Default["showUsageAsMegabytes"])
            {
                return (byteValue / 1024 / 1024);
            }
            return byteValue;
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
