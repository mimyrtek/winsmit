using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WinSmit
{
    static class CreateScripts
    {
        private static String header = "#####################################################\n" +
                                "# Created by WinSmit\n" +
                                "# " + System.DateTime.Now.ToString() + " \n" +
                                "#####################################################\n" +
                                "#!/bin/ksh\n";
  

        public static void createRunScript(CurrentProject cp)
        {
            TextWriter tw = null;
            if (Directory.Exists(cp.Path+ "\\"+cp.Name))
            {
                string filename = "run_smitty.sh";
                if (MessageBox.Show("The file \n"+ filename+ "\nalready exists in\n " + cp.Path + "\\" + cp.Name+ "\n\nDo you want to overwrite the file?\n","WinSmit",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    // create a new run file
                    tw = new StreamWriter(cp.Path + "\\" + cp.Name + "\\" + filename);
                    tw.Write(header);
                    tw.Close();
                }
                else
                {
                    return; 
                }
                
            } 
            
            DirectoryInfo di = Directory.CreateDirectory(cp.Path+ "\\"+cp.Name);
            // create a new run file

            tw = new StreamWriter(cp.Path+ "\\"+cp.Name+"\\"+"run_smitty.sh");
            tw.Write(header);
            tw.Close();
        }
    }
}
