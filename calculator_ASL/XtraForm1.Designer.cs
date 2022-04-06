namespace calculator_ASL
{
    partial class XtraForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.SkinsLink = new DevExpress.XtraBars.BarLinkContainerItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.digital_clock = new System.Windows.Forms.Label();
            this.timer_clock = new System.Windows.Forms.Timer(this.components);
            this.button_clock_change = new DevExpress.XtraEditors.SimpleButton();
            this.label_color_clock = new System.Windows.Forms.Label();
            this.combo_color_clock = new DevExpress.XtraEditors.ComboBoxEdit();
            this.analog_clock_pic = new System.Windows.Forms.PictureBox();
            this.sec_pic = new System.Windows.Forms.PictureBox();
            this.minute_pic = new System.Windows.Forms.PictureBox();
            this.hour_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_color_clock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analog_clock_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barLinkContainerItem1,
            this.barSubItem1,
            this.SkinsLink});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Wygląd";
            this.barSubItem1.Id = 2;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.SkinsLink)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // SkinsLink
            // 
            this.SkinsLink.Caption = "Skins";
            this.SkinsLink.Id = 3;
            this.SkinsLink.Name = "SkinsLink";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1003, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 533);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1003, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 513);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1003, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 513);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Wybór Skórki";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barLinkContainerItem1
            // 
            this.barLinkContainerItem1.Caption = "Skórki";
            this.barLinkContainerItem1.Id = 1;
            this.barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // digital_clock
            // 
            this.digital_clock.AutoSize = true;
            this.digital_clock.Font = new System.Drawing.Font("Tahoma", 45F, System.Drawing.FontStyle.Bold);
            this.digital_clock.Location = new System.Drawing.Point(689, 163);
            this.digital_clock.Name = "digital_clock";
            this.digital_clock.Size = new System.Drawing.Size(302, 72);
            this.digital_clock.TabIndex = 4;
            this.digital_clock.Text = "00:00:00";
            // 
            // timer_clock
            // 
            this.timer_clock.Interval = 1000;
            this.timer_clock.Tick += new System.EventHandler(this.timer_clock_Tick);
            // 
            // button_clock_change
            // 
            this.button_clock_change.Location = new System.Drawing.Point(691, 366);
            this.button_clock_change.Name = "button_clock_change";
            this.button_clock_change.Size = new System.Drawing.Size(300, 23);
            this.button_clock_change.TabIndex = 5;
            this.button_clock_change.Text = "Zmien zegar na analogowy";
            this.button_clock_change.Click += new System.EventHandler(this.button_clock_change_Click);
            // 
            // label_color_clock
            // 
            this.label_color_clock.AutoSize = true;
            this.label_color_clock.Location = new System.Drawing.Point(688, 307);
            this.label_color_clock.Name = "label_color_clock";
            this.label_color_clock.Size = new System.Drawing.Size(110, 13);
            this.label_color_clock.TabIndex = 6;
            this.label_color_clock.Text = "Kolor czcionki zegara:";
            // 
            // combo_color_clock
            // 
            this.combo_color_clock.Location = new System.Drawing.Point(810, 304);
            this.combo_color_clock.MenuManager = this.barManager1;
            this.combo_color_clock.Name = "combo_color_clock";
            this.combo_color_clock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combo_color_clock.Properties.Items.AddRange(new object[] {
            "Czarny",
            "Czerwony",
            "Niebieski",
            "Bialy"});
            this.combo_color_clock.Size = new System.Drawing.Size(181, 20);
            this.combo_color_clock.TabIndex = 7;
            this.combo_color_clock.SelectedIndexChanged += new System.EventHandler(this.combo_color_clock_SelectedIndexChanged);
            // 
            // analog_clock_pic
            // 
            this.analog_clock_pic.BackColor = System.Drawing.Color.Transparent;
            this.analog_clock_pic.Location = new System.Drawing.Point(691, 60);
            this.analog_clock_pic.Name = "analog_clock_pic";
            this.analog_clock_pic.Size = new System.Drawing.Size(300, 300);
            this.analog_clock_pic.TabIndex = 12;
            this.analog_clock_pic.TabStop = false;
            this.analog_clock_pic.Visible = false;
            // 
            // sec_pic
            // 
            this.sec_pic.BackColor = System.Drawing.Color.Transparent;
            this.sec_pic.Location = new System.Drawing.Point(691, 60);
            this.sec_pic.Name = "sec_pic";
            this.sec_pic.Size = new System.Drawing.Size(300, 300);
            this.sec_pic.TabIndex = 13;
            this.sec_pic.TabStop = false;
            this.sec_pic.Visible = false;
            // 
            // minute_pic
            // 
            this.minute_pic.BackColor = System.Drawing.Color.Transparent;
            this.minute_pic.Location = new System.Drawing.Point(691, 60);
            this.minute_pic.Name = "minute_pic";
            this.minute_pic.Size = new System.Drawing.Size(300, 300);
            this.minute_pic.TabIndex = 14;
            this.minute_pic.TabStop = false;
            this.minute_pic.Visible = false;
            // 
            // hour_pic
            // 
            this.hour_pic.BackColor = System.Drawing.Color.Transparent;
            this.hour_pic.Location = new System.Drawing.Point(691, 60);
            this.hour_pic.Name = "hour_pic";
            this.hour_pic.Size = new System.Drawing.Size(300, 300);
            this.hour_pic.TabIndex = 15;
            this.hour_pic.TabStop = false;
            this.hour_pic.Visible = false;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 553);
            this.Controls.Add(this.hour_pic);
            this.Controls.Add(this.minute_pic);
            this.Controls.Add(this.sec_pic);
            this.Controls.Add(this.analog_clock_pic);
            this.Controls.Add(this.combo_color_clock);
            this.Controls.Add(this.label_color_clock);
            this.Controls.Add(this.button_clock_change);
            this.Controls.Add(this.digital_clock);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XtraForm1";
            this.Text = "Kalkulator z zegarem";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_color_clock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analog_clock_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarLinkContainerItem SkinsLink;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private System.Windows.Forms.Label digital_clock;
        private System.Windows.Forms.Timer timer_clock;
        private DevExpress.XtraEditors.ComboBoxEdit combo_color_clock;
        private System.Windows.Forms.Label label_color_clock;
        private DevExpress.XtraEditors.SimpleButton button_clock_change;
        private System.Windows.Forms.PictureBox analog_clock_pic;
        private System.Windows.Forms.PictureBox hour_pic;
        private System.Windows.Forms.PictureBox minute_pic;
        private System.Windows.Forms.PictureBox sec_pic;
    }
}