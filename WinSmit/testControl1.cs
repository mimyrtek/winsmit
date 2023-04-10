using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WinSmit
{
    public partial class testControl1 : UserControl
    {
        TreeNode mynode;
        public testControl1(TreeNode node,WSMain form)
        {
            InitializeComponent();
            mynode = node;
            
        }

        private void testControl1_Load(object sender, EventArgs e)
        {
            textBox1.Text = mynode.Text;
            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            mynode.Text = textBox1.Text;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
