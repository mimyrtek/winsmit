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


namespace WinSmit
{
    //public partial class WSmainNew : ComponentFactory.Krypton.Toolkit.KryptonForm
    public partial class Progress : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
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

        private static sm_menu_opt process_sm_menu_opt(string s, string menuType)
        {
            

            sm_menu_opt sm = new sm_menu_opt();

            string[] ss = Regex.Split(s, "¥¥");

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
                            sm.set_help_msg_id(right);
                            break;
                        case "help_msg_loc":
                            sm.set_help_msg_loc(right);
                            break;
                        case "help_msg_base":
                            sm.set_help_msg_base(right);
                            break;
                        case "help_msg_book":
                            sm.set_help_msg_book(right);
                            break;
                        case "comment":
                            sm.comment = right;
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

            string[] ss = Regex.Split(s, "¥¥");

            foreach (string str in ss)
            {
                string tmp_str = str.Trim();
                
                
                //string tmp_str = str.TrimStart('\t');
                //tmp_str = str.TrimEnd('\n');
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
                            if(right=="f")
                            {
                              sm.entry_type= sm_cmd_opt_entry_type.File;
                            }
                            if(right=="x")
                            {
                              sm.entry_type= sm_cmd_opt_entry_type.Hex;
                            }
                            if (right == "n")
                            {
                                sm.entry_type = sm_cmd_opt_entry_type.No_Entry;
                            }
                            if (right == "#")
                            {
                                sm.entry_type = sm_cmd_opt_entry_type.Numeric;
                            }
                            if (right == "r")
                            {
                                sm.entry_type = sm_cmd_opt_entry_type.Raw_Text;
                            }
                            if (right == "t")
                            {
                                sm.entry_type = sm_cmd_opt_entry_type.Text;
                            }
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
                            sm.set_help_msg_id(right);
                            break;
                        case "help_msg_loc":
                            sm.set_help_msg_loc(right);
                            break;
                        case "help_msg_base":
                            sm.set_help_msg_base(right);
                            break;
                        case "help_msg_book":
                            sm.set_help_msg_book(right);
                            break;
                        case "comment":
                            sm.comment = right;
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

            string[] ss = Regex.Split(s, "¥¥");

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
                            if (right == "y")
                            {
                                sm.has_name_select = true;
                            }
                            else
                            {
                                sm.has_name_select = false;
                            }
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
                            if (right == "c")
                            {
                                sm.type = sm_name_hdr_type.Cat_cooked_name; ;
                            }
                            if (right == "r")
                            {
                                sm.type = sm_name_hdr_type.Cat_raw_name;
                            }
                            if (right == "j")
                            {
                                sm.type = sm_name_hdr_type.Just_next_ID;
                            }
                            if (right == " ")
                            {
                                sm.type = sm_name_hdr_type.Just_next_ID;
                            }
                            if (right == "")
                            {
                                sm.type = sm_name_hdr_type.Just_next_ID;
                            }
                            break;
                        case "ghost":
                            if (right == "y")
                            {
                                sm.ghost = true;
                            }
                            else
                            {
                                sm.ghost = false;
                            }
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
                            if ((right != "d") && (right != "n"))
                            {
                                Console.WriteLine();

                            }
                            if (right == "d")
                            {
                                sm.next_type = sm_name_hdr_next_type.Dialog;
                            }
                            if (right == "n")
                            {
                                sm.next_type = sm_name_hdr_next_type.Name;
                            }
                            break;
                        case "help_msg_id":
                            sm.set_help_msg_id(right);
                            break;
                        case "help_msg_loc":
                            sm.set_help_msg_loc(right);
                            break;
                        case "help_msg_base":
                            sm.set_help_msg_base(right);
                            break;
                        case "help_msg_book":
                            sm.set_help_msg_book(right);
                            break;
                        case "comment":
                            sm.comment = right;
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

            string[] ss = Regex.Split(s, "¥¥");

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
                            if (right == "y")
                            {
                                sm.has_name_select = true;
                            }
                            else
                            {
                                sm.has_name_select = false;
                            }

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
                            if (right == "y")
                            {
                                sm.ask = true;
                            }
                            else
                            {
                                sm.ask = true;
                            }

                            break;
                        case "exec_mode":
                            sm.exec_mode = right;
                            break;
                        case "ghost":
                            if (right == "y")
                            {
                                sm.ghost = true;
                            }
                            else
                            {
                                sm.ghost = false;
                            }

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
                            sm.set_help_msg_id(right);
                            break;
                        case "help_msg_loc":
                            sm.set_help_msg_loc(right);
                            break;
                        case "help_msg_base":
                            sm.set_help_msg_base(right);
                            break;
                        case "help_msg_book":
                            sm.set_help_msg_book(right);
                            break;
                        case "comment":
                            sm.comment=right;
                            break;
                        default:
                            break;
                    }
                }
            }
            return sm;
        }
        //
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
                //prefix all know tokens with ¥¥ in a for loop
                foreach (string tks in tokens)
                {

                    string input = "(\\b" + tks + "\\b)(\\s*=)";
                    s = Regex.Replace(s, input, "¥¥" + tks + "=");

                }

                s = s.Replace("sm_menu_opt:", "");
                sm = process_sm_menu_opt(s, "sm_menu_opt");
                // new code
                if ((sm.id != "") && (sm.id != sm.next_id))
                {
                    list_sm_stanzas.Add(sm);
                    list_menu_opt.Add(sm);
                }
                else
                {
                    Console.WriteLine("Not added :" + sm.toString());
                }
                //
                node = new WinSmitTreeNode(sm);
                this.menu_opt_BG.ReportProgress(i, node);
                System.Threading.Thread.Sleep(1);
            }

        }
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
                //if (cmd_opt_BG.CancellationPending)
                //{
                //    e.Cancel = true;
                //    return;
                //}
                s = strItem;
                ArrayList replacements = fixCodingBrackets(ref s);

                //prefix all know tokens with ¥¥ in a for loop
                foreach (string tks in tokens)
                {
                    string input = "(\\b" + tks + "\\b)(\\s*=)";
                    s = Regex.Replace(s, input, "¥¥" + tks + "=");

                }
                // rereplace
                // now replace all brackets
                foreach (string rep in replacements)
                {
                    s = s.Replace("¶¶¶¶¶¶¶¶¶", rep);

                }
                // empty the arraylist
                replacements.Clear();


                s = s.Replace("sm_cmd_opt:", "");
                sm = process_sm_cmd_opt(s, "sm_cmd_opt");

                if ((sm.id != "") && (sm.id != sm.option_id))
                {
                    list_cmd_opt.Add(sm);
                    list_sm_stanzas.Add(sm);
                }
                else
                {
                    Console.WriteLine("Not added :" + sm.toString());
                }
                this.cmd_opt_BG.ReportProgress(i);
                System.Threading.Thread.Sleep(0);
            }

        }
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


                s = strItem;
                ArrayList replacements = fixCodingBrackets(ref s);

                //prefix all know tokens with ¥¥ in a for loop
                foreach (string tks in tokens)
                {

                    string input = "(\\b" + tks + "\\b)(\\s*=)";
                    s = Regex.Replace(s, input, "¥¥" + tks + "=");

                }
                // rereplace
                // now replace all brackets
                foreach (string rep in replacements)
                {
                    s = s.Replace("¶¶¶¶¶¶¶¶¶", rep);

                }
                // empty the arraylist
                replacements.Clear();

                s = s.Replace("sm_name_hdr:", "");
                sm = process_sm_name_hdr(s, "sm_name_hdr");
                if ((sm.id != "") && (sm.id != sm.next_id) && (sm.type == sm_name_hdr_type.Just_next_ID))
                {
                    list_sm_stanzas.Add(sm);
                    list_name_hdr.Add(sm);
                }
                else
                {
                    Console.WriteLine("Not added :" + sm.toString());
                }

                this.name_hdr_BG.ReportProgress(i, node);
                System.Threading.Thread.Sleep(10);
            }



        }
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
                s = strItem;

                ArrayList replacements = fixCodingBrackets(ref s);

                //prefix all know tokens with ¥¥ in a for loop
                foreach (string tks in tokens)
                {

                    string input = "(\\b" + tks + "\\b)(\\s*=)";
                    s = Regex.Replace(s, input, "¥¥" + tks + "=");

                }
                // rereplace
                // now replace all brackets
                foreach (string rep in replacements)
                {
                    s = s.Replace("¶¶¶¶¶¶¶¶¶", rep);

                }
                // empty the arraylist
                replacements.Clear();


                s = s.Replace("sm_cmd_hdr:", "");
                sm = process_sm_cmd_hdr(s, "sm_cmd_hdr");
                if ((sm.id != "") && (sm.id != sm.next_id))
                {
                    list_sm_stanzas.Add(sm);
                    list_cmd_hdr.Add(sm);
                }
                else
                {
                    Console.WriteLine("Not added :" + sm.toString());
                }


                this.cmd_hdr_BG.ReportProgress(i, node);
                System.Threading.Thread.Sleep(10);
            }
        }

        private static ArrayList fixCodingBrackets(ref string s)
        {
            //********************************************************************
            // all text between curly brackets must be taken out and replaced with 
            // a placeholder
            // lets find all open curly brackets
            int start = 0;
            int startposition = 0;
            int endposition = 0;
            ArrayList replacements = new ArrayList();
            char[] c = s.ToCharArray();

            for (int ii = 0; ii < c.Length; ii++)
            {
                //find start of brackets
                if (c[ii] == '{')
                {
                    start++; //increment the counter
                    if (start == 1)
                    {
                        startposition = ii;// remember the startpoint
                    }
                }
                if ((c[ii] == '}') && (start > 0))
                {
                    start--;
                    if (start == 0)
                    {
                        endposition = ii;
                        //we have the last } so get the substring
                        replacements.Add(s.Substring(startposition, ii - startposition + 1));
                    }
                }
            }
            // now replace all brackets
            foreach (string rep in replacements)
            {
                s = s.Replace(rep, "¶¶¶¶¶¶¶¶¶");

            }
            //********************************************
            return replacements;
        }
        //
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
                //sm_menu_opt_treeView.Nodes.Add(node);
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
                //sm_menu_opt_treeView.Nodes.Add(node);
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
                //sm_menu_opt_treeView.Nodes.Add(node);
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
                //sm_menu_opt_treeView.Nodes.Add(node);
            }
            this.progressbar1.Value = e.ProgressPercentage;
        }
        private void cmd_opt_BG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //TreeNode node = (TreeNode)e.UserState;
            //sm_treeView.Nodes.Add(node);
            this.progressbar2.Value = e.ProgressPercentage;
        }
        private void name_hdr_BG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //WinSmitTreeNode node = (WinSmitTreeNode)e.UserState;
            //sm_treeView.Nodes.Add(node);
            this.progressbar3.Value = e.ProgressPercentage;

        }
        private void cmd_hdr_BG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //WinSmitTreeNode node = (WinSmitTreeNode)e.UserState;
            //sm_treeView.Nodes.Add(node);
            this.progressbar4.Value = e.ProgressPercentage;
        }
        //
        private void menu_opt_BG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Label1.Text += " Finished";
            if ((this.Label1.Text.EndsWith("Finished"))
                && (this.Label2.Text.EndsWith("Finished"))
                && (this.Label3.Text.EndsWith("Finished"))
                && (this.Label4.Text.EndsWith("Finished"))
                )
            {
                // fillTree();
            }



        }
        private void cmd_opt_BG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Label2.Text += " Finished";
            if ((this.Label1.Text.EndsWith("Finished"))
                && (this.Label2.Text.EndsWith("Finished"))
                && (this.Label3.Text.EndsWith("Finished"))
                && (this.Label4.Text.EndsWith("Finished"))
                )
            {
                // fillTree();
            }

        }
        private void name_hdr_BG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Label3.Text += " Finished";
            if ((this.Label1.Text.EndsWith("Finished"))
                && (this.Label2.Text.EndsWith("Finished"))
                && (this.Label3.Text.EndsWith("Finished"))
                && (this.Label4.Text.EndsWith("Finished"))
                )
            {
                //  fillTree();
            }

        }
        private void cmd_hdr_BG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Label4.Text += " Finished";
            if ((this.Label1.Text.EndsWith("Finished"))
                && (this.Label2.Text.EndsWith("Finished"))
                && (this.Label3.Text.EndsWith("Finished"))
                && (this.Label4.Text.EndsWith("Finished"))
                )
            {
                // fillTree();
            }

        }

      
    }
}
