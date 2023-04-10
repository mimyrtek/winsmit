using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing.Design;

namespace WinSmitV3
{
    

    [Serializable]
    class Project
    {
        //private variables
        private string _name;
        private string _path;
        private string _Solution_Name;

        //****************************
        //implementation
        //****************************
        [DescriptionAttribute("Project Name"), CategoryAttribute("Project")]
        public string Name
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
        //****************************
       
        [DescriptionAttribute("Work directory"), CategoryAttribute("Project")]
        public string Directory
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }
        //****************************

        [DescriptionAttribute("Solution Name"), CategoryAttribute("Project")]
        public string Solution_Name
        {
            get
            {
                return _Solution_Name;
            }
            set
            {
                _Solution_Name = value;
            }
        }
        //****************************

      

    }
}
