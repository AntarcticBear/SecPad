using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SecPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextArea.SelectedText))
            {
                Clipboard.SetText(TextArea.SelectedText);
            }
            else if (!string.IsNullOrEmpty(TextArea.Text))
            {
                Clipboard.SetText(TextArea.Text);
            }
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                TextArea.SelectedText = Clipboard.GetText();
            }
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            TextArea.Cut();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            TextArea.Clear();
            try {
                Clipboard.Clear();
            } catch { /*何もしない*/ }
            base.OnFormClosing(e);
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            using (FontDialog fd = new FontDialog())
            {
                fd.Font = TextArea.Font;
                fd.ShowColor = false; // 色は不要
                fd.ShowEffects = false; // イタリック、ボールドは不要

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    TextArea.Font = fd.Font;

                    Properties.Settings.Default.FontName = TextArea.Font.Name;
                    Properties.Settings.Default.FontSize = TextArea.Font.Size;
                    Properties.Settings.Default.Save();
                }
            }
        }
    }
}
