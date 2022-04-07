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
        Double result_value = 0;
        Double memory = 0;
        String operation_performed = "";
        Boolean is_operation_performed = false;
        Boolean is_operation_simply_performed = false;
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
            this.KeyPreview = true;
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

        // 0-9 buttons and ,
        private void simpleButton_Click(object sender, EventArgs e)
        {
            if ((text_box.Text == "0") || (is_operation_performed))
            {
                text_box.Clear();
            }

            is_operation_performed = false;
            is_operation_simply_performed = false;
            SimpleButton button = (SimpleButton)sender;

            if (button.Text == ",")
            {
                if (!text_box.Text.Contains(","))
                {
                    text_box.Text = text_box.Text + button.Text;
                }
            }
            else
            {
                text_box.Text = text_box.Text + button.Text;
            }
        }

        // +, -, x, /, %, log_y, x^y, sqrt(x,y) operations
        private void simpleButton_click_operator(object sender, EventArgs e)
        {
            SimpleButton button = (SimpleButton)sender;

            if (result_value != 0 && !is_operation_simply_performed)
            {
                simpleButton_operator_action(sender, e);
                operation_performed = button.Text;
                is_operation_performed = true;
            }
            else if(result_value != 0 && is_operation_simply_performed)
            {
                operation_performed = button.Text;
                is_operation_simply_performed = false;
                is_operation_performed = true;
            }
            else
            {
                operation_performed = button.Text;
                result_value = Double.Parse(text_box.Text);
                is_operation_performed = true;
            }
        }

        //  AC button
        private void simpleButton39_Click(object sender, EventArgs e)
        {
            result_value = 0;
            text_box.Text = "0";
        }

        //  +/- button
        private void simpleButton36_Click(object sender, EventArgs e)
        {
            if (text_box.Text[0] == '-')
            {
                string temp = text_box.Text.Remove(0, 1);
                text_box.Text = temp;
            }
            else
            {
                if (text_box.Text != "0")
                {
                    string temp = this.text_box.Text.Insert(0, "-");
                    text_box.Text = temp;
                }
            }
        }

        // = operation
        private void simpleButton_operator_action(object sender, EventArgs e)
        {
            is_operation_simply_performed = true;
            switch (operation_performed)
            {
                case "+":
                    text_box.Text = (result_value + Double.Parse(text_box.Text)).ToString();
                    break;
                case "-":
                    text_box.Text = (result_value - Double.Parse(text_box.Text)).ToString();
                    break;
                case "*":
                    text_box.Text = (result_value * Double.Parse(text_box.Text)).ToString();
                    break;
                case "/":
                    text_box.Text = (result_value / Double.Parse(text_box.Text)).ToString();
                    break;
                case "%":
                    text_box.Text = (result_value % Double.Parse(text_box.Text)).ToString();
                    break;
                case "sqrt(x,y)":
                    text_box.Text = Math.Pow(result_value, 1 / Double.Parse(text_box.Text)).ToString();
                    break;
                case "log_y":
                    text_box.Text = Math.Log(result_value, Double.Parse(text_box.Text)).ToString();
                    break;
                case "x^y":
                    text_box.Text = Math.Pow(result_value, Double.Parse(text_box.Text)).ToString();
                    break;
                default:
                    break;
            }
            result_value = Double.Parse(text_box.Text);
        }

        private void simpleButton_click_operator_one_value(object sender, EventArgs e)
        {
            SimpleButton button = (SimpleButton)sender;

            operation_performed = button.Text;
            result_value = Double.Parse(text_box.Text);
            is_operation_performed = true;
            double radians = result_value * Math.PI / 180;

            switch (operation_performed)
            {
                case "10^x":
                    text_box.Text = Math.Pow(10, result_value).ToString();
                    break;
                case "e^x":
                    text_box.Text = Math.Pow(Math.E, result_value).ToString();
                    break;
                case "x^3":
                    text_box.Text = Math.Pow(result_value, 3).ToString();
                    break;
                case "x^2":
                    text_box.Text = Math.Pow(result_value, 2).ToString();
                    break;
                case "x!":
                    double n = result_value;
                    double res = 1;
                    while (n != 1)
                    {
                        res = res * n;
                        n = n - 1;
                    }
                    text_box.Text = res.ToString();
                    break;
                case "ln":
                    text_box.Text = Math.Log(result_value).ToString();
                    break;
                case "log_10":
                    text_box.Text = Math.Log(result_value, 10).ToString();
                    break;
                case "sqrt(x)":
                    text_box.Text = Math.Sqrt(result_value).ToString();
                    break;
                case "sqrt(x,3)":
                    text_box.Text = Math.Pow(result_value, 1.0 / 3.0).ToString();
                    break;
                case "e":
                    text_box.Text = Math.E.ToString();
                    break;
                case "Pi":
                    text_box.Text = Math.PI.ToString();
                    break;
                case "sin":
                    text_box.Text = Math.Sin(radians).ToString();
                    break;
                case "cos":
                    text_box.Text = Math.Cos(radians).ToString();
                    break;
                case "tan":
                    text_box.Text = Math.Tan(radians).ToString();
                    break;
                case "sinh":
                    text_box.Text = Math.Sinh(radians).ToString();
                    break;
                case "cosh":
                    text_box.Text = Math.Cosh(radians).ToString();
                    break;
                case "tanh":
                    text_box.Text = Math.Tanh(radians).ToString();
                    break;
                case "RAND":
                    Random rnd = new Random();
                    text_box.Text = rnd.Next().ToString();
                    break;
                default:
                    break;
            }
            result_value = Double.Parse(text_box.Text);
        }

        private void XtraForm1_KeyDown(object sender, KeyEventArgs e)
        { 
            switch (e.KeyCode)
            {
                case Keys.K:
                    simpleButton13.PerformClick();
                    break;
                case Keys.D2:
                    simpleButton12.PerformClick();
                    break;
                case Keys.D3:
                    simpleButton11.PerformClick();
                    break;
                case Keys.D4:
                    simpleButton16.PerformClick();
                    break;
                case Keys.D5:
                    simpleButton15.PerformClick();
                    break;
                case Keys.D6:
                    simpleButton14.PerformClick();
                    break;
                case Keys.D7:
                    simpleButton1.PerformClick();
                    break;
                case Keys.D8:
                    simpleButton18.PerformClick();
                    break;
                case Keys.D9:
                    simpleButton17.PerformClick();
                    break;
                case Keys.D0:
                    simpleButton10.PerformClick();
                    break;
            }
        }

        // MC
        private void simpleButton35_Click(object sender, EventArgs e)
        {
            memory = 0;
            is_operation_performed = true;
        }

        // M+
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            memory = memory + Double.Parse(text_box.Text);
            is_operation_performed = true;
        }

        // M-
        private void simpleButton27_Click(object sender, EventArgs e)
        {
            memory = memory - Double.Parse(text_box.Text);
            is_operation_performed = true;
        }

        // MR
        private void simpleButton34_Click(object sender, EventArgs e)
        {
            text_box.Text = memory.ToString();
            is_operation_performed = true;
        }

        // timer tick action (change time and rotation of image)
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

        // changing color of font digital clock
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

        // rotation of image
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