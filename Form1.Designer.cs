namespace SecPad
{
    partial class Form1
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
            ButtonPanel = new Panel();
            ExitPanel = new Panel();
            ExitButton = new Button();
            FontButton = new Button();
            CutButton = new Button();
            PasteButton = new Button();
            CopyButton = new Button();
            TextArea = new TextBox();
            fontDialog1 = new FontDialog();
            CautionPanel = new Panel();
            Caution = new Label();
            ButtonPanel.SuspendLayout();
            ExitPanel.SuspendLayout();
            CautionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(ExitPanel);
            ButtonPanel.Controls.Add(FontButton);
            ButtonPanel.Controls.Add(CutButton);
            ButtonPanel.Controls.Add(PasteButton);
            ButtonPanel.Controls.Add(CopyButton);
            ButtonPanel.Dock = DockStyle.Top;
            ButtonPanel.Location = new Point(0, 0);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(1100, 40);
            ButtonPanel.TabIndex = 0;
            // 
            // ExitPanel
            // 
            ExitPanel.Controls.Add(ExitButton);
            ExitPanel.Dock = DockStyle.Right;
            ExitPanel.Location = new Point(958, 0);
            ExitPanel.Margin = new Padding(0, 5, 20, 5);
            ExitPanel.Name = "ExitPanel";
            ExitPanel.Padding = new Padding(0, 5, 20, 5);
            ExitPanel.Size = new Size(142, 40);
            ExitPanel.TabIndex = 5;
            // 
            // ExitButton
            // 
            ExitButton.Dock = DockStyle.Right;
            ExitButton.Font = new Font("Meiryo UI", 10.8F);
            ExitButton.Location = new Point(42, 5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(80, 30);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // FontButton
            // 
            FontButton.Font = new Font("Meiryo UI", 10.8F);
            FontButton.Location = new Point(330, 5);
            FontButton.Name = "FontButton";
            FontButton.Size = new Size(80, 30);
            FontButton.TabIndex = 4;
            FontButton.Text = "Font";
            FontButton.UseVisualStyleBackColor = true;
            FontButton.Click += FontButton_Click;
            // 
            // CutButton
            // 
            CutButton.Font = new Font("Meiryo UI", 10.8F);
            CutButton.Location = new Point(220, 5);
            CutButton.Name = "CutButton";
            CutButton.Size = new Size(80, 30);
            CutButton.TabIndex = 2;
            CutButton.Text = "Cut";
            CutButton.UseVisualStyleBackColor = true;
            CutButton.Click += CutButton_Click;
            // 
            // PasteButton
            // 
            PasteButton.Font = new Font("Meiryo UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            PasteButton.Location = new Point(120, 5);
            PasteButton.Name = "PasteButton";
            PasteButton.Size = new Size(80, 30);
            PasteButton.TabIndex = 1;
            PasteButton.Text = "Paste";
            PasteButton.UseVisualStyleBackColor = true;
            PasteButton.Click += PasteButton_Click;
            // 
            // CopyButton
            // 
            CopyButton.Font = new Font("Meiryo UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            CopyButton.Location = new Point(20, 5);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(80, 30);
            CopyButton.TabIndex = 0;
            CopyButton.Text = "Copy";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += button1_Click;
            // 
            // TextArea
            // 
            TextArea.Dock = DockStyle.Fill;
            TextArea.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextArea.Location = new Point(0, 40);
            TextArea.Multiline = true;
            TextArea.Name = "TextArea";
            TextArea.ScrollBars = ScrollBars.Both;
            TextArea.Size = new Size(1100, 541);
            TextArea.TabIndex = 1;
            TextArea.WordWrap = false;
            // 
            // CautionPanel
            // 
            CautionPanel.Controls.Add(Caution);
            CautionPanel.Dock = DockStyle.Bottom;
            CautionPanel.Location = new Point(0, 557);
            CautionPanel.Name = "CautionPanel";
            CautionPanel.Size = new Size(1100, 24);
            CautionPanel.TabIndex = 2;
            // 
            // Caution
            // 
            Caution.AutoSize = true;
            Caution.Dock = DockStyle.Right;
            Caution.Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Caution.Location = new Point(522, 0);
            Caution.Name = "Caution";
            Caution.Size = new Size(578, 19);
            Caution.TabIndex = 0;
            Caution.Text = "No save / No network. Text and clipboard are cleared when the app is closed.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 581);
            Controls.Add(CautionPanel);
            Controls.Add(TextArea);
            Controls.Add(ButtonPanel);
            Name = "Form1";
            ButtonPanel.ResumeLayout(false);
            ExitPanel.ResumeLayout(false);
            CautionPanel.ResumeLayout(false);
            CautionPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ButtonPanel;
        private TextBox TextArea;
        private Button CopyButton;
        private Button CutButton;
        private Button PasteButton;
        private Button ExitButton;
        private Button FontButton;
        private FontDialog fontDialog1;
        private Panel ExitPanel;
        private Panel CautionPanel;
        private Label Caution;
    }
}
