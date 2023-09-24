using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esDnevnik
{
    public class PromeniUC
    {
        public static void promeniUC(UserControl novaUC, Panel panel)
        {
            panel.Controls.Clear();
            panel.Controls.Add(novaUC);
            novaUC.Dock = DockStyle.Fill;
        }
    }
}
