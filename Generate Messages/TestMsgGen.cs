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

namespace Generate_Messages
{
    public partial class TestMsgGen : Form
    {
        public TestMsgGen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            V1Instance v1 = new V1Instance("https://www11.v1host.com/VersionOneMI/", "admin", "admin");
            for (int i = 0; i <= Convert.ToInt32(textBox1.Text.ToString());i++)
            {
                OmMessage tempMsg = v1.Create.Message("You are a test "+ i.ToString(), "This isa body check", v1.LoggedInMember);
                tempMsg.Send();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
