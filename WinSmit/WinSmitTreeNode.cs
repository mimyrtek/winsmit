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
        private sm_menu_opt _sm_menu_opt;
        public sm_menu_opt sm_menu_opt
        {
            get 
            {
                if(_sm_menu_opt==null)
                {
                    _sm_menu_opt = new sm_menu_opt();
                }
                return _sm_menu_opt;
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
