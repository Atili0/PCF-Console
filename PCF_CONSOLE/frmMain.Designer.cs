namespace PCF_CONSOLE
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
            this.fbdSearchFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowserFolder = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNamespace = new System.Windows.Forms.Label();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cbTemplate = new System.Windows.Forms.ComboBox();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ccCMD = new ConsoleControl.ConsoleControl();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowserFolder
            // 
            this.btnBrowserFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowserFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowserFolder.Location = new System.Drawing.Point(676, 28);
            this.btnBrowserFolder.Name = "btnBrowserFolder";
            this.btnBrowserFolder.Size = new System.Drawing.Size(53, 23);
            this.btnBrowserFolder.TabIndex = 0;
            this.btnBrowserFolder.Text = "...";
            this.btnBrowserFolder.UseVisualStyleBackColor = true;
            this.btnBrowserFolder.Click += new System.EventHandler(this.btnBrowserFolder_Click_1);
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.Location = new System.Drawing.Point(12, 28);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(653, 20);
            this.txtFolder.TabIndex = 1;
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(12, 81);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(235, 20);
            this.txtNamespace.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(253, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 20);
            this.txtName.TabIndex = 6;
            // 
            // lblNamespace
            // 
            this.lblNamespace.AutoSize = true;
            this.lblNamespace.Location = new System.Drawing.Point(12, 61);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(64, 13);
            this.lblNamespace.TabIndex = 7;
            this.lblNamespace.Text = "Namespace";
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(491, 61);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(51, 13);
            this.lblTemplate.TabIndex = 8;
            this.lblTemplate.Text = "Template";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(250, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // cbTemplate
            // 
            this.cbTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTemplate.FormattingEnabled = true;
            this.cbTemplate.Items.AddRange(new object[] {
            "field",
            "dataset"});
            this.cbTemplate.Location = new System.Drawing.Point(494, 81);
            this.cbTemplate.Name = "cbTemplate";
            this.cbTemplate.Size = new System.Drawing.Size(235, 21);
            this.cbTemplate.TabIndex = 10;
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFolder.Location = new System.Drawing.Point(735, 81);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(53, 23);
            this.btnCreateFolder.TabIndex = 0;
            this.btnCreateFolder.Text = "Create";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnBuild);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 388);
            this.panel1.TabIndex = 12;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(165, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(84, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(3, 3);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 13;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ccCMD
            // 
            this.ccCMD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ccCMD.IsInputEnabled = true;
            this.ccCMD.Location = new System.Drawing.Point(261, 113);
            this.ccCMD.Name = "ccCMD";
            this.ccCMD.SendKeyboardCommandsToProcess = false;
            this.ccCMD.ShowDiagnostics = false;
            this.ccCMD.Size = new System.Drawing.Size(527, 385);
            this.ccCMD.TabIndex = 15;
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(735, 28);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(53, 23);
            this.btnCheck.TabIndex = 16;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.ccCMD);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTemplate);
            this.Controls.Add(this.cbTemplate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNamespace);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnBrowserFolder);
            this.Controls.Add(this.txtNamespace);
            this.Name = "frmMain";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBrowserFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdSearchFolder;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.Label lblNamespace;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbTemplate;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private ConsoleControl.ConsoleControl ccCMD;
        private System.Windows.Forms.Button btnCheck;
    }
}