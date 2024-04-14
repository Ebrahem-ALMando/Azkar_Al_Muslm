using Azkar_Al_Muslm.GUI;
using Azkar_Al_Muslm.Properties;
using Bunifu.Framework.UI;
using DevExpress.DXTemplateGallery.Extensions;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azkar_Al_Muslm.CLASSES
{
    internal class CardData
    {
        private Color colorCard = Color.FromArgb(135, 169, 20);
        private Color colorPanelTitle = Color.FromArgb(100, 169, 50);
        private Color colorBorderPanelTitle = Color.FromArgb(220, 180, 50);
        private Color colorPanelContent = Color.FromArgb(238, 242, 180);
        private Color colorBorderPanelContent = Color.FromArgb(135, 169, 20);
        private Color colorPanel_RTB = Color.FromArgb(238, 242, 180);
        private Color colorBorderPanel_RTB = Color.DarkGoldenrod;
        private Color colorPanelBTNCopy = Color.FromArgb(238, 242, 180);
        private Color colorBorderPanelBTNCopy = Color.FromArgb(100, 169, 50);
        private int id = 0;
        private string name = "";
        private string desc = "";
        public CardData() { }
        public CardData(int id,string name,string desc)
        { 
            this.id = id;
            this.name = name;
            this.desc = desc;
          
        
        }
        public BunifuCards createCard()
        {
            BunifuCards bunifuCards=new BunifuCards();
            bunifuCards.BackColor = Color.Goldenrod;
            bunifuCards.BorderRadius = 5;
            bunifuCards.BottomSahddow = true;
            bunifuCards.color = colorCard;
            bunifuCards.Controls.Add(createPanelTitle(id));
            bunifuCards.Controls.Add(createPanelContent(id));
            bunifuCards.LeftSahddow = true;
            bunifuCards.Name = $"bunifuCards{id}";
            bunifuCards.RightSahddow = true;
            bunifuCards.ShadowDepth = 20;
            bunifuCards.Size = new Size(528, 363);

            switch (id % 2)
            {
                case 0:
                    bunifuCards.Margin = new Padding(11,15,7,3);
                    break;
                case 1:
                    bunifuCards.Margin = new Padding(7, 15, 11, 3);
                    break;
            }

            return bunifuCards;
        }
       
        public void setConfigPanel(int id,Guna2Panel panel, Color borderColor
           ,Color fillColor,Size size,Point pointLoc,string name)
        {
            panel.BackColor = Color.Transparent;
            panel.BorderColor = borderColor;
            panel.FillColor = fillColor;
            panel.Size = size;
            panel.Location = pointLoc;
            panel.Name = name+id;
            panel.BorderRadius = 10;
            panel.BorderThickness = 3;
            panel.CustomizableEdges.BottomLeft = false;
            panel.CustomizableEdges.TopRight = false;
            
        }
        public Guna2Panel createPanelTitle(int id)
        {
            Guna2Panel panel = new Guna2Panel();
            setConfigPanel(id,panel, colorBorderPanelTitle, colorPanelTitle,
               new Size (496, 67),new Point (16, 16), "guna2PanelTitle");
            panel.Controls.Add(name != null ? createLableTitle(id) : null);
            return panel;
        }
        public Guna2Panel createPanelContent(int id)
        {
            Guna2Panel panel = new Guna2Panel();
            setConfigPanel(id, panel, colorBorderPanelContent, colorPanelContent,
                new Size(496, 258), new Point(16, 90), "guna2PanelContent");
            panel.Controls.Add(createPanel_RTB(id));
            panel.Controls.Add(createPanel_BTNCopy(id));
            return panel;
        }
        public Guna2Panel createPanel_RTB(int id)
        {
            Guna2Panel panel = new Guna2Panel();
            setConfigPanel(id, panel, colorBorderPanel_RTB, colorPanel_RTB,
                 new Size(460, 158), new Point(14,12), "guna2Panel_RTB");
            panel.Controls.Add(createTextBox(id));
            return panel;
        }
        public Guna2Panel createPanel_BTNCopy(int id)
        {
            Guna2Panel panel = new Guna2Panel();
            setConfigPanel(id, panel, colorBorderPanelBTNCopy, colorPanelBTNCopy,
                 new Size(460, 61), new Point(14,184), "guna2PanelBTNCopy");
            panel.Controls.Add(createBTNCopyDesc(id));
            return panel;
        }
        public Label createLableTitle(int id)
        {
            Label label = new Label();
            label.Font = new Font("El Messiri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(214)))), ((int)(((byte)(112)))));
            label.Location = new Point(86, 9);
            label.Name = $"label{id}";
            label.Size = new Size(369, 44);
            label.TabIndex = 5;
            label.Text = name;
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }
        public TextBox createTextBox(int id)
        {
            TextBox TextBox = new TextBox();
            TextBox.BackColor = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(170)))));
            TextBox.BorderStyle = BorderStyle.None;
            TextBox.Font = new Font("El Messiri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBox.ForeColor = Color.DarkGoldenrod;
            TextBox.Location = new Point(18, 10);
            TextBox.Name = $"TB_DescName{id}";


            TextBox.Text = desc;
            TextBox.ReadOnly = true;
            TextBox.Size = new Size(427, 138);
            TextBox.Multiline = true;
    

            return TextBox;
        }
    
        public Guna2CircleButton createBTNCopyDesc(int id)
        {
            Guna2CircleButton button = new Guna2CircleButton();
            button.Animated = true;
            button.AnimatedGIF = true;
            button.BackColor = System.Drawing.Color.Transparent;
            button.Cursor = System.Windows.Forms.Cursors.Hand;
            button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            button.FillColor = System.Drawing.Color.Transparent;
            button.Font = new System.Drawing.Font("Segoe UI", 9F);
            button.ForeColor = System.Drawing.Color.White;
            button.HoverState.FillColor = System.Drawing.Color.Transparent;
            button.HoverState.Image = global::Azkar_Al_Muslm.Properties.Resources.icons8_copy_50px;
            button.Image = global::Azkar_Al_Muslm.Properties.Resources.icons8_copy_50px_1;
            button.ImageSize = new System.Drawing.Size(50, 50);
            button.Location = new System.Drawing.Point(212, 3);
            button.Name = "BTN_CopyDesc";
            button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(169)))), ((int)(((byte)(50)))));
            button.PressedDepth = 100;
            button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            button.Size = new System.Drawing.Size(52, 52);
            button.TabIndex = 9;
            button.Tag = "";
            button.UseTransparentBackground = true;
            return button;
        }
    }
}
