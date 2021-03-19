using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNet001.Core
{
    class ChangeColor
    {
        public ChangeColor()
        {

        }
        public void ColorHover(object sender)
        {
            Panel pnl = (Panel)sender;
            pnl.BackColor = Color.FromArgb(211, 211, 211);
        }
        public void ColorNomal(object sender)
        {
            Panel pnl = (Panel)sender;
            if (pnl.Tag.ToString() == "1")
            {
                pnl.BackColor = Color.FromArgb(211, 211, 211);
            }
            else
            {
                pnl.BackColor = Color.FromArgb(169, 169, 169);
            }
        }
        public void ColorNomalLabel(object sender)
        {
            Label lb = (Label)sender;
            Panel pnl = (Panel)lb.Parent;
            if (pnl.Tag.ToString() == "1")
            {
                pnl.BackColor = Color.FromArgb(211, 211, 211);
            }
            else
            {
                pnl.BackColor = Color.FromArgb(169, 169, 169);
            }
        }
        public void ColorHoverLabel(object sender)
        {
            Label lb = (Label)sender;
            Panel pnl = (Panel)lb.Parent;
            pnl.BackColor = Color.FromArgb(211, 211, 211);
        }
        public void ColorClick(object sender)
        {
            Panel pnl = (Panel)sender;
            Panel pnlParent = (Panel)pnl.Parent;
            foreach (Panel item in pnlParent.Controls.OfType<Panel>())
            {
                item.Tag = 0;
                item.BackColor = pnl.BackColor = Color.FromArgb(169, 169, 169);
            }
            pnl.Tag = 1;
            pnl.BackColor = Color.FromArgb(211,211,211);
        }
        public void LabelClick(object sender)
        {
            Label lb = (Label)sender;
            Panel pnl = (Panel)lb.Parent;
            Panel pnlParent = (Panel)pnl.Parent;
            foreach (Panel item in pnlParent.Controls.OfType<Panel>())
            {
                item.Tag = 0;
                item.BackColor = pnl.BackColor = Color.FromArgb(169, 169, 169);
            }
            pnl.Tag = 1;
            pnl.BackColor = Color.FromArgb(211, 211, 211);
        }
    }
}

