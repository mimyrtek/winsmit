using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Drawing.Design;

namespace WinSmit
{
    // enummerators
    // n= No Entry
    // t= Text
    // # = Numeric
    // x= Hex Entry
    // f = File Entry
    // r = raw text
    public enum sm_cmd_opt_entry_type {No_Entry,Text,Numeric,Hex,File,Raw_Text}
    
    //
    public class SourceTypePropertyGridEditor : UITypeEditor
    {
    }

    public class sm_cmd_opt:sm_stanza 
    {

        public sm_cmd_opt()
        {
            this._name = "";
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
        //******************************
        private string _disc_field_name;
        //******************************
        [DescriptionAttribute("A string that should match one of the name fields in the output of the cmd_to_discover command in the associated dialog header. The value of disc_field_name is a string with a maximum length of 64 characters. "+
"The value of the disc_field_name descriptor can be defined using the raw or cooked name from a preceding selector instead of the cmd_to_discover command in the associated header object. If the descriptor is defined with input from a preceding selector, it must be set to either \"_rawname\" or \"_cookedname\", or to the corresponding sm_name_hdr.cooked_field_name value or sm_name_hdr.raw_field_name value if this was used to redefine the default name."),
        CategoryAttribute("Application Setttings")]
        public string disc_field_name
        {
            get
            {
                return _disc_field_name;
            }
            set
            {
                _disc_field_name = value;
            }
        }
        //******************************
        private string _name;
        //******************************
        [DescriptionAttribute("The string that appears on the dialog or selector screen as the field name. It is the visual questioning or prompting part of the object, a natural language description of a flag, option or parameter of the command specified in the cmd_to_exec field of the associated dialog header object. The value of name is a string with a maximum length of 1024 characters."),
        CategoryAttribute("Name Setttings")]
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
        //******************************
        private string _name_msg_file;
        //******************************
        [DescriptionAttribute("The file name (not the full path name) that is the Message Facility catalog for the string, name. The value of name_msg_file is a string with a maximum length of 1024 characters. Message catalogs required by an application program can be developed with the Message Facility."),
        CategoryAttribute("Name Setttings")]
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
        //******************************
        private string _name_msg_set;
        //******************************
        [DescriptionAttribute("The Message Facility set ID for the string, name. Set IDs can be used to indicate subsets of a single catalog. The value of name_msg_set is an integer."),
        CategoryAttribute("Name Setttings")]
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
        //******************************
        private string _name_msg_id;
        //******************************
        [DescriptionAttribute("The Message Facility message ID for the string, name. The value of name_msg_id is an integer. Set to 0 if not used."),
        CategoryAttribute("Name Setttings")]
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
        //******************************
        private string _op_type;
        //******************************
        [DescriptionAttribute("The type of auxiliary operation supported for this field. The value of op_type is a string. Valid values are: "+
"\"\" or \"n\" - This is the default case. No auxiliary operations (list or ring selection) are supported for this field."+
"\"l\" - List selection operation provided. A pop-up window displays a list of items produced by running the command in the cmd_to_list field of this object when the user selects the F4=List function of the SMIT interface."+
"\"r\" - Ring selection operation provided. The string in the disp_values or aix_values field is interpreted as a comma-delimited set of valid entries. The user can tab or backtab through these values to make a selection. Also, the F4=List interface function can be used in this case, since SMIT will transform the ring into a list as needed."+
"The values \"N\", \"L\", and \"R\" can be used as op_type values just as the lowercase values \"n\", \"l\", and \"r\". However, with the uppercase values, if the cmd_to_exec command is run and returns with an exit value of 0, then the corresponding entry field will be cleared to an empty string."),
        CategoryAttribute("Application Setttings")]
        public string op_type
        {
            get
            {
                return _op_type;
            }
            set
            {
                _op_type = value;
            }
        }
        //******************************
        private string _entry_type;
        //******************************
        [DescriptionAttribute("The type of value required by the entry field. The value of entry_type is a string. Valid values are: "+
"\"\" or \"n\" - No entry; the current value cannot be modified via direct type-in. The field is informational only."+
"\"t\" - Text entry; alphanumeric input can be entered."+
"\"#\" - Numeric entry; only the numeric characters 0, 1, 2, 3, 4, 5, 6, 7, 8, or 9 can be entered. A - (minus sign) or + (plus sign) can be entered as the first character."+
"\"x\" - Hex entry; hexadecimal input only can be entered."+
"\"f\" - File entry; a file name should be entered."+
"\"r\" - Raw text entry; alphanumeric input can be entered. Leading and trailing spaces are considered significant and are not stripped off the field."),
        CategoryAttribute("Application Setttings")]
        [Editor(typeof(SourceTypePropertyGridEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public sm_cmd_opt_entry_type entry_type
        {
            get
            {
                if (_entry_type == null)
                {
                    _entry_type = "n";
                }

                if (_entry_type.Equals("n"))
                {
                    return sm_cmd_opt_entry_type.No_Entry;
                }
                else if (_entry_type.Equals("t")) 
                {
                    return sm_cmd_opt_entry_type.Text;
                }
                else if (_entry_type.Equals("#"))
                {
                    return sm_cmd_opt_entry_type.Numeric;
                }
                else if (_entry_type.Equals("x"))
                {
                    return sm_cmd_opt_entry_type.Hex;
                }
                else if (_entry_type.Equals("f"))
                {
                    return sm_cmd_opt_entry_type.File;
                }
                else if (_entry_type.Equals("r"))
                {
                    return sm_cmd_opt_entry_type.Raw_Text;
                }
                else
                {
                    return sm_cmd_opt_entry_type.No_Entry;
                }
            }
            set
            {
                if (value.ToString().Equals("No_Entry")) { _entry_type = "n"; }
                if (value.ToString().Equals("Text")) { _entry_type = "t"; }
                if (value.ToString().Equals("Numeric")) { _entry_type = "#"; }
                if (value.ToString().Equals("Hex")) { _entry_type = "x"; }
                if (value.ToString().Equals("File")) { _entry_type = "f"; }
                if (value.ToString().Equals("Raw_Text")) { _entry_type = "r"; }
            }
        }
        //******************************
        private string _entry_size;
        //******************************
        [DescriptionAttribute("Limits the number of characters the user can type in the entry field. The value of entry_size is an integer. A value of 0 defaults to the maximum allowed value size."),
        CategoryAttribute("Application Setttings")]
        public string entry_size
        {
            get
            {
                return _entry_size;
            }
            set
            {
                _entry_size = value;
            }
        }
        //******************************
        private string _required;
        //******************************
        [DescriptionAttribute("Defines if a command field must be sent to the cmd_to_exec command defined in the associated dialog header object. The value of required is a string. If the object is part of a selector screen, the required field should normally be set to \"\" (empty string). If the object is part of a dialog screen, valid values are: "+
"\"\" or \"n\" - No; the option is added to the command string in the cmd_to_exec command only if the user changes the initially-displayed value. This is the default case."+
"\"y\" - Yes; the value of the prefix field and the value of the entry field are always sent to the cmd_to_exec command."+
"\"+\" - The value of the prefix field and the value of the entry field are always sent to the cmd_to_exec command. The entry field must contain at least one non-blank character. SMIT will not allow the user to run the task until this condition is satisfied."+
"\"?\" - Except when empty; the value of the prefix field and the value of the entry field are sent to the cmd_to_exec field unless the entry field is empty."),
        CategoryAttribute("Application Setttings")]
        public string required
        {
            get
            {
                return _required;
            }
            set
            {
                _required = value;
            }
        }
        //******************************
        private string _prefix;
        //******************************
        [DescriptionAttribute("In the simplest case, defines the flag to send with the entry field value to the cmd_to_exec command defined in the associated dialog header object. The value of prefix is a string with a maximum length of 1024 characters. "+
"The use of this field depends on the setting of the required field, the contents of the prefix field, and the contents of the associated entry field."+
"Note: If the prefix field is set to -- (dash dash), the content of the associated entry field is appended to the end of the cmd_to_exec command. If the prefix field is set to --' (dash dash single quotation mark), the contents of the associated entry field is appended to the end of the cmd_to_exec command in single quotes."),
        CategoryAttribute("Application Setttings")]
        public string prefix
        {
            get
            {
                return _prefix;
            }
            set
            {
                _prefix = value;
            }
        }
        //******************************
        private string _cmd_to_list_mode;
        //******************************
        [DescriptionAttribute("Defines how much of an item from a list should be used. The list is produced by the command specified in this object's cmd_to_list field. The value of cmd_to_list_mode is a string with a maximum length of 1 character. Valid values are: "+
"\"\" or \"a\" - Get all fields. This is the default case."+
"\"1\" - Get the first field."+
"\"2\" - Get the second field."+
"\"r\" - Range; running the command string in the cmd_to_list field returns a range (such as 1..99) instead of a list. Ranges are for information only; they are displayed in a list pop-up, but do not change the associated entry field."),
        CategoryAttribute("Application Setttings")]
        public string cmd_to_list_mode
        {
            get
            {
                return _cmd_to_list_mode;
            }
            set
            {
                _cmd_to_list_mode = value;
            }
        }
        //******************************
        private string _cmd_to_list;
        //******************************
        [DescriptionAttribute("The command string used to get a list of valid values for the value field. The value of cmd_to_list is a string with a maximum length of 1024 characters. This command should output values that are separated by \n (new line) characters"),
       CategoryAttribute("Application Setttings"), ReadOnlyAttribute(true)]
        public string cmd_to_list
        {
            get
            {
                return _cmd_to_list;
            }
            set
            {
                _cmd_to_list = value;
            }
        }
        //******************************
        private string _cmd_to_list_postfix;
        //******************************
        [DescriptionAttribute("The postfix to interpret and add to the command string specified in the cmd_to_list field of the dialog object. The value of cmd_to_list_postfix is a string with a maximum length of 1024 characters. If the first line starts with # (pound sign) following a space, that entry will be made non-selectable. This is useful for column headings. Subsequent lines that start with a #, optionally preceded by spaces, are treated as a comment and as a continuation of the preceding entry."),
        CategoryAttribute("Application Setttings")]
        public string cmd_to_list_postfix
        {
            get
            {
                return _cmd_to_list_postfix;
            }
            set
            {
                _cmd_to_list_postfix = value;
            }
        }
        //******************************
        private string _multi_select;
        //******************************
        [DescriptionAttribute("Defines if the user can make multiple selections from a list of valid values produced by the command in the cmd_to_list field of the dialog object. The value of multi_select is a string. Valid values are: "+
"\"\" - No; a user can select only one value from a list. This is the default case."+
"\",\" - Yes; a user can select multiple items from the list. When the command is built, a comma is inserted between each item."+
"\"y\" - Yes; a user can select multiple values from the list. When the command is built, the option prefix is inserted once before the string of selected items."+
"\"m\" - Yes; a user can select multiple items from the list. When the command is built, the option prefix is inserted before each selected item."),
        CategoryAttribute("Application Setttings")]
        public string multi_select
        {
            get
            {
                return _multi_select;
            }
            set
            {
                _multi_select = value;
            }
        }
        //******************************
        private string _value_index;
        //******************************
        [DescriptionAttribute("For an option ring, the zero-origin index to the array of disp_value fields. The value_index number indicates the value that is displayed as the default in the entry field to the user. The value of entry_size is an integer."),
        CategoryAttribute("Application Setttings")]
        public string value_index
        {
            get
            {
                return _value_index;
            }
            set
            {
                _value_index = value;
            }
        }
        //******************************
        private string _disp_values;
        //******************************
        [DescriptionAttribute("The array of valid values in an option ring to be presented to the user. The value of the disp_values fields is a string with a maximum length of 1024 characters. The field values are separated by , (commas) with no spaces preceding or following the commas"),
        CategoryAttribute("Application Setttings")]
        public string disp_values
        {
            get
            {
                return _disp_values;
            }
            set
            {
                _disp_values = value;
            }
        }
        //******************************
        private string _values_msg_file;
        //******************************
        [DescriptionAttribute("The file name (not the full path name) that is the Message Facility catalog for the values in the disp_values fields, if the values are initialized at development time. The value of the values_msg_file field is a string with a maximum length of 1024 characters. Message catalogs required by an application program can be developed with the Message Facility."),
        CategoryAttribute("Message Setttings")]
        public string values_msg_file
        {
            get
            {
                return _values_msg_file;
            }
            set
            {
                _values_msg_file = value;
            }
        }
        //******************************
        private string _values_msg_set;
        //******************************
        [DescriptionAttribute("The Message Facility set ID for the values in the disp_values fields. Set to 0 if not used."),
        CategoryAttribute("Message Setttings")]
        public string values_msg_set
        {
            get
            {
                return _values_msg_set;
            }
            set
            {
                _values_msg_set = value;
            }
        }
        //******************************
        private string _values_msg_id;
        //******************************
        [DescriptionAttribute("The Message Facility message ID for the values in the disp_values fields. Set to 0 if not used."),
        CategoryAttribute("Message Setttings")]
        public string values_msg_id
        {
            get
            {
                return _values_msg_id;
            }
            set
            {
                _values_msg_id = value;
            }
        }
        //******************************
        private string _aix_values;
        //******************************
        [DescriptionAttribute("If for an option ring, an array of values specified so that each element corresponds to the element in the disp_values array in the same position; use if the natural language values in disp_values are not the actual options to be used for the command. The value of the aix_values field is a string with a maximum length of 1024 characters. "),
        CategoryAttribute("Application Setttings")]
        public string aix_values
        {
            get
            {
                return _aix_values;
            }
            set
            {
                _aix_values = value;
            }
        }
       
        public string toString()
        {
            char newline = (char)10;
            char tab = (char)09;
            
            string _s = "";
            _s = "sm_cmd_opt:"+newline;
            _s = _s + tab + "id_seq_num = " + "\"" + this.id_seq_num + "\""+ newline;
            _s = _s + tab + "id = " + "\"" + this.id + "\"" + newline;
            _s = _s + tab + "disc_field_name = " + "\"" + this.disc_field_name + "\"" + newline;
            _s = _s + tab + "name = " + "\"" + this.name + "\"" + newline;
            _s = _s + tab + "name_msg_file = " + "\"" + this.name_msg_file + "\"" + newline;
            _s = _s + tab + "name_msg_set = " + this.name_msg_set + "" + newline;
            _s = _s + tab + "name_msg_id = " + this.name_msg_id + "" + newline;
            _s = _s + tab + "op_type = " + "\"" + this.op_type + "\"" + newline;
            _s = _s + tab + "entry_type = " + "\"" + this._entry_type + "\"" + newline;
            _s = _s + tab + "entry_size = " + this.entry_size + "" + newline;
            _s = _s + tab + "required = " + "\"" + this.required + "\"" + newline;
            _s = _s + tab + "prefix = " + "\"" + this.prefix + "\"" + newline;
            _s = _s + tab + "cmd_to_list_mode = " + "\"" + this.cmd_to_list_mode + "\"" + newline;
            _s = _s + tab + "cmd_to_list = " + "\"" + this.cmd_to_list + "\"" + newline;
            _s = _s + tab + "cmd_to_list_postfix = " + "\"" + this.cmd_to_list_postfix + "\"" + newline;
            _s = _s + tab + "multi_select = " + "\"" + this.multi_select + "\"" + newline;
            _s = _s + tab + "value_index = " + this.value_index + "" + newline;
            _s = _s + tab + "disp_values = " + "\"" + this.disp_values + "\"" + newline;
            _s = _s + tab + "values_msg_file = " + "\"" + this.values_msg_file + "\"" + newline;
            _s = _s + tab + "values_msg_set = " + this.values_msg_set + "" + newline;
            _s = _s + tab + "values_msg_id = " + this.values_msg_id + "" + newline;
            _s = _s + tab + "aix_values = " + "\"" + this.aix_values + "\"" + newline;
            _s = _s + tab + "help_msg_id = " + "\"" + this.get_help_msg_id() + "\"" + newline;
            _s = _s + tab + "help_msg_loc = " + "\"" + this.get_help_msg_loc() + "\"" + newline;
            _s = _s + tab + "help_msg_base = " + "\"" + this.get_help_msg_base() + "\"" + newline;
            _s = _s + tab + "help_msg_book = " + "\"" + this.get_help_msg_book() + "\"" + newline;
            
            
            return _s;
        }
    }
}
