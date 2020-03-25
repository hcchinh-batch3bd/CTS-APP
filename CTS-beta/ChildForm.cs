﻿using CTS_beta.Form_CTS;
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
        private static Form currentChildForm;
        public static void OpenChildForm(UserControl childForm, Panel panel)
        {
            if (!panel.Controls.ContainsKey(childForm.Name.ToString()))
            {
                
                childForm.Dock = DockStyle.Fill;
                panel.Controls.Add(childForm);
            }
            panel.Controls[childForm.Name.ToString()].BringToFront();
        }
    }
}
