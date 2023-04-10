using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Navigator;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Text.RegularExpressions;
using ADOX;


namespace WinSmit
{
    public partial class WSMain : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        // properties
        private CurrentProject _CurrentProject;
        public CurrentProject CurrentProject
        {
            get
            {
                if (_CurrentProject == null)
                {
                    _CurrentProject = new CurrentProject();

                }

                return _CurrentProject;
            }
            set
            {
                _CurrentProject = value;
            }
        }



        public WSMain()
        {
            InitializeComponent();
        }


        private void WSMain_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check if we have an open project if yes warn the user
            if (CurrentProject.Path != null)
            {
                if (MessageBox.Show("A project is already open. Please close the current project", "Project", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    return;
                }
            }


            saveFileDialog1.Filter = "WinSmit Project (*.prj)|*.prj";

            saveFileDialog1.Title = "Create new WinSmit Project";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // write file
                //this.CurrentProject.Path = this.saveFileDialog1.FileName;



                String[] name = System.IO.Path.GetFileName(this.saveFileDialog1.FileName).Split('.');
                CurrentProject.Name = name[0];
                String path = System.IO.Path.GetDirectoryName(this.saveFileDialog1.FileName);
                this.CurrentProject.Path = path;
                CurrentProject.projectFile = name[0] + ".prj";

                TreeNode tn = new TreeNode();
                tn.Text = this.CurrentProject.Path;


                tn.Nodes.Add(name[0] + ".dump");
                tn.Nodes.Add("run_smitty.sh");
                tn.Nodes.Add("reload_smitty.sh");
                tn.Nodes.Add("setup_smitty.sh");

                //create files 
                write_smitty(path, "run_smitty.sh");
                write_smitty(path, name[0] + ".dump");
                write_smitty(path, name[0] + ".prj");
                write_smitty(path, "reload_smitty.sh");
                write_smitty(path, "setup_smitty.sh");

                // add nodes to treeview

                projectTreeView.Nodes.Add(tn);
                projectPage.Text = name[0] + " Project";
                winsmitPage.Text = name[0] + ".dump";



            }
            else
            {
                // MessageBox.Show("The Cancel button was clicked or Esc was pressed");
            }

        }

        private void write_smitty(string path, string filename)
        {
            TextWriter tw = new StreamWriter(path + "/" + filename);
            //write a line of text to the file
            tw.WriteLine(DateTime.Now);

            // close the stream
            tw.Close();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showProjectPageToolStripMenuItem_Click(object sender, EventArgs e)
        {




        }




        private void closeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                // here we must save the current project 
                // just update the project tree name and the winsmit tree name
                CurrentProject.name_projectTree = CurrentProject.Name + "prj.dat";
                CurrentProject.name_winsmitTree = CurrentProject.Name + "smit.dat";
                Stream stream = File.Open(CurrentProject.Path + "\\" + CurrentProject.projectFile, FileMode.Create);
                BinaryFormatter bformatter = new BinaryFormatter();
                Console.WriteLine("Writing Current Project");
                bformatter.Serialize(stream, CurrentProject);
                stream.Close();

                //save the project tree view
                stream = File.Open((CurrentProject.Path + "\\" + CurrentProject.name_projectTree), FileMode.Create);
                projectTreeView.Serialize(stream, bformatter);
                stream.Close();

                //save the winsmit tree view 
                stream = File.Open(CurrentProject.Path + "\\" + CurrentProject.name_winsmitTree, FileMode.Create);
                winsmitTreeView.Serialize(stream, bformatter);
                stream.Close();

                // clear the Current project
                CurrentProject = null;

                // clear the trees
                projectTreeView.Nodes.Clear();
                winsmitTreeView.Nodes.Clear();

                // clear the tabs
                projectPage.Text = "Project";
                winsmitPage.Text = "WinSmit";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "WinSmit Project (*.prj)|*.prj";

            openFileDialog1.Title = "Open WinSmit Project";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();
                CurrentProject = (CurrentProject)bformatter.Deserialize(stream);
                stream.Close();

                stream = File.Open(CurrentProject.Path + "\\" + CurrentProject.name_projectTree, FileMode.Open);
                bformatter = new BinaryFormatter();
                projectTreeView.Deserialize(stream, bformatter);
                stream.Close();

                stream = File.Open(CurrentProject.Path + "\\" + CurrentProject.name_winsmitTree, FileMode.Open);
                bformatter = new BinaryFormatter();
                winsmitTreeView.Deserialize(stream, bformatter);
                stream.Close();
                //
                propertyGrid1.SelectedObject = CurrentProject;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TreeNode tn = winsmitTreeView.SelectedNode;

            if (tn != null)
            {
                TreeNode wtn = new TreeNode();
                wtn.Text = "blaaa";
                tn.Nodes.Add(wtn);
            }
            else
            {
                TreeNode wtn = new TreeNode();
                wtn.Text = "blaaa";
                winsmitTreeView.Nodes.Add(wtn);
            }

        }

        private void winsmitTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tn = winsmitTreeView.SelectedNode;


        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("c:\\tmp\\smitusr.dump");
            string s = sr.ReadToEnd();
            sr.Close();
            s = s.Replace("sm_menu_opt", "@@sm_menu_opt");
            s = s.Replace("sm_cmd_opt", "@@sm_cmd_opt");
            s = s.Replace("sm_name_hdr", "@@sm_name_hdr");
            s = s.Replace("sm_cmd_hdr", "@@sm_cmd_hdr");
            string[] ss = Regex.Split(s, "@@");

            //clear string s
            s = "";

            foreach (string strItem in ss)
            {
                s = strItem;
                //prefix all know tokens with @@ in a for loop
                foreach (string tks in Util.tokens)
                {
                    s = s.Replace(tks, "@@" + tks.Replace("\t", ""));
                }
                Console.WriteLine(s);
            }

            foreach (string tks in Util.tokens)
            {
                Console.WriteLine(tks);
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DBUtil dbutil = new DBUtil();
            DBUtil.createNewDataBaseFile("mike1.mdb", "c:\\");
            DBUtil.createNewTableInDataBaseFile("mike1.mdb", "c:\\", "smit");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBUtil.fillDataset("mike1.mdb", "c:\\", "smit");
        }

    }
}