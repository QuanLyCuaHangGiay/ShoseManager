using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNet001.Core
{
    class ChangeForm
    {
        public ChangeForm()
        {

        }
        public void change(System.Windows.Forms.UserControl user)
        {
            user.Dock = DockStyle.Fill;
            Index.Indexs.panel.Controls.Add(user);
            foreach (System.Windows.Forms.UserControl item in Index.Indexs.panel.Controls.OfType<System.Windows.Forms.UserControl>())
            {
                Index.Indexs.panel.Controls.Remove(item);
            }
        }
        public void changeUC(System.Windows.Forms.UserControl user, Panel pnl)
        {
            foreach (System.Windows.Forms.UserControl item in pnl.Controls.OfType<System.Windows.Forms.UserControl>())
            {
                pnl.Controls.Remove(item);
            }
            user.Dock = DockStyle.Fill;
            pnl.Controls.Add(user);


        }
    }
}

