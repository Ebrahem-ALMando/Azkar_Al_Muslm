using Azkar_Al_Muslm.FORMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azkar_Al_Muslm.CLASSES
{
    internal class Cls_PageManager
    {
        private readonly Form_Home home;
        /*private readonly Form_Settings settings;*/
        public Cls_PageManager(Form_Home home)
        {
            this.home = home;
        }
        /*  public Cls_PageManager(Form_Settings settings)
          {
              this.settings = settings;
          }*/
        public void LoadPage(UserControl PageUserControl)
        {
            //==>  Load old page
            var oldpage = home.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldpage != null)
            {
                home.panelContainer.Controls.Remove(oldpage);
                //==> Remove To memory 
                oldpage.Dispose();
            }
            //==> Load New Page
            PageUserControl.Dock = DockStyle.Fill;
            home.panelContainer.Controls.Add(PageUserControl);
        }
    }
}
