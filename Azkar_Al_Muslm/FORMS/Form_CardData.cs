using Azkar_Al_Muslm.CLASSES;
using Bunifu.Framework.UI;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using Guna.UI2.Licensing.LightJson;
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
    public partial class Form_CardData : DevExpress.XtraEditors.XtraForm
    {
        
        private int id = 0;
        private string name = "";
        private string desc = "";
        private dynamic jsonObject;
        private int begin = 1;
        private int end = 9;
        CardData card;
        private bool isLoadAllData;
        private bool isLoadFirstData;
        private string typeLoadData="";
        private string txName;
        private string lbName;
        private string btnName;
        private int numPage=1;


        public Form_CardData()
        {
            InitializeComponent();
        }
        public Form_CardData(dynamic jsonObject)
        {
            InitializeComponent();
            this.bunifuCards1.Visible = false;
            this.bunifuCards5.Visible = false;
            

            configLoadGUI(jsonObject);
        }
    

        public async void configLoadGUI(dynamic jsonObject)
        {
            card= new CardData();
            this.jsonObject = jsonObject;
            cardWaite.Visible = true;
            FLP_allCardData.Visible = false;
            loadData(begin, end);

           /* await loadNew(); */
            await Task.Delay(1000);
            cardWaite.Visible = false;
            FLP_allCardData.Dock = DockStyle.Fill;
            FLP_allCardData.Visible = true;

        }
        public void configBTN_EN_DS()
        {
            isLoadAllData = end != 99;
            isLoadFirstData = begin != 1;
            BTN_nextData.Enabled = isLoadAllData;
            BTN_backData.Enabled = isLoadFirstData;
        }
        public void loadNextData()
        {
            if (end < 99)
            {
                begin += 9;
                end = Math.Min(begin + 8, 99);
            }
            typeLoadData = "Next";
            numPage++;
            loadData(begin, end);
         
          
        }

        public void loadBackData()
        {
            if (begin > 1)
            {
                begin -= 9;
                end = begin + 8;
            }
            else if (begin == 1)
            {
                begin = 1;
                end = 9;
            }
            typeLoadData = "Back";
            numPage--;
            loadData(begin, end);
           
        }
        public void loadData(int begin, int end)
        {
            configBTN_EN_DS();
         
            for (int i = begin; i <= end; i++)
            {
                id = jsonObject[i].id;
                name = jsonObject[i].name;
                desc = jsonObject[i].text;



                if (i >= 1 && i <= 9 && typeLoadData != "Back")
                {
            
                    card.setData(id, name, desc,this);
                    FLP_allCardData.Controls.Add(card.createCard());
                }
                else
                {
                    if (typeLoadData == "Next")
                    {
                         txName = $"TB_DescName{id - 9}";
                         lbName = $"label{id - 9}";
                         btnName= $"BTN_CopyDesc{id-9}";
                    }
                    else if (typeLoadData == "Back")
                    {
                         txName = $"TB_DescName{id + 9}";
                         lbName = $"label{id + 9}";
                         btnName = $"BTN_CopyDesc{id + 9}";
                    }
            
                    updateCardData(txName, lbName,btnName, id, name, desc);

                }
                LBL_pageNum.Text = $"{numPage}/11";

            }
        }
        private void updateCardData(string TXName,string LBName,string btnName, int id, string name, string desc)
        {
            Control controlTX = this.Controls.Find(TXName, true).FirstOrDefault();
            if (controlTX != null && controlTX is TextBox)
            {
               TextBox textBox = (TextBox)controlTX;
                textBox.Text = desc;
                textBox.Name = $"TB_DescName{id}";
            }
            Control controlLB = this.Controls.Find(LBName, true).FirstOrDefault();
            if (controlLB != null && controlLB is Label)
            {
                Label label = (Label)controlLB;
                label.Text = name;
                label.Name = $"label{id}";
            }
            Control controBTN = this.Controls.Find(btnName, true).FirstOrDefault();
            if (controBTN != null && controBTN is Guna2CircleButton)
            {
                Guna2CircleButton button = (Guna2CircleButton)controBTN;
                button.Name = $"BTN_CopyDesc{id}";
                button.Tag = desc;
            }
        }










        private void Form_CardData_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true; 

            this.Visible = false; 
        }

        private void BTN_nextData_Click(object sender, EventArgs e)
        {
            loadNextData();
        }

        private void BTN_backData_Click(object sender, EventArgs e)
        {
            loadBackData();
        }
    }
}