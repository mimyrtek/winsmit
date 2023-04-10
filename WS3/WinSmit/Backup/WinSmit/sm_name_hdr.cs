using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Globalization;
using System.Drawing.Design;

namespace WinSmit
{
    // enummerators
    // j=Just_next_ID, r=Cat_raw_name, c =Cat_cooked_name
    public enum sm_name_hdr_type { Just_next_ID, Cat_raw_name, Cat_cooked_name }
    public enum sm_name_hdr_next_type { Dialog, Name }


    class sm_name_hdr 
    {
        //
        const string s_next_id = "Specifies the header object for the subsequent screen; set to the value of the id field of the sm_cmd_hdr object or the sm_name_hdr object that follows this selector. The next_type field described below specifies which object class is indicated. The value of next_id is a string with a maximum length of 64 characters. ";
        const string s_id = "The ID or name of the object. The id field can be externalized as a fast path ID unless has_name_select is set to \"y\" (yes). The value of id is a string with a maximum length of 64 characters. IDs should be unique to your application and unique within your system. ";
        const string s_option_id = "Specifies the body of this selector; set to the id field of the sm_cmd_opt object. The value of option_id is a string with a maximum length of 64 characters. ";
        const string s_has_name_select = "Specifies whether this screen must be preceded by a selector screen. Valid values are: \"\" or \"n\" No; this is the default case. The id of this object can be used as a fast path, even if preceded by a selector screen. \n" +
"\"y\" Yes; a selector must precede this object. This setting prevents the id of this object from being used as a fast path to the corresponding dialog screen. ";

        const string s_name = "The text displayed as the title of the selector screen. The value of name is a string with a maximum length of 1024 characters. The string can be formatted with embedded \n (newline) characters. ";
        const string s_name_msg_file = " The file name (not the full path name) that is the Message Facility catalog for the string, name. The value of name_msg_file is a string with a maximum length of 1024 characters. Message catalogs required by an application program can be developed with the Message Facility. ";
        const string s_name_msg_set = "The Message Facility set ID for the string, name. Set IDs can be used to indicate subsets of a single catalog. The value of name_msg_set is an integer. ";
        const string s_name_msg_id = "The Message Facility ID for the string, name. The value of name_msg_id is an integer. ";
        const string s_type = "The method to be used to process the selector. The value of type is a string with a maximum length of 1 character. Valid values are: \"\" or \"j\" Just next ID; the object following this object is always the object specified by the value of the next_id descriptor. The next_id descriptor is a fully-defined string initialized at development time. " + "\n" +
        "\"r\" Cat raw name; in this case, the next_id descriptor is defined partially at development time and partially at runtime by user input. The value of the next_id descriptor defined at development time is concatenated with the value selected by the user to create the id value to search for next (that of the dialog or selector to display). \n" +
        "\"c\" Cat cooked name; the value selected by the user requires processing for more information. This value is passed to the command named in the cmd_to_classify descriptor, and then output from the command is concatenated with the value of the next_id descriptor to create the id descriptor to search for next (that of the dialog or selector to display). ";

        const string s_ghost = "Specifies whether to display this selector screen or only the list pop-up panel produced by the command in the cmd_to_list field. The value of ghost is a string. Valid values are: \"\" or \"n\" No; display this selector screen. \n" +
        "\"y\" Yes; display only the pop-up panel produced by the command string constructed using the cmd_to_list and cmd_to_list_postfix fields in the associated sm_cmd_opt object. If there is no cmd_to_list value, SMIT assumes this object is a super-ghost (nothing is displayed), runs the cmd_to_classify command, and proceeds. ";

        const string s_cmd_to_classify = "The command string to be used, if needed, to classify the value of the name field of the sm_cmd_opt object associated with this selector. The value of cmd_to_classify is a string with a maximum length of 1024 characters. The input to the cmd_to_classify taken from the entry field is called the \"raw name\" and the output of the cmd_to_classify is called the \"cooked name\". Previous to AIX Version 4.2.1, you could create only one value with cmd_to_classify. If that value included a colon, it was escaped automatically. In AIX Version 4.2.1 and later, you can create multiple values with cmd_to_classify, but the colons are no longer escaped. The colon is now being used as a delimiter by this command. If you use colons in your values, you must preserve them manually. ";
        const string s_cmd_to_classify_postfix = "The postfix to interpret and add to the command string in the cmd_to_classify field. The value of cmd_to_classify_postfix is a string with a maximum length of 1024 characters.  ";
        const string s_raw_field_name = "The alternate name for the raw value. The value of raw_field_name is a string with a maximum length of 1024 characters. The default value is \"_rawname\".  ";
        const string s_cooked_field_name = "The alternate name for the cooked value. The value of cooked_field_name is a string with a maximum length of 1024 characters. The default value is \"cookedname\". ";
        const string s_next_type = "The type of screen that follows this selector. Valid values are: \"n\" Name; a selector screen follows. See the description of next_id above for related information. \n" +
        "\"d\" Dialog; a dialog screen follows. See the description of next_id above for related information. ";

        const string s_help_msg_id = "Specifies a Message Facility message set number and message ID number with a comma as the separator or a numeric string equal to a SMIT identifier tag.  ";
        const string s_help_msg_loc = "The file name sent as a parameter to the man command for retrieval of help text, or the file name of a file containing help text. The value of help_msg_loc is a string with a maximum length of 1024 characters. ";
        const string s_help_msg_base = "The fully qualified path name of a library that SMIT reads for the file names associated with the correct book. ";
        const string s_help_msg_book = "Contains the string with the value of the name file contained in the file library indicated by help_msg_base. ";




        private int _key;
        //****************************
        [DescriptionAttribute(""), CategoryAttribute("Internal Settings"), ReadOnlyAttribute(true)]
        public int key
        {
            get
            {
                return _key;
            }
            set
            {
                _key = value;
            }
        }
        //  sm_name_hdr:
        private string _id;
        //****************************
        [DescriptionAttribute(s_id),
     CategoryAttribute("ID and Position Settings")]
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        //***************************
        private string _next_id;
        //****************************
        [DescriptionAttribute(s_next_id),
    CategoryAttribute("ID and Position Settings")]
        public string next_id
        {
            get
            {
                return _next_id;
            }
            set
            {
                _next_id = value;
            }
        }
        //***************************
        private string _option_id;
        //****************************
        [DescriptionAttribute(s_option_id),
    CategoryAttribute("ID and Position Settings")]
        public string option_id
        {
            get
            {
                return _option_id;
            }
            set
            {
                _option_id = value;
            }
        }
        //***************************
        private string _has_name_select;
        //****************************
        [DescriptionAttribute(s_has_name_select),
     CategoryAttribute("Name Settings")]
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
        //***************************
        private string _name;
        //****************************
        [DescriptionAttribute(s_name),
        CategoryAttribute("Name Settings")]
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
        //***************************
        private string _name_msg_file;
        //****************************
        [DescriptionAttribute(s_name_msg_file),
    CategoryAttribute("Name Settings")]
        public string name_msg_file
        {
            get
            {
                if (_name_msg_file == null)
                {
                    _name_msg_file = "0";
                }
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
        [DescriptionAttribute(s_name_msg_set),
    CategoryAttribute("Name Settings")]
        public string name_msg_set
        {
            get
            {
                if (_name_msg_set == null)
                {
                    _name_msg_set = "0";
                }
                return _name_msg_set;
            }
            set
            {
                _name_msg_set = value;
            }
        }
        //****************************
        private string _name_msg_id;
        //****************************
        [DescriptionAttribute(s_name_msg_id),
    CategoryAttribute("Name Settings")]
        public string name_msg_id
        {
            get
            {
                if (_name_msg_id == null)
                {
                    _name_msg_id = "0";
                }
                return _name_msg_id;
            }
            set
            {
                _name_msg_id = value;
            }
        }
        //****************************
        private string _type;
        //****************************
        [DescriptionAttribute(s_type),
        CategoryAttribute("Application Settings")]
        [Editor(typeof(SourceTypePropertyGridEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public sm_name_hdr_type type
        {
            get
            {
                if (_type.Equals("j"))
                {
                    return sm_name_hdr_type.Just_next_ID;
                }
                else if (_type.Equals(" "))
                {
                    return sm_name_hdr_type.Cat_raw_name;
                }
                else if (_type.Equals(""))
                {
                    return sm_name_hdr_type.Cat_raw_name;
                }
                else if (_type.Equals("r"))
                {
                    return sm_name_hdr_type.Cat_raw_name;
                }
                else if (_type.Equals("c"))
                {
                    return sm_name_hdr_type.Cat_cooked_name;
                }
                else
                {
                    return sm_name_hdr_type.Just_next_ID;
                }

            }
            set
            {
                if (value.ToString().Equals("Just_next_ID")) { _type = "j"; }
                if (value.ToString().Equals("Cat_raw_name")) { _type = "r"; }
                if (value.ToString().Equals("Cat_cooked_name")) { _type = "c"; }
            }
        }
        //****************************
        private string _ghost;
        //****************************
        [DescriptionAttribute(s_ghost),
     CategoryAttribute("Application Settings")]
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
        private string _cmd_to_classify;
        //****************************
        [DescriptionAttribute(s_cmd_to_classify),
    CategoryAttribute("Application Settings"), ReadOnlyAttribute(true)]
        public string cmd_to_classify
        {
            get
            {
                return _cmd_to_classify;
            }
            set
            {
                _cmd_to_classify = value;
            }
        }
        //****************************
        private string _cmd_to_classify_postfix;
        //****************************
        [DescriptionAttribute(s_cmd_to_classify_postfix),
     CategoryAttribute("Application Settings")]
        public string cmd_to_classify_postfix
        {
            get
            {
                return _cmd_to_classify_postfix;
            }
            set
            {
                _cmd_to_classify_postfix = value;
            }
        }
        //****************************
        private string _raw_field_name;
        //****************************
        [DescriptionAttribute(s_raw_field_name),
     CategoryAttribute("Application Settings")]
        public string raw_field_name
        {
            get
            {
                return _raw_field_name;
            }
            set
            {
                _raw_field_name = value;
            }
        }
        //****************************
        private string _cooked_field_name;
        //****************************
        [DescriptionAttribute(s_cooked_field_name),
     CategoryAttribute("Application Settings")]
        public string cooked_field_name
        {
            get
            {
                return _cooked_field_name;
            }
            set
            {
                _cooked_field_name = value;
            }
        }
        //****************************
        private string _next_type;
        //****************************
        [DescriptionAttribute(s_next_type),
        CategoryAttribute("Application Settings")]
        [Editor(typeof(SourceTypePropertyGridEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public sm_name_hdr_next_type next_type
        {
            get
            {
                if (_next_type.Equals("d"))
                {
                    return sm_name_hdr_next_type.Dialog;
                }
                else if (_next_type.Equals("n"))
                {
                    return sm_name_hdr_next_type.Name;
                }
                else
                {
                    return sm_name_hdr_next_type.Name;
                }
            }
            set
            {

                if (value.ToString().Equals("Dialog")) { _next_type = "d"; }
                if (value.ToString().Equals("Name")) { _next_type = "n"; }

            }
        }
        //****************************
        private string _help_msg_id;
        //****************************
        [DescriptionAttribute(s_help_msg_id),
     CategoryAttribute("Help Settings")]
        public string help_msg_id
        {
            get
            {
                return _help_msg_id;
            }
            set
            {
                _help_msg_id = value;
            }
        }
        //****************************
        private string _help_msg_loc;
        //****************************
        [DescriptionAttribute(s_help_msg_loc),
     CategoryAttribute("Help Settings")]
        public string help_msg_loc
        {
            get
            {
                return _help_msg_loc;
            }
            set
            {
                _help_msg_loc = value;
            }
        }
        //****************************

        private string _help_msg_base;
        //****************************
        [DescriptionAttribute(s_help_msg_base),
     CategoryAttribute("Help Settings")]
        public string help_msg_base
        {
            get
            {
                return _help_msg_base;
            }
            set
            {
                _help_msg_base = value;
            }
        }
        //****************************

        private string _help_msg_book;
        //****************************
        [DescriptionAttribute(s_help_msg_book),
     CategoryAttribute("Help Settings")]
        public string help_msg_book
        {
            get
            {
                return _help_msg_book;
            }
            set
            {
                _help_msg_book = value;
            }
        }
        //****************************

        public string toString()
        {
            char newline = (char)10;
            char tab = (char)09;
            //char cr = (char)13;

            string _s = "";
            _s = "sm_name_hdr:" + newline;
            _s = _s + tab + "id = " + "\"" + this.id + "\"" + newline;
            _s = _s + tab + "next_id = " + "\"" + this.next_id + "\"" + newline;
            _s = _s + tab + "option_id = " + "\"" + this.option_id + "\"" + newline;
            _s = _s + tab + "has_name_select = " + "\"" + this._has_name_select + "\"" + newline;
            _s = _s + tab + "name = " + "\"" + this.name + "\"" + newline;
            _s = _s + tab + "name_msg_file = " + "\"" + this.name_msg_file + "\"" + newline;
            _s = _s + tab + "name_msg_set = " + this.name_msg_set + "" + newline;
            _s = _s + tab + "name_msg_id = " + this.name_msg_id + "" + newline;
            _s = _s + tab + "type = " + "\"" + this._type + "\"" + newline;
            _s = _s + tab + "ghost = " + "\"" + this._ghost + "\"" + newline;
            _s = _s + tab + "cmd_to_classify = " + "\"" + this.cmd_to_classify + "\"" + newline;
            _s = _s + tab + "cmd_to_classify_postfix = " + "\"" + this.cmd_to_classify_postfix + "\"" + newline;
            _s = _s + tab + "raw_field_name = " + "\"" + this.raw_field_name + "\"" + newline;
            _s = _s + tab + "cooked_field_name = " + "\"" + this.cooked_field_name + "\"" + newline;
            _s = _s + tab + "next_type = " + "\"" + this._next_type + "\"" + newline;
            _s = _s + tab + "help_msg_id = " + "\"" + this.help_msg_id + "\"" + newline;
            _s = _s + tab + "help_msg_loc = " + "\"" + this.help_msg_loc + "\"" + newline;
            _s = _s + tab + "help_msg_base = " + "\"" + this.help_msg_base + "\"" + newline;
            _s = _s + tab + "help_msg_book = " + "\"" + this.help_msg_book + "\"" + newline; 

            return _s;
        }
    }
}
