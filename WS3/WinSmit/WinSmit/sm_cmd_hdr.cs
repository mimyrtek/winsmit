using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Globalization;


namespace WinSmit
{
   public class sm_cmd_hdr:sm_stanza
    {
        
        //Descriptions


const string s_has_name_select ="Specifies whether this screen must be preceded by a selector screen or a menu screen. Valid values are: \"\" or \"n\" No; this is the default case. \n"+
"\"y\" Yes; a selector precedes this object. This setting prevents the id of this object from being used as a fast path to the corresponding dialog screen. ";
 
const string s_name ="The text displayed as the title of the dialog screen. The value of name is a string with a maximum length of 1024 characters. The text describes the task performed by the dialog. The string can be formatted with embedded \n (newline) characters. ";
const string s_name_msg_file = "The file name (not the full path name) that is the Message Facility catalog for the string, name. The value of name_msg_file is a string with a maximum length of 1024 characters. Message catalogs required by an application program can be developed with the Message Facility. ";
const string s_name_msg_set ="The Message Facility set ID for the string, name. Set IDs can be used to indicate subsets of a single catalog. The value of name_msg_set is an integer. ";
const string s_name_msg_id ="The Message Facility ID for the string, name. Message IDs can be created by the message extractor tools owned by the Message Facility. The value of name_msg_id is an integer. ";
const string s_cmd_to_exec ="The initial part of the command string, which can be the command or the command and any fixed options that execute the task of the dialog. Other options are automatically appended through user interaction with the command option objects (sm_cmd_opt) associated with the dialog screen. The value of cmd_to_exec is a string with a maximum length of 1024 characters. ";
const string s_ask ="Defines whether or not the user is prompted to reconsider the choice to execute the task. Valid values are: \"\" or \"n\" No; the user is not prompted for confirmation; the task is performed when the dialog is committed. This is the default setting for the ask descriptor. \n" +
"\"y\" Yes; the user is prompted to confirm that the task be performed; the task is performed only after user confirmation. \n"+
"Prompting the user for execution confirmation is especially useful prior to performance of deletion tasks, where the deleted resource is either difficult or impossible to recover, or when there is no displayable dialog associated with the task (when the ghost field is set to \"y\").";
 
 
const string s_exec_mode ="Defines the handling of standard input, standard output, and the stderr file during task execution. The value of exec_mode is a string. Valid values are: \"\" or \"p\" Pipe mode; the default setting for the exec_mode descriptor. The command executes with standard output and the stderr file redirected through pipes to SMIT. SMIT manages output from the command. The output is saved and is scrollable by the user after the task finishes running. While the task runs, output is scrolled as needed. \n" +
"\"n\" No scroll pipe mode; works like the \"p\" mode, except that the output is not scrolled while the task runs. The first screen of output will be shown as it is generated and then remains there while the task runs. The output is saved and is scrollable by the user after the task finishes running. \n"+
"\"i\" Inherit mode; the command executes with standard input, standard output, and the stderr file inherited by the child process in which the task runs. This mode gives input and output control to the executed command. This value is intended for commands that need to write to the /dev/tty file, perform cursor addressing, or use libcur or libcurses library operations. \n"+
"\"e\" Exit/exec mode; causes SMIT to run (do an execl subroutine call on) the specified command string in the current process, which effectively terminates SMIT. This is intended for running commands that are incompatible with SMIT (which change display modes or font sizes, for instance). A warning is given that SMIT will exit before running the command. \n"+
"\"E\" Same as \"e\", but no warning is given before exiting SMIT. \n"+
"\"P\" , \"N\" or \"I\" Backup modes; work like the corresponding \"p\", \"n\", and \"i\" modes, except that if the cmd_to_exec command is run and returns with an exit value of 0, SMIT backs up to the nearest preceding menu (if any), or to the nearest preceding selector (if any), or to the command line. ";
 
const string s_ghost ="Indicates if the normally displayed dialog should not be shown. The value of ghost is a string. Valid values are: \"\" or \"n\" No; the dialog associated with the task is displayed. This is the default setting. \n" +
"\"y\" Yes; the dialog associated with the task is not displayed because no further information is required from the user. The command specified in the cmd_to_exec descriptor is executed as soon as the user selects the task. ";
 
const string s_cmd_to_discover ="The command string used to discover the default or current values of the object being manipulated. The value of cmd_to_discover is a string with a maximum length of 1024 characters. The command is executed before the dialog is displayed, and its output is retrieved. Output of the command must be in colon format. ";
const string s_cmd_to_discover_postfix ="The postfix to interpret and add to the command string in the cmd_to_discover field. The value of cmd_to_discover_postfix is a string with a maximum length of 1024 characters.  ";
const string s_help_msg_id ="Specifies a Message Facility message set number and message ID number with a comma as the separator or a numeric string equal to a SMIT identifier tag.  ";
const string s_help_msg_loc ="The file name sent as a parameter to the man command for retrieval of help text, or the file name of a file containing help text. The value of help_msg_loc is a string with a maximum length of 1024 characters. ";
const string s_help_msg_base ="The fully qualified path name of a library that SMIT reads for the file names associated with the correct book. ";
const string s_help_msg_book ="Contains the string with the value of the name file contained in the file library indicated by help_msg_base. ";

        
        private string _has_name_select;
        
        [DescriptionAttribute(s_has_name_select), CategoryAttribute("Name Setttings")]
        public bool has_name_select
        {
            get
            {
                if (_has_name_select == "y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    _has_name_select = "y";
                }
                else
                {
                    _has_name_select = "n";
                }
            }
        }
        //****************************
        private string _comment;
        //****************************
        [DescriptionAttribute(), CategoryAttribute("Comment")]
        public string comment
        {
            get
            {
                return _comment;
            }
            set
            {
                _comment = value;
            }
        }
        //****************************
        private string _name;
        //****************************
        [DescriptionAttribute(s_name), CategoryAttribute("Name Setttings")]
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        //****************************
        private string _name_msg_file;
        //****************************
        [DescriptionAttribute(s_name_msg_file), CategoryAttribute("Name Setttings")]
        public string name_msg_file
        {
            get
            {
                return _name_msg_file;
            }
            set
            {
                _name_msg_file = value;
            }
        }
        //****************************
        private string _name_msg_set;
        //****************************
        [DescriptionAttribute(s_name_msg_set), CategoryAttribute("Name Setttings")]
        public string name_msg_set
        {
            get
            {
                return _name_msg_set;
            }
            set
            {
                _name_msg_set = value;
            }
        }
        //****************************

        //****************************
        private string _name_msg_id;
        //****************************
        [DescriptionAttribute(s_name_msg_id), CategoryAttribute("Name Setttings")]
        public string name_msg_id
        {
            get
            {
                return _name_msg_id;
            }
            set
            {
                _name_msg_id = value;
            }
        }
        //****************************
        private string _cmd_to_exec;
        //****************************
        [DescriptionAttribute(s_cmd_to_exec), CategoryAttribute("Application Setttings"), ReadOnlyAttribute(true)]
        public string cmd_to_exec
        {
            get
            {
                return _cmd_to_exec;
            }
            set
            {
                _cmd_to_exec = value;
            }
        }
        //****************************
        private string _ask;
        
        //****************************
        [DescriptionAttribute(s_ask), CategoryAttribute("Application Setttings")]
        
        public bool ask
        {
            get
            {
                if (_ask == "y")
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value ==true)
                {

                    _ask = "y";
                }
                else
                {
                    _ask = "n";
                }

                
            }
        }
        //****************************
        private string _exec_mode;
        //****************************
        [DescriptionAttribute(s_exec_mode), CategoryAttribute("Application Setttings")]
        public string exec_mode
        {
            get
            {
                return _exec_mode;
            }
            set
            {
                _exec_mode = value;
            }
        }
        //****************************
        private string _ghost;
        //****************************
        [DescriptionAttribute(s_ghost), CategoryAttribute("Application Setttings")]
        public bool ghost
        {
            get
            {
                if (_ghost == "y")
                {

                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            set
            {
                if (value == true)
                {

                    _ghost = "y";
                }
                else
                {
                    _ghost = "n";
                }
            }
        }
        //****************************
        private string _cmd_to_discover;
        //****************************
        [DescriptionAttribute(s_cmd_to_discover), CategoryAttribute("Application Setttings"), ReadOnlyAttribute(true)]
        public string cmd_to_discover
        {
            get
            {
                return _cmd_to_discover;
            }
            set
            {
                _cmd_to_discover = value;
            }
        }
        //****************************
        private string _cmd_to_discover_postfix;
        //****************************
        [DescriptionAttribute(s_cmd_to_discover_postfix), CategoryAttribute("Application Setttings")]
        public string cmd_to_discover_postfix
        {
            get
            {
                return _cmd_to_discover_postfix;
            }
            set
            {
                _cmd_to_discover_postfix = value;
            }
        }
        //****************************
        private string _name_size;
        //****************************
        [DescriptionAttribute(""),CategoryAttribute("Name Setttings")]
        public string name_size
        {
            get
            {
                return _name_size;
            }
            set
            {
                _name_size = value;
            }
        }
        //****************************
        private string _value_size;
        //****************************
        [DescriptionAttribute(""), CategoryAttribute("Application Setttings")]
        public string value_size
        {
            get
            {
                return _value_size;
            }
            set
            {
                _value_size = value;
            }
        }
        
        public string toString()
        {
            char newline = (char)10;
            char tab = (char)09;
            //char cr = (char)13;
            

            string _s = "";
            _s = "sm_cmd_hdr:"+ newline;
            _s = _s + tab +"id = " + "\""+ this.id + "\""+ newline;
            _s = _s + tab + "option_id = " + "\"" + this.option_id + "\"" + newline;
            _s = _s + tab + "has_name_select = " + "\"" + this._has_name_select + "\"" + newline;
            _s = _s + tab + "name = " + "\"" + this.name + "\"" + newline;
            _s = _s + tab + "name_msg_file = " + "\"" + this.name_msg_file + "\"" + newline;
            _s = _s + tab + "name_msg_set = " + this.name_msg_set + newline;
            _s = _s + tab + "name_msg_id = " + this.name_msg_id + newline;
            _s = _s + tab + "cmd_to_exec = " + "\"" + this.cmd_to_exec + "\"" + newline;
            _s = _s + tab + "ask = " + "\"" + this._ask + "\"" + newline;
            _s = _s + tab + "exec_mode = " + "\"" + this.exec_mode + "\"" + newline;
            _s = _s + tab + "ghost = " + "\"" + this._ghost + "\"" + newline;
            _s = _s + tab + "cmd_to_discover = " + "\"" + this.cmd_to_discover + "\"" + newline;
            _s = _s + tab + "cmd_to_discover_postfix = " + "\"" + this.cmd_to_discover_postfix + "\"" + newline;
            _s = _s + tab + "name_size = " + this.name_size + "" + newline;
            _s = _s + tab + "value_size = " + this.value_size + "" + newline;
            _s = _s + tab + "help_msg_id = " + "\"" + this.get_help_msg_id() + "\"" + newline;
            _s = _s + tab + "help_msg_loc = " + "\"" + this.get_help_msg_loc() + "\"" + newline;
            _s = _s + tab + "help_msg_base = " + "\"" + this.get_help_msg_base() + "\"" + newline;
            _s = _s + tab + "help_msg_book = " + "\"" + this.get_help_msg_book() + "\"" + newline;
            return _s;
        }

    }
}
