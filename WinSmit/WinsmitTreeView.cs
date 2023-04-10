using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace WinSmit
{

    /// <summary>
    /// Summary description for SerializableTreeView.
    /// </summary> 
    /// 
    [Serializable]
    public class WinSmitTreeView : TreeView, ISerializable
    {

        public WinSmitTreeView()
            : base()
        { }

        public WinSmitTreeView(SerializationInfo info, StreamingContext context)
            : this()
        {

            SerializationInfoEnumerator infoEnumerator = info.GetEnumerator();
            while (infoEnumerator.MoveNext())
            {

                TreeNode node = info.GetValue(infoEnumerator.Name, infoEnumerator.ObjectType) as TreeNode;
                if (node != null)
                {

                    this.Nodes.Add(node);

                }

            }

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            foreach (TreeNode node in this.Nodes)
                {

                    info.AddValue(System.Guid.NewGuid().ToString(), node);

                }
        }

        /// <summary> 
        /// Serialize all the nodes of this tree to the stream provided, using the formatter provided. 
        /// </summary> 
        /// <param name="stream">The stream to serialize to.</param> 
        /// <param name="formatter">The formatter used to serialize.</param> 
        public void Serialize(Stream stream, IFormatter formatter)
        {

            formatter.Serialize(stream, this);

        }

        /// <summary> 
        /// Recreate this tree from a serialized version. 
        /// </summary> 
        /// <param name="stream">the stream that contains the serialized tree.</param> 
        /// <param name="formatter">the formatter used to desrialize the stream.</param> 
        public void Deserialize(Stream stream, IFormatter formatter)
        {

            // Clear our tree: 
            this.Nodes.Clear();
            WinSmitTreeView temp = formatter.Deserialize(stream) as WinSmitTreeView;
            if (temp != null)
            {

                // copy the nodes from the temp to our tree: 
                foreach (TreeNode node in temp.Nodes)
                {
                    this.Nodes.Add(node.Clone() as TreeNode);
                }

            }

        }

    }

}

