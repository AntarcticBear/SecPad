namespace SecPad
{
    public partial class SecPad : Form
    {
        private (Button copy, TextBox target, Button apply)[] _setupList;
        public SecPad()
        {
            InitializeComponent();

            _setupList =
            [
                (BtnCpyApp,  TxtBoxApp,  BtnApyApp),
                (BtnCpyURL,  TxtBoxURL,  BtnApyURL),
                (BtnCpyID,   TxtBoxID,   BtnApyID),
                (BtnCpyPass, TxtBoxPass, BtnApyPass),
                (BtnCpyMail, TxtBoxMail, BtnApyMail),
                (BtnCpyFld1, TxtBoxFld1, BtnApyFld1),
                (BtnCpyFld2, TxtBoxFld2, BtnApyFld2),
                (BtnCpyFld3, TxtBoxFld3, BtnApyFld3)
            ];

            foreach (var item in _setupList)
            {
                item.apply.Tag = item.target;
                item.apply.Click += OnApplyClick;

                item.copy.Tag = item.target;
                item.copy.Click += OnCopyClick;
            }
        }

        private void BtnExt_Click(object sender, EventArgs e)
        {
            TextArea.Clear();
            foreach (var txt in new[] { TxtBoxApp, TxtBoxURL, TxtBoxID, TxtBoxPass, TxtBoxMail, TxtBoxFld1, TxtBoxFld2, TxtBoxFld3 })
            {
                txt.Clear();
            }
            try
            {
                Clipboard.Clear();
            }
            catch (System.Exception) { }
            Close();
        }

        private void BtnClr_Click(object sender, EventArgs e)
        {
            TextArea.Clear();
            try
            {
                Clipboard.Clear();
            }
            catch (System.Exception) { }
        }


        private void BtnCut_Click(object sender, EventArgs e)
        {
            TextArea.Cut();
        }

        private void BtnCpy_Click(object sender, EventArgs e)
        {
            TextArea.Copy();
        }

        private void BtnPst_Click(object sender, EventArgs e)
        {
            TextArea.Paste();
        }

        private void OnApplyClick(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;
            if (btn.Tag is not TextBox target) return;

            var text = TextArea.SelectedText;
            if (text.Length == 0) return;

            target.Text = text;
        }

        private void OnCopyClick(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;
            if (btn.Tag is not TextBox target) return;

            var text = target.Text;
            if (text.Length == 0) return;

            try
            {
                Clipboard.SetText(text);
            }
            catch (System.Exception) { }
        }

        private void ChangeFont()
        {
            using (FontDialog fd = new FontDialog())
            {
                fd.Font = TextArea.Font;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    TextArea.Font = fd.Font;

                    foreach (var obj in _setupList)
                    {
                        obj.target.Font = fd.Font;
                    }

                    BtnFontSel.Text = fd.Font.Name;
                }
            }
        }

        private void BtnFontSel_Click(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void LbLArw_Click(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void SecPad_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Clipboard.Clear();
            }
            catch (System.Exception) { }
        }
    }
}
