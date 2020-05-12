using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialUpSimulator
{
    public partial class ConnectingForm : Form
    {
        List<string> connectionStrings = new List<string>();
        string phoneNumberToDial = "";
        int currentConnectionStringIndex = 0;

        public ConnectingForm()
        {
            InitializeComponent();
            SetWindowTitle();
            SetPhoneNumberToDial();
            CreateConnectionStrings();
            dialup_simulation_worker.WorkerReportsProgress = true;
            dialup_simulation_worker.RunWorkerAsync();
        }

        private void SetWindowTitle()
        {
            this.Text = "Connecting to " + (string)Properties.Settings.Default["connectionName"];
        }

        private void SetPhoneNumberToDial()
        {
            this.phoneNumberToDial = (string)Properties.Settings.Default["phoneNumber"];
        }

        private void CreateConnectionStrings()
        {
            connectionStrings.Add("Opening port...");
            connectionStrings.Add("Dialing " + phoneNumberToDial + "...");
            connectionStrings.Add("Verifying username and password...");
            connectionStrings.Add("Registering your computer on the network...");
            connectionStrings.Add("Authenticated.");
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void CloseApplication()
        {
            Utilities.EnableActiveNetwork();
            this.Close();
            Application.OpenForms[0].Close();
        }

        private void dialup_simulation_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            OpenPort(e, worker);
            DialNumber(e, worker);
            VerifyUsernamePassword(e, worker);
            RegisterComputerOnNetwork(e, worker);
            CompleteAuthentication(e, worker);
        }

        private void OpenPort(DoWorkEventArgs e, BackgroundWorker worker)
        {
            worker.ReportProgress(0);
            Utilities.DisableActiveNetwork(); // Disable the active network if the user allows it
            System.Threading.Thread.Sleep(500);
        }

        private void DialNumber(DoWorkEventArgs e, BackgroundWorker worker)
        {
            worker.ReportProgress(25);
            PlaySoundResource(Properties.Resources.dialtone_us);
            foreach (char c in phoneNumberToDial)
            {
                PlaySoundResource(getResourceFromCharacter(c));
            }
            System.Threading.Thread.Sleep(2000);
            PlaySoundResource(Properties.Resources.dialup);
        }

        private void PlaySoundResource(UnmanagedMemoryStream soundResourceToPlay)
        {
            SoundPlayer snd = new SoundPlayer(soundResourceToPlay);
            snd.PlaySync();
        }

        private void VerifyUsernamePassword(DoWorkEventArgs e, BackgroundWorker worker)
        {
            worker.ReportProgress(50);
            System.Threading.Thread.Sleep(2000);
        }

        private void RegisterComputerOnNetwork(DoWorkEventArgs e, BackgroundWorker worker)
        {
            worker.ReportProgress(75);
            Utilities.EnableActiveNetwork(); // Re-enable the active network if the user allows it
            System.Threading.Thread.Sleep(3000);
        }

        private void CompleteAuthentication(DoWorkEventArgs e, BackgroundWorker worker)
        {
            worker.ReportProgress(100);
            System.Threading.Thread.Sleep(500);
        }

        private UnmanagedMemoryStream getResourceFromCharacter(char character)
        {
            switch(character)
            {
                case '0':
                    return Properties.Resources._0;
                case '1':
                    return Properties.Resources._1;
                case '2':
                    return Properties.Resources._2;
                case '3':
                    return Properties.Resources._3;
                case '4':
                    return Properties.Resources._4;
                case '5':
                    return Properties.Resources._5;
                case '6':
                    return Properties.Resources._6;
                case '7':
                    return Properties.Resources._7;
                case '8':
                    return Properties.Resources._8;
                case '9':
                    return Properties.Resources._9;
                case '#':
                    return Properties.Resources.pound;
                case '*':
                    return Properties.Resources.star;
                default:
                    return Properties.Resources.pause;
            }
        }

        private void dialup_simulation_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CloseApplication();
        }

        private void dialup_simulation_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (currentConnectionStringIndex < connectionStrings.Capacity - 1)
            {
                SetLabelText(currentConnectionStringIndex);
                currentConnectionStringIndex++;
            }
        }

        private void SetLabelText(int stepNumber)
        {
            status_label.Text = "Status: " + connectionStrings[stepNumber];
        }
    }
}
