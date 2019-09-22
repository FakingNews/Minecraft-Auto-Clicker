namespace Notepad.exe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnDSC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Close = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHotkey = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHotkeyRemove = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidePanel.BackgroundImage")));
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidePanel.Controls.Add(this.btnDSC);
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.sidePanel.GradientBottomRight = System.Drawing.Color.MediumBlue;
            this.sidePanel.GradientTopLeft = System.Drawing.Color.MidnightBlue;
            this.sidePanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Quality = 10;
            this.sidePanel.Size = new System.Drawing.Size(163, 214);
            this.sidePanel.TabIndex = 1;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // btnDSC
            // 
            this.btnDSC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.btnDSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.btnDSC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDSC.BorderRadius = 0;
            this.btnDSC.ButtonText = "  Self Destruct";
            this.btnDSC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDSC.DisabledColor = System.Drawing.Color.Gray;
            this.btnDSC.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDSC.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDSC.Iconimage")));
            this.btnDSC.Iconimage_right = null;
            this.btnDSC.Iconimage_right_Selected = null;
            this.btnDSC.Iconimage_Selected = null;
            this.btnDSC.IconMarginLeft = 0;
            this.btnDSC.IconMarginRight = 0;
            this.btnDSC.IconRightVisible = true;
            this.btnDSC.IconRightZoom = 0D;
            this.btnDSC.IconVisible = true;
            this.btnDSC.IconZoom = 60D;
            this.btnDSC.IsTab = true;
            this.btnDSC.Location = new System.Drawing.Point(3, 158);
            this.btnDSC.Name = "btnDSC";
            this.btnDSC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.btnDSC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.btnDSC.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDSC.selected = false;
            this.btnDSC.Size = new System.Drawing.Size(157, 53);
            this.btnDSC.TabIndex = 6;
            this.btnDSC.Text = "  Self Destruct";
            this.btnDSC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSC.Textcolor = System.Drawing.Color.White;
            this.btnDSC.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Notepad.exe.Properties.Resources.grim;
            this.pictureBox1.Location = new System.Drawing.Point(3, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topPanel.BackgroundImage")));
            this.topPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topPanel.Controls.Add(this.bunifuFlatButton1);
            this.topPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.topPanel.GradientBottomRight = System.Drawing.Color.MediumBlue;
            this.topPanel.GradientTopLeft = System.Drawing.Color.MidnightBlue;
            this.topPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.topPanel.Location = new System.Drawing.Point(0, -1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Quality = 10;
            this.topPanel.Size = new System.Drawing.Size(429, 25);
            this.topPanel.TabIndex = 2;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "X";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(395, -10);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(39, 45);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "X";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // Close
            // 
            this.Close.Activecolor = System.Drawing.Color.Transparent;
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.BorderRadius = 0;
            this.Close.ButtonText = "X";
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.DisabledColor = System.Drawing.Color.Transparent;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Iconcolor = System.Drawing.Color.Transparent;
            this.Close.Iconimage = ((System.Drawing.Image)(resources.GetObject("Close.Iconimage")));
            this.Close.Iconimage_right = null;
            this.Close.Iconimage_right_Selected = null;
            this.Close.Iconimage_Selected = null;
            this.Close.IconMarginLeft = 0;
            this.Close.IconMarginRight = 0;
            this.Close.IconRightVisible = true;
            this.Close.IconRightZoom = 0D;
            this.Close.IconVisible = true;
            this.Close.IconZoom = 0D;
            this.Close.IsTab = false;
            this.Close.Location = new System.Drawing.Point(1829, 800);
            this.Close.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.Close.Name = "Close";
            this.Close.Normalcolor = System.Drawing.Color.Transparent;
            this.Close.OnHovercolor = System.Drawing.Color.Transparent;
            this.Close.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.Close.selected = false;
            this.Close.Size = new System.Drawing.Size(611, 203);
            this.Close.TabIndex = 3;
            this.Close.Text = "X";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close.Textcolor = System.Drawing.Color.White;
            this.Close.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.MidnightBlue;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.bunifuSlider1.Location = new System.Drawing.Point(173, 73);
            this.bunifuSlider1.MaximumValue = 20;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(245, 30);
            this.bunifuSlider1.TabIndex = 4;
            this.bunifuSlider1.Value = 0;
            this.bunifuSlider1.ValueChanged += new System.EventHandler(this.BunifuSlider1_ValueChanged);
            this.bunifuSlider1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BunifuSlider1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(398, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(248, 105);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(274, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Randomizer";
            // 
            // txtHotkey
            // 
            this.txtHotkey.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.txtHotkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.txtHotkey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtHotkey.BorderRadius = 0;
            this.txtHotkey.ButtonText = "Custom Key";
            this.txtHotkey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtHotkey.DisabledColor = System.Drawing.Color.Gray;
            this.txtHotkey.Iconcolor = System.Drawing.Color.Transparent;
            this.txtHotkey.Iconimage = null;
            this.txtHotkey.Iconimage_right = null;
            this.txtHotkey.Iconimage_right_Selected = null;
            this.txtHotkey.Iconimage_Selected = null;
            this.txtHotkey.IconMarginLeft = 0;
            this.txtHotkey.IconMarginRight = 0;
            this.txtHotkey.IconRightVisible = true;
            this.txtHotkey.IconRightZoom = 0D;
            this.txtHotkey.IconVisible = true;
            this.txtHotkey.IconZoom = 60D;
            this.txtHotkey.IsTab = true;
            this.txtHotkey.Location = new System.Drawing.Point(173, 131);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.txtHotkey.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.txtHotkey.OnHoverTextColor = System.Drawing.Color.White;
            this.txtHotkey.selected = false;
            this.txtHotkey.Size = new System.Drawing.Size(114, 34);
            this.txtHotkey.TabIndex = 7;
            this.txtHotkey.Text = "Custom Key";
            this.txtHotkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtHotkey.Textcolor = System.Drawing.Color.White;
            this.txtHotkey.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtHotkey.Click += new System.EventHandler(this.TxtHotkey_Click);
            // 
            // btnHotkeyRemove
            // 
            this.btnHotkeyRemove.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.btnHotkeyRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.btnHotkeyRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHotkeyRemove.BorderRadius = 0;
            this.btnHotkeyRemove.ButtonText = "Clear Key";
            this.btnHotkeyRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotkeyRemove.DisabledColor = System.Drawing.Color.Gray;
            this.btnHotkeyRemove.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHotkeyRemove.Iconimage = null;
            this.btnHotkeyRemove.Iconimage_right = null;
            this.btnHotkeyRemove.Iconimage_right_Selected = null;
            this.btnHotkeyRemove.Iconimage_Selected = null;
            this.btnHotkeyRemove.IconMarginLeft = 0;
            this.btnHotkeyRemove.IconMarginRight = 0;
            this.btnHotkeyRemove.IconRightVisible = true;
            this.btnHotkeyRemove.IconRightZoom = 0D;
            this.btnHotkeyRemove.IconVisible = true;
            this.btnHotkeyRemove.IconZoom = 60D;
            this.btnHotkeyRemove.IsTab = true;
            this.btnHotkeyRemove.Location = new System.Drawing.Point(304, 131);
            this.btnHotkeyRemove.Name = "btnHotkeyRemove";
            this.btnHotkeyRemove.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.btnHotkeyRemove.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(72)))), ((int)(((byte)(123)))));
            this.btnHotkeyRemove.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHotkeyRemove.selected = false;
            this.btnHotkeyRemove.Size = new System.Drawing.Size(114, 34);
            this.btnHotkeyRemove.TabIndex = 10;
            this.btnHotkeyRemove.Text = "Clear Key";
            this.btnHotkeyRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHotkeyRemove.Textcolor = System.Drawing.Color.White;
            this.btnHotkeyRemove.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(426, 217);
            this.Controls.Add(this.btnHotkeyRemove);
            this.Controls.Add(this.txtHotkey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSlider1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel sidePanel;
        private Bunifu.Framework.UI.BunifuGradientPanel topPanel;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDSC;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton txtHotkey;
        private Bunifu.Framework.UI.BunifuFlatButton btnHotkeyRemove;
    }
}

