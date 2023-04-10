namespace WinSmitV3
{
    partial class CreateProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProject));
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.name_textBox1 = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.solution_textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ok_button2 = new System.Windows.Forms.Button();
            this.cancel_button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.niceLine1 = new WinSmitV3.NiceLine();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeader1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.DirtyPaletteCounter = 19;
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 121);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(39, 19);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Text = "Name";
            this.kryptonLabel1.Values.ExtraText = "";
            this.kryptonLabel1.Values.Image = null;
            this.kryptonLabel1.Values.Text = "Name";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.DirtyPaletteCounter = 19;
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 147);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(52, 19);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Text = "Location";
            this.kryptonLabel2.Values.ExtraText = "";
            this.kryptonLabel2.Values.Image = null;
            this.kryptonLabel2.Values.Text = "Location";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.DirtyPaletteCounter = 19;
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 173);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(83, 19);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Text = "Solution Name";
            this.kryptonLabel3.Values.ExtraText = "";
            this.kryptonLabel3.Values.Image = null;
            this.kryptonLabel3.Values.Text = "Solution Name";
            // 
            // name_textBox1
            // 
            this.name_textBox1.Location = new System.Drawing.Point(104, 117);
            this.name_textBox1.Name = "name_textBox1";
            this.name_textBox1.Size = new System.Drawing.Size(287, 20);
            this.name_textBox1.TabIndex = 1;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(104, 143);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(287, 20);
            this.location.TabIndex = 2;
            // 
            // solution_textBox3
            // 
            this.solution_textBox3.Location = new System.Drawing.Point(104, 169);
            this.solution_textBox3.Name = "solution_textBox3";
            this.solution_textBox3.Size = new System.Drawing.Size(204, 20);
            this.solution_textBox3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Browse";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ok_button2
            // 
            this.ok_button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button2.Location = new System.Drawing.Point(314, 263);
            this.ok_button2.Name = "ok_button2";
            this.ok_button2.Size = new System.Drawing.Size(75, 23);
            this.ok_button2.TabIndex = 6;
            this.ok_button2.Text = "OK";
            this.ok_button2.UseVisualStyleBackColor = true;
            this.ok_button2.Click += new System.EventHandler(this.ok_button2_Click);
            // 
            // cancel_button3
            // 
            this.cancel_button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button3.Location = new System.Drawing.Point(397, 263);
            this.cancel_button3.Name = "cancel_button3";
            this.cancel_button3.Size = new System.Drawing.Size(75, 23);
            this.cancel_button3.TabIndex = 7;
            this.cancel_button3.Text = "Cancel";
            this.cancel_button3.UseVisualStyleBackColor = true;
            this.cancel_button3.Click += new System.EventHandler(this.cancel_button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(314, 170);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Create Directory for Solution";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.DirtyPaletteCounter = 3;
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(481, 56);
            this.kryptonHeader1.TabIndex = 13;
            this.kryptonHeader1.Text = "   Create new WinSmit Project";
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "   Create new WinSmit Project";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // niceLine1
            // 
            this.niceLine1.Location = new System.Drawing.Point(12, 242);
            this.niceLine1.Name = "niceLine1";
            this.niceLine1.Size = new System.Drawing.Size(457, 15);
            this.niceLine1.TabIndex = 11;
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 298);
            this.Controls.Add(this.kryptonHeader1);
            this.Controls.Add(this.niceLine1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cancel_button3);
            this.Controls.Add(this.ok_button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.solution_textBox3);
            this.Controls.Add(this.location);
            this.Controls.Add(this.name_textBox1);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new WinSmit Project";
            this.Load += new System.EventHandler(this.CreateProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeader1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.TextBox name_textBox1;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.TextBox solution_textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ok_button2;
        private System.Windows.Forms.Button cancel_button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private NiceLine niceLine1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        
    }
}