namespace WinSmit
{
    partial class ProjectWiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectWiz));
            this.wizard1 = new KellermanSoftware.ThemedWizard.Wizard();
            this.welcomePage1 = new KellermanSoftware.ThemedWizard.WelcomePage();
            this.NamePage = new KellermanSoftware.ThemedWizard.InteriorPage();
            this.projectNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.localPath = new KellermanSoftware.ThemedWizard.InteriorPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.remotePathAixTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.projectPathTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.completionPage1 = new KellermanSoftware.ThemedWizard.CompletionPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbScripts = new System.Windows.Forms.Label();
            this.lbRemotePath = new System.Windows.Forms.Label();
            this.lbLocalPath = new System.Windows.Forms.Label();
            this.lbProjectname = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NamePage.SuspendLayout();
            this.localPath.SuspendLayout();
            this.completionPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizard1
            // 
            this.wizard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizard1.Location = new System.Drawing.Point(0, 0);
            this.wizard1.Name = "wizard1";
            this.wizard1.Size = new System.Drawing.Size(507, 348);
            this.wizard1.WizardPages.Add(this.welcomePage1);
            this.wizard1.WizardPages.Add(this.NamePage);
            this.wizard1.WizardPages.Add(this.localPath);
            this.wizard1.WizardPages.Add(this.completionPage1);
            this.wizard1.CancelButtonClick += new System.EventHandler(this.wizard1_CancelButtonClick);
            this.wizard1.FinishButtonClick += new System.EventHandler(this.wizard1_FinishButtonClick);
            this.wizard1.NextButtonClick += new KellermanSoftware.ThemedWizard.WizardNextButtonClickEventHandler(this.wizard1_NextButtonClick);
            // 
            // welcomePage1
            // 
            this.welcomePage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.welcomePage1.LeftPanelBackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomePage1.LeftPanelBackgroundImage")));
            this.welcomePage1.Name = "welcomePage1";
            this.welcomePage1.Title = "Welcome to the WinSmit Project Wizard.";
            // 
            // NamePage
            // 
            this.NamePage.BackColor = System.Drawing.SystemColors.Control;
            this.NamePage.Controls.Add(this.projectNameTB);
            this.NamePage.Controls.Add(this.label1);
            this.NamePage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NamePage.HeaderPanelBackgroundImage = ((System.Drawing.Image)(resources.GetObject("NamePage.HeaderPanelBackgroundImage")));
            this.NamePage.Name = "NamePage";
            // 
            // projectNameTB
            // 
            this.projectNameTB.Location = new System.Drawing.Point(207, 97);
            this.projectNameTB.Name = "projectNameTB";
            this.projectNameTB.Size = new System.Drawing.Size(157, 20);
            this.projectNameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Project Name";
            // 
            // localPath
            // 
            this.localPath.BackColor = System.Drawing.SystemColors.Control;
            this.localPath.Controls.Add(this.checkBox1);
            this.localPath.Controls.Add(this.remotePathAixTB);
            this.localPath.Controls.Add(this.label3);
            this.localPath.Controls.Add(this.button1);
            this.localPath.Controls.Add(this.projectPathTB);
            this.localPath.Controls.Add(this.label2);
            this.localPath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.localPath.HeaderPanelBackgroundImage = ((System.Drawing.Image)(resources.GetObject("localPath.HeaderPanelBackgroundImage")));
            this.localPath.Name = "localPath";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(188, 219);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Generate Shell Scripts";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // remotePathAixTB
            // 
            this.remotePathAixTB.Location = new System.Drawing.Point(188, 158);
            this.remotePathAixTB.Name = "remotePathAixTB";
            this.remotePathAixTB.Size = new System.Drawing.Size(279, 20);
            this.remotePathAixTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Remote Location on AIX System";
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(473, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projectPathTB
            // 
            this.projectPathTB.Location = new System.Drawing.Point(188, 97);
            this.projectPathTB.Name = "projectPathTB";
            this.projectPathTB.Size = new System.Drawing.Size(279, 20);
            this.projectPathTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project Path";
            // 
            // completionPage1
            // 
            this.completionPage1.Controls.Add(this.label8);
            this.completionPage1.Controls.Add(this.lbScripts);
            this.completionPage1.Controls.Add(this.lbRemotePath);
            this.completionPage1.Controls.Add(this.lbLocalPath);
            this.completionPage1.Controls.Add(this.lbProjectname);
            this.completionPage1.Controls.Add(this.label7);
            this.completionPage1.Controls.Add(this.label6);
            this.completionPage1.Controls.Add(this.label5);
            this.completionPage1.Controls.Add(this.label4);
            this.completionPage1.Name = "completionPage1";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Project Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Local Project Path";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Remote Project Path (ODMDIR)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Create shell scripts";
            // 
            // lbScripts
            // 
            this.lbScripts.AutoSize = true;
            this.lbScripts.Location = new System.Drawing.Point(298, 164);
            this.lbScripts.Name = "lbScripts";
            this.lbScripts.Size = new System.Drawing.Size(95, 13);
            this.lbScripts.TabIndex = 7;
            this.lbScripts.Text = "Create shell scripts";
            // 
            // lbRemotePath
            // 
            this.lbRemotePath.AutoSize = true;
            this.lbRemotePath.Location = new System.Drawing.Point(298, 135);
            this.lbRemotePath.Name = "lbRemotePath";
            this.lbRemotePath.Size = new System.Drawing.Size(158, 13);
            this.lbRemotePath.TabIndex = 6;
            this.lbRemotePath.Text = "Remote Project Path (ODMDIR)";
            // 
            // lbLocalPath
            // 
            this.lbLocalPath.AutoSize = true;
            this.lbLocalPath.Location = new System.Drawing.Point(298, 106);
            this.lbLocalPath.Name = "lbLocalPath";
            this.lbLocalPath.Size = new System.Drawing.Size(94, 13);
            this.lbLocalPath.TabIndex = 5;
            this.lbLocalPath.Text = "Local Project Path";
            // 
            // lbProjectname
            // 
            this.lbProjectname.AutoSize = true;
            this.lbProjectname.Location = new System.Drawing.Point(298, 77);
            this.lbProjectname.Name = "lbProjectname";
            this.lbProjectname.Size = new System.Drawing.Size(71, 13);
            this.lbProjectname.TabIndex = 4;
            this.lbProjectname.Text = "Project Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(121, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "The new project will be created with the following values:\r\n";
            // 
            // ProjectWiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 348);
            this.Controls.Add(this.wizard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjectWiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinSmit Project Wizard";
            this.NamePage.ResumeLayout(false);
            this.NamePage.PerformLayout();
            this.localPath.ResumeLayout(false);
            this.localPath.PerformLayout();
            this.completionPage1.ResumeLayout(false);
            this.completionPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KellermanSoftware.ThemedWizard.Wizard wizard1;
        private KellermanSoftware.ThemedWizard.WelcomePage welcomePage1;
        private KellermanSoftware.ThemedWizard.InteriorPage NamePage;
        private KellermanSoftware.ThemedWizard.CompletionPage completionPage1;
        private KellermanSoftware.ThemedWizard.InteriorPage localPath;
        private System.Windows.Forms.TextBox projectNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox remotePathAixTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox projectPathTB;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lbScripts;
        private System.Windows.Forms.Label lbRemotePath;
        private System.Windows.Forms.Label lbLocalPath;
        private System.Windows.Forms.Label lbProjectname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}