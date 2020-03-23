using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTS_beta
{
    class ShowMenu
    {
        public static void customizeDesing(Panel panel)
        {
            panel.Visible = false;
        }

        public static void hideSubMenu(Panel panel)
        {
            if (panel.Visible == true)
            {
                panel.Visible = false;
            }
        }

        public static void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu(subMenu);
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
    }
}
