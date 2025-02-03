namespace Ultimate_TRex_Game_Atestat
{
    partial class ChooseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseForm));
            BackB = new Button();
            ContinueB = new Button();
            Char1 = new PictureBox();
            Char2 = new PictureBox();
            Char3 = new PictureBox();
            notes = new Label();
            name = new Label();
            ((System.ComponentModel.ISupportInitialize)Char1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Char2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Char3).BeginInit();
            SuspendLayout();
            // 
            // BackB
            // 
            resources.ApplyResources(BackB, "BackB");
            BackB.Name = "BackB";
            BackB.UseVisualStyleBackColor = true;
            BackB.Click += BackB_Click;
            // 
            // ContinueB
            // 
            resources.ApplyResources(ContinueB, "ContinueB");
            ContinueB.Name = "ContinueB";
            ContinueB.UseVisualStyleBackColor = true;
            ContinueB.Click += ContinueB_Click;
            // 
            // Char1
            // 
            Char1.BackgroundImage = Properties.Resources.Random;
            resources.ApplyResources(Char1, "Char1");
            Char1.Name = "Char1";
            Char1.TabStop = false;
            Char1.Click += Char2_Click;
            Char1.MouseLeave += Char3_MouseLeave;
            Char1.MouseHover += Char2_MouseHover;
            // 
            // Char2
            // 
            resources.ApplyResources(Char2, "Char2");
            Char2.Name = "Char2";
            Char2.TabStop = false;
            Char2.Click += Char2_Click;
            Char2.MouseLeave += Char3_MouseLeave;
            Char2.MouseHover += Char2_MouseHover;
            // 
            // Char3
            // 
            resources.ApplyResources(Char3, "Char3");
            Char3.Name = "Char3";
            Char3.TabStop = false;
            Char3.Click += Char2_Click;
            Char3.MouseLeave += Char3_MouseLeave;
            Char3.MouseHover += Char2_MouseHover;
            // 
            // notes
            // 
            resources.ApplyResources(notes, "notes");
            notes.Name = "notes";
            // 
            // name
            // 
            resources.ApplyResources(name, "name");
            name.Name = "name";
            // 
            // ChooseForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            ControlBox = false;
            Controls.Add(name);
            Controls.Add(notes);
            Controls.Add(Char3);
            Controls.Add(Char2);
            Controls.Add(Char1);
            Controls.Add(ContinueB);
            Controls.Add(BackB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ChooseForm";
            Load += ChooseForm_Load;
            ((System.ComponentModel.ISupportInitialize)Char1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Char2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Char3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackB;
        private Button ContinueB;
        private PictureBox Char1;
        private PictureBox Char2;
        private PictureBox Char3;
        private Label notes;
        private Label name;
    }
}