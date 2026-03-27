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
            ExitButton = new Button();
            CutButton = new Button();
            PasteButton = new Button();
            CopyButton = new Button();
            TextArea = new TextBox();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(ExitButton);
            ButtonPanel.Controls.Add(CutButton);
            ButtonPanel.Controls.Add(PasteButton);
            ButtonPanel.Controls.Add(CopyButton);
            ButtonPanel.Dock = DockStyle.Top;
            ButtonPanel.Location = new Point(0, 0);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(1100, 40);
            ButtonPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(400, 5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(80, 30);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // CutButton
            // 
            CutButton.Location = new Point(220, 5);
            CutButton.Name = "CutButton";
            CutButton.Size = new Size(94, 29);
            CutButton.TabIndex = 2;
            CutButton.Text = "Cut";
            CutButton.UseVisualStyleBackColor = true;
            CutButton.Click += CutButton_Click;
            // 
            // PasteButton
            // 
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
            TextArea.Location = new Point(0, 40);
            TextArea.Multiline = true;
            TextArea.Name = "TextArea";
            TextArea.ScrollBars = ScrollBars.Both;
            TextArea.Size = new Size(1100, 541);
            TextArea.TabIndex = 1;
            TextArea.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 581);
            Controls.Add(TextArea);
            Controls.Add(ButtonPanel);
            Name = "Form1";
            ButtonPanel.ResumeLayout(false);
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
    }
}
