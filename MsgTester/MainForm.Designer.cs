namespace MsgManagerUI
{
    partial class FormMsgMgr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMsgMgr));
            this.btnLoad = new System.Windows.Forms.Button();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbV1Path = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.v1MessageStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v1MessageStoreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblTotalMsgs = new System.Windows.Forms.Label();
            this.lblMsgCount = new System.Windows.Forms.Label();
            this.lblMark4Del = new System.Windows.Forms.Label();
            this.lblDeletion = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v1MessageStoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v1MessageStoreBindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(174, 322);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(178, 45);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "LoadMessages";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.ItemHeight = 20;
            this.listBoxMessages.Location = new System.Drawing.Point(12, 26);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMessages.Size = new System.Drawing.Size(742, 284);
            this.listBoxMessages.TabIndex = 2;
            this.listBoxMessages.Visible = false;
            this.listBoxMessages.Click += new System.EventHandler(this.listBoxMessages_Click);
            this.listBoxMessages.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(418, 322);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 44);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Logout";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.configurationToolStripMenuItem.Text = "Save Path";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(22)))), ((int)(((byte)(47)))));
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.tbV1Path);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.tbPassword);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Controls.Add(this.tbUserName);
            this.panelLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLogin.Location = new System.Drawing.Point(91, 31);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(584, 285);
            this.panelLogin.TabIndex = 11;
            this.panelLogin.VisibleChanged += new System.EventHandler(this.panelLogin_VisibleChanged);
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "VersionOne Path";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbV1Path
            // 
            this.tbV1Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbV1Path.Location = new System.Drawing.Point(188, 29);
            this.tbV1Path.Name = "tbV1Path";
            this.tbV1Path.Size = new System.Drawing.Size(381, 29);
            this.tbV1Path.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(245, 239);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 32);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(188, 170);
            this.tbPassword.MaxLength = 20;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(227, 29);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(8, 106);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(113, 25);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "UserName";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(188, 100);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(227, 29);
            this.tbUserName.TabIndex = 2;
            this.tbUserName.Text = "admin";
            // 
            // v1MessageStoreBindingSource
            // 
            this.v1MessageStoreBindingSource.DataSource = typeof(MsgManager.V1MessageStore);
            // 
            // v1MessageStoreBindingSource1
            // 
            this.v1MessageStoreBindingSource1.DataSource = typeof(MsgManager.V1MessageStore);
            // 
            // lblTotalMsgs
            // 
            this.lblTotalMsgs.AutoSize = true;
            this.lblTotalMsgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMsgs.Location = new System.Drawing.Point(647, 348);
            this.lblTotalMsgs.Name = "lblTotalMsgs";
            this.lblTotalMsgs.Size = new System.Drawing.Size(114, 18);
            this.lblTotalMsgs.TabIndex = 12;
            this.lblTotalMsgs.Text = "Total Messages";
            this.lblTotalMsgs.Visible = false;
            // 
            // lblMsgCount
            // 
            this.lblMsgCount.AutoSize = true;
            this.lblMsgCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgCount.Location = new System.Drawing.Point(690, 327);
            this.lblMsgCount.Name = "lblMsgCount";
            this.lblMsgCount.Size = new System.Drawing.Size(16, 18);
            this.lblMsgCount.TabIndex = 13;
            this.lblMsgCount.Text = "0";
            this.lblMsgCount.Visible = false;
            this.lblMsgCount.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblMark4Del
            // 
            this.lblMark4Del.AutoSize = true;
            this.lblMark4Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark4Del.ForeColor = System.Drawing.Color.Red;
            this.lblMark4Del.Location = new System.Drawing.Point(55, 327);
            this.lblMark4Del.Name = "lblMark4Del";
            this.lblMark4Del.Size = new System.Drawing.Size(16, 18);
            this.lblMark4Del.TabIndex = 15;
            this.lblMark4Del.Text = "0";
            this.lblMark4Del.Visible = false;
            this.lblMark4Del.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // lblDeletion
            // 
            this.lblDeletion.AutoSize = true;
            this.lblDeletion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletion.Location = new System.Drawing.Point(12, 348);
            this.lblDeletion.Name = "lblDeletion";
            this.lblDeletion.Size = new System.Drawing.Size(138, 18);
            this.lblDeletion.TabIndex = 14;
            this.lblDeletion.Text = "Marked for Deletion";
            this.lblDeletion.Visible = false;
            this.lblDeletion.Click += new System.EventHandler(this.label5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(766, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // FormMsgMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 399);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblMark4Del);
            this.Controls.Add(this.lblDeletion);
            this.Controls.Add(this.lblMsgCount);
            this.Controls.Add(this.lblTotalMsgs);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.listBoxMessages);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMsgMgr";
            this.Text = "Message Manager";
            this.Load += new System.EventHandler(this.FormMsgMgr_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v1MessageStoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v1MessageStoreBindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.BindingSource v1MessageStoreBindingSource;
        private System.Windows.Forms.BindingSource v1MessageStoreBindingSource1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbV1Path;
        private System.Windows.Forms.Label lblTotalMsgs;
        private System.Windows.Forms.Label lblMsgCount;
        private System.Windows.Forms.Label lblMark4Del;
        private System.Windows.Forms.Label lblDeletion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

