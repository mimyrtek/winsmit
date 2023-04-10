using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace WinSmit
{
    public static class Util
    {
        /// <summary>

        /// Set up the tokens for each stanza

        /// </summary>

        private static ArrayList _tokens;

        public static ArrayList tokens
        {
            get
            {
                if (_tokens == null)
                {
                    //sm_menu_opt
                    _tokens = new ArrayList();
                    _tokens.Add("\tid =");
                    _tokens.Add("\tid_seq_num =");
                    _tokens.Add("\tnext_id =");
                    _tokens.Add("\ttext =");
                    _tokens.Add("\ttext_msg_file =");
                    _tokens.Add("\ttext_msg_set =");
                    _tokens.Add("\ttext_msg_id =");
                    _tokens.Add("\tnext_type =");
                    _tokens.Add("\talias =");
                    _tokens.Add("\thelp_msg_id =");
                    _tokens.Add("\thelp_msg_loc =");
                    _tokens.Add("\thelp_msg_base =");
                    _tokens.Add("\thelp_msg_book =");

                    //sm_cmd_hdr
                    _tokens.Add("\toption_id =");
                    _tokens.Add("\thas_name_select =");
                    _tokens.Add("\tname =");
                    _tokens.Add("\tname_msg_file =");
                    _tokens.Add("\tname_msg_set =");
                    _tokens.Add("\tname_msg_id =");
                    _tokens.Add("\tcmd_to_exec =");
                    _tokens.Add("\task =");
                    _tokens.Add("\texec_mode =");
                    _tokens.Add("\tghost =");
                    _tokens.Add("\tcmd_to_discover =");
                    _tokens.Add("\tcmd_to_discover_postfix =");
                    _tokens.Add("\tname_size =");
                    _tokens.Add("\tvalue_size =");
                    //sm_cmd_opt

                    _tokens.Add("\tdisc_field_name =");
                    _tokens.Add("\top_type =");
                    _tokens.Add("\tentry_type =");
                    _tokens.Add("\tentry_size =");
                    _tokens.Add("\trequired =");
                    _tokens.Add("\tprefix =");
                    _tokens.Add("\tcmd_to_list_mode =");
                    _tokens.Add("\tcmd_to_list =");
                    _tokens.Add("\tcmd_to_list_postfix =");
                    _tokens.Add("\tmulti_select =");
                    _tokens.Add("\tvalue_index =");
                    _tokens.Add("\tdisp_values =");
                    _tokens.Add("\tvalues_msg_file =");
                    _tokens.Add("\tvalues_msg_set =");
                    _tokens.Add("\tvalues_msg_id =");
                    _tokens.Add("\taix_values =");
                    //sm_name_hdr
                    _tokens.Add("\ttype =");
                    _tokens.Add("\tcmd_to_classify =");
                    _tokens.Add("\tcmd_to_classify_postfix =");
                    _tokens.Add("\traw_field_name =");
                    _tokens.Add("\tcooked_field_name =");
                    _tokens.Add("\tnext_type =");
                }
                return _tokens;
            }
        }
 
    }
}
