using System;
using System.Linq;
using System.Windows.Forms;
using MsgManager;
using OmMessage = VersionOne.SDK.ObjectModel.Message;

namespace MsgManagerUI
{
    public partial class FormMsgMgr : Form
    {
        private UiLogin _loginObj;
        private string _v1Path;

        public FormMsgMgr()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //Dont need to clear anymore.  whenver login form is shown, we call this line.
            //listBoxMessages.Items.Clear();
            LoadMsgIntoGui();
            UpdateGuiMessageCount();
        }

        private void SetGuiDelMessageCount()
        {
            lblMark4Del.Text = 0.ToString();
        }

        private void UpdateGuiMessageCount()
        {
            lblMsgCount.Text = listBoxMessages.Items.Count.ToString();
        }

        public void ConnectPrep(string tempUrl, out UiLogin loginObj)
        {
            if (tempUrl == null) throw new ArgumentNullException("tempUrl");
            loginObj = new UiLogin(tempUrl, tbUserName.Text, tbPassword.Text);

            if (loginObj.isV1Connected)
            {
                //Hide the login windows and show the other parts
                ShowMainforms();
                exitToolStripMenuItem.Enabled = true;
            }
            //Clear the box immediately after logging in.  It may be some left 
            //over from previous session.
            listBoxMessages.Items.Clear();
        }

        private void ClearLoginForm()
        {
            panelLogin.Controls["tbPassword"].ResetText();
        }

        private void ShowMainforms()
        {
            panelLogin.Visible = false;
            listBoxMessages.Visible = true;
            btnLoad.Visible = true;
            btnDelete.Visible = true;
            lblDeletion.Visible = true;
            lblMark4Del.Visible = true;
            lblMsgCount.Visible = true;
            lblTotalMsgs.Visible = true;
            panelLogin.Refresh();
            listBoxMessages.Refresh();
        }

        private void ShowLoginForms()
        {
            panelLogin.Visible = true;
            listBoxMessages.Visible = false;
            btnLoad.Visible = false;
            btnDelete.Visible = false;
            lblDeletion.Visible = false;
            lblMark4Del.Visible = false;
            lblMsgCount.Visible = false;
            lblTotalMsgs.Visible = false;
            panelLogin.Refresh();
            listBoxMessages.Refresh();
        }


        private void LoadMsgIntoGui()
        {
//The session holds this big ass storage holding all this users messages
            Session.V1S.messageStore = new V1MessageStore(Session.V1S.V1Inst);

            //Load em up!!!
            Session.V1S.messageStore.QueryMessages();
            foreach (OmMessage m in Session.V1S.messageStore._messageContainer)
            {
                listBoxMessages.Items.Add(m.Name);
            }
        }

        private void ListBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatusBar(null);
            lblMark4Del.Text = listBoxMessages.SelectedItems.Count.ToString();
            //So what if the index changed?  I don't think I car anymore because what is imortant that we just 
            //create a list of items to be deleted.
/*
            //TODO if it changed AND if multiple is selected then pick the first one and ignore remaining
            //else just show current
            VersionOne.SDK.ObjectModel.Message currentMsg;
            currentMsg = listBox1.SelectedItems.Count > 1
                             ? v1S.messageStore._messageContainer.ElementAt(0)
                             : v1S.messageStore._messageContainer.ElementAt(listBox1.SelectedIndex);
            richTextBox1.Clear();
            richTextBox1.AppendText(currentMsg.Description);
            Member mem = currentMsg.CreatedBy;
            textBox1.Clear();
            textBox1.AppendText(mem.Username);
 */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (OmMessage m in Session.V1S.messageStore._messageContainer)
            {
                listBoxMessages.Items.Add(m.Name);
            }
        }

        //Delete button
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to delete the selected?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo);
            // This assumes a 1 to 1 correlation between the listbox and the message container.  You are screwed if these
            // get out of sync
            if (answer == DialogResult.Yes)
            {
                foreach (int index in listBoxMessages.SelectedIndices)
                {
                    Session.V1S.messageStore.DeleteSingleMessage(
                        Session.V1S.messageStore._messageContainer.ElementAt(index));
                }

                //Save the number of things that I deleted to dump in the status bar
                //Will Clear this as soon as 
                string lastStatus = "Deleted " + lblMark4Del.Text + " Messages";
                UpdateStatusBar(lastStatus);

                //Clear and Re-Get the new list items
                listBoxMessages.Items.Clear();
                Session.V1S.messageStore.QueryMessages();
                foreach (OmMessage m in Session.V1S.messageStore._messageContainer)
                {
                    listBoxMessages.Items.Add(m.Name);
                }
                UpdateGuiMessageCount();
                SetGuiDelMessageCount();
            }
            else
            {
                UpdateStatusBar("Delete Cancelled");
            }
        }

//TODO pattern match ^Cancel. or just keep damn thing generic
        private void UpdateStatusBar(string textIn)
        {
            string sl;
            if (textIn == null)
                //statusStrip1.Text = " ";
                statusStrip1.Items[0].Text = " ";
            else
                //statusStrip1.Text = textIn;
                statusStrip1.Items[0].Text = textIn;
            statusStrip1.Refresh(); //TODO do I need to do this everytime?
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void FormMsgMgr_Load(object sender, EventArgs e)
        {
            _v1Path = UiUtils.GetPathFromConfig();
        }

        private void tbV1Path_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string tempURL = tbV1Path.Text;
            //Grab it from the UI.  If it is empty, then it will get fetched inside of ConnectPrep
            ConnectPrep(tempURL, out _loginObj);
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void listBoxMessages_Click(object sender, EventArgs e)
        {
            //lblMark4Del.Text = listBoxMessages.SelectedItems.Count.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                if ((_loginObj== null) ||(_loginObj.isV1Connected))
                {
                    ShowLoginForms();
                    ClearLoginForm();
                    exitToolStripMenuItem.Enabled = false;
                }
            
           
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        //When this from form loads, read the config file.
        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelLogin_VisibleChanged(object sender, EventArgs e)
        {
            tbV1Path.Text = _v1Path;

        }

      

        private void tbV1Path_Enter(object sender, EventArgs e)
        {
   //         tbV1Path.Text = _v1Path;
//            tbV1Path.Refresh();
        }

    }
}