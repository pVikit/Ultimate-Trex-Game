namespace Ultimate_TRex_Game_Atestat
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PlayB = new Button();
            HelpB = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            CloseB = new Button();
            SuspendLayout();
            // 
            // PlayB
            // 
            resources.ApplyResources(PlayB, "PlayB");
            PlayB.Name = "PlayB";
            PlayB.UseVisualStyleBackColor = true;
            PlayB.Click += PlayB_Click;
            // 
            // HelpB
            // 
            resources.ApplyResources(HelpB, "HelpB");
            HelpB.Name = "HelpB";
            HelpB.UseVisualStyleBackColor = true;
            HelpB.Click += HelpB_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // CloseB
            // 
            resources.ApplyResources(CloseB, "CloseB");
            CloseB.Name = "CloseB";
            CloseB.UseVisualStyleBackColor = true;
            CloseB.Click += CloseB_Click;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ControlBox = false;
            Controls.Add(CloseB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(HelpB);
            Controls.Add(PlayB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PlayB;
        private Button HelpB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button CloseB;
    }
}
