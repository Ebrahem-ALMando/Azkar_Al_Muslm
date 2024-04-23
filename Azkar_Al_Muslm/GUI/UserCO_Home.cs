using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native.WebClientUIControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using DevExpress.DataProcessing.ExtractStorage;
using Azkar_Al_Muslm.FORMS;

namespace Azkar_Al_Muslm.GUI
{
    public partial class UserCO_Home : DevExpress.XtraEditors.XtraUserControl
    {
        private static UserCO_Home homeUserControl;
        string azkarSabah = "من فوائدها انشراح الصدر وطمأنينة القلب ومعية الله تعالى وذكره للعبد في الملأ الأعلى قال الله تعالى: الَّذِينَ آمَنُواْ وَتَطْمَئِنُّ قُلُوبُهُم بِذِكْرِ اللّهِ أَلاَ بِذِكْرِ اللّهِ تَطْمَئِنُّ الْقُلُوبُ.{الرعد:28}.\r\nوقال رسول الله صلى الله عليه وسلم: يقول الله عز وجل أنا عند ظن عبدي بي، وأنا معه حين يذكرني إن ذكرني في نفسه ذكرته في نفسي، وإن ذكرني في ملأ ذكرته في ملأ هم خير منهم. الحديث رواه مسلم وغيره.";
        string azkarMassa = "قال الله تعالى: (فَاذْكُرُونِي أَذْكُرْكُمْ وَاشْكُرُوا لِي وَلَا تَكْفُرُونِ) [البقرة: 152]، أمر الله تعالى عباده بذكره، فذكر الله تعالى عبادةٌ عظيمة وسهلة، فهي لا تحتاج لبذل مجهودٍ ، إنّما هي تحريك اللسان مع حضور القلب والعقل، أجرها عظيمٌ وفوائدها جمّة، تعود فائدتها على العبد في الدنيا والآخرة، وقتها مطلقٌ بإمكان العبد ذكر ربه في كلّ حال، ولكن هناك أذكارٌ مخصوصةٌ بوقت معين وعددٍ معين، كأذكار الصباح والمساء والتي لها من الفضل والبركة ما لا يدركه إلّا من داوم عليها.";
        private int fontSize = 12;
        private bool enlarging = true;
        private bool delayActive = false;
        private int id = -1;
        private string name;
        private string desc;
        int num = 0;
        private dynamic jsonObject;
        private Random random;
        private Form_CardData cardData = null;
        public UserCO_Home()

        {
            InitializeComponent();
            RTB_AzkarSabah.Text = azkarSabah;
            RTB_AzkarMassa.Text = azkarMassa;
            readFileNameAllah();
          
        }
        public static UserCO_Home Instance()
        {
            //==> Freeing resources and not cloning more than once
            return homeUserControl ?? (new UserCO_Home());
        }
        public void readFileNameAllah()
        {
            try
            {
                string jsonString = Encoding.UTF8.GetString(Properties.Resources.Names_Of_Allah);

               //Conver Json File To Object In C# 
                jsonObject = JsonConvert.DeserializeObject(jsonString);
                nextName(jsonObject);
            }
            catch (Exception ex)
            {
               MessageBox.Show("حدث خطأ: " + ex.Message);
            }
        }
        public void nextName(dynamic jsonObject)
        {
            if(num <=99) 
            {
                id = jsonObject[num].id;
                name = jsonObject[num].name;
                desc = jsonObject[num].text;
                num++;
            }
            else
            {
                num = 0;
                nextName(jsonObject);
                /*int seed = (int)DateTime.Now.Ticks;
                random = new Random(seed);*/
                /*num = random.Next(100);*/


            }
            LBL_NameAllah.Text = name;


        }
/*        public void splitName(string name,int numChar)
        {
            LBL_NameAllah.Text = "";
            if (numChar == 0 )
            {
                for (int i = 0; i < name.Length; i++)
                {
                    LBL_NameAllah.Text += name[i];
                    
                }
            }
            else
            {
            *//*    for (int i = name.Length; i >= 0; i--)
                {
                    LBL_NameAllah.Text += name[i];
                    Task.Delay(50);
                }*//*
            }
          
        }*/
        private  void TM_NameAllah_Tick(object sender, EventArgs e)
        {
           nextName(jsonObject);
         /*   if (!delayActive)
            {
                if (enlarging)
                {
                    fontSize += 1;
                    if (fontSize >= 13) // الحجم الأقصى
                    {
                        enlarging = false;
                        delayActive = true;
                        await Task.Delay(5000);
                        delayActive = false;
                    }
                }
                else
                {
                    fontSize -= 1;
                    if (fontSize <= 10) // الحجم الأدنى
                    {
                        enlarging = true;
                        delayActive = true;
                        await Task.Delay(5000);
                        delayActive = false;
                    }
                }

                // تحديث حجم الخط لـ Label
                LBL_NameAllah.Font = new Font(LBL_NameAllah.Font.FontFamily, fontSize);*/
            }

        private void BTN_NextName_Click(object sender, EventArgs e)
        {
            nextName(jsonObject);
            TM_NameAllah.Stop();
            TM_NameAllah.Start();
        }

        private void BTN_DescriptionName_Click(object sender, EventArgs e)
        {
            if (name != ""&& desc!="")
            {
                Form_Description form_Description = new Form_Description(name,desc);
                TM_NameAllah.Stop();
                form_Description.ShowDialog();
                TM_NameAllah.Start();

            }
        }

        private void BTN_allNames_Click(object sender, EventArgs e)
        {

          

          

            if (cardData == null || cardData.IsDisposed)
            {
                cardData = new Form_CardData(jsonObject);
            }

            if (!cardData.Visible)
            {
                cardData.Visible = true;
                cardData.FLP_allCardData.AutoScrollPosition=new Point(0,0);
            }
        }
    }
    }

