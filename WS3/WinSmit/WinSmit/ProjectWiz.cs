using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinSmit
{
    public partial class ProjectWiz : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private CurrentProject _currentProject;

        public CurrentProject currentProject
        {
            get
            {
                return this._currentProject;

            }
        }

        public ProjectWiz(CurrentProject project)
        {
            InitializeComponent();
            _currentProject = project;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Application.StartupPath;
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                projectPathTB.Text = folderBrowserDialog1.SelectedPath;
            }
            
        }

        private void wizard1_NextButtonClick(KellermanSoftware.ThemedWizard.Wizard sender, KellermanSoftware.ThemedWizard.WizardNextButtonClickEventArgs args)
        {
            // name page
            if (wizard1.CurrentPageIndex == NamePage.PageIndex)
            {
                if (projectNameTB.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a Project Name.", "WinSmit Project Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    args.Cancel = true;
                    args.NextPageIndex = NamePage.PageIndex;
                }
                else
                {
                    args.Cancel = false;
                    
                }
            }
            // path page
            if (wizard1.CurrentPageIndex == localPath.PageIndex)
            {
                if(projectPathTB.Text.Length==0)
                {
                    MessageBox.Show("Please enter a Project Path.", "WinSmit Project Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    args.Cancel = true;
                    args.NextPageIndex = localPath.PageIndex;
                    return;
                }
                bool exists = System.IO.Directory.Exists(@projectPathTB.Text);

                if ((projectPathTB.Text.Length >0) &&(exists==false))
                {
                    MessageBox.Show("Please select a valid Project Path.", "WinSmit Project Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    args.Cancel = true;
                    args.NextPageIndex = localPath.PageIndex;
                    return;
                }
                // here we must check if we have a project already

                if(remotePathAixTB.Text.Length==0)
                {
                    MessageBox.Show("Please enter a valid Remote Path.", "WinSmit Project Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    args.Cancel = true;
                    args.NextPageIndex = localPath.PageIndex;
                    return;
                }

                lbLocalPath.Text = projectPathTB.Text;
                lbProjectname.Text = projectNameTB.Text;
                lbRemotePath.Text = remotePathAixTB.Text;
                if (checkBox1.Checked == true)
                {
                    lbScripts.Text = "Yes";
                }
                else
                {
                    lbScripts.Text = "No";
                }

            }

        }

        private void wizard1_CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void wizard1_FinishButtonClick(object sender, EventArgs e)
        {
            // looks like all is OK
            // create a new project
            
            _currentProject.Name = projectNameTB.Text;
            _currentProject.Path = projectPathTB.Text;
            _currentProject.odmdir = remotePathAixTB.Text;
            this.Close();
           
        }
    }
}