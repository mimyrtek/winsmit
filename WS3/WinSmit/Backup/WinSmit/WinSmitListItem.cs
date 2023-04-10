using System;
using System.Collections.Generic;
using System.Text;


namespace WinSmit
{
    class WinSmitListItem : System.Windows.Forms.ListViewItem
    {
        private sm_menu_opt _sm_menu_opt;
        public sm_menu_opt sm_menu_opt
        {
            get
            {
                if (_sm_menu_opt == null)
                {
                    _sm_menu_opt = new sm_menu_opt();
                }
                return _sm_menu_opt;
            }
            set
            {
                _sm_menu_opt = value;

            }

        }
    }
}
