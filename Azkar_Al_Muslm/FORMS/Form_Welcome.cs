using Azkar_Al_Muslm.FORMS;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Azkar_Al_Muslm
{
    public partial class Form_Welcome : DevExpress.XtraEditors.XtraForm
    {
        private string text = "استغفر الله العظيم . . . ";
        private int displayCount = 0;
        private int currentIndex = 0; 
        private int totalDisplayCount = 1000; // عدد المرات التي ترغب في عرض النص فيها
        public Form_Welcome()
        {
            InitializeComponent();
            WE_Progressbar.Value = 0;
            LB_astghfar.Text = "";
            BTN_Cont.Visible = false;
         
        }

       public void startPrograss()
        {
            if (WE_Progressbar.Value >= 0 && WE_Progressbar.Value < 100)
            {
                TM_Prograss.Start();
                WE_Progressbar.Value += 1;

            }
            else
            {
                TM_Prograss.Stop();
                BTN_Cont.Visible = true;
            }
      
        }
        public void startText()
        {

            if (displayCount < totalDisplayCount)
            {
                if (currentIndex < text.Length)
                {
                    LB_astghfar.Text += text[currentIndex]; // عرض الحرف الحالي
                    currentIndex++; // زيادة المؤشر للانتقال إلى الحرف التالي
                }
                else
                {
                    currentIndex = 0;
                    displayCount++; // زيادة عدد مرات العرض بمجرد انتهاء النص
                    LB_astghfar.Text = "";
      
                }
            }
            else
            {
                TM_Text.Stop(); // إيقاف التوقيت بعد الانتهاء من عرض النص في العدد المطلوب من المرات
        
            }



        }
        private void TM_Text_Tick(object sender, EventArgs e)
        {
            startText();
        }
        private void TM_Prograss_Tick(object sender, EventArgs e)
        {
            startPrograss();
        }

        private void BTN_Cont_Click(object sender, EventArgs e)
        {
           
          /*  string[] lines = Properties.Resources.Azkar.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                MessageBox.Show(line); // عرض كل سطر في MessageBox
                Console.WriteLine(line); // طباعة كل سطر في الإخراج (Output)
            }*/

            Form_Home _Home = new Form_Home();
            _Home.ShowDialog();
            this.Close();

            /* try
             {
                 // فتح مفتاح التسجيل للكتابة
                 using (RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run"))
                 {
                     // تعيين القيمة لتطبيقك في التسجيل
                     reg.SetValue("MyApplication", Application.ExecutablePath);
                 }
                 MessageBox.Show("تم حفظ الإعداد بنجاح.");
             }
             catch (Exception ex)
             {
                 MessageBox.Show("حدث خطأ: " + ex.Message);
             }*/
        }
    }
}
