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
    }
}