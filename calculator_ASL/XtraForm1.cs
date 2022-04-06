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
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(SkinsLink);
            timer_clock.Start();
        }

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            digital_clock.Text = DateTime.Now.ToString("T");
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
    }
}