using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;
using System.IO;

namespace WinSmit
{
    public partial class Progress : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public Progress()
        {
            InitializeComponent();
        }
        
        public Progress(string data)
        {
            
            this.filedata = data;
            InitializeComponent();
            string[] preparse = Regex.Split(data, "\n");
            progressBar5.Maximum = preparse.Length;
            
            
        }
        private List<sm_menu_opt> list_menu_opt = new List<sm_menu_opt>();
        private List<sm_cmd_opt> list_cmd_opt = new List<sm_cmd_opt>();
        private List<sm_name_hdr> list_name_hdr = new List<sm_name_hdr>();
        private List<sm_cmd_hdr> list_cmd_hdr = new List<sm_cmd_hdr>();
        private List<sm_stanza> list_sm_stanzas = new List<sm_stanza>();

        private string _filedata;
        public string  filedata
        {
            get
            {
                return this._filedata;
            }
            set
            {
                this._filedata = value;
            }
        }

        public ProgressBar progressbar1
        {
            get
            {
                return this.progressBar1;
            }
        }
        public ProgressBar progressbar2
        {
            get
            {
                return this.progressBar2;
            }
        }
        public ProgressBar progressbar3
        {
            get
            {
                return this.progressBar3;
            }
        }
        public ProgressBar progressbar4
        {
            get
            {
                return this.progressBar4;
            }
        }
        //
        public Label Label1
        {
            get
            {
                return this.label1;
            }
        }
        public Label Label2
        {
            get
            {
                return this.label2;
            }
        }
        public Label Label3
        {
            get
            {
                return this.label3;
            }
        }
        public Label Label4
        {
            get
            {
                return this.label4;
            }
        }

        public List<sm_menu_opt> List_menu_opt
        {
            get { return list_menu_opt; }
            set { list_menu_opt = value; }
        }
        public List<sm_cmd_opt> List_cmd_opt
        {
            get { return list_cmd_opt; }
            set { list_cmd_opt = value; }
        }
        public List<sm_name_hdr> List_name_hdr
        {
            get { return list_name_hdr; }
            set { list_name_hdr = value; }
        }
        public List<sm_cmd_hdr> List_cmd_hdr
        {
            get { return list_cmd_hdr; }
            set { list_cmd_hdr = value; }
        }
        public List<sm_stanza> List_sm_stanzas
        {
            get { return list_sm_stanzas; }
            set { list_sm_stanzas = value; }
        }


        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preparseWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string  data = (string)e.Argument;
            string[] preparse = Regex.Split(data, "\n");
            //progressBar5.Maximum = preparse.Length;
            // create a temp file
            // error handling is still missing
            TextWriter tw = new StreamWriter(Application.StartupPath + "/" + "~tmp.dump");
            
            // clear the comment array
            ArrayList commentarray = new ArrayList();
            // now find either sm_menu_opt or any of the other stanza lines
            int i = 0;
            foreach (string line in preparse)
            {
                i++;
                this.preparseWorker.ReportProgress(i);
                //System.Threading.Thread.Sleep(0);
                // save everything that starts with #
                // into the comment array
                //if ((line.StartsWith("#")) || (line.StartsWith("*")))
                if (line.StartsWith("*"))
                {
                    commentarray.Add(line);
                }
                // but if we find the stanze
                else if (line.StartsWith("sm_menu_opt") || line.StartsWith("sm_cmd_opt") || line.StartsWith("sm_name_hdr") || line.StartsWith("sm_cmd_hdr"))
                {
                    string completeComment = "";
                    //add the comment stuff after 
                    foreach (string comment in commentarray)
                    {
                        completeComment = completeComment + comment;
                    }
                    // then write it out to the file
                    // the comment is now within the stanza and 
                    // so will be picked up at parsing time (sm processing
                    tw.Write(line + " comment =" + completeComment);
                    // clear the comment array again
                    commentarray.Clear();
                }
                else // if we dont have a sm stanza just write as usual
                {
                    tw.Write(line);
                }
                System.Threading.Thread.Sleep(0);
            }
            // close the temp file
            tw.Close();
                

        }

        private void preparseWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar5.Value = e.ProgressPercentage;
        }

        private void preparseWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // now read the new temp file with the comment
            //in the right place
            StreamReader sr = new StreamReader(Application.StartupPath + "/" + "~tmp.dump");
            string s = sr.ReadToEnd();
            sr.Close();
            // because we dont want crap lying around
            // delete the temp file
            if (File.Exists(Application.StartupPath + "/" + "~tmp.dump"))
            {
                File.Delete(Application.StartupPath + "/" + "tmp.dump");
            }
            // start processing the s string
            s = s.Replace("sm_menu_opt", "¥¥sm_menu_opt");
            s = s.Replace("sm_cmd_opt", "¥¥sm_cmd_opt");
            s = s.Replace("sm_name_hdr", "¥¥sm_name_hdr");
            s = s.Replace("sm_cmd_hdr", "¥¥sm_cmd_hdr");
            string[] ss = Regex.Split(s, "¥¥");
            // now create four list arrays to store the different
            // stanza types then these can be passed to four 
            // background workers.

            ArrayList sm_menu_opt_array = new ArrayList();
            ArrayList sm_cmd_opt_array = new ArrayList();
            ArrayList sm_name_hdr_array = new ArrayList();
            ArrayList sm_cmd_hdr_array = new ArrayList();



            // change color of the progress bars
            this.progressbar1.ForeColor = Color.Blue;
            this.progressbar2.ForeColor = Color.Blue;
            this.progressbar3.ForeColor = Color.Blue;
            this.progressbar4.ForeColor = Color.Blue;

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
            this.progressbar1.Maximum = sm_menu_opt_array.Count;
            this.progressbar2.Maximum = sm_cmd_opt_array.Count;
            this.progressbar3.Maximum = sm_name_hdr_array.Count;
            this.progressbar4.Maximum = sm_cmd_hdr_array.Count;
            // now start the background workers for each arraylisten
            this.menu_opt_BG.RunWorkerAsync(sm_menu_opt_array);
            this.cmd_hdr_BG.RunWorkerAsync(sm_cmd_hdr_array);
            this.name_hdr_BG.RunWorkerAsync(sm_name_hdr_array);
            this.cmd_opt_BG.RunWorkerAsync(sm_cmd_opt_array);



        }

        private void Progress_Load(object sender, EventArgs e)
        {
            this.preparseWorker.RunWorkerAsync(filedata);
           
        }

        private void Progress_ResizeEnd(object sender, EventArgs e)
        {
            
            
        }

        
        

    }
}