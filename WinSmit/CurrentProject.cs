using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WinSmit
{

    [Serializable]

    public class CurrentProject
    {
        //****************************
        private string _name;
        [DescriptionAttribute(), CategoryAttribute("Project"), ReadOnlyAttribute(true)]
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
/// <summary>
/// 
/// </summary>
        private string _location;
        [DescriptionAttribute(), CategoryAttribute("Project"), ReadOnlyAttribute(true)]
        public string Path
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private string _name_projectTree;
        [DescriptionAttribute(), CategoryAttribute("Project"), ReadOnlyAttribute(true)]
        public string name_projectTree
        {
            get
            {
                return _name_projectTree;
            }
            set
            {
                _name_projectTree = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// 
        
        private string _name_winsmitTree;
        [DescriptionAttribute(), CategoryAttribute("Project"), ReadOnlyAttribute(true)]
        public string name_winsmitTree
        {
            get
            {
                return _name_winsmitTree;
            }
            set
            {
                _name_winsmitTree = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// 
        
        private string _projectFile;
        [DescriptionAttribute(), CategoryAttribute("Project"), ReadOnlyAttribute(true)]
        public string projectFile
        {
            get
            {
                return _projectFile;
            }
            set
            {
                _projectFile = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// 
        private string _odmdir;
        [DescriptionAttribute(), CategoryAttribute("AIX ODM config"), ReadOnlyAttribute(false)]
        public string odmdir
        {
            get
            {
                return _odmdir;
            }
            set
            {
                _odmdir = value;

                 }
        }


    }
}
