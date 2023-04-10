using System;
using System.Collections.Generic;
using System.Text;

namespace WinSmit
{
    class samples
    {
       

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    //get the ROOT node
        //    TreeNodeCollection tc = sm_menu_opt_treeView.Nodes;
        //    foreach (WinSmitTreeNode wtn in tc)
        //    {
        //        try
        //        {
        //            if (wtn.sm_menu_opt.id == "__ROOT__")
        //            {
        //                sm_menu_opt_treeView.Nodes.Remove(wtn);
        //                winsmitTreeView.Nodes.Add(wtn);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }
        //    // now we have the root node(s)
        //    CallRecursive(winsmitTreeView);
        //}

        //private void CallRecursive(WinSmitTreeView treeView)
        //{
        //    // loop the tree
        //    TreeNodeCollection nodes = treeView.Nodes;
        //    foreach (WinSmitTreeNode n in nodes)
        //    {
        //        findAllChildren(n);
        //        PrintRecursive(n);
        //    }
        //}

        //private void findAllChildren(WinSmitTreeNode currentNode)
        //{
        //    TreeNodeCollection tc = sm_menu_opt_treeView.Nodes;

        //    try
        //    {
        //        //iterate over the sm_menu_opt treeview
        //        foreach (WinSmitTreeNode wtn in tc)
        //        {
        //            // if we find a tree node with the id same as next id from 
        //            // current node we need to look for its children and then add
        //            // this node to the current node
        //            if (currentNode.sm_menu_opt.next_id == wtn.sm_menu_opt.id)
        //            {
        //                sm_menu_opt_treeView.Nodes.Remove(wtn);
        //                currentNode.Nodes.Add(wtn);
        //                //findAllChildren(wtn);
        //            }


        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}


        //private void PrintRecursive(WinSmitTreeNode treeNode)
        //{
        //    findAllNextIds(treeNode.sm_menu_opt.next_id, treeNode);

        //    foreach (WinSmitTreeNode tn in treeNode.Nodes)
        //    {
        //        PrintRecursive(tn);
        //    }
        //}

        //private void findAllNextIds(string p, WinSmitTreeNode currentnode)
        //{
        //    TreeNodeCollection tc = sm_menu_opt_treeView.Nodes;

        //    foreach (WinSmitTreeNode wtn in tc)
        //    {
        //        if (wtn.sm_menu_opt.id == p)
        //        {
        //            sm_menu_opt_treeView.Nodes.Remove(wtn);
        //            currentnode.Nodes.Add(wtn);
        //        }
        //    }


        //}


    }
}
