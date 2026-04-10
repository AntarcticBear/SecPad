using Microsoft.VisualBasic.ApplicationServices;

namespace SecPad
{
    partial class SecPad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelTop = new Panel();
            LbLArw = new Label();
            BtnFontSel = new Button();
            ButtonExit = new Button();
            PanelBottom = new Panel();
            label1 = new Label();
            PanelFields = new Panel();
            BtnCpyApp = new Button();
            BtnApyFld3 = new Button();
            BtnCpyFld3 = new Button();
            TxtBoxFld3 = new TextBox();
            BtnApyFld2 = new Button();
            BtnCpyFld2 = new Button();
            TxtBoxFld2 = new TextBox();
            BtnApyFld1 = new Button();
            BtnCpyFld1 = new Button();
            TxtBoxFld1 = new TextBox();
            BtnApyMail = new Button();
            BtnCpyMail = new Button();
            TxtBoxMail = new TextBox();
            BtnApyPass = new Button();
            BtnCpyPass = new Button();
            TxtBoxPass = new TextBox();
            BtnApyID = new Button();
            BtnCpyID = new Button();
            TxtBoxID = new TextBox();
            BtnApyURL = new Button();
            BtnCpyURL = new Button();
            TxtBoxURL = new TextBox();
            BtnApyApp = new Button();
            TxtBoxApp = new TextBox();
            PanelTextArea = new Panel();
            TextArea = new TextBox();
            PnlTxtBtns = new Panel();
            BtnClr = new Button();
            BtnCut = new Button();
            BtnPst = new Button();
            BtnCpy = new Button();
            PanelTop.SuspendLayout();
            PanelBottom.SuspendLayout();
            PanelFields.SuspendLayout();
            PanelTextArea.SuspendLayout();
            PnlTxtBtns.SuspendLayout();
            SuspendLayout();
            // 
            // PanelTop
            // 
            PanelTop.AutoScroll = true;
            PanelTop.Controls.Add(LbLArw);
            PanelTop.Controls.Add(BtnFontSel);
            PanelTop.Controls.Add(ButtonExit);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Padding = new Padding(10, 5, 16, 5);
            PanelTop.Size = new Size(1087, 43);
            PanelTop.TabIndex = 0;
            // 
            // LbLArw
            // 
            LbLArw.AutoSize = true;
            LbLArw.Font = new Font("Yu Gothic UI", 12F);
            LbLArw.Location = new Point(345, 7);
            LbLArw.Name = "LbLArw";
            LbLArw.Size = new Size(32, 28);
            LbLArw.TabIndex = 2;
            LbLArw.Text = "▼";
            LbLArw.Click += LbLArw_Click;
            // 
            // BtnFontSel
            // 
            BtnFontSel.BackColor = SystemColors.Menu;
            BtnFontSel.BackgroundImageLayout = ImageLayout.None;
            BtnFontSel.Cursor = Cursors.Hand;
            BtnFontSel.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            BtnFontSel.FlatAppearance.BorderSize = 2;
            BtnFontSel.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            BtnFontSel.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            BtnFontSel.FlatStyle = FlatStyle.Popup;
            BtnFontSel.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFontSel.Location = new Point(103, 7);
            BtnFontSel.Name = "BtnFontSel";
            BtnFontSel.Size = new Size(240, 30);
            BtnFontSel.TabIndex = 1;
            BtnFontSel.Text = "Consolas";
            BtnFontSel.UseVisualStyleBackColor = false;
            BtnFontSel.Click += BtnFontSel_Click;
            // 
            // ButtonExit
            // 
            ButtonExit.Dock = DockStyle.Right;
            ButtonExit.Location = new Point(977, 5);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(94, 33);
            ButtonExit.TabIndex = 0;
            ButtonExit.Text = "Exit";
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += BtnExt_Click;
            // 
            // PanelBottom
            // 
            PanelBottom.AutoSize = true;
            PanelBottom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelBottom.Controls.Add(label1);
            PanelBottom.Dock = DockStyle.Bottom;
            PanelBottom.Font = new Font("Yu Gothic UI", 9F);
            PanelBottom.Location = new Point(0, 525);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(1087, 38);
            PanelBottom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Yu Gothic UI", 8F);
            label1.Location = new Point(0, 0);
            label1.MaximumSize = new Size(1087, 0);
            label1.Name = "label1";
            label1.Size = new Size(371, 38);
            label1.TabIndex = 0;
            label1.Text = "Select text on the right and apply it to the fields on the left.\r\nAll data and clipboard are cleared on exit.";
            // 
            // PanelFields
            // 
            PanelFields.Controls.Add(BtnCpyApp);
            PanelFields.Controls.Add(BtnApyFld3);
            PanelFields.Controls.Add(BtnCpyFld3);
            PanelFields.Controls.Add(TxtBoxFld3);
            PanelFields.Controls.Add(BtnApyFld2);
            PanelFields.Controls.Add(BtnCpyFld2);
            PanelFields.Controls.Add(TxtBoxFld2);
            PanelFields.Controls.Add(BtnApyFld1);
            PanelFields.Controls.Add(BtnCpyFld1);
            PanelFields.Controls.Add(TxtBoxFld1);
            PanelFields.Controls.Add(BtnApyMail);
            PanelFields.Controls.Add(BtnCpyMail);
            PanelFields.Controls.Add(TxtBoxMail);
            PanelFields.Controls.Add(BtnApyPass);
            PanelFields.Controls.Add(BtnCpyPass);
            PanelFields.Controls.Add(TxtBoxPass);
            PanelFields.Controls.Add(BtnApyID);
            PanelFields.Controls.Add(BtnCpyID);
            PanelFields.Controls.Add(TxtBoxID);
            PanelFields.Controls.Add(BtnApyURL);
            PanelFields.Controls.Add(BtnCpyURL);
            PanelFields.Controls.Add(TxtBoxURL);
            PanelFields.Controls.Add(BtnApyApp);
            PanelFields.Controls.Add(TxtBoxApp);
            PanelFields.Dock = DockStyle.Left;
            PanelFields.Location = new Point(0, 43);
            PanelFields.Name = "PanelFields";
            PanelFields.Size = new Size(440, 482);
            PanelFields.TabIndex = 2;
            // 
            // BtnCpyApp
            // 
            BtnCpyApp.Font = new Font("Yu Gothic UI", 8F);
            BtnCpyApp.Location = new Point(12, 5);
            BtnCpyApp.Name = "BtnCpyApp";
            BtnCpyApp.Size = new Size(67, 47);
            BtnCpyApp.TabIndex = 30;
            BtnCpyApp.Text = "App\r\n(Copy)";
            BtnCpyApp.UseVisualStyleBackColor = true;
            // 
            // BtnApyFld3
            // 
            BtnApyFld3.Location = new Point(367, 377);
            BtnApyFld3.Name = "BtnApyFld3";
            BtnApyFld3.Size = new Size(67, 29);
            BtnApyFld3.TabIndex = 29;
            BtnApyFld3.Text = "Apply";
            BtnApyFld3.UseVisualStyleBackColor = true;
            // 
            // BtnCpyFld3
            // 
            BtnCpyFld3.Font = new Font("Yu Gothic UI", 8F);
            BtnCpyFld3.Location = new Point(12, 369);
            BtnCpyFld3.Name = "BtnCpyFld3";
            BtnCpyFld3.Size = new Size(67, 47);
            BtnCpyFld3.TabIndex = 28;
            BtnCpyFld3.Text = "Field3\r\n(Copy)";
            BtnCpyFld3.UseVisualStyleBackColor = true;
            // 
            // TxtBoxFld3
            // 
            TxtBoxFld3.Font = new Font("Consolas", 20F);
            TxtBoxFld3.Location = new Point(85, 369);
            TxtBoxFld3.Name = "TxtBoxFld3";
            TxtBoxFld3.Size = new Size(280, 47);
            TxtBoxFld3.TabIndex = 27;
            TxtBoxFld3.WordWrap = false;
            // 
            // BtnApyFld2
            // 
            BtnApyFld2.Location = new Point(367, 325);
            BtnApyFld2.Name = "BtnApyFld2";
            BtnApyFld2.Size = new Size(67, 29);
            BtnApyFld2.TabIndex = 26;
            BtnApyFld2.Text = "Apply";
            BtnApyFld2.UseVisualStyleBackColor = true;
            // 
            // BtnCpyFld2
            // 
            BtnCpyFld2.Font = new Font("Yu Gothic UI", 8F);
            BtnCpyFld2.Location = new Point(12, 318);
            BtnCpyFld2.Name = "BtnCpyFld2";
            BtnCpyFld2.Size = new Size(67, 47);
            BtnCpyFld2.TabIndex = 25;
            BtnCpyFld2.Text = "Field2\r\n(Copy)";
            BtnCpyFld2.UseVisualStyleBackColor = true;
            // 
            // TxtBoxFld2
            // 
            TxtBoxFld2.Font = new Font("Consolas", 20F);
            TxtBoxFld2.Location = new Point(85, 317);
            TxtBoxFld2.Name = "TxtBoxFld2";
            TxtBoxFld2.Size = new Size(280, 47);
            TxtBoxFld2.TabIndex = 24;
            TxtBoxFld2.WordWrap = false;
            // 
            // BtnApyFld1
            // 
            BtnApyFld1.Location = new Point(367, 273);
            BtnApyFld1.Name = "BtnApyFld1";
            BtnApyFld1.Size = new Size(67, 29);
            BtnApyFld1.TabIndex = 23;
            BtnApyFld1.Text = "Apply";
            BtnApyFld1.UseVisualStyleBackColor = true;
            // 
            // BtnCpyFld1
            // 
            BtnCpyFld1.Font = new Font("Yu Gothic UI", 8F);
            BtnCpyFld1.Location = new Point(12, 265);
            BtnCpyFld1.Name = "BtnCpyFld1";
            BtnCpyFld1.Size = new Size(67, 47);
            BtnCpyFld1.TabIndex = 22;
            BtnCpyFld1.Text = "Field1\r\n(Copy)";
            BtnCpyFld1.UseVisualStyleBackColor = true;
            // 
            // TxtBoxFld1
            // 
            TxtBoxFld1.Font = new Font("Consolas", 20F);
            TxtBoxFld1.Location = new Point(85, 265);
            TxtBoxFld1.Name = "TxtBoxFld1";
            TxtBoxFld1.Size = new Size(280, 47);
            TxtBoxFld1.TabIndex = 21;
            TxtBoxFld1.WordWrap = false;
            // 
            // BtnApyMail
            // 
            BtnApyMail.Location = new Point(367, 221);
            BtnApyMail.Name = "BtnApyMail";
            BtnApyMail.Size = new Size(67, 29);
            BtnApyMail.TabIndex = 20;
            BtnApyMail.Text = "Apply";
            BtnApyMail.UseVisualStyleBackColor = true;
            // 
            // BtnCpyMail
            // 
            BtnCpyMail.Font = new Font("Yu Gothic UI", 8F);
            BtnCpyMail.Location = new Point(12, 215);
            BtnCpyMail.Name = "BtnCpyMail";
            BtnCpyMail.Size = new Size(67, 47);
            BtnCpyMail.TabIndex = 19;
            BtnCpyMail.Text = "Mail\r\n(Copy)";
            BtnCpyMail.UseVisualStyleBackColor = true;
            // 
            // TxtBoxMail
            // 
            TxtBoxMail.Font = new Font("Consolas", 20F);
            TxtBoxMail.Location = new Point(85, 213);
            TxtBoxMail.Name = "TxtBoxMail";
            TxtBoxMail.Size = new Size(280, 47);
            TxtBoxMail.TabIndex = 18;
            TxtBoxMail.WordWrap = false;
            // 
            // BtnApyPass
            // 
            BtnApyPass.Location = new Point(367, 169);
            BtnApyPass.Name = "BtnApyPass";
            BtnApyPass.Size = new Size(67, 29);
            BtnApyPass.TabIndex = 16;
            BtnApyPass.Text = "Apply";
            BtnApyPass.UseVisualStyleBackColor = true;
            // 
            // BtnCpyPass
            // 
            BtnCpyPass.Font = new Font("Yu Gothic UI", 8F);
            BtnCpyPass.Location = new Point(12, 162);
            BtnCpyPass.Name = "BtnCpyPass";
            BtnCpyPass.Size = new Size(67, 47);
            BtnCpyPass.TabIndex = 15;
            BtnCpyPass.Text = "Passwd\r\n(Copy)";
            BtnCpyPass.UseVisualStyleBackColor = true;
            // 
            // TxtBoxPass
            // 
            TxtBoxPass.Font = new Font("Consolas", 20F);
            TxtBoxPass.Location = new Point(85, 161);
            TxtBoxPass.Name = "TxtBoxPass";
            TxtBoxPass.Size = new Size(280, 47);
            TxtBoxPass.TabIndex = 14;
            TxtBoxPass.WordWrap = false;
            // 
            // BtnApyID
            // 
            BtnApyID.Location = new Point(367, 117);
            BtnApyID.Name = "BtnApyID";
            BtnApyID.Size = new Size(67, 29);
            BtnApyID.TabIndex = 12;
            BtnApyID.Text = "Apply";
            BtnApyID.UseVisualStyleBackColor = true;
            // 
            // BtnCpyID
            // 
            BtnCpyID.Font = new Font("Yu Gothic UI", 8F);
            BtnCpyID.Location = new Point(12, 109);
            BtnCpyID.Name = "BtnCpyID";
            BtnCpyID.Size = new Size(67, 47);
            BtnCpyID.TabIndex = 11;
            BtnCpyID.Text = "ID\r\n(Copy)";
            BtnCpyID.UseVisualStyleBackColor = true;
            // 
            // TxtBoxID
            // 
            TxtBoxID.Font = new Font("Consolas", 20F);
            TxtBoxID.Location = new Point(85, 109);
            TxtBoxID.Name = "TxtBoxID";
            TxtBoxID.Size = new Size(280, 47);
            TxtBoxID.TabIndex = 10;
            TxtBoxID.WordWrap = false;
            // 
            // BtnApyURL
            // 
            BtnApyURL.Location = new Point(367, 65);
            BtnApyURL.Name = "BtnApyURL";
            BtnApyURL.Size = new Size(67, 29);
            BtnApyURL.TabIndex = 9;
            BtnApyURL.Text = "Apply";
            BtnApyURL.UseVisualStyleBackColor = true;
            // 
            // BtnCpyURL
            // 
            BtnCpyURL.Font = new Font("Yu Gothic UI", 8F);
            BtnCpyURL.Location = new Point(12, 57);
            BtnCpyURL.Name = "BtnCpyURL";
            BtnCpyURL.Size = new Size(67, 47);
            BtnCpyURL.TabIndex = 8;
            BtnCpyURL.Text = "URL\r\n(Copy)";
            BtnCpyURL.UseVisualStyleBackColor = true;
            // 
            // TxtBoxURL
            // 
            TxtBoxURL.Font = new Font("Consolas", 20F);
            TxtBoxURL.Location = new Point(85, 57);
            TxtBoxURL.Name = "TxtBoxURL";
            TxtBoxURL.Size = new Size(280, 47);
            TxtBoxURL.TabIndex = 7;
            TxtBoxURL.WordWrap = false;
            // 
            // BtnApyApp
            // 
            BtnApyApp.Location = new Point(367, 13);
            BtnApyApp.Name = "BtnApyApp";
            BtnApyApp.Size = new Size(67, 29);
            BtnApyApp.TabIndex = 6;
            BtnApyApp.Text = "Apply";
            BtnApyApp.UseVisualStyleBackColor = true;
            // 
            // TxtBoxApp
            // 
            TxtBoxApp.Font = new Font("Consolas", 20F);
            TxtBoxApp.Location = new Point(85, 5);
            TxtBoxApp.Name = "TxtBoxApp";
            TxtBoxApp.Size = new Size(280, 47);
            TxtBoxApp.TabIndex = 1;
            TxtBoxApp.WordWrap = false;
            // 
            // PanelTextArea
            // 
            PanelTextArea.Controls.Add(TextArea);
            PanelTextArea.Controls.Add(PnlTxtBtns);
            PanelTextArea.Dock = DockStyle.Fill;
            PanelTextArea.Location = new Point(440, 43);
            PanelTextArea.Name = "PanelTextArea";
            PanelTextArea.Size = new Size(647, 482);
            PanelTextArea.TabIndex = 3;
            // 
            // TextArea
            // 
            TextArea.Dock = DockStyle.Fill;
            TextArea.Font = new Font("Consolas", 20F);
            TextArea.HideSelection = false;
            TextArea.Location = new Point(0, 50);
            TextArea.Multiline = true;
            TextArea.Name = "TextArea";
            TextArea.ScrollBars = ScrollBars.Both;
            TextArea.Size = new Size(647, 432);
            TextArea.TabIndex = 0;
            TextArea.WordWrap = false;
            // 
            // PnlTxtBtns
            // 
            PnlTxtBtns.BackColor = SystemColors.ActiveBorder;
            PnlTxtBtns.Controls.Add(BtnClr);
            PnlTxtBtns.Controls.Add(BtnCut);
            PnlTxtBtns.Controls.Add(BtnPst);
            PnlTxtBtns.Controls.Add(BtnCpy);
            PnlTxtBtns.Dock = DockStyle.Top;
            PnlTxtBtns.Location = new Point(0, 0);
            PnlTxtBtns.Name = "PnlTxtBtns";
            PnlTxtBtns.Padding = new Padding(0, 10, 16, 10);
            PnlTxtBtns.Size = new Size(647, 50);
            PnlTxtBtns.TabIndex = 1;
            // 
            // BtnClr
            // 
            BtnClr.Dock = DockStyle.Right;
            BtnClr.Location = new Point(537, 10);
            BtnClr.Name = "BtnClr";
            BtnClr.Size = new Size(94, 30);
            BtnClr.TabIndex = 3;
            BtnClr.Text = "Clear";
            BtnClr.UseVisualStyleBackColor = true;
            BtnClr.Click += BtnClr_Click;
            // 
            // BtnCut
            // 
            BtnCut.Location = new Point(222, 10);
            BtnCut.Name = "BtnCut";
            BtnCut.Size = new Size(94, 30);
            BtnCut.TabIndex = 2;
            BtnCut.Text = "Cut";
            BtnCut.UseVisualStyleBackColor = true;
            BtnCut.Click += BtnCut_Click;
            // 
            // BtnPst
            // 
            BtnPst.Location = new Point(122, 10);
            BtnPst.Name = "BtnPst";
            BtnPst.Size = new Size(94, 30);
            BtnPst.TabIndex = 1;
            BtnPst.Text = "Paste";
            BtnPst.UseVisualStyleBackColor = true;
            BtnPst.Click += BtnPst_Click;
            // 
            // BtnCpy
            // 
            BtnCpy.Location = new Point(24, 10);
            BtnCpy.Name = "BtnCpy";
            BtnCpy.Size = new Size(94, 30);
            BtnCpy.TabIndex = 0;
            BtnCpy.Text = "Copy";
            BtnCpy.UseVisualStyleBackColor = true;
            BtnCpy.Click += BtnCpy_Click;
            // 
            // SecPad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 563);
            Controls.Add(PanelTextArea);
            Controls.Add(PanelFields);
            Controls.Add(PanelBottom);
            Controls.Add(PanelTop);
            MinimumSize = new Size(900, 550);
            Name = "SecPad";
            Text = "SecPad";
            FormClosing += SecPad_FormClosing;
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            PanelBottom.ResumeLayout(false);
            PanelBottom.PerformLayout();
            PanelFields.ResumeLayout(false);
            PanelFields.PerformLayout();
            PanelTextArea.ResumeLayout(false);
            PanelTextArea.PerformLayout();
            PnlTxtBtns.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelTop;
        private Panel PanelBottom;
        private Panel PanelFields;
        private Panel PanelTextArea;
        private TextBox TextArea;
        private Button ButtonExit;
        private TextBox TxtBoxApp;
        private Button BtnApyApp;
        private Button BtnApyID;
        private Button BtnCpyID;
        private TextBox TxtBoxID;
        private Button BtnApyURL;
        private Button BtnCpyURL;
        private TextBox TxtBoxURL;
        private Button BtnApyPass;
        private Button BtnCpyPass;
        private TextBox TxtBoxPass;
        private Button BtnApyMail;
        private Button BtnCpyMail;
        private TextBox TxtBoxMail;
        private Button BtnApyFld1;
        private Button BtnCpyFld1;
        private TextBox TxtBoxFld1;
        private Button BtnApyFld3;
        private Button BtnCpyFld3;
        private TextBox TxtBoxFld3;
        private Button BtnApyFld2;
        private Button BtnCpyFld2;
        private TextBox TxtBoxFld2;
        private Button BtnCpyApp;
        private Button BtnFontSel;
        private Panel PnlTxtBtns;
        private Button BtnPst;
        private Button BtnCpy;
        private Button BtnClr;
        private Button BtnCut;
        private Label LbLArw;
        private Label label1;
    }
}
