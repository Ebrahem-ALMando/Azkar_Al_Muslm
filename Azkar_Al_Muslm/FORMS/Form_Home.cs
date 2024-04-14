using Azkar_Al_Muslm.CLASSES;
using Azkar_Al_Muslm.GUI;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azkar_Al_Muslm.FORMS
{
    public partial class Form_Home : DevExpress.XtraEditors.XtraForm
    {
        private Guna2Button currentButton = null;
        private Guna2Button previousButton = null;
        private readonly Cls_PageManager pageManager;

        Image oldImage = null;
        public Form_Home()
        {
            InitializeComponent();
            getDateNow();
            loadFirstTheme();
            pageManager = new Cls_PageManager(this);
            pageManager.LoadPage(UserCO_Home.Instance());

        }

        private void getDateNow() =>
            LBL_Date.Text=DateTime.Now.ToString("yyyy/MM/dd");

        private void TM_TimeNow_Tick(object sender, EventArgs e)
        {
            LBL_TimeNow.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
       
        private void loadFirstTheme()
        {
            currentButton = BTN_Home;
            currentButton.FillColor = Color.FromArgb(220, 180, 50);
            currentButton.Image = Properties.Resources.icons8_home_50px;
            currentButton.ForeColor = Color.White;
            currentButton.BorderColor = Color.FromArgb(238, 242, 210);
            /*currentButton.BorderThickness = 2;*/
            previousButton = currentButton;
        }
        private void setConfigButton(object button, Image image)
        {
            currentButton = (Guna2Button)button;
            Image imgOld = previousButton.Image;
            currentButton.Image = image;
            currentButton.ForeColor = Color.White;
            currentButton.BorderColor = Color.FromArgb(238, 242, 210);
            currentButton.FillColor = Color.FromArgb(220, 180, 50);
            if (previousButton != null && currentButton != previousButton)
            {
                previousButton.ForeColor = Color.FromArgb(246, 214, 112);
                previousButton.BorderColor = Color.FromArgb(239, 203, 16);
                previousButton.FillColor = Color.Transparent;

                switch (previousButton.Name)
                {
                    case "BTN_Home":
                        oldImage = Properties.Resources.icons8_home_50px_1;
                        break;
                    case "BTN_Setting":
                        oldImage = Properties.Resources.icons8_administrative_tools_50px_2;
                        break;
                    case "BTN_About":
                        oldImage = Properties.Resources.icons8_About_50px_2;
                        break;
                   
                }
                previousButton.Image = oldImage;
            }
            previousButton = currentButton;
        }

        private void BTN_Setting_Click(object sender, EventArgs e)
        {
            var image = Properties.Resources.icons8_administrative_tools_50px_1;
            setConfigButton(sender, image);
        
        }

        private void BTN_Home_Click(object sender, EventArgs e)
        {
            var image = Properties.Resources.icons8_home_50px;
            setConfigButton(sender, image);
            pageManager.LoadPage(UserCO_Home.Instance());
        }

        private void BTN_About_Click(object sender, EventArgs e)
        {
            var image = Properties.Resources.icons8_About_50px;
            setConfigButton(sender, image);
        }
    }
}