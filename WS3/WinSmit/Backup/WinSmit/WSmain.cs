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
using System.Data.OleDb;


namespace WinSmit
{
    public partial class WSMain : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        // properties
        public SortedList SortedMenuList = new SortedList();
        private List<sm_menu_opt> list_menu_opt = new List<sm_menu_opt>();

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

        private static sm_menu_opt process_sm_menu_opt(string s, string menuType)
        {
            sm_menu_opt sm = new sm_menu_opt();

            string[] ss = Regex.Split(s, "@@");

            foreach (string str in ss)
            {
                string tmp_str = str.TrimStart('\t');
                tmp_str = str.TrimEnd('\n');
                // find first =
                int index = tmp_str.IndexOf('=');
                string right = "";
                string left = "";
                if (index > 0)
                {
                    left = tmp_str.Substring(0, index).Trim();
                    right = tmp_str.Substring(index + 1, tmp_str.Length - index - 1).Trim();
                    right = right.TrimStart('\"');
                    right = right.TrimEnd('\"');
                    switch (left)
                    {
                        case "id_seq_num":
                            sm.id_seq_num = right;
                            break;
                        case "id":
                            sm.id = right;
                            break;
                        case "next_id":
                            sm.next_id = right;
                            break;
                        case "text":
                            sm.text = right;
                            break;
                        case "text_msg_file":
                            sm.text_msg_file = right;
                            break;
                        case "text_msg_set":
                            sm.text_msg_set = right;
                            break;
                        case "text_msg_id":
                            sm.text_msg_id = right;
                            break;
                        case "next_type":
                            if (right == "m")
                            {
                                sm.next_type = sm_menu_opt_next_type.Menu;
                            }
                            if (right == "i")
                            {
                                sm.next_type = sm_menu_opt_next_type.Info;
                            }
                            if (right == "d")
                            {
                                sm.next_type = sm_menu_opt_next_type.Dialog;
                            }
                            if (right == "n")
                            {
                                sm.next_type = sm_menu_opt_next_type.Name;
                            }

                            break;
                        case "alias":
                            sm.alias = right;
                            break;
                        case "help_msg_id":
                            sm.help_msg_id = right;
                            break;
                        case "help_msg_loc":
                            sm.help_msg_loc = right;
                            break;
                        case "help_msg_base":
                            sm.help_msg_base = right;
                            break;
                        case "help_msg_book":
                            sm.help_msg_book = right;
                            break;
                        default:
                            break;
                    }
                }
            }
            return sm;
        }
        private static sm_cmd_opt process_sm_cmd_opt(string s, string menuType)
        {
            sm_cmd_opt sm = new sm_cmd_opt();

            string[] ss = Regex.Split(s, "@@");

            foreach (string str in ss)
            {
                string tmp_str = str.TrimStart('\t');
                tmp_str = str.TrimEnd('\n');
                // find first =
                int index = tmp_str.IndexOf('=');
                string right = "";
                string left = "";
                if (index > 0)
                {
                    left = tmp_str.Substring(0, index).Trim();
                    right = tmp_str.Substring(index + 1, tmp_str.Length - index - 1).Trim();
                    right = right.TrimStart('\"');
                    right = right.TrimEnd('\"');
                    switch (left)
                    {
                        case "id_seq_num":
                            sm.id_seq_num = right;
                            break;
                        case "id":
                            sm.id = right;
                            break;
                        case "disc_field_name":
                            sm.disc_field_name = right;
                            break;
                        case "name":
                            sm.name = right;
                            break;
                        case "name_msg_file":
                            sm.name_msg_file = right;
                            break;
                        case "name_msg_set":
                            sm.name_msg_set = right;
                            break;
                        case "name_msg_id":
                            sm.name_msg_id = right;
                            break;
                        case "op_type":
                            sm.op_type = right;
                            break;
                        case "entry_type":
                            //sm.entry_type =right;
                            break;
                        case "entry_size":
                            sm.entry_size = right;
                            break;
                        case "required":
                            sm.required = right;
                            break;
                        case "prefix":
                            sm.prefix = right;
                            break;
                        case "cmd_to_list_mode":
                            sm.cmd_to_list_mode = right;
                            break;
                        case "cmd_to_list":
                            sm.cmd_to_list = right;
                            break;
                        case "cmd_to_list_postfix":
                            sm.cmd_to_list_postfix = right;
                            break;
                        case "multi_select":
                            sm.multi_select = right;
                            break;
                        case "value_index":
                            sm.value_index = right;
                            break;
                        case "disp_values":
                            sm.disp_values = right;
                            break;
                        case "values_msg_file":
                            sm.values_msg_file = right;
                            break;
                        case "values_msg_set":
                            sm.values_msg_set = right;
                            break;
                        case "values_msg_id":
                            sm.values_msg_id = right;
                            break;
                        case "aix_values":
                            sm.aix_values = right;
                            break;
                        case "help_msg_id":
                            sm.help_msg_id = right;
                            break;
                        case "help_msg_loc":
                            sm.help_msg_loc = right;
                            break;
                        case "help_msg_base":
                            sm.help_msg_base = right;
                            break;
                        case "help_msg_book":
                            sm.help_msg_book = right;
                            break;
                        default:
                            break;
                    }
                }
            }
            return sm;
        }
        private static sm_name_hdr process_sm_name_hdr(string s, string menuType)
        {
            sm_name_hdr sm = new sm_name_hdr();

            string[] ss = Regex.Split(s, "@@");

            foreach (string str in ss)
            {
                string tmp_str = str.TrimStart('\t');
                tmp_str = str.TrimEnd('\n');
                // find first =
                int index = tmp_str.IndexOf('=');
                string right = "";
                string left = "";
                if (index > 0)
                {
                    left = tmp_str.Substring(0, index).Trim();
                    right = tmp_str.Substring(index + 1, tmp_str.Length - index - 1).Trim();
                    right = right.TrimStart('\"');
                    right = right.TrimEnd('\"');
                    switch (left)
                    {

                        case "id":
                            sm.id = right;
                            break;
                        case "next_id":
                            sm.next_id = right;
                            break;
                        case "option_id":
                            sm.option_id = right;
                            break;
                        case "has_name_select":
                            //sm.has_name_select= right;
                            break;
                        case "name":
                            sm.name = right;
                            break;
                        case "name_msg_file":
                            sm.name_msg_file = right;
                            break;
                        case "name_msg_set":
                            sm.name_msg_set = right;
                            break;
                        case "name_msg_id":
                            sm.name_msg_id = right;
                            break;
                        case "type":
                            //sm.type = right;
                            break;
                        case "ghost":
                            //sm.ghost = right;
                            break;
                        case "cmd_to_classify":
                            sm.cmd_to_classify = right;
                            break;
                        case "cmd_to_classify_postfix":
                            sm.cmd_to_classify_postfix = right;
                            break;
                        case "raw_field_name":
                            sm.raw_field_name = right;
                            break;
                        case "cooked_field_name":
                            sm.cooked_field_name = right;
                            break;
                        case "next_type":
                            //sm.next_type = right;
                            break;
                        case "help_msg_id":
                            sm.help_msg_id = right;
                            break;
                        case "help_msg_loc":
                            sm.help_msg_loc = right;
                            break;
                        case "help_msg_base":
                            sm.help_msg_base = right;
                            break;
                        case "help_msg_book":
                            sm.help_msg_book = right;
                            break;
                        default:
                            break;
                    }
                }
            }
            return sm;
        }
        private static sm_cmd_hdr process_sm_cmd_hdr(string s, string menuType)
        {
            sm_cmd_hdr sm = new sm_cmd_hdr();

            string[] ss = Regex.Split(s, "@@");

            foreach (string str in ss)
            {
                string tmp_str = str.TrimStart('\t');
                tmp_str = str.TrimEnd('\n');
                // find first =
                int index = tmp_str.IndexOf('=');
                string right = "";
                string left = "";
                if (index > 0)
                {
                    left = tmp_str.Substring(0, index).Trim();
                    right = tmp_str.Substring(index + 1, tmp_str.Length - index - 1).Trim();
                    right = right.TrimStart('\"');
                    right = right.TrimEnd('\"');
                    switch (left)
                    {
                        case "id":
                            sm.id = right;
                            break;
                        case "option_id":
                            sm.option_id = right;
                            break;
                        case "has_name_select":
                            //sm.has_name_select = right;
                            break;
                        case "name":
                            sm.name = right;
                            break;
                        case "name_msg_file":
                            sm.name_msg_file = right;
                            break;
                        case "name_msg_set":
                            sm.name_msg_set = right;
                            break;
                        case "name_msg_id":
                            sm.name_msg_id = right;
                            break;
                        case "cmd_to_exec":
                            sm.cmd_to_exec = right;
                            break;
                        case "ask":
                            //sm.ask = right;
                            break;
                        case "exec_mode":
                            sm.exec_mode = right;
                            break;
                        case "ghost":
                            //sm.ghost = right;
                            break;
                        case "cmd_to_discover":
                            sm.cmd_to_discover = right;
                            break;
                        case "cmd_to_discover_postfix":
                            sm.cmd_to_discover_postfix = right;
                            break;
                        case "name_size":
                            sm.name_size = right;
                            break;
                        case "value_size":
                            sm.value_size = right;
                            break;
                        case "help_msg_id":
                            sm.help_msg_id = right;
                            break;
                        case "help_msg_loc":
                            sm.help_msg_loc = right;
                            break;
                        case "help_msg_base":
                            sm.help_msg_base = right;
                            break;
                        case "help_msg_book":
                            sm.help_msg_book = right;
                            break;
                        default:
                            break;
                    }
                }
            }
            return sm;
        }

        #region Properties
        private static ArrayList _tokens;
        public static ArrayList tokens
        {
            get
            {
                if (_tokens == null)
                {
                    //sm_menu_opt
                    _tokens = new ArrayList();
                    _tokens.Add("id");
                    _tokens.Add("id_seq_num");
                    _tokens.Add("next_id");
                    _tokens.Add("text");
                    _tokens.Add("text_msg_file");
                    _tokens.Add("text_msg_set");
                    _tokens.Add("text_msg_id");
                    _tokens.Add("next_type");
                    _tokens.Add("alias");
                    _tokens.Add("help_msg_id");
                    _tokens.Add("help_msg_loc");
                    _tokens.Add("help_msg_base");
                    _tokens.Add("help_msg_book");

                    //sm_cmd_hdr
                    _tokens.Add("option_id");
                    _tokens.Add("has_name_select");
                    _tokens.Add("name");
                    _tokens.Add("name_msg_file");
                    _tokens.Add("name_msg_set");
                    _tokens.Add("name_msg_id");
                    _tokens.Add("cmd_to_exec");
                    _tokens.Add("ask");
                    _tokens.Add("exec_mode");
                    _tokens.Add("ghost");
                    _tokens.Add("cmd_to_discover");
                    _tokens.Add("cmd_to_discover_postfix");
                    _tokens.Add("name_size");
                    _tokens.Add("value_size");
                    //sm_cmd_opt

                    _tokens.Add("disc_field_name");
                    _tokens.Add("op_type");
                    _tokens.Add("entry_type");
                    _tokens.Add("entry_size");
                    _tokens.Add("required");
                    _tokens.Add("prefix");
                    _tokens.Add("cmd_to_list_mode");
                    _tokens.Add("cmd_to_list");
                    _tokens.Add("cmd_to_list_postfix");
                    _tokens.Add("multi_select");
                    _tokens.Add("value_index");
                    _tokens.Add("disp_values");
                    _tokens.Add("values_msg_file");
                    _tokens.Add("values_msg_set");
                    _tokens.Add("values_msg_id");
                    _tokens.Add("aix_values");
                    //sm_name_hdr
                    _tokens.Add("type");
                    _tokens.Add("cmd_to_classify");
                    _tokens.Add("cmd_to_classify_postfix");
                    _tokens.Add("raw_field_name");
                    _tokens.Add("cooked_field_name");
                    _tokens.Add("next_type");
                }
                return _tokens;
            }
        }
        #endregion

        #region menu_opt_BG background worker
        private void menu_opt_BG_DoWork(object sender, DoWorkEventArgs e)
        {
            ArrayList al = (ArrayList)e.Argument;
            WinSmitTreeNode node = new WinSmitTreeNode(); ;
            sm_menu_opt sm = new sm_menu_opt();
            string s = "";
            //counter
            int i = 0;
            foreach (string strItem in al)
            {
                i++;
                //check if canceled
                if (menu_opt_BG.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                s = strItem;
                //prefix all know tokens with @@ in a for loop
                foreach (string tks in tokens)
                {
                    string input = "\\b" + tks + "\\b";
                    s = Regex.Replace(s, input, "@@" + tks);
                    //s = s.Replace(tks, "@@" + tks.Replace("\t", ""));
                }

                s = s.Replace("sm_menu_opt:", "");
                sm = process_sm_menu_opt(s, "sm_menu_opt");
                // new code
                list_menu_opt.Add(sm);


                //
                node = new WinSmitTreeNode();
                node.Text = sm.text;
                node.sm_menu_opt = sm;
                // add to list view
                //WinSmitListItem wli = new WinSmitListItem();
                //wli.Text = sm.id;
                //wli.sm_menu_opt = sm;
                //node = new TreeNode(sm.text);
                this.menu_opt_BG.ReportProgress(i, node);
                System.Threading.Thread.Sleep(5);
            }

        }
        private void menu_opt_BG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WinSmitTreeNode node = (WinSmitTreeNode)e.UserState;


            if (node.sm_menu_opt.next_type == sm_menu_opt_next_type.Dialog)
            {

                if (node.sm_menu_opt.alias == "y")
                {
                    node.ImageIndex = 9;
                    node.SelectedImageIndex = 9;
                    node.Text = "<<ALIAS next id = >>" + node.sm_menu_opt.next_id;
                }
                else
                {
                    node.ImageIndex = 10;
                    node.SelectedImageIndex = 10;
                }
                sm_menu_opt_treeView.Nodes.Add(node);
            }
            if (node.sm_menu_opt.next_type == sm_menu_opt_next_type.Info)
            {

                if (node.sm_menu_opt.alias == "y")
                {
                    node.ImageIndex = 9;
                    node.SelectedImageIndex = 9;
                    node.Text = "<<ALIAS next id = >>" + node.sm_menu_opt.next_id;
                }
                else
                {

                    node.ImageIndex = 11;
                    node.SelectedImageIndex = 11;
                }
                sm_menu_opt_treeView.Nodes.Add(node);
            }
            if (node.sm_menu_opt.next_type == sm_menu_opt_next_type.Menu)
            {

                if (node.sm_menu_opt.alias == "y")
                {
                    node.ImageIndex = 9;
                    node.SelectedImageIndex = 9;
                    node.Text = "<<ALIAS next id = " + node.sm_menu_opt.next_id + ">>";
                }
                else
                {
                    node.ImageIndex = 12;
                    node.SelectedImageIndex = 12;
                }
                sm_menu_opt_treeView.Nodes.Add(node);
            }
            if (node.sm_menu_opt.next_type == sm_menu_opt_next_type.Name)
            {

                if (node.sm_menu_opt.alias == "y")
                {
                    node.ImageIndex = 9;
                    node.SelectedImageIndex = 9;
                    node.Text = "<<ALIAS next id = >>" + node.sm_menu_opt.next_id;
                }
                else
                {
                    node.ImageIndex = 13;
                    node.SelectedImageIndex = 13;
                }
                sm_menu_opt_treeView.Nodes.Add(node);
            }
            progressBar1.Value = e.ProgressPercentage;
        }
        private void menu_opt_BG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.ForeColor = Color.Green;
        }
        #endregion menu opt background worker
        #region cmd_opt_BG background worker
        private void cmd_opt_BG_DoWork(object sender, DoWorkEventArgs e)
        {
            ArrayList al = (ArrayList)e.Argument;
            WinSmitTreeNode node = new WinSmitTreeNode(); ;
            sm_cmd_opt sm = new sm_cmd_opt();
            string s = "";
            //counter
            int i = 0;
            foreach (string strItem in al)
            {
                i++;
                //check if canceled
                if (cmd_opt_BG.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                s = strItem;
                //prefix all know tokens with @@ in a for loop
                foreach (string tks in tokens)
                {
                    s = s.Replace(tks, "@@" + tks.Replace("\t", ""));
                }

                s = s.Replace("sm_cmd_opt:", "");
                sm = process_sm_cmd_opt(s, "sm_cmd_opt");
                node = new WinSmitTreeNode();//sm.name);
                node.Name = sm.name;
                node.Text = sm.name;
                node.sm_cmd_opt = sm;
                this.cmd_opt_BG.ReportProgress(i, node);
                System.Threading.Thread.Sleep(2);
            }

        }
        private void cmd_opt_BG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TreeNode node = (TreeNode)e.UserState;
            sm_treeView.Nodes.Add(node);
            progressBar2.Value = e.ProgressPercentage;
        }
        private void cmd_opt_BG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar2.ForeColor = Color.Green;
        }
        #endregion cmd_opt_BG background worker
        #region name_hdr_BG background worker
        private void name_hdr_BG_DoWork(object sender, DoWorkEventArgs e)
        {
            ArrayList al = (ArrayList)e.Argument;
            TreeNode node = new TreeNode(); ;
            sm_name_hdr sm = new sm_name_hdr();
            string s = "";
            //counter
            int i = 0;
            foreach (string strItem in al)
            {
                i++;
                //check if canceled
                if (name_hdr_BG.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                s = strItem;
                //prefix all know tokens with @@ in a for loop
                foreach (string tks in tokens)
                {
                    s = s.Replace(tks, "@@" + tks.Replace("\t", ""));
                }

                s = s.Replace("sm_name_hdr:", "");
                sm = process_sm_name_hdr(s, "sm_name_hdr");
                node = new WinSmitTreeNode(sm);
                this.name_hdr_BG.ReportProgress(i, node);
                System.Threading.Thread.Sleep(5);
            }



        }
        private void name_hdr_BG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WinSmitTreeNode node = (WinSmitTreeNode)e.UserState;
            sm_treeView.Nodes.Add(node);
            progressBar3.Value = e.ProgressPercentage;

        }
        private void name_hdr_BG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar3.ForeColor = Color.Green;
        }
        #endregion name_hdr_BG background worker
        #region cmd_hdr_BG background worker
        private void cmd_hdr_BG_DoWork(object sender, DoWorkEventArgs e)
        {
            ArrayList al = (ArrayList)e.Argument;
            WinSmitTreeNode node = new WinSmitTreeNode(); ;
            sm_cmd_hdr sm = new sm_cmd_hdr();
            string s = "";
            //counter
            int i = 0;
            foreach (string strItem in al)
            {
                i++;
                //check if canceled
                if (cmd_hdr_BG.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                s = strItem;
                //prefix all know tokens with @@ in a for loop
                foreach (string tks in tokens)
                {
                    s = s.Replace(tks, "@@" + tks.Replace("\t", ""));
                }

                s = s.Replace("sm_cmd_hdr:", "");
                sm = process_sm_cmd_hdr(s, "sm_cmd_hdr");
                node = new WinSmitTreeNode(sm);
                //node = new WinSmitTreeNode();
                //node.Text = sm.name;
                //node.sm_cmd_hdr = sm;
                this.cmd_hdr_BG.ReportProgress(i, node);
                System.Threading.Thread.Sleep(2);
            }
        }
        private void cmd_hdr_BG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WinSmitTreeNode node = (WinSmitTreeNode)e.UserState;
            sm_treeView.Nodes.Add(node);
            progressBar4.Value = e.ProgressPercentage;
        }
        private void cmd_hdr_BG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar4.ForeColor = Color.Green;
        }
        #endregion cmd_hdr_BG background worker



        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            winsmitTreeView.Nodes.Clear();
            sm_menu_opt_treeView.Nodes.Clear();
            sm_treeView.Nodes.Clear();
            list_menu_opt.Clear();

            //open a smitty file and start processing
            openFileDialog1.Filter = "WinSmit File (*.dump)|*.dump";
            openFileDialog1.Title = "Open WinSmit File";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // read file
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string s = sr.ReadToEnd();
                sr.Close();


                s = s.Replace("sm_menu_opt", "@@sm_menu_opt");
                s = s.Replace("sm_cmd_opt", "@@sm_cmd_opt");
                s = s.Replace("sm_name_hdr", "@@sm_name_hdr");
                s = s.Replace("sm_cmd_hdr", "@@sm_cmd_hdr");
                string[] ss = Regex.Split(s, "@@");
                // now create four list arrays to store the different
                // stanza types then these can be passed to four 
                // background workers.

                ArrayList sm_menu_opt_array = new ArrayList();
                ArrayList sm_cmd_opt_array = new ArrayList();
                ArrayList sm_name_hdr_array = new ArrayList();
                ArrayList sm_cmd_hdr_array = new ArrayList();
                // change color of the progress bars
                progressBar1.ForeColor = Color.Blue;
                progressBar2.ForeColor = Color.Blue;
                progressBar3.ForeColor = Color.Blue;
                progressBar4.ForeColor = Color.Blue;

                foreach (string st in ss)
                {
                    if (st.StartsWith("sm_menu_opt"))
                    {
                        sm_menu_opt_array.Add(st);
                    }
                    if (st.StartsWith("sm_cmd_opt"))
                    {
                        sm_cmd_opt_array.Add(st);
                    }
                    if (st.StartsWith("sm_name_hdr"))
                    {
                        sm_name_hdr_array.Add(st);
                    }
                    if (st.StartsWith("sm_cmd_hdr"))
                    {
                        sm_cmd_hdr_array.Add(st);
                    }
                }
                //set the progress bar max value
                progressBar1.Maximum = sm_menu_opt_array.Count;
                progressBar2.Maximum = sm_cmd_opt_array.Count;
                progressBar3.Maximum = sm_name_hdr_array.Count;
                progressBar4.Maximum = sm_cmd_hdr_array.Count;

                //toolStripProgressBar1.Visible = true;

                // now start the background workers for each arraylist
                this.menu_opt_BG.RunWorkerAsync(sm_menu_opt_array);
                this.cmd_hdr_BG.RunWorkerAsync(sm_cmd_hdr_array);
                this.name_hdr_BG.RunWorkerAsync(sm_name_hdr_array);
                this.cmd_opt_BG.RunWorkerAsync(sm_cmd_opt_array);

                //this.backgroundWorker1.RunWorkerAsync(openFileDialog1.FileName);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            kryptonNavigator1.Pages[1].Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kryptonNavigator1.Pages[1].Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //get the ROOT node
            TreeNodeCollection tc = sm_menu_opt_treeView.Nodes;
            foreach (WinSmitTreeNode wtn in tc)
            {
                try
                {
                    if (wtn.sm_menu_opt.id == "__ROOT__")
                    {
                        sm_menu_opt_treeView.Nodes.Remove(wtn);
                        winsmitTreeView.Nodes.Add(wtn);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            // now we have the root node(s)
            CallRecursive(winsmitTreeView);
        }

        private void CallRecursive(WinSmitTreeView treeView)
        {
            // loop the tree
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (WinSmitTreeNode n in nodes)
            {
                findAllChildren(n);
                PrintRecursive(n);
            }
        }

        private void findAllChildren(WinSmitTreeNode currentNode)
        {
            TreeNodeCollection tc = sm_menu_opt_treeView.Nodes;

            try
            {
                //iterate over the sm_menu_opt treeview
                foreach (WinSmitTreeNode wtn in tc)
                {
                    // if we find a tree node with the id same as next id from 
                    // current node we need to look for its children and then add
                    // this node to the current node
                    if (currentNode.sm_menu_opt.next_id == wtn.sm_menu_opt.id)
                    {
                        sm_menu_opt_treeView.Nodes.Remove(wtn);
                        currentNode.Nodes.Add(wtn);
                        //findAllChildren(wtn);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void PrintRecursive(WinSmitTreeNode treeNode)
        {
            findAllNextIds(treeNode.sm_menu_opt.next_id, treeNode);

            foreach (WinSmitTreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(tn);
            }
        }

        private void findAllNextIds(string p, WinSmitTreeNode currentnode)
        {
            TreeNodeCollection tc = sm_menu_opt_treeView.Nodes;

            foreach (WinSmitTreeNode wtn in tc)
            {
                if (wtn.sm_menu_opt.id == p)
                {
                    sm_menu_opt_treeView.Nodes.Remove(wtn);
                    currentnode.Nodes.Add(wtn);
                }
            }


        }



        private void winsmitTreeView_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            WinSmitTreeNode tn = (WinSmitTreeNode)winsmitTreeView.SelectedNode;

            tn.BackColor = Color.SteelBlue;


            propertyGrid2.SelectedObject = tn.sm_menu_opt;
            kryptonNavigator2.Pages[1].Text = tn.sm_menu_opt.text;
            // if this is a node with a mane and an alias show the alias as well
            if(tn.sm_menu_opt_alias!=null)
            {
                kryptonNavigator2.Pages[2].Show();
                alias_propertyGrid.SelectedObject=tn.sm_menu_opt_alias;
                kryptonNavigator2.Pages[2].Text="Alias";
            }
            else
            {
                kryptonNavigator2.Pages[2].Hide();
            }



            foreach (WinSmitTreeNode treenode in sm_treeView.Nodes)
            {
                if (treenode.sm_cmd_hdr != null)
                {
                    sm_cmd_hdr foundnode = treenode.sm_cmd_hdr;
                    if (foundnode.id == tn.sm_menu_opt.next_id)
                    {
                        sm_treeView.Nodes.Remove(treenode);
                        winSmitTreeView1.Nodes.Add(treenode);

                    }
                }
                if (treenode.sm_cmd_opt != null)
                {
                    sm_cmd_opt foundnode = treenode.sm_cmd_opt;
                    if (foundnode.id == tn.sm_menu_opt.next_id)
                    {
                        break;
                    }
                }
                if (treenode.sm_menu_opt != null)
                {
                    sm_menu_opt foundnode = treenode.sm_menu_opt;
                    if (foundnode.id == tn.sm_menu_opt.next_id)
                    {
                        break;
                    }
                }
                if (treenode.sm_name_hdr != null)
                {
                    sm_name_hdr foundnode = treenode.sm_name_hdr;
                    if (foundnode.id == tn.sm_menu_opt.next_id)
                    {
                        break;
                    }
                }

                //if (sm_cmd_hdr_tn.sm_cmd_hdr.id == tn.sm_menu_opt.next_id)
                //{
                //    Console.WriteLine("found it");
                //    break;
                //}
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            winsmitTreeView.TreeViewNodeSorter = new NodeSorter();
        }

        public class NodeSorter : IComparer
        {
            // Compare the length of the strings, or the strings
            // themselves, if they are the same length.
            public int Compare(object x, object y)
            {
                WinSmitTreeNode tx = x as WinSmitTreeNode;
                WinSmitTreeNode ty = y as WinSmitTreeNode;

                // Compare the length of the strings, returning the difference.
                int one = 0;
                int two = 0;



                if ((IsInteger(tx.sm_menu_opt.id_seq_num)) && (IsInteger(ty.sm_menu_opt.id_seq_num)))
                {
                    one = Int32.Parse(tx.sm_menu_opt.id_seq_num);
                    two = Int32.Parse(ty.sm_menu_opt.id_seq_num);
                    return one - two;
                }


                if (tx.sm_menu_opt.id_seq_num != ty.sm_menu_opt.id_seq_num)
                {
                    return tx.sm_menu_opt.id_seq_num.Length - ty.sm_menu_opt.id_seq_num.Length;
                }

                // If they are the same length, call Compare.
                //return string.Compare(ty.Text, tx.Text);

                return string.Compare(ty.sm_menu_opt.id_seq_num, tx.sm_menu_opt.id_seq_num, StringComparison.Ordinal);
            }
            public static bool IsInteger(string theValue)
            {
                try
                {
                    Convert.ToInt32(theValue);
                    return true;
                }
                catch
                {
                    return false;
                }
            } //IsInteger

        }

        private void sm_menu_opt_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            WinSmitTreeNode tn = (WinSmitTreeNode)sm_menu_opt_treeView.SelectedNode;
            propertyGrid2.SelectedObject = tn.sm_menu_opt;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            winsmitTreeView.BeginUpdate();
            winsmitTreeView.ExpandAll();
            winsmitTreeView.EndUpdate();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            winsmitTreeView.BeginUpdate();
            CallGetEndpoints(winsmitTreeView);
            winsmitTreeView.EndUpdate();
        }

        private void CallGetEndpoints(WinSmitTreeView treeView)
        {
            // Print each node recursively.
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (WinSmitTreeNode n in nodes)
            {
                GetEndpoints(n);
            }
        }
        private void GetEndpoints(WinSmitTreeNode treeNode)
        {

            if (treeNode.GetNodeCount(true) == 0)
            {
                if (treeNode.sm_menu_opt.alias != "y")
                {
                    try
                    {
                        WinSmitTreeNode tnc = new WinSmitTreeNode();
                        SortedMenuList.Add(treeNode.sm_menu_opt.next_id, tnc);
                        listBox1.Items.Add(treeNode.sm_menu_opt.next_id);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }

                }
            }
            foreach (WinSmitTreeNode tn in treeNode.Nodes)
            {
                GetEndpoints(tn);
            }
        }

        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            winsmitTreeView.CollapseAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //find the root node
            List<sm_menu_opt> sublist = list_menu_opt.FindAll(
               delegate(sm_menu_opt sm)
               {
                   // must decide what base node?

                   //if ((sm.id == "__ROOT__") && (sm.id_seq_num == "0"))
                   if ((sm.id == "__ROOT__"))
                   {
                       return true;
                   }
                   else
                   {
                       return false;
                   }
               }
           );

            foreach (sm_menu_opt sm in sublist)
            {
                WinSmitTreeNode node = new WinSmitTreeNode();
                node.Text = sm.text;
                node.sm_menu_opt = sm;
                //set the icons
                setIcons(node);
                // add this to the treeview    
                winsmitTreeView.Nodes.Add(node);
                // go and look fir children
                findChildNodes(node);
            }


        }

        private void setIcons(WinSmitTreeNode node)
        {
            if (node.sm_menu_opt.next_type == sm_menu_opt_next_type.Dialog)
            {
                node.ImageIndex = 10;
                node.SelectedImageIndex = 10;
            }
            if (node.sm_menu_opt.next_type == sm_menu_opt_next_type.Info)
            {
                node.ImageIndex = 11;
                node.SelectedImageIndex = 11;
            }
            if (node.sm_menu_opt.next_type == sm_menu_opt_next_type.Menu)
            {
                node.ImageIndex = 12;
                node.SelectedImageIndex = 12;
            }
            if (node.sm_menu_opt.next_type == sm_menu_opt_next_type.Name)
            {
                node.ImageIndex = 13;
                node.SelectedImageIndex = 13;
            }
            if(node.sm_menu_opt_alias!=null)
            {
                node.ImageIndex = 14;
                node.SelectedImageIndex = 14;
            }

        }
        /// <summary>
        /// findChildNodes
        /// </summary>
        /// <param name="node"></param>
        private void findChildNodes(WinSmitTreeNode node)
        {
            // this just creates a sublist of nodes based on 
            // the serch criteria in the delegate.
            List<sm_menu_opt> sublist = list_menu_opt.FindAll(
                delegate(sm_menu_opt child)
                {
                    if ((child.id == node.sm_menu_opt.next_id) && (child.alias != "y"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            );
            // we have the sublist of children now let process them
            // the sublist contains all children of the "node"
            foreach (sm_menu_opt child in sublist)
            {
                //create new node
                WinSmitTreeNode n_node = new WinSmitTreeNode();
                // set text
                n_node.Text = child.text; 
                // assign the sm_menu_opt to the new node
                n_node.sm_menu_opt = child; 

                // here we should check if we have an alias for this new node
                List<sm_menu_opt> aliaslist = findAlias(child);
                if(aliaslist.Count>0)
                {
                    foreach(sm_menu_opt alias in aliaslist)
                    {
                        n_node.sm_menu_opt_alias = alias;
                        n_node.ImageIndex = 14;
                        n_node.SelectedImageIndex = 14;
                    }
                }

                //
                setIcons(n_node);
                //setIcons(node);
                // add the new node "n_node" to the parent node "node"
                node.Nodes.Add(n_node);
                foreach (WinSmitTreeNode wtn in sm_menu_opt_treeView.Nodes)
                {
                    if (wtn.Text == n_node.Text)
                    {
                        sm_menu_opt_treeView.Nodes.Remove(wtn);
                    }
                }
                // recurse the tree    
                findChildNodes(n_node);
            }
        }
        /// <summary>
        /// find an alias for a sm_menu_opt
        /// </summary>
        /// <param name="base_sm"></param>
        /// <returns></returns>
        private List<sm_menu_opt> findAlias(sm_menu_opt base_sm)
        {
            List<sm_menu_opt> sublist = list_menu_opt.FindAll(
                delegate(sm_menu_opt sm)
                {
                    if ((sm.next_id == base_sm.next_id) && (sm.alias == "y"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            );
            return sublist;
        }
               
        /// <summary>
        /// reset the selected back ground color of in the tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void winsmitTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                winsmitTreeView.SelectedNode.BackColor = Color.White;
            }
            catch (Exception ex)
            {
            }
        }

       


    }
}