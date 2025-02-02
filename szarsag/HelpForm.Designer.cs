namespace Ultimate_TRex_Game_Atestat
{
    partial class HelpForm
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
            HelpText = new RichTextBox();
            BackB = new Button();
            SuspendLayout();
            // 
            // HelpText
            // 
            HelpText.BackColor = Color.FloralWhite;
            HelpText.Location = new Point(6, 5);
            HelpText.Name = "HelpText";
            HelpText.Size = new Size(773, 388);
            HelpText.TabIndex = 0;
            HelpText.Text = "";
            HelpText.TextChanged += HelpText_TextChanged;
            // 
            // BackB
            // 
            BackB.Location = new Point(12, 399);
            BackB.Name = "BackB";
            BackB.Size = new Size(94, 29);
            BackB.TabIndex = 1;
            BackB.Text = "Back";
            BackB.UseVisualStyleBackColor = true;
            BackB.Click += BackB_Click;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(787, 440);
            ControlBox = false;
            Controls.Add(BackB);
            Controls.Add(HelpText);
            Name = "HelpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Help Center";
            Load += Help_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox HelpText;
        private Button BackB;
    }
}