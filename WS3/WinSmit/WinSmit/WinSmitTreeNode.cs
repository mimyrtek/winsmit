using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace WinSmit
{
    [Serializable]
    class WinSmitTreeNode : System.Windows.Forms.TreeNode, ISerializable
    {
        public WinSmitTreeNode()
        {
        }

        public WinSmitTreeNode(sm_stanza sm)
        {
            if (sm.GetType().Name == "sm_menu_opt")
            {
                this.Text = ((sm_menu_opt)sm).text;
                this.sm_menu_opt = (sm_menu_opt)sm;
            }
            if (sm.GetType().Name == "sm_cmd_opt")
            {
                this.Text = ((sm_cmd_opt)sm).name;
                this.sm_cmd_opt = (sm_cmd_opt)sm;
            }
            if (sm.GetType().Name == "sm_name_hdr")
            {
                this.Text = ((sm_name_hdr)sm).name;
                this.sm_name_hdr = (sm_name_hdr)sm;
            }
            if (sm.GetType().Name == "sm_cmd_hdr")
            {
                this.Text = ((sm_cmd_hdr)sm).name;
                this.sm_cmd_hdr = (sm_cmd_hdr)sm;
            }
        }
        public WinSmitTreeNode(sm_cmd_hdr sm)
        {
            this.Text = sm.name;
            this.sm_cmd_hdr = sm;
        }
        public WinSmitTreeNode(sm_cmd_opt sm)
        {
            this.Text = sm.name;
            this.sm_cmd_opt = sm;
        }
        public WinSmitTreeNode(sm_name_hdr sm)
        {
            this.Text = sm.name;
            this.sm_name_hdr = sm;
        }
        public WinSmitTreeNode(sm_menu_opt sm)
        {
            this.Text = sm.text;
            this.sm_menu_opt = sm;
        }

        private bool _deleted;
        public bool deleted
        {
            get
            {
                return _deleted;

            }
            set
            {
                _deleted = value;
            }
        }

        private sm_menu_opt _sm_menu_opt;
        private sm_cmd_opt _sm_cmd_opt;
        private sm_name_hdr _sm_name_hdr;
        private sm_cmd_hdr _sm_cmd_hdr;
        private sm_menu_opt _sm_menu_opt_alias;

        public sm_stanza sm_stanza
        {
            get
            {
                if (this.sm_menu_opt != null)
                {
                    return sm_menu_opt;
                }
                else if (this.sm_cmd_opt != null)
                {
                    return sm_cmd_opt;
                }
                else if (this.sm_name_hdr != null)
                {
                    return sm_name_hdr;
                }
                else if (this.sm_cmd_hdr != null)
                {
                    return sm_cmd_hdr;
                }
                else
                {
                    return null;
                }

            }
        }


        public sm_menu_opt sm_menu_opt_alias
        {
            get
            {
                return _sm_menu_opt_alias;
            }
            set
            {
                _sm_menu_opt_alias = value;
            }

        }

        public sm_menu_opt sm_menu_opt
        {
            get
            {
                return _sm_menu_opt;
            }
            set
            {                
                _sm_menu_opt = value;
            }

        }
        public sm_cmd_opt sm_cmd_opt
        {
            get
            {
                return _sm_cmd_opt;
            }
            set
            {
                _sm_cmd_opt = value;
            }

        }
        public sm_name_hdr sm_name_hdr
        {
            get
            {
                return _sm_name_hdr;
            }
            set
            {
                _sm_name_hdr = value;
            }

        }
        public sm_cmd_hdr sm_cmd_hdr
        {
            get
            {
                return _sm_cmd_hdr;
            }
            set
            {
                _sm_cmd_hdr = value;
            }

        }




        public void Serialize(Stream stream, IFormatter formatter)
        {

            formatter.Serialize(stream, this);

        }
        public void Deserialize(Stream stream, IFormatter formatter)
        {
            WinSmitTreeNode temp = formatter.Deserialize(stream) as WinSmitTreeNode;
            //if (temp != null)
            //{
            //    // copy the nodes from the temp to our tree: 
            //    foreach (TreeNode node in temp.Nodes)
            //    {
            //        this.Nodes.Add(node.Clone() as TreeNode);
            //    }
            //}
        }


    }
}
