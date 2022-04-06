using DevExpress.XtraBars.Helpers;
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

namespace calculator_ASL
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        Bitmap back, hour, minute, second;
        public XtraForm1()
        {
            InitializeComponent();

            back = new Bitmap(".\\clock.png");
            hour = new Bitmap(".\\hour.png");
            minute = new Bitmap(".\\minute.png");
            second = new Bitmap(".\\second.png");
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(SkinsLink);
            timer_clock.Start();
        }

        private void button_clock_change_Click(object sender, EventArgs e)
        {
            if (digital_clock.Visible)
            {
                sec_pic.Visible = true;
                minute_pic.Visible = true;
                hour_pic.Visible = true;
                analog_clock_pic.Visible = true;
                digital_clock.Visible = false;
                label_color_clock.Visible = false;
                combo_color_clock.Visible = false;
                button_clock_change.Text = "Zmien zegar na cyfrowy";
            }
            else
            {
                sec_pic.Visible = false;
                minute_pic.Visible = false;
                hour_pic.Visible = false;
                analog_clock_pic.Visible = false;
                digital_clock.Visible = true;
                label_color_clock.Visible = true;
                combo_color_clock.Visible = true;
                button_clock_change.Text = "Zmien zegar na analogowy";
            }
        }

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            digital_clock.Text = DateTime.Now.ToString("T");
            
            DateTime Now = DateTime.Now;
            int Hour = Now.Hour;
            int Minute = Now.Minute;
            int Second = Now.Second;

            Single angleS = Second * 6;
            Single angleM = Minute * 6 + angleS / 60;
            Single angleH = Hour * 30 + angleM / 12;


            analog_clock_pic.Image = back;

            analog_clock_pic.Controls.Add(hour_pic);
            hour_pic.Location = new Point(0, 0);
            hour_pic.Image = rotateImage(hour, angleH);

            hour_pic.Controls.Add(minute_pic);
            minute_pic.Location = new Point(0, 0);
            minute_pic.Image = rotateImage(minute, angleM);

            minute_pic.Controls.Add(sec_pic);
            sec_pic.Location = new Point(0, 0);
            sec_pic.Image = rotateImage(second, angleS);
        }

        private void combo_color_clock_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = combo_color_clock.SelectedIndex;
            switch (selected)
            {
                case 0:
                    digital_clock.ForeColor = System.Drawing.Color.Black;
                    break;
                case 1:
                    digital_clock.ForeColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    digital_clock.ForeColor = System.Drawing.Color.Blue;
                    break;
                case 3:
                    digital_clock.ForeColor = System.Drawing.Color.White;
                    break;
            }
        }

        private Bitmap rotateImage(Bitmap roteteMe, float angle)
        {
            Bitmap rotetedImage = new Bitmap(roteteMe.Width, roteteMe.Height);

            using (Graphics g = Graphics.FromImage(rotetedImage))
            {
                g.TranslateTransform(roteteMe.Width / 2, roteteMe.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-roteteMe.Width / 2, -roteteMe.Height / 2);
                g.DrawImage(roteteMe, new Point(0, 0));
            }

            return rotetedImage;
        }
    }
}