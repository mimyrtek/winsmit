using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinSmit
{
    public partial class MenuWiz : Form
    {
        public MenuWiz()
        {
            InitializeComponent();
        }

        private void wizard1_NextButtonClick(KellermanSoftware.ThemedWizard.Wizard sender, KellermanSoftware.ThemedWizard.WizardNextButtonClickEventArgs args)
        {
            if(wizard1.CurrentPageIndex== welcomePage1.PageIndex && simpleMenu.Checked==true)
            {
                args.NextPageIndex  = SimpleMenuPage1.PageIndex;
            }
            if (wizard1.CurrentPageIndex == welcomePage1.PageIndex && standardMenu.Checked == true)
            {
                args.NextPageIndex = StandardMenuPage1.PageIndex;
            }
            if (wizard1.CurrentPageIndex == welcomePage1.PageIndex && advancedMenu.Checked == true)
            {
                args.NextPageIndex = AdvancedMenuPage1.PageIndex;
            }
        }

        private void autogenerate_CheckStateChanged(object sender, EventArgs e)
        {
            if (autogenerate.Checked == true)
            {
                nextid_TB.Enabled = false;
                Guid guid = System.Guid.NewGuid();
                nextid_TB.Text = guid.ToString();
            }
            else
            {
                nextid_TB.Enabled = true;
                nextid_TB.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command_to_execute.Text = "foo\n{\nhostname\n }\nfoo";
        }

        
    }
}