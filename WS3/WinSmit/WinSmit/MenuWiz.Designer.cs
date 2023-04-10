namespace WinSmit
{
    partial class MenuWiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuWiz));
            this.wizard1 = new KellermanSoftware.ThemedWizard.Wizard();
            this.welcomePage1 = new KellermanSoftware.ThemedWizard.WelcomePage();
            this.advancedMenu = new System.Windows.Forms.RadioButton();
            this.standardMenu = new System.Windows.Forms.RadioButton();
            this.simpleMenu = new System.Windows.Forms.RadioButton();
            this.SimpleMenuPage1 = new KellermanSoftware.ThemedWizard.InteriorPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nextid_TB = new System.Windows.Forms.TextBox();
            this.autogenerate = new System.Windows.Forms.CheckBox();
            this.command_to_execute = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SimpleMenuPage2 = new KellermanSoftware.ThemedWizard.InteriorPage();
            this.SimpleMenurPage3 = new KellermanSoftware.ThemedWizard.InteriorPage();
            this.SimpleMenuPage4 = new KellermanSoftware.ThemedWizard.InteriorPage();
            this.StandardMenuPage1 = new KellermanSoftware.ThemedWizard.InteriorPage();
            this.AdvancedMenuPage1 = new KellermanSoftware.ThemedWizard.InteriorPage();
            this.completionPage1 = new KellermanSoftware.ThemedWizard.CompletionPage();
            this.welcomePage1.SuspendLayout();
            this.SimpleMenuPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizard1
            // 
            this.wizard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizard1.Location = new System.Drawing.Point(0, 0);
            this.wizard1.Name = "wizard1";
            this.wizard1.Size = new System.Drawing.Size(522, 373);
            this.wizard1.WizardPages.Add(this.welcomePage1);
            this.wizard1.WizardPages.Add(this.SimpleMenuPage1);
            this.wizard1.WizardPages.Add(this.SimpleMenuPage2);
            this.wizard1.WizardPages.Add(this.SimpleMenurPage3);
            this.wizard1.WizardPages.Add(this.SimpleMenuPage4);
            this.wizard1.WizardPages.Add(this.StandardMenuPage1);
            this.wizard1.WizardPages.Add(this.AdvancedMenuPage1);
            this.wizard1.WizardPages.Add(this.completionPage1);
            this.wizard1.NextButtonClick += new KellermanSoftware.ThemedWizard.WizardNextButtonClickEventHandler(this.wizard1_NextButtonClick);
            // 
            // welcomePage1
            // 
            this.welcomePage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.welcomePage1.Controls.Add(this.advancedMenu);
            this.welcomePage1.Controls.Add(this.standardMenu);
            this.welcomePage1.Controls.Add(this.simpleMenu);
            this.welcomePage1.Icon = ((System.Drawing.Image)(resources.GetObject("welcomePage1.Icon")));
            this.welcomePage1.LeftPanelBackColor = System.Drawing.SystemColors.Info;
            this.welcomePage1.LeftPanelBackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomePage1.LeftPanelBackgroundImage")));
            this.welcomePage1.Name = "welcomePage1";
            this.welcomePage1.Title = "Welcome to the WinSmit Menu Wizard.";
            // 
            // advancedMenu
            // 
            this.advancedMenu.AutoSize = true;
            this.advancedMenu.Location = new System.Drawing.Point(201, 214);
            this.advancedMenu.Name = "advancedMenu";
            this.advancedMenu.Size = new System.Drawing.Size(266, 17);
            this.advancedMenu.TabIndex = 2;
            this.advancedMenu.TabStop = true;
            this.advancedMenu.Text = "Advanced Menu Dialog with Selectors and Options";
            this.advancedMenu.UseVisualStyleBackColor = true;
            // 
            // standardMenu
            // 
            this.standardMenu.AutoSize = true;
            this.standardMenu.Location = new System.Drawing.Point(201, 156);
            this.standardMenu.Name = "standardMenu";
            this.standardMenu.Size = new System.Drawing.Size(192, 17);
            this.standardMenu.TabIndex = 1;
            this.standardMenu.TabStop = true;
            this.standardMenu.Text = "Standard Menu Dialog with Options";
            this.standardMenu.UseVisualStyleBackColor = true;
            // 
            // simpleMenu
            // 
            this.simpleMenu.AutoSize = true;
            this.simpleMenu.Location = new System.Drawing.Point(201, 100);
            this.simpleMenu.Name = "simpleMenu";
            this.simpleMenu.Size = new System.Drawing.Size(119, 17);
            this.simpleMenu.TabIndex = 0;
            this.simpleMenu.TabStop = true;
            this.simpleMenu.Text = "Simple Menu Dialog";
            this.simpleMenu.UseVisualStyleBackColor = true;
            // 
            // SimpleMenuPage1
            // 
            this.SimpleMenuPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SimpleMenuPage1.Controls.Add(this.button1);
            this.SimpleMenuPage1.Controls.Add(this.label3);
            this.SimpleMenuPage1.Controls.Add(this.nextid_TB);
            this.SimpleMenuPage1.Controls.Add(this.autogenerate);
            this.SimpleMenuPage1.Controls.Add(this.command_to_execute);
            this.SimpleMenuPage1.Controls.Add(this.label2);
            this.SimpleMenuPage1.Controls.Add(this.menuName);
            this.SimpleMenuPage1.Controls.Add(this.label1);
            this.SimpleMenuPage1.ForeColor = System.Drawing.Color.Black;
            this.SimpleMenuPage1.HeaderPanelBackgroundImage = ((System.Drawing.Image)(resources.GetObject("SimpleMenuPage1.HeaderPanelBackgroundImage")));
            this.SimpleMenuPage1.Icon = ((System.Drawing.Image)(resources.GetObject("SimpleMenuPage1.Icon")));
            this.SimpleMenuPage1.Name = "SimpleMenuPage1";
            this.SimpleMenuPage1.Subtitle = "Create a simple Menu";
            this.SimpleMenuPage1.Title = "Simple Menu ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "gen. Sample";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Next ID";
            // 
            // nextid_TB
            // 
            this.nextid_TB.Enabled = false;
            this.nextid_TB.Location = new System.Drawing.Point(158, 273);
            this.nextid_TB.Name = "nextid_TB";
            this.nextid_TB.Size = new System.Drawing.Size(258, 20);
            this.nextid_TB.TabIndex = 5;
            // 
            // autogenerate
            // 
            this.autogenerate.AutoSize = true;
            this.autogenerate.Location = new System.Drawing.Point(158, 250);
            this.autogenerate.Name = "autogenerate";
            this.autogenerate.Size = new System.Drawing.Size(126, 17);
            this.autogenerate.TabIndex = 4;
            this.autogenerate.Text = "auto generate next id";
            this.autogenerate.UseVisualStyleBackColor = true;
            this.autogenerate.CheckStateChanged += new System.EventHandler(this.autogenerate_CheckStateChanged);
            // 
            // command_to_execute
            // 
            this.command_to_execute.Location = new System.Drawing.Point(158, 107);
            this.command_to_execute.Name = "command_to_execute";
            this.command_to_execute.Size = new System.Drawing.Size(258, 128);
            this.command_to_execute.TabIndex = 3;
            this.command_to_execute.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Command to  execute";
            // 
            // menuName
            // 
            this.menuName.Location = new System.Drawing.Point(158, 81);
            this.menuName.Name = "menuName";
            this.menuName.Size = new System.Drawing.Size(258, 20);
            this.menuName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Name";
            // 
            // SimpleMenuPage2
            // 
            this.SimpleMenuPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SimpleMenuPage2.ForeColor = System.Drawing.Color.Black;
            this.SimpleMenuPage2.HeaderPanelBackgroundImage = ((System.Drawing.Image)(resources.GetObject("SimpleMenuPage2.HeaderPanelBackgroundImage")));
            this.SimpleMenuPage2.Icon = ((System.Drawing.Image)(resources.GetObject("SimpleMenuPage2.Icon")));
            this.SimpleMenuPage2.Name = "SimpleMenuPage2";
            // 
            // SimpleMenurPage3
            // 
            this.SimpleMenurPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SimpleMenurPage3.ForeColor = System.Drawing.Color.Black;
            this.SimpleMenurPage3.HeaderPanelBackgroundImage = ((System.Drawing.Image)(resources.GetObject("SimpleMenurPage3.HeaderPanelBackgroundImage")));
            this.SimpleMenurPage3.Icon = ((System.Drawing.Image)(resources.GetObject("SimpleMenurPage3.Icon")));
            this.SimpleMenurPage3.Name = "SimpleMenurPage3";
            // 
            // SimpleMenuPage4
            // 
            this.SimpleMenuPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SimpleMenuPage4.ForeColor = System.Drawing.Color.Black;
            this.SimpleMenuPage4.HeaderPanelBackgroundImage = ((System.Drawing.Image)(resources.GetObject("SimpleMenuPage4.HeaderPanelBackgroundImage")));
            this.SimpleMenuPage4.Icon = ((System.Drawing.Image)(resources.GetObject("SimpleMenuPage4.Icon")));
            this.SimpleMenuPage4.Name = "SimpleMenuPage4";
            // 
            // StandardMenuPage1
            // 
            this.StandardMenuPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StandardMenuPage1.ForeColor = System.Drawing.Color.Black;
            this.StandardMenuPage1.HeaderPanelBackgroundImage = ((System.Drawing.Image)(resources.GetObject("StandardMenuPage1.HeaderPanelBackgroundImage")));
            this.StandardMenuPage1.Icon = ((System.Drawing.Image)(resources.GetObject("StandardMenuPage1.Icon")));
            this.StandardMenuPage1.Name = "StandardMenuPage1";
            this.StandardMenuPage1.Title = "StandardMenuPage1";
            // 
            // AdvancedMenuPage1
            // 
            this.AdvancedMenuPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdvancedMenuPage1.ForeColor = System.Drawing.Color.Black;
            this.AdvancedMenuPage1.HeaderPanelBackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdvancedMenuPage1.HeaderPanelBackgroundImage")));
            this.AdvancedMenuPage1.Icon = ((System.Drawing.Image)(resources.GetObject("AdvancedMenuPage1.Icon")));
            this.AdvancedMenuPage1.Name = "AdvancedMenuPage1";
            this.AdvancedMenuPage1.Title = "AdvancedMenuPage1";
            // 
            // completionPage1
            // 
            this.completionPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("completionPage1.BackgroundImage")));
            this.completionPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.completionPage1.Name = "completionPage1";
            // 
            // MenuWiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 373);
            this.Controls.Add(this.wizard1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuWiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuWiz";
            this.welcomePage1.ResumeLayout(false);
            this.welcomePage1.PerformLayout();
            this.SimpleMenuPage1.ResumeLayout(false);
            this.SimpleMenuPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KellermanSoftware.ThemedWizard.Wizard wizard1;
        private KellermanSoftware.ThemedWizard.WelcomePage welcomePage1;
        private KellermanSoftware.ThemedWizard.InteriorPage SimpleMenuPage1;
        private KellermanSoftware.ThemedWizard.CompletionPage completionPage1;
        private System.Windows.Forms.RadioButton simpleMenu;
        private KellermanSoftware.ThemedWizard.InteriorPage SimpleMenuPage2;
        private KellermanSoftware.ThemedWizard.InteriorPage SimpleMenurPage3;
        private KellermanSoftware.ThemedWizard.InteriorPage SimpleMenuPage4;
        private System.Windows.Forms.RadioButton standardMenu;
        private System.Windows.Forms.RadioButton advancedMenu;
        private KellermanSoftware.ThemedWizard.InteriorPage StandardMenuPage1;
        private KellermanSoftware.ThemedWizard.InteriorPage AdvancedMenuPage1;
        private System.Windows.Forms.RichTextBox command_to_execute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox menuName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nextid_TB;
        private System.Windows.Forms.CheckBox autogenerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}