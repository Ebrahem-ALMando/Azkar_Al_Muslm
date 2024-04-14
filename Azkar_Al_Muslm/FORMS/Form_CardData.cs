using Azkar_Al_Muslm.CLASSES;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using Guna.UI2.Licensing.LightJson;
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
    public partial class Form_CardData : DevExpress.XtraEditors.XtraForm
    {
        
        private int id = 0;
        private string name = "";
        private string desc = "";
        private dynamic jsonObject;
        private int begin = 1;
        private int end = 10;
        public Form_CardData()
        {
            InitializeComponent();
        }
        public Form_CardData(dynamic jsonObject)
        {
            InitializeComponent();
            this.bunifuCards1.Visible = false;
            this.bunifuCards5.Visible = false;
            this.jsonObject = jsonObject;


            loadData(jsonObject, begin, end);

            loadNew();
        }

        public void loadData(dynamic jsonObject, int begin, int end)
        {
            for (int i = begin; i <= end; i++)
            {
                id = jsonObject[i].id;
                name = jsonObject[i].name;
                desc = jsonObject[i].text;
                CardData card = new CardData(id, name, desc);
                FLP_allCardData.Controls.Add(card.createCard()); // تم تغيير AddControl إلى Controls.Add
            }
        }
        public async void loadNew()
        {
            await Task.Delay(1000);
            begin = begin + 10;
            end = end + 40;
            loadData(jsonObject, begin, end);
           
            begin = begin + 40;
            end = end + 49;
            loadData(jsonObject, begin, end);

        }





        private void FLP_allCardData_Scroll(object sender, ScrollEventArgs e)
        {
            LBL_DescName.Text=e.NewValue.ToString();
            if (this.VerticalScroll.Value + this.VerticalScroll.LargeChange >= this.VerticalScroll.Maximum)
            {
             

            }
           
        }

       
    }
}