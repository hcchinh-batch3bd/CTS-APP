using CTS_beta.Form_CTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTS_beta
{
    class ChildForm
    {
        public static void OpenChildForm(UserControl childForm, Panel panel)
        {
            if (!panel.Controls.ContainsKey(childForm.Name.ToString()))
            {
                
                childForm.Dock = DockStyle.Fill;
                if (!panel.InvokeRequired)
                    panel.Controls.Add(childForm);
                else
                    panel.Invoke(new Action(() => panel.Controls.Add(childForm)));
            }
            if (!panel.InvokeRequired)
                panel.Controls[childForm.Name.ToString()].BringToFront();
            else
                panel.Invoke(new Action(() => panel.Controls[childForm.Name.ToString()].BringToFront()));
        }
    }
}
