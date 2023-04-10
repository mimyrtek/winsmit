using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WinSmit
{
    public class sm_stanza
    {
        private Guid _guid;
        private Boolean _used;
        public sm_stanza()
        { 
        this._guid = System.Guid.NewGuid();
        this._used = false;
        }

        const string s_id = "The ID or name of the object. The value of id is a string with a maximum length of 64 characters. The id field can be used as a fast path ID unless there is a selector associated with the dialog. IDs should be unique to your application and unique within your system. ";
        const string s_option_id = "The id of the sm_cmd_opt objects (the dialog fields) to which this header refers. The value of option_id is a string with a maximum length of 64 characters. ";
        const string s_next_id = "The fast path name of the next menu, if the value for the next_type descriptor of this object is \"m\" (menu). The next_id of a menu should be unique both to your application and within the particular SMIT database used. All non-alias sm_menu_opt objects with id values matching the value of next_id form the set of selections for that menu. The value of next_id is a string with a maximum length of 64 characters. ";
        const string s_id_seq_num = "The position of this item in relation to other items on the menu. Non-title sm_menu_opt objects are sorted on this string field. The value of id_seq_num is a string with a maximum length of 16 characters. ";
        /// <summary>
        /// 
        /// </summary>
        private string _id;
        private string _next_id;
        private string _option_id;
        private string _id_seq_num;
       

        public bool Used
        {
            get { return _used; }
        }
        public void set_isUsed(bool used)
        {
            _used = used ;
        }

        public Guid getGuid()
        {
            return this._guid;
        }

        [DescriptionAttribute(s_id), CategoryAttribute("ID and Position Setttings")]
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

        [DescriptionAttribute(s_option_id), CategoryAttribute("ID and Position Setttings")]
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
        [DescriptionAttribute(s_next_id), CategoryAttribute("ID and Position Setttings")]
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
        [DescriptionAttribute(s_id_seq_num), CategoryAttribute("ID and Position Setttings")]
        public string id_seq_num
        {
            get
            {
                if (_id_seq_num == null)
                {
                    _id_seq_num = "";
                }
                return _id_seq_num;
            }
            set
            {
                _id_seq_num = value;
            }
        }

        private string _help_msg_loc;
        private string _help_msg_base;
        private string _help_msg_book;
        private string _help_msg_id;

        public void set_help_msg_id(string s)
        {
            this._help_msg_id = s;
        }
        public void set_help_msg_loc(string s)
        {
            this._help_msg_loc = s;
        }
        public void set_help_msg_base(string s)
        {
            this._help_msg_base = s;
        }
        public void set_help_msg_book(string s)
        {
            this._help_msg_book = s;
        }

        public string get_help_msg_id()
        {
            return _help_msg_id;
        }
        public string get_help_msg_loc()
        {
            return _help_msg_loc;
        }
        public string get_help_msg_base()
        {
            return _help_msg_base;
        }
        public string get_help_msg_book()
        {
            return _help_msg_book;
        }
    }
}
