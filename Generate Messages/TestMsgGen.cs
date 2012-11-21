using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VersionOne.SDK.ObjectModel;
using OmMessage = VersionOne.SDK.ObjectModel.Message;
using System.Threading;

namespace Generate_Messages
{
    public partial class TestMsgGen : Form
    {
        private V1Instance v1;
        public TestMsgGen()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation =true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            v1 = new V1Instance("https://www11.v1host.com/VersionOneMI/", "admin", "admin");
            progressBar1.Maximum = Convert.ToInt32(textBox1.Text.ToString());
            progressBar1.Visible = true;
            if (backgroundWorker1.IsBusy != true)
                backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
               
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= Convert.ToInt32(textBox1.Text.ToString()); i++)
            {
                OmMessage tempMsg = v1.Create.Message("You are a test " + i.ToString(), "This is a content", v1.LoggedInMember);
                tempMsg.Send();
                backgroundWorker1.ReportProgress(i);
            }

        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;
            // Set the text of this window.
            this.Text = e.ProgressPercentage.ToString();
        }
        private void backgroundWorker1_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }
    }
}
