<<<<<<< HEAD:Redirects/MainGui.Designer.cs
﻿namespace Redirects
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dialogOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dataGridLista = new System.Windows.Forms.DataGridView();
            this.source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destiny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioPermanent = new System.Windows.Forms.RadioButton();
            this.radioTemporary = new System.Windows.Forms.RadioButton();
            this.groupResponse = new System.Windows.Forms.GroupBox();
            this.chkLive = new System.Windows.Forms.CheckBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.groupEnvironment = new System.Windows.Forms.GroupBox();
            this.chkBrowser = new System.Windows.Forms.CheckBox();
            this.chkV2 = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtClipboard = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.brgwLoading = new System.ComponentModel.BackgroundWorker();
            this.bgrwCopy = new System.ComponentModel.BackgroundWorker();
            this.btnHelp = new System.Windows.Forms.Button();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLista)).BeginInit();
            this.groupResponse.SuspendLayout();
            this.groupEnvironment.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridLista
            // 
            this.dataGridLista.AllowUserToAddRows = false;
            this.dataGridLista.AllowUserToDeleteRows = false;
            this.dataGridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.source,
            this.destiny,
            this.status});
            this.dataGridLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridLista.Location = new System.Drawing.Point(40, 96);
            this.dataGridLista.Name = "dataGridLista";
            this.dataGridLista.ReadOnly = true;
            this.dataGridLista.Size = new System.Drawing.Size(688, 487);
            this.dataGridLista.TabIndex = 1;
            // 
            // source
            // 
            this.source.FillWeight = 300F;
            this.source.HeaderText = "Source";
            this.source.Name = "source";
            this.source.ReadOnly = true;
            this.source.Width = 300;
            // 
            // destiny
            // 
            this.destiny.FillWeight = 300F;
            this.destiny.HeaderText = "Destiny";
            this.destiny.Name = "destiny";
            this.destiny.ReadOnly = true;
            this.destiny.Width = 300;
            // 
            // status
            // 
            this.status.FillWeight = 300F;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 300;
            // 
            // radioPermanent
            // 
            this.radioPermanent.AutoSize = true;
            this.radioPermanent.Checked = true;
            this.radioPermanent.ForeColor = System.Drawing.Color.Black;
            this.radioPermanent.Location = new System.Drawing.Point(9, 38);
            this.radioPermanent.Name = "radioPermanent";
            this.radioPermanent.Size = new System.Drawing.Size(118, 17);
            this.radioPermanent.TabIndex = 3;
            this.radioPermanent.TabStop = true;
            this.radioPermanent.Text = "Permanent (301)";
            this.radioPermanent.UseVisualStyleBackColor = true;
            this.radioPermanent.CheckedChanged += new System.EventHandler(this.radioPermanent_CheckedChanged);
            // 
            // radioTemporary
            // 
            this.radioTemporary.AutoSize = true;
            this.radioTemporary.ForeColor = System.Drawing.Color.Black;
            this.radioTemporary.Location = new System.Drawing.Point(9, 89);
            this.radioTemporary.Name = "radioTemporary";
            this.radioTemporary.Size = new System.Drawing.Size(117, 17);
            this.radioTemporary.TabIndex = 4;
            this.radioTemporary.Text = "Temporary (302)";
            this.radioTemporary.UseVisualStyleBackColor = true;
            this.radioTemporary.CheckedChanged += new System.EventHandler(this.radioTemporary_CheckedChanged);
            // 
            // groupResponse
            // 
            this.groupResponse.BackColor = System.Drawing.Color.Transparent;
            this.groupResponse.Controls.Add(this.radioPermanent);
            this.groupResponse.Controls.Add(this.radioTemporary);
            this.groupResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupResponse.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupResponse.Location = new System.Drawing.Point(734, 302);
            this.groupResponse.Name = "groupResponse";
            this.groupResponse.Size = new System.Drawing.Size(148, 132);
            this.groupResponse.TabIndex = 5;
            this.groupResponse.TabStop = false;
            this.groupResponse.Text = "Response";
            // 
            // chkLive
            // 
            this.chkLive.AutoSize = true;
            this.chkLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLive.ForeColor = System.Drawing.Color.Black;
            this.chkLive.Location = new System.Drawing.Point(9, 128);
            this.chkLive.Name = "chkLive";
            this.chkLive.Size = new System.Drawing.Size(91, 20);
            this.chkLive.TabIndex = 9;
            this.chkLive.Text = "Live Test";
            this.chkLive.UseVisualStyleBackColor = true;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(9, 53);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(109, 20);
            this.txtIp.TabIndex = 10;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(9, 96);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(109, 20);
            this.txtUrl.TabIndex = 11;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIp.ForeColor = System.Drawing.Color.Black;
            this.lblIp.Location = new System.Drawing.Point(6, 33);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(72, 13);
            this.lblIp.TabIndex = 12;
            this.lblIp.Text = "IP (Akamai)";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.ForeColor = System.Drawing.Color.Black;
            this.lblUrl.Location = new System.Drawing.Point(6, 78);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 13;
            this.lblUrl.Text = "URL";
            // 
            // groupEnvironment
            // 
            this.groupEnvironment.BackColor = System.Drawing.Color.Transparent;
            this.groupEnvironment.Controls.Add(this.chkBrowser);
            this.groupEnvironment.Controls.Add(this.chkLive);
            this.groupEnvironment.Controls.Add(this.lblUrl);
            this.groupEnvironment.Controls.Add(this.txtIp);
            this.groupEnvironment.Controls.Add(this.lblIp);
            this.groupEnvironment.Controls.Add(this.txtUrl);
            this.groupEnvironment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupEnvironment.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupEnvironment.Location = new System.Drawing.Point(734, 90);
            this.groupEnvironment.Name = "groupEnvironment";
            this.groupEnvironment.Size = new System.Drawing.Size(148, 197);
            this.groupEnvironment.TabIndex = 14;
            this.groupEnvironment.TabStop = false;
            this.groupEnvironment.Text = "Environment Configuration";
            // 
            // chkBrowser
            // 
            this.chkBrowser.AutoSize = true;
            this.chkBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBrowser.ForeColor = System.Drawing.Color.Black;
            this.chkBrowser.Location = new System.Drawing.Point(9, 154);
            this.chkBrowser.Name = "chkBrowser";
            this.chkBrowser.Size = new System.Drawing.Size(124, 20);
            this.chkBrowser.TabIndex = 18;
            this.chkBrowser.Text = "Show Browser";
            this.chkBrowser.UseVisualStyleBackColor = true;
            // 
            // chkV2
            // 
            this.chkV2.AutoSize = true;
            this.chkV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkV2.ForeColor = System.Drawing.Color.Black;
            this.chkV2.Location = new System.Drawing.Point(539, 33);
            this.chkV2.Name = "chkV2";
            this.chkV2.Size = new System.Drawing.Size(101, 20);
            this.chkV2.TabIndex = 14;
            this.chkV2.Text = "V2 Header";
            this.chkV2.UseVisualStyleBackColor = true;
            this.chkV2.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(292, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 31);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Redirects Tester";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::Redirects.Properties.Resources.Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(734, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = global::Redirects.Properties.Resources.play_icon;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.Location = new System.Drawing.Point(734, 516);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(148, 29);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtClipboard
            // 
            this.txtClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClipboard.Image = global::Redirects.Properties.Resources.Clipboard_Paste_icon;
            this.txtClipboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtClipboard.Location = new System.Drawing.Point(734, 482);
            this.txtClipboard.Name = "txtClipboard";
            this.txtClipboard.Size = new System.Drawing.Size(148, 28);
            this.txtClipboard.TabIndex = 2;
            this.txtClipboard.Text = "Paste From Clipboard";
            this.txtClipboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtClipboard.UseVisualStyleBackColor = true;
            this.txtClipboard.Click += new System.EventHandler(this.txtClipboard_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Image = global::Redirects.Properties.Resources.doc_excel_csv;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.Location = new System.Drawing.Point(734, 449);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(148, 27);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load CSV";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // brgwLoading
            // 
            this.brgwLoading.DoWork += new System.ComponentModel.DoWorkEventHandler(this.brgwLoading_DoWork);
            // 
            // bgrwCopy
            // 
            this.bgrwCopy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgrwCopy_DoWork);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = global::Redirects.Properties.Resources.help;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHelp.Location = new System.Drawing.Point(890, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(24, 27);
            this.btnHelp.TabIndex = 18;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseHover += new System.EventHandler(this.btnHelp_MouseHover);
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.IsBalloon = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Redirects.Properties.Resources.circuit_texture;
            this.ClientSize = new System.Drawing.Size(926, 607);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.chkV2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupEnvironment);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupResponse);
            this.Controls.Add(this.txtClipboard);
            this.Controls.Add(this.dataGridLista);
            this.Controls.Add(this.btnLoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redirects Tester";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLista)).EndInit();
            this.groupResponse.ResumeLayout(false);
            this.groupResponse.PerformLayout();
            this.groupEnvironment.ResumeLayout(false);
            this.groupEnvironment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dialogOpenFile;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridLista;
        private System.Windows.Forms.Button txtClipboard;
        private System.Windows.Forms.RadioButton radioPermanent;
        private System.Windows.Forms.RadioButton radioTemporary;
        private System.Windows.Forms.GroupBox groupResponse;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkLive;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.GroupBox groupEnvironment;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn source;
        private System.Windows.Forms.DataGridViewTextBoxColumn destiny;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.CheckBox chkV2;
        private System.ComponentModel.BackgroundWorker brgwLoading;
        private System.ComponentModel.BackgroundWorker bgrwCopy;
        private System.Windows.Forms.CheckBox chkBrowser;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ToolTip toolTipHelp;
    }
}

=======
﻿namespace Redirects
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dialogOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dataGridLista = new System.Windows.Forms.DataGridView();
            this.source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destiny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioPermanent = new System.Windows.Forms.RadioButton();
            this.radioTemporary = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pgrBar = new System.Windows.Forms.ProgressBar();
            this.chkLive = new System.Windows.Forms.CheckBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbIps = new System.Windows.Forms.ComboBox();
            this.chkV2 = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtClipboard = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pictureLoad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridLista
            // 
            this.dataGridLista.AllowUserToAddRows = false;
            this.dataGridLista.AllowUserToDeleteRows = false;
            this.dataGridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.source,
            this.destiny,
            this.status});
            this.dataGridLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridLista.Location = new System.Drawing.Point(40, 96);
            this.dataGridLista.Name = "dataGridLista";
            this.dataGridLista.ReadOnly = true;
            this.dataGridLista.Size = new System.Drawing.Size(688, 449);
            this.dataGridLista.TabIndex = 1;
            // 
            // source
            // 
            this.source.FillWeight = 300F;
            this.source.HeaderText = "Source";
            this.source.Name = "source";
            this.source.ReadOnly = true;
            this.source.Width = 300;
            // 
            // destiny
            // 
            this.destiny.FillWeight = 300F;
            this.destiny.HeaderText = "Destiny";
            this.destiny.Name = "destiny";
            this.destiny.ReadOnly = true;
            this.destiny.Width = 300;
            // 
            // status
            // 
            this.status.FillWeight = 300F;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 300;
            // 
            // radioPermanent
            // 
            this.radioPermanent.AutoSize = true;
            this.radioPermanent.Checked = true;
            this.radioPermanent.ForeColor = System.Drawing.Color.Black;
            this.radioPermanent.Location = new System.Drawing.Point(9, 38);
            this.radioPermanent.Name = "radioPermanent";
            this.radioPermanent.Size = new System.Drawing.Size(118, 17);
            this.radioPermanent.TabIndex = 3;
            this.radioPermanent.TabStop = true;
            this.radioPermanent.Text = "Permanent (301)";
            this.radioPermanent.UseVisualStyleBackColor = true;
            this.radioPermanent.CheckedChanged += new System.EventHandler(this.radioPermanent_CheckedChanged);
            // 
            // radioTemporary
            // 
            this.radioTemporary.AutoSize = true;
            this.radioTemporary.ForeColor = System.Drawing.Color.Black;
            this.radioTemporary.Location = new System.Drawing.Point(9, 89);
            this.radioTemporary.Name = "radioTemporary";
            this.radioTemporary.Size = new System.Drawing.Size(117, 17);
            this.radioTemporary.TabIndex = 4;
            this.radioTemporary.Text = "Temporary (302)";
            this.radioTemporary.UseVisualStyleBackColor = true;
            this.radioTemporary.CheckedChanged += new System.EventHandler(this.radioTemporary_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioPermanent);
            this.groupBox1.Controls.Add(this.radioTemporary);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(734, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 132);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Response";
            // 
            // pgrBar
            // 
            this.pgrBar.Location = new System.Drawing.Point(40, 560);
            this.pgrBar.Name = "pgrBar";
            this.pgrBar.Size = new System.Drawing.Size(688, 23);
            this.pgrBar.TabIndex = 7;
            // 
            // chkLive
            // 
            this.chkLive.AutoSize = true;
            this.chkLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLive.ForeColor = System.Drawing.Color.Black;
            this.chkLive.Location = new System.Drawing.Point(9, 128);
            this.chkLive.Name = "chkLive";
            this.chkLive.Size = new System.Drawing.Size(91, 20);
            this.chkLive.TabIndex = 9;
            this.chkLive.Text = "Live Test";
            this.chkLive.UseVisualStyleBackColor = true;
            // 
            // txtIp
            // 
            this.txtIp.Enabled = false;
            this.txtIp.Location = new System.Drawing.Point(111, 33);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(109, 20);
            this.txtIp.TabIndex = 10;
            this.txtIp.Visible = false;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(9, 96);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(109, 20);
            this.txtUrl.TabIndex = 11;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIp.ForeColor = System.Drawing.Color.Black;
            this.lblIp.Location = new System.Drawing.Point(6, 33);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(72, 13);
            this.lblIp.TabIndex = 12;
            this.lblIp.Text = "IP (Akamai)";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.ForeColor = System.Drawing.Color.Black;
            this.lblUrl.Location = new System.Drawing.Point(6, 78);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 13;
            this.lblUrl.Text = "URL";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbIps);
            this.groupBox2.Controls.Add(this.chkV2);
            this.groupBox2.Controls.Add(this.chkLive);
            this.groupBox2.Controls.Add(this.lblUrl);
            this.groupBox2.Controls.Add(this.lblIp);
            this.groupBox2.Controls.Add(this.txtUrl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox2.Location = new System.Drawing.Point(734, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 197);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Environment Configuration";
            // 
            // cmbIps
            // 
            this.cmbIps.FormattingEnabled = true;
            this.cmbIps.Location = new System.Drawing.Point(9, 49);
            this.cmbIps.Name = "cmbIps";
            this.cmbIps.Size = new System.Drawing.Size(109, 21);
            this.cmbIps.TabIndex = 18;
            // 
            // chkV2
            // 
            this.chkV2.AutoSize = true;
            this.chkV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkV2.ForeColor = System.Drawing.Color.Black;
            this.chkV2.Location = new System.Drawing.Point(9, 159);
            this.chkV2.Name = "chkV2";
            this.chkV2.Size = new System.Drawing.Size(101, 20);
            this.chkV2.TabIndex = 14;
            this.chkV2.Text = "V2 Header";
            this.chkV2.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(292, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 31);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Redirects Tester";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::Redirects.Properties.Resources.Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(734, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Redirects.Properties.Resources.swlogo2x;
            this.pictureBox1.Location = new System.Drawing.Point(743, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = global::Redirects.Properties.Resources.play_icon;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.Location = new System.Drawing.Point(734, 516);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(148, 29);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtClipboard
            // 
            this.txtClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClipboard.Image = global::Redirects.Properties.Resources.Clipboard_Paste_icon;
            this.txtClipboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtClipboard.Location = new System.Drawing.Point(734, 482);
            this.txtClipboard.Name = "txtClipboard";
            this.txtClipboard.Size = new System.Drawing.Size(148, 28);
            this.txtClipboard.TabIndex = 2;
            this.txtClipboard.Text = "Paste From Clipboard";
            this.txtClipboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtClipboard.UseVisualStyleBackColor = true;
            this.txtClipboard.Click += new System.EventHandler(this.txtClipboard_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Image = global::Redirects.Properties.Resources.doc_excel_csv;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.Location = new System.Drawing.Point(734, 449);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(148, 27);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load CSV";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.lblLoading);
            this.panel.Controls.Add(this.pictureLoad);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(926, 607);
            this.panel.TabIndex = 18;
            this.panel.Visible = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(226, 60);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(451, 34);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "I am doing magic. Please be patient!";
            // 
            // pictureLoad
            // 
            this.pictureLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLoad.BackColor = System.Drawing.Color.Transparent;
            this.pictureLoad.Image = global::Redirects.Properties.Resources.lg_dash_ring_loading_icon;
            this.pictureLoad.Location = new System.Drawing.Point(248, 171);
            this.pictureLoad.Name = "pictureLoad";
            this.pictureLoad.Size = new System.Drawing.Size(389, 339);
            this.pictureLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureLoad.TabIndex = 0;
            this.pictureLoad.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Redirects.Properties.Resources.circuit_texture;
            this.ClientSize = new System.Drawing.Size(926, 607);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pgrBar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtClipboard);
            this.Controls.Add(this.dataGridLista);
            this.Controls.Add(this.btnLoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redirects Tester";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dialogOpenFile;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridLista;
        private System.Windows.Forms.Button txtClipboard;
        private System.Windows.Forms.RadioButton radioPermanent;
        private System.Windows.Forms.RadioButton radioTemporary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar pgrBar;
        private System.Windows.Forms.CheckBox chkLive;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn source;
        private System.Windows.Forms.DataGridViewTextBoxColumn destiny;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.CheckBox chkV2;
        private System.Windows.Forms.ComboBox cmbIps;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureLoad;
        private System.Windows.Forms.Label lblLoading;
    }
}

>>>>>>> master:Redirects/Form1.Designer.cs
