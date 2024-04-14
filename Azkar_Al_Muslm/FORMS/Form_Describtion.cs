using DevExpress.XtraEditors;
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
    public partial class Form_Description : DevExpress.XtraEditors.XtraForm
    {
        private string name;
        private string description;
        public Form_Description()
        {
            InitializeComponent();
            
        }
        public Form_Description(string name,string desc)
        {
            InitializeComponent();
            loadData(name, desc);


        }
        public void loadData(string name, string desc)
        {
            this.name = name;
            this.description = desc;
            LBL_Name.Text =$"\" {name} \" " ;
            RTB_DescName.Text = desc;

        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CopyDesc_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RTB_DescName.Text);
        }
    }
}