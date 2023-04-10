using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Collections.Specialized;
using System.Drawing.Design;
using System.Drawing;
using System.Resources;
using System.Windows.Forms.Design;


namespace WinSmit
{
[Serializable]
    // enummerators
    public enum sm_menu_opt_next_type { Menu, Dialog, Info, Name }
    //
    public class SourceTypePropertyGridEditor : UITypeEditor
    {
    }
    class sm_menu_opt
    {

        //The descriptors for sm_menu_opt objects are:

        const string s_id = "The ID or name of the object. The value of id is a string with a maximum length of 64 characters. IDs should be unique both to your application and unique within the particular SMIT database used. See the next_id and alias definitions for this object for related information. ";
        const string s_id_seq_num = "The position of this item in relation to other items on the menu. Non-title sm_menu_opt objects are sorted on this string field. The value of id_seq_num is a string with a maximum length of 16 characters. ";
        const string s_next_id = "The fast path name of the next menu, if the value for the next_type descriptor of this object is \"m\" (menu). The next_id of a menu should be unique both to your application and within the particular SMIT database used. All non-alias sm_menu_opt objects with id values matching the value of next_id form the set of selections for that menu. The value of next_id is a string with a maximum length of 64 characters. ";
        const string s_text = "The description of the task that is displayed as the menu item. The value of text is a string with a maximum length of 1024 characters. This string can be formatted with embedded \n (newline) characters. ";
        const string s_text_msg_file = "The file name (not the full path name) that is the Message Facility catalog for the string, text. The value of text_msg_file is a string with a maximum length of 1024 characters. Message catalogs required by an application program can be developed with the Message Facility. Set to \"\" if you are not using the Message Facility. ";
        const string s_text_msg_set = "The Message Facility set ID for the string, text. Set IDs can be used to indicate subsets of a single catalog. The value of text_msg_set is an integer. Set to 0 if you are not using the Message Facility. ";
        const string s_text_msg_id = "The Message Facility ID for the string, text. The value of text_msg_id is an integer. Set to 0 if you are not using the Message Facility. ";
        const string s_next_type = "The type of the next object if this item is selected. Valid values are: \"m\" Menu; the next object is a menu (sm_menu_opt). " + "\n" +
"\"d\" Dialog; the next object is a dialog (sm_cmd_hdr). " + "\n" +
"\"n\" Name; the next object is a selector (sm_name_hdr). " + "\n" +
"\"i\" Info; this object is used to put blank or other separator lines in a menu, or to present a topic that does not lead to an executable task but about which help is provided via the help_msg_loc descriptor of this object. ";

        const string s_alias = "Defines whether or not the value of the id descriptor for this menu object is an alias for another existing fast path specified in the next_id field of this object. The value of the alias descriptor must be \"n\" for a menu object.  ";
        const string s_help_msg_id = "Specifies a Message Facility message set number and message ID number with a comma as the separator or a numeric string equal to a SMIT identifier tag.  ";
        const string s_help_msg_loc = "The file name sent as a parameter to the man command for retrieval of help text, or the file name of a file containing help text. The value of help_msg_loc is a string with a maximum length of 1024 characters. ";
        const string s_help_msg_base = "The fully qualified path name of a library that SMIT reads for the file names associated with the correct book. ";
        const string s_help_msg_book = "Contains the string with the value of the name file contained in the file library indicated by help_msg_base. ";


        //

        //
        public sm_menu_opt()
        {
            _text_msg_id = "0";
            _text_msg_set = "0";

        }


        private string _id_seq_num;
        private string _id;
        private string _next_id;
        private string _text;
        private string _text_msg_file;
        private string _text_msg_set;
        private string _text_msg_id;
        private string _next_type;
        private string _alias;
        private string _help_msg_id;
        private string _help_msg_loc;
        private string _help_msg_base;
        private string _help_msg_book;

        private int _key;
        //****************************
        [DescriptionAttribute("Do not chang the value of this key"),
        CategoryAttribute("Internal Settings")]
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
        [DescriptionAttribute(s_help_msg_base), CategoryAttribute("Help Settings")]
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
        [DescriptionAttribute(s_help_msg_loc), CategoryAttribute("Help Settings")]
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
        [DescriptionAttribute(s_help_msg_id), CategoryAttribute("Help Settings")]
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
        [DescriptionAttribute(s_alias), CategoryAttribute("Application Settings")]
        public string alias
        {
            get
            {
                return _alias;
            }
            set
            {
                _alias = value;
            }
        }
        [DescriptionAttribute(s_next_type), CategoryAttribute("Application Settings")]
        //private HE_YesNo _YesNo;
        [Editor(typeof(SourceTypePropertyGridEditor), typeof(System.Drawing.Design.UITypeEditor))]


        public sm_menu_opt_next_type next_type
        {
            get
            {
                if (_next_type.Equals("m"))
                {
                    return sm_menu_opt_next_type.Menu;
                }
                else if (_next_type.Equals("d"))
                {
                    return sm_menu_opt_next_type.Dialog;
                }
                else if (_next_type.Equals("i"))
                {
                    return sm_menu_opt_next_type.Info;
                }
                else if (_next_type.Equals("n"))
                {
                    return sm_menu_opt_next_type.Name;
                }
                else
                {
                    return sm_menu_opt_next_type.Menu;
                }

            }
            set
            {
                if (value.ToString().Equals("Menu")) { _next_type = "m"; }
                if (value.ToString().Equals("Dialog")) { _next_type = "d"; }
                if (value.ToString().Equals("Name")) { _next_type = "n"; }
                if (value.ToString().Equals("Info")) { _next_type = "i"; }
            }

        }


        [DescriptionAttribute(s_text_msg_id), CategoryAttribute("Name Settings")]
        public string text_msg_id
        {
            get
            {
                return _text_msg_id;
            }
            set
            {
                _text_msg_id = value;
            }
        }
        [DescriptionAttribute(s_text_msg_set), CategoryAttribute("Name Settings")]
        public string text_msg_set
        {
            get
            {
                return _text_msg_set;
            }
            set
            {
                _text_msg_set = value;
            }
        }
        [DescriptionAttribute(s_text_msg_file), CategoryAttribute("Name Settings")]
        public string text_msg_file
        {
            get
            {
                return _text_msg_file;
            }
            set
            {
                _text_msg_file = value;
            }
        }
        [DescriptionAttribute(s_text), CategoryAttribute("Name Settings")]
        public string text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        [DescriptionAttribute(s_next_id), CategoryAttribute("ID and Position Settings")]
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
        [DescriptionAttribute(s_id), CategoryAttribute("ID and Position Settings")]
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
        [DescriptionAttribute(s_id_seq_num), CategoryAttribute("ID and Position Settings")]
        public string id_seq_num
        {
            get
            {
                return _id_seq_num;
            }
            set
            {
                _id_seq_num = value;
            }
        }

        public string toString()
        {
            char newline = (char)10;
            char tab = (char)09;
            //char cr = (char)13;



            string _s = "";
            _s = "sm_menu_opt:" + newline;
            _s = _s + tab + "id_seq_num = " + "\"" + this.id_seq_num + "\"" + newline;
            _s = _s + tab + "id = " + "\"" + this.id + "\"" + newline;
            _s = _s + tab + "next_id = " + "\"" + this.next_id + "\"" + newline;
            _s = _s + tab + "text = " + "\"" + this.text + "\"" + newline;
            _s = _s + tab + "text_msg_file = " + "\"" + this.text_msg_file + "\"" + newline;
            _s = _s + tab + "text_msg_set = " + this.text_msg_set + "" + newline;
            _s = _s + tab + "text_msg_id = " + this.text_msg_id + "" + newline;
            _s = _s + tab + "next_type = " + "\"" + this._next_type + "\"" + newline;
            _s = _s + tab + "alias = " + "\"" + this.alias + "\"" + newline;
            _s = _s + tab + "help_msg_id = " + "\"" + this.help_msg_id + "\"" + newline;
            _s = _s + tab + "help_msg_loc = " + "\"" + this.help_msg_loc + "\"" + newline;
            _s = _s + tab + "help_msg_base = " + "\"" + this.help_msg_base + "\"" + newline;
            _s = _s + tab + "help_msg_book = " + "\"" + this.help_msg_book + "\"" + newline;


            return _s;
        }


    }
}

