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
            TextArea.Text = string.Empty;
            Clipboard.Clear();
            base.OnFormClosing(e);
        }
    }
}
