#define DEBUG

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace WinSmit
{
    public static class Util
    {

        public const string SPLIT = "(\bid\b|"+
"\bid_seq_num\b|"+
"\bnext_id\b|"+ 
"\btext\b|"+ 
"\btext_msg_file\b|"+
"\btext_msg_set\b|"+
"\btext_msg_id\b|"+ 
"\bnext_type\b|"+ 
"\balias\b|"+ 
"\bhelp_msg_id\b|"+
"\bhelp_msg_loc\b|"+ 
"\bhelp_msg_base\b|"+ 
"\bhelp_msg_book\b|"+ 
"\boption_id\b|"+ 
"\bhas_name_select\b|"+ 
"\bname\b|"+
"\bname_msg_file\b|"+
"\bname_msg_set\b|"+ 
"\bname_msg_id\b|"+ 
"\bcmd_to_exec\b|"+ 
"\bask\b|"+ 
"\bexec_mode\b|"+ 
"\bghost\b|"+ 
"\bcmd_to_discover\b|"+ 
"\bcmd_to_discover_postfix\b|"+
"\bname_size\b|"+ 
"\bvalue_size\b|"+ 
"\bdisc_field_name\b|"+ 
"\bop_type\b|"+
"\bentry_type\b|"+ 
"\bentry_size\b|"+ 
"\brequired\b|"+ 
"\bprefix\b|"+ 
"\bcmd_to_list_mode\b|"+ 
"\bcmd_to_list\b|"+ 
"\bcmd_to_list_postfix\b|"+ 
"\bmulti_select\b|"+ 
"\bvalue_index\b|"+ 
"\bdisp_values\b|"+ 
"\bvalues_msg_file\b|"+ 
"\bvalues_msg_set\b|"+ 
"\bvalues_msg_id\b|"+ 
"\baix_values\b|"+ 
"\btype\b|"+ 
"\bcmd_to_classify\b|"+ 
"\bcmd_to_classify_postfix\b|"+
"\braw_field_name\b|"+ 
"\bcooked_field_name\b|"+ 
"\bnext_type\b)"; 

       
        /// <summary>
        /// OpenSmitFile
        /// </summary>
        /// <param name="filename"></param>
        public static void OpenSmitFile(string filename)
        {
           
        }
        
    }

}
