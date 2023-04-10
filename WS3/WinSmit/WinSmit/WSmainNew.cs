using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;

namespace WinSmit
{
    public partial class WSmainNew : Form
    {
        private List<sm_menu_opt> list_menu_opt = new List<sm_menu_opt>();
        private List<sm_cmd_opt> list_cmd_opt = new List<sm_cmd_opt>();
        private List<sm_name_hdr> list_name_hdr = new List<sm_name_hdr>();
        private List<sm_cmd_hdr> list_cmd_hdr = new List<sm_cmd_hdr>();
        private List<sm_stanza> list_sm_stanzas = new List<sm_stanza>();



      
        private ArrayList Empty_MenuDialog = new ArrayList();
        private ArrayList Empty_MenuName = new ArrayList();
        private ArrayList Empty_Name_Hdr = new ArrayList();
        private ArrayList Empty_Cmd_Hdr = new ArrayList();
        private int counter = 0;
        
        Progress pg = new Progress();
        WinSmitSettings winsmitsettings = new WinSmitSettings();

        public WSmainNew()
        {
            InitializeComponent();
        }

               
        private void fillTree()
        {
            counter = 0;
           
            //find the root node
            List<sm_stanza> sublist = list_sm_stanzas.FindAll(
               delegate(sm_stanza sm)
               {
                   // must decide what base node?
                   //if ((sm.id == "__ROOT__") && (sm.id_seq_num == "0"))
                   string rootnode = winsmitsettings.root_node;

                   if ((sm.id == rootnode))
                   {
                       return true;
                   }
                   else
                   {
                       return false;
                   }
               }
           );

            if(sublist.Count==0)
            {
                string message = "The base node " + winsmitsettings.root_node + " was not found in this file." +
                    "\nPlease change the root node in Tools -> Options and try again.";

                MessageBox.Show(message, winsmitsettings.version, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //fillTreeProgressBar.Visible = false;
                return;
            }

            foreach (sm_stanza sm in sublist)
            {
                sm.set_isUsed(true);
                WinSmitTreeNode node = new WinSmitTreeNode(sm);

                //set the icons
                setIcons(node);
                // add this to the treeview    
                winsmitTreeView.Nodes.Add(node);
                counter++;
                //fillTreeProgressBar.Value = counter;
                // go and look for children
                

                findChildNodes(node);
            }
            try
            {
                LogBox.AppendText(counter + " sm_menu_opt have been added\n");
            }
            catch (Exception)
            {
                
               
            }
            //fillTreeProgressBar.Visible = false;
        }
        private void setIcons(WinSmitTreeNode node)
        {
            if (node.sm_menu_opt != null)
            {
                if (node.sm_menu_opt.next_type == sm_menu_opt_next_type.Dialog)
                {
                    node.ImageIndex = 7;
                    node.SelectedImageIndex = 7;
                }
                if (node.sm_menu_opt.next_type == sm_menu_opt_next_type.Info)
                {
                    node.ImageIndex = 4;
                    node.SelectedImageIndex = 4;
                }
                if (node.sm_menu_opt.next_type == sm_menu_opt_next_type.Menu)
                {
                    node.ImageIndex = 5;
                    node.SelectedImageIndex = 5;
                }
                if (node.sm_menu_opt.next_type == sm_menu_opt_next_type.Name)
                {
                    node.ImageIndex = 6;
                    node.SelectedImageIndex = 6;
                }
                if (node.sm_menu_opt_alias != null)
                {
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                }
            }
            if (node.sm_name_hdr != null)
            {
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
            }
            if (node.sm_cmd_hdr != null)
            {
                node.ImageIndex = 2;
                node.SelectedImageIndex = 2;
            }
            if ((node.sm_cmd_opt != null) && (node.sm_name_hdr == null))
            {
                node.ImageIndex = 3;
                node.SelectedImageIndex = 3;
            }

        }
        private void findChildNodes(WinSmitTreeNode node)
        {
           
            if (node.sm_menu_opt != null)
            {
                // this just creates a sublist of nodes based on 
                // the serch criteria in the delegate.
                List<sm_menu_opt> sublist = new List<sm_menu_opt>();
                sublist.Clear();
                sublist = list_menu_opt.FindAll(
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
                    child.set_isUsed(true);
                    WinSmitTreeNode n_node = new WinSmitTreeNode(child);
                    // set text
                    //n_node.Text = child.text;
                    // assign the sm_menu_opt to the new node
                    //n_node.sm_menu_opt = child;

                    // here we should check if we have an alias for this new node
                    List<sm_menu_opt> aliaslist = findAlias(child);
                    if (aliaslist.Count > 0)
                    {
                        foreach (sm_menu_opt alias in aliaslist)
                        {
                            alias.set_isUsed(true);
                            n_node.sm_menu_opt_alias = alias;
                            n_node.ImageIndex = 14;
                            n_node.SelectedImageIndex = 14;
                        }
                    }

                    //
                    setIcons(n_node);
                    //setIcons(node);
                    // add the new node "n_node" to the parent node "node"
                    counter++;
                   // fillTreeProgressBar.Value = counter;
                    node.Nodes.Add(n_node);
                    // recurse the tree    
                    findChildNodes(n_node);
                }
            }

        }
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

        
       

        private void populateMenuNodes()
        {
            
            Empty_MenuDialog.Clear();
            Empty_MenuName.Clear();
            Empty_Cmd_Hdr.Clear();
            Empty_Name_Hdr.Clear();
            CallPopulateEmptylists(winsmitTreeView);
            
            ///
            foreach (WinSmitTreeNode tn in Empty_MenuDialog)
            {
                findChildren(tn);
            }
            foreach (WinSmitTreeNode tn in Empty_MenuName)
            {
                findChildren(tn);
            }
            CallPopulateEmptylists(winsmitTreeView);
        }

        private void CallPopulateEmptylists(WinSmitTreeView winsmitTreeView)
        {
            TreeNodeCollection nodes = winsmitTreeView.Nodes;
            foreach (WinSmitTreeNode n in nodes)
            {
                PopulateEmptylists(n);
            }
        }
        private void findChildren(WinSmitTreeNode tn)
        {
            string nextid = "";
            Guid guid = System.Guid.NewGuid();

            List<sm_cmd_hdr> sbl_cmd_hdr = new List<sm_cmd_hdr>();
            List<sm_name_hdr> sbl_name_hdr = new List<sm_name_hdr>();
            List<sm_cmd_opt> sbl_cmd_opt = new List<sm_cmd_opt>();
            //*******************************************************
            // if we have a sm_menu_opt and the next type is Dialog
            // only look in sm_cmd_hdr
            

            if ((tn.sm_menu_opt != null) && (tn.sm_menu_opt.next_type==sm_menu_opt_next_type.Dialog))
            {
                nextid = tn.sm_menu_opt.next_id;

                // check if we have multiple next id's
                // they would be seperated by a comma
                // if index > 0 then we have multiple
                if(nextid.IndexOf(',')>0)
                {
                    string[] nextid_array = nextid.Split(',');
                }
                //
                sbl_cmd_hdr.Clear();
                sbl_cmd_hdr = list_cmd_hdr.FindAll(
                   delegate(sm_cmd_hdr child)
                   {
                       if ((child.id != null) && (child.id == nextid))
                       {
                           return true;
                       }
                       else
                       {
                           return false;
                       }
                   }
               );

                foreach(sm_cmd_hdr sm in sbl_cmd_hdr)
                {
                    //create new node
                    WinSmitTreeNode n_node = new WinSmitTreeNode(sm);
                    sm.set_isUsed(true);
                    setIcons(n_node);
                    tn.Nodes.Add(n_node);
                    findChildren(n_node);

                }
            }
            //*******************************************************
            // if we have a sm_menu_opt and the next type is Name
            // only look in sm_name_hdr
            if ((tn.sm_menu_opt != null) && (tn.sm_menu_opt.next_type == sm_menu_opt_next_type.Name))
            {
                nextid = tn.sm_menu_opt.next_id;

                // check if we have multiple next id's
                // they would be seperated by a comma
                // if index > 0 then we have multiple
                if (nextid.IndexOf(',') > 0)
                {
                    string[] nextid_array = nextid.Split(',');
                }
                //


                sbl_name_hdr.Clear();
                sbl_name_hdr = list_name_hdr.FindAll(
                   delegate(sm_name_hdr child)
                   {
                       if ((child.id != null) && (child.id == nextid))
                       {
                           return true;
                       }
                       else
                       {
                           return false;
                       }
                   }
               );
                foreach (sm_name_hdr sm in sbl_name_hdr)
                {
                    //create new node
                    WinSmitTreeNode n_node = new WinSmitTreeNode(sm);
                    sm.set_isUsed(true);
                    setIcons(n_node);
                    if (sm.GetType().Name == "sm_name_hdr")
                    {
                        List<sm_cmd_opt> opt_sublist = findOption((sm_name_hdr)sm);
                        // if we have some in the opt_sublist we need to add it to the 
                        //same node as the sm_name_hdr
                        foreach (sm_cmd_opt opt in opt_sublist)
                        {
                            n_node.sm_cmd_opt = opt;
                            //tn.Nodes.Add(opt_node);
                            setIcons(n_node);
                        }
                    }
                    tn.Nodes.Add(n_node);
                    findChildren(n_node);

                }
            }
            //*******************************************************
            // if we have a sm_cmd_hdr look only for sm_cmd_opt
            if (tn.sm_cmd_hdr != null)
            {
                nextid = tn.sm_cmd_hdr.option_id;

                // check if we have multiple next id's
                // they would be seperated by a comma
                // if index > 0 then we have multiple
                if (nextid.IndexOf(',') > 0)
                {
                    ArrayList al = new ArrayList();
                    string[] nextid_array = nextid.Split(',');
                    foreach (string nxxt in nextid_array)
                    {
                        al.Add(nxxt);
                    }
                    sbl_cmd_opt.Clear();
                    sbl_cmd_opt = list_cmd_opt.FindAll(
                       delegate(sm_cmd_opt child)
                       {
                           //if ((child.id != null) && (child.id == nextid))
                           if ((child.id != null) && (al.Contains(child.id)))
                           {
                               return true;
                           }
                           else
                           {
                               return false;
                           }
                       }
                   );

                }
                else
                {
                    sbl_cmd_opt.Clear();
                    sbl_cmd_opt = list_cmd_opt.FindAll(
                       delegate(sm_cmd_opt child)
                       {
                           if ((child.id != null) && (child.id == nextid))
                           {
                               return true;
                           }
                           else
                           {
                               return false;
                           }
                       }
                   );
                }
                foreach (sm_cmd_opt sm in sbl_cmd_opt)
                {
                    //create new node
                    WinSmitTreeNode n_node = new WinSmitTreeNode(sm);
                    sm.set_isUsed(true);
                    setIcons(n_node);
                    tn.Nodes.Add(n_node);
                    findChildren(n_node);

                }
            }
            //*******************************************************
            // if we have a sm_name_hdr  and next type = name
            // look in sm_name_hdr only
            if ((tn.sm_name_hdr != null)&&(tn.sm_name_hdr.next_type==sm_name_hdr_next_type.Name))
            {
                nextid = tn.sm_name_hdr.next_id;
                // check if we have multiple next id's
                // they would be seperated by a comma
                // if index > 0 then we have multiple
                if (nextid.IndexOf(',') > 0)
                {
                    string[] nextid_array = nextid.Split(',');
                }
                //

                sbl_name_hdr.Clear();
                sbl_name_hdr = list_name_hdr.FindAll(
                   delegate(sm_name_hdr child)
                   {
                       if ((child.id != null) && (child.id == nextid))
                       {
                           return true;
                       }
                       else
                       {
                           return false;
                       }
                   }
               );
                foreach (sm_name_hdr sm in sbl_name_hdr)
                {
                    //create new node
                    WinSmitTreeNode n_node = new WinSmitTreeNode(sm);
                    sm.set_isUsed(true);
                    setIcons(n_node);
                    if (sm.GetType().Name == "sm_name_hdr")
                    {
                        List<sm_cmd_opt> opt_sublist = findOption((sm_name_hdr)sm);
                        // if we have some in the opt_sublist we need to add it to the 
                        //same node as the sm_name_hdr
                        foreach (sm_cmd_opt opt in opt_sublist)
                        {
                            n_node.sm_cmd_opt = opt;
                            opt.set_isUsed(true);
                            //tn.Nodes.Add(opt_node);
                            setIcons(n_node);
                        }
                    }
                    tn.Nodes.Add(n_node);
                    findChildren(n_node);


                }
            }
            //*******************************************************
            // if we have a sm_name_hdr  and next type = Dialog
            // look in sm_cmd_hdr only
            if ((tn.sm_name_hdr != null) && (tn.sm_name_hdr.next_type == sm_name_hdr_next_type.Dialog))
            {
                nextid = tn.sm_name_hdr.next_id;
                // check if we have multiple next id's
                // they would be seperated by a comma
                // if index > 0 then we have multiple
                if (nextid.IndexOf(',') > 0)
                {
                    string[] nextid_array = nextid.Split(',');
                }
                //
                sbl_cmd_hdr.Clear();
                sbl_cmd_hdr = list_cmd_hdr.FindAll(
                   delegate(sm_cmd_hdr child)
                   {
                       if ((child.id != null) && (child.id == nextid))
                       {
                           return true;
                       }
                       else
                       {
                           return false;
                       }
                   }
               );
                

                foreach (sm_cmd_hdr sm in sbl_cmd_hdr)
                {
                    //create new node
                    WinSmitTreeNode n_node = new WinSmitTreeNode(sm);
                    sm.set_isUsed(true);
                    setIcons(n_node);
                    tn.Nodes.Add(n_node);
                    findChildren(n_node);

                }
            }
            
        }
        private void PopulateEmptylists(WinSmitTreeNode n)
        {
            if (n.GetNodeCount(true) == 0)
            {
                if ((n.sm_menu_opt != null) && (n.sm_menu_opt.next_type == sm_menu_opt_next_type.Dialog))
                {
                    Empty_MenuDialog.Add(n);
                }
                if ((n.sm_menu_opt != null) && (n.sm_menu_opt.next_type == sm_menu_opt_next_type.Name))
                {
                    Empty_MenuName.Add(n);
                }
                if (n.sm_name_hdr != null)
                {
                    Empty_Name_Hdr.Add(n);
                }
                if ((n.sm_cmd_hdr != null) && (n.sm_cmd_hdr.ghost != true) && (n.sm_cmd_hdr.next_id != null))
                {
                    Empty_Cmd_Hdr.Add(n);
                }

            }
            foreach (WinSmitTreeNode tn in n.Nodes)
            {
                PopulateEmptylists(tn);
            }
        }
        private List<sm_cmd_opt> findOption(sm_name_hdr namehdr)
        {
            List<sm_cmd_opt> sublist = list_cmd_opt.FindAll(
                delegate(sm_cmd_opt sm)
                {
                    if ((sm.id == namehdr.option_id))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            );
            foreach(sm_cmd_opt opt in sublist)
            {
                opt.set_isUsed(true);
            }

            return sublist;
        }
        private void sortTree()
        {
            winsmitTreeView.TreeViewNodeSorter = new NodeSorter();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            winsmitTreeView.BeginUpdate();
            winsmitTreeView.ExpandAll();
            winsmitTreeView.EndUpdate();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            winsmitTreeView.BeginUpdate();
            winsmitTreeView.CollapseAll();
            winsmitTreeView.EndUpdate();
        }
        //
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
                // get the objects from the tree node
                // it can be that we have different stanzas in the node so 
                string tx_id_seq_num = "";
                string ty_id_seq_num = "";
                //
                if (tx.sm_menu_opt != null)
                {
                    tx_id_seq_num = tx.sm_menu_opt.id_seq_num;
                }
                else if (tx.sm_name_hdr != null)
                {
                    tx_id_seq_num = tx.sm_name_hdr.id_seq_num;
                }
                else if (tx.sm_cmd_hdr != null)
                {
                    tx_id_seq_num = tx.sm_cmd_hdr.id_seq_num;
                }
                else if (tx.sm_cmd_opt != null)
                {
                    tx_id_seq_num = tx.sm_cmd_opt.id_seq_num;
                }
                //
                if (ty.sm_menu_opt != null)
                {
                    ty_id_seq_num = ty.sm_menu_opt.id_seq_num;
                }
                else if (ty.sm_name_hdr != null)
                {
                    ty_id_seq_num = ty.sm_name_hdr.id_seq_num;
                }
                else if (ty.sm_cmd_hdr != null)
                {
                    ty_id_seq_num = ty.sm_cmd_hdr.id_seq_num;
                }
                else if (ty.sm_cmd_opt != null)
                {
                    ty_id_seq_num = ty.sm_cmd_opt.id_seq_num;
                }
                //
                if ((IsInteger(tx_id_seq_num)) && (IsInteger(ty_id_seq_num)))
                {
                    one = Int32.Parse(tx_id_seq_num);
                    two = Int32.Parse(ty_id_seq_num);
                    return one - two;
                }
                if (tx_id_seq_num != ty_id_seq_num)
                {
                    return tx_id_seq_num.Length - ty_id_seq_num.Length;
                }
                // If they are the same length, call Compare.
                //return string.Compare(ty.Text, tx.Text);
                return string.Compare(ty_id_seq_num, tx_id_seq_num, StringComparison.Ordinal);
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

        private void winsmitTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            WinSmitTreeNode tn = (WinSmitTreeNode)winsmitTreeView.SelectedNode;
            tn.BackColor = Color.Aquamarine;
            kryptonPage3.Show();

            if (tn.sm_cmd_hdr != null)
            {
                propertyGrid1.SelectedObject = tn.sm_cmd_hdr;
                kryptonPage3.Text = tn.sm_cmd_hdr.name;
                kryptonPage3.ImageSmall = global::WinSmit.Resource1.cmd_hdr;
                kryptonPage4.Hide();
                // hide what we dont need
                hideAll();
                // show
                cmd_to_discoverPage.Show();
                cmd_to_execPage.Show();
                CommentPage.Show();
                

                // databinding
                comment_TB.DataBindings.Clear();
                comment_TB.DataBindings.Add("Text", tn.sm_cmd_hdr,"comment");
                CommentPage.ImageSmall = global::WinSmit.Resource1.cmd_hdr;
                //
                cmd_to_discoverTB.DataBindings.Clear();
                cmd_to_discoverTB.DataBindings.Add("Text", tn.sm_cmd_hdr, "cmd_to_discover");
                cmd_to_discoverPage.ImageSmall = global::WinSmit.Resource1.cmd_hdr;
                //
                                //
                cmd_to_exec_TB.DataBindings.Clear();
                cmd_to_exec_TB.DataBindings.Add("Text", tn.sm_cmd_hdr, "cmd_to_exec");
                cmd_to_execPage.ImageSmall = global::WinSmit.Resource1.cmd_hdr;
                
            }
            if ((tn.sm_menu_opt != null)&&(tn.sm_menu_opt_alias==null))
            {
                propertyGrid1.SelectedObject = tn.sm_menu_opt;
                kryptonPage3.Text = tn.sm_menu_opt.text;
               
                if(tn.sm_menu_opt.next_type==sm_menu_opt_next_type.Dialog)
                {
                    kryptonPage3.ImageSmall = global::WinSmit.Resource1.menu_dialog;
                    CommentPage.ImageSmall = global::WinSmit.Resource1.menu_dialog;
                }
                if (tn.sm_menu_opt.next_type == sm_menu_opt_next_type.Name)
                {
                    kryptonPage3.ImageSmall = global::WinSmit.Resource1.menu_name;
                    CommentPage.ImageSmall = global::WinSmit.Resource1.menu_name;
                }
                if (tn.sm_menu_opt.next_type == sm_menu_opt_next_type.Menu)
                {
                    kryptonPage3.ImageSmall = global::WinSmit.Resource1.menu_menu;
                    CommentPage.ImageSmall = global::WinSmit.Resource1.menu_menu;
                }
                kryptonPage4.Hide();
                hideAll();
                CommentPage.Show();
                // databinding
                comment_TB.DataBindings.Clear();
                comment_TB.DataBindings.Add("Text", tn.sm_menu_opt, "comment");
                
                

            }
            if ((tn.sm_menu_opt != null) && (tn.sm_menu_opt_alias != null))
            {
                propertyGrid1.SelectedObject = tn.sm_menu_opt;
                propertyGrid2.SelectedObject = tn.sm_menu_opt_alias;
                kryptonPage3.Text = tn.sm_menu_opt.text;
                if (tn.sm_menu_opt.next_type == sm_menu_opt_next_type.Dialog)
                {
                    kryptonPage3.ImageSmall = global::WinSmit.Resource1.menu_dialog;
                    CommentPage.ImageSmall = global::WinSmit.Resource1.menu_dialog;
                }
                if (tn.sm_menu_opt.next_type == sm_menu_opt_next_type.Name)
                {
                    kryptonPage3.ImageSmall = global::WinSmit.Resource1.menu_name;
                    CommentPage.ImageSmall = global::WinSmit.Resource1.menu_name;
                    
                }
                if (tn.sm_menu_opt.next_type == sm_menu_opt_next_type.Menu)
                {
                    kryptonPage3.ImageSmall = global::WinSmit.Resource1.menu_menu;
                    CommentPage.ImageSmall = global::WinSmit.Resource1.menu_menu;
                }
                kryptonPage4.Text = "Alias "+ tn.sm_menu_opt_alias.text;
                kryptonPage4.ImageSmall = global::WinSmit.Resource1.alias;
                kryptonPage4.Show();
                hideAll();
                CommentPage.Show();
                commentPage2.Show();
                commentPage2.ImageSmall = global::WinSmit.Resource1.alias;
                // databinding
                comment_TB.DataBindings.Clear();
                comment_TB.DataBindings.Add("Text", tn.sm_menu_opt, "comment");

                comment2_TB.DataBindings.Clear();
                comment2_TB.DataBindings.Add("Text", tn.sm_menu_opt_alias, "comment");

                
            }
            if ((tn.sm_name_hdr != null)&&(tn.sm_cmd_opt!=null))
            {
                propertyGrid1.SelectedObject = tn.sm_name_hdr;
                kryptonPage3.Text = tn.sm_name_hdr.name;
                kryptonPage3.ImageSmall = global::WinSmit.Resource1.name_hdr;

                propertyGrid2.SelectedObject = tn.sm_cmd_opt;
                kryptonPage4.ImageSmall = global::WinSmit.Resource1.cmd_opt;
                kryptonPage4.Show();
                kryptonPage4.Text = tn.sm_cmd_opt.name;

                // hide what we dont need
                hideAll();
                // show
                cmd_to_classifyPage.ImageSmall = global::WinSmit.Resource1.name_hdr;
                cmd_to_listPage.ImageSmall = global::WinSmit.Resource1.cmd_opt;
                CommentPage.ImageSmall = global::WinSmit.Resource1.name_hdr;
                commentPage2.ImageSmall = global::WinSmit.Resource1.cmd_opt;
                
                cmd_to_classifyPage.Show();
                cmd_to_listPage.Show();
                CommentPage.Show();
                commentPage2.Show();
                // databinding
                comment_TB.DataBindings.Clear();
                comment_TB.DataBindings.Add("Text", tn.sm_name_hdr, "comment");

                comment2_TB.DataBindings.Clear();
                comment2_TB.DataBindings.Add("Text", tn.sm_cmd_opt, "comment");
                
                cmd_to_classify_TB.DataBindings.Clear();
                cmd_to_classify_TB.DataBindings.Add("Text", tn.sm_name_hdr, "cmd_to_classify");

                cmd_to_listTB.DataBindings.Clear();
                cmd_to_listTB.DataBindings.Add("text", tn.sm_cmd_opt, "cmd_to_list");
               

                
            }
            if ((tn.sm_cmd_opt != null)&&(tn.sm_name_hdr==null))
            {
                propertyGrid1.SelectedObject = tn.sm_cmd_opt;
                kryptonPage3.ImageSmall = global::WinSmit.Resource1.cmd_opt;
                kryptonPage4.Hide();
                // hide what we dont need
                hideAll();
                // show
                cmd_to_listPage.Show();
                CommentPage.Show();
                
                cmd_to_listPage.ImageSmall = global::WinSmit.Resource1.cmd_opt;
                CommentPage.ImageSmall = global::WinSmit.Resource1.cmd_opt;
                // databinding
                cmd_to_listTB.DataBindings.Clear();
                cmd_to_listTB.DataBindings.Add("Text", tn.sm_cmd_opt, "cmd_to_list");
                
                comment_TB.DataBindings.Clear();
                comment_TB.DataBindings.Add("Text", tn.sm_cmd_opt, "comment");
                
            }
        }

        private void winsmitTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                winsmitTreeView.SelectedNode.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
        public void hideAll()
        {
            CommentPage.Hide();
            commentPage2.Hide();
            cmd_to_execPage.Hide();
            cmd_to_classifyPage.Hide();
            cmd_to_listPage.Hide();
            cmd_to_discoverPage.Hide();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open
            start();
        }

        private void start()
        {
            winsmitTreeView.Nodes.Clear();
            list_cmd_hdr.Clear();
            list_cmd_opt.Clear();
            list_menu_opt.Clear();
            list_name_hdr.Clear();
            list_sm_stanzas.Clear();
            //
            openFileDialog1.Filter = "WinSmit File (*.dump)|*.dump";
            if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                kryptonPage2.Show();
                kryptonPage2.Text = openFileDialog1.FileName;
                //read file
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string s = sr.ReadToEnd();
                sr.Close();
                Progress pg = new Progress(s);
                pg.ShowDialog();

                list_cmd_hdr = pg.List_cmd_hdr;
                list_cmd_opt = pg.List_cmd_opt;
                list_menu_opt = pg.List_menu_opt;
                list_name_hdr = pg.List_name_hdr;
                list_sm_stanzas = pg.List_sm_stanzas;
                fillTree();
                populateMenuNodes();
            }

            
        }

        private void kryptonRibbonGroupButton3_Click(object sender, EventArgs e)
        {
            start();
        }

        private void kryptonRibbonGroupButton5_Click(object sender, EventArgs e)
        {

        }

        private void kryptonRibbonGroupButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void kryptonRibbonGroupButton1_Click(object sender, EventArgs e)
        {
            CurrentProject cp = new CurrentProject();
            ProjectWiz pjw = new ProjectWiz(cp);
            pjw.ShowDialog();
            // set the name for the project on the tab
            kryptonPage1.Text = cp.Name;
            projectTreeView.Nodes.Add(cp.Name + " Project");
            // create scripts
            CreateScripts.createRunScript(cp);


        }

        private void kryptonRibbonGroup5_DialogBoxLauncherClick(object sender, EventArgs e)
        {

        }

        private void kryptonRibbonGroupButton9_Click(object sender, EventArgs e)
        {

        }

        private void kryptonRibbonGroupButton10_Click(object sender, EventArgs e)
        {

        }

        private void kryptonRibbonGroupButton8_Click(object sender, EventArgs e)
        {
           
            start();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       
        
      
        
        
        
       
    }
}