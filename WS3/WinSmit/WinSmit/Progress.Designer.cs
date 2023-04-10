namespace WinSmit
{
    partial class Progress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Progress));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.OKbutton = new System.Windows.Forms.Button();
            this.preparseWorker = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.menu_opt_BG = new System.ComponentModel.BackgroundWorker();
            this.cmd_opt_BG = new System.ComponentModel.BackgroundWorker();
            this.cmd_hdr_BG = new System.ComponentModel.BackgroundWorker();
            this.name_hdr_BG = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.progressBar5);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre Parser";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "This can take a few moments for large files.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pre processing file to get stanza comments";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(6, 55);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(483, 17);
            this.progressBar5.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loading Smit Stanzas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "sm_name_hdr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "sm_cmd_hdr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "sm_cmd_opt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "sm_menu_opt";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(161, 88);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(328, 17);
            this.progressBar4.TabIndex = 3;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(161, 65);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(328, 17);
            this.progressBar3.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(161, 42);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(328, 17);
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(161, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(328, 17);
            this.progressBar1.TabIndex = 0;
            // 
            // OKbutton
            // 
            this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbutton.Location = new System.Drawing.Point(426, 334);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 3;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // preparseWorker
            // 
            this.preparseWorker.WorkerReportsProgress = true;
            this.preparseWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.preparseWorker_DoWork);
            this.preparseWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.preparseWorker_RunWorkerCompleted);
            this.preparseWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.preparseWorker_ProgressChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(333, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menu_opt_BG
            // 
            this.menu_opt_BG.WorkerReportsProgress = true;
            this.menu_opt_BG.WorkerSupportsCancellation = true;
            this.menu_opt_BG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.menu_opt_BG_DoWork);
            this.menu_opt_BG.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.menu_opt_BG_RunWorkerCompleted);
            this.menu_opt_BG.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.menu_opt_BG_ProgressChanged);
            // 
            // cmd_opt_BG
            // 
            this.cmd_opt_BG.WorkerReportsProgress = true;
            this.cmd_opt_BG.WorkerSupportsCancellation = true;
            this.cmd_opt_BG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.cmd_opt_BG_DoWork);
            this.cmd_opt_BG.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.cmd_opt_BG_RunWorkerCompleted);
            this.cmd_opt_BG.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.cmd_opt_BG_ProgressChanged);
            // 
            // cmd_hdr_BG
            // 
            this.cmd_hdr_BG.WorkerReportsProgress = true;
            this.cmd_hdr_BG.WorkerSupportsCancellation = true;
            this.cmd_hdr_BG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.cmd_hdr_BG_DoWork);
            this.cmd_hdr_BG.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.cmd_hdr_BG_RunWorkerCompleted);
            this.cmd_hdr_BG.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.cmd_hdr_BG_ProgressChanged);
            // 
            // name_hdr_BG
            // 
            this.name_hdr_BG.WorkerReportsProgress = true;
            this.name_hdr_BG.WorkerSupportsCancellation = true;
            this.name_hdr_BG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.name_hdr_BG_DoWork);
            this.name_hdr_BG.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.name_hdr_BG_RunWorkerCompleted);
            this.name_hdr_BG.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.name_hdr_BG_ProgressChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 81);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003;
            // 
            // Progress
            // 
            this.AcceptButton = this.OKbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(530, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Progress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress";
            this.ResizeEnd += new System.EventHandler(this.Progress_ResizeEnd);
            this.Load += new System.EventHandler(this.Progress_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker preparseWorker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker menu_opt_BG;
        private System.ComponentModel.BackgroundWorker cmd_opt_BG;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker cmd_hdr_BG;
        private System.ComponentModel.BackgroundWorker name_hdr_BG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;

    }
}