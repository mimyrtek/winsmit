namespace WinSmit
{
    partial class wiz:ComponentFactory.Krypton.Toolkit.KryptonForm
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
            this.okButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cancelButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.okButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel3)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton1
            // 
            this.okButton1.DirtyPaletteCounter = 2;
            this.okButton1.Location = new System.Drawing.Point(340, 256);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(90, 25);
            this.okButton1.TabIndex = 0;
            this.okButton1.Text = "OK";
            this.okButton1.Values.ExtraText = "";
            this.okButton1.Values.Image = null;
            this.okButton1.Values.ImageStates.ImageCheckedNormal = null;
            this.okButton1.Values.ImageStates.ImageCheckedPressed = null;
            this.okButton1.Values.ImageStates.ImageCheckedTracking = null;
            this.okButton1.Values.Text = "OK";
            // 
            // cancelButton2
            // 
            this.cancelButton2.DirtyPaletteCounter = 2;
            this.cancelButton2.Location = new System.Drawing.Point(244, 256);
            this.cancelButton2.Name = "cancelButton2";
            this.cancelButton2.Size = new System.Drawing.Size(90, 25);
            this.cancelButton2.TabIndex = 1;
            this.cancelButton2.Text = "Cancel";
            this.cancelButton2.Values.ExtraText = "";
            this.cancelButton2.Values.Image = null;
            this.cancelButton2.Values.ImageStates.ImageCheckedNormal = null;
            this.cancelButton2.Values.ImageStates.ImageCheckedPressed = null;
            this.cancelButton2.Values.ImageStates.ImageCheckedTracking = null;
            this.cancelButton2.Values.Text = "Cancel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.kryptonLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 50);
            this.panel1.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.DirtyPaletteCounter = 4;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(245, 26);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Text = "Create new WinSmit Project";
            this.kryptonLabel1.Values.ExtraText = "";
            this.kryptonLabel1.Values.Image = null;
            this.kryptonLabel1.Values.Text = "Create new WinSmit Project";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.DirtyPaletteCounter = 1;
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 69);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(77, 19);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Text = "Project Name";
            this.kryptonLabel2.Values.ExtraText = "";
            this.kryptonLabel2.Values.Image = null;
            this.kryptonLabel2.Values.Text = "Project Name";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.DirtyPaletteCounter = 2;
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 94);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(103, 19);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Text = "Project Workspace";
            this.kryptonLabel3.Values.ExtraText = "";
            this.kryptonLabel3.Values.Image = null;
            this.kryptonLabel3.Values.Text = "Project Workspace";
            
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 9;
            // 
            // wiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 293);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton2);
            this.Controls.Add(this.okButton1);
            this.Name = "wiz";
            this.Text = "wiz";
            ((System.ComponentModel.ISupportInitialize)(this.okButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLabel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton okButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelButton2;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.TextBox textBox1;
    }
}