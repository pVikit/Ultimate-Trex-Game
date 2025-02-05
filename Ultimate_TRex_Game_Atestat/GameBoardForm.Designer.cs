namespace Ultimate_TRex_Game_Atestat
{
    partial class GameBoardForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoardForm));
            Menu = new MenuStrip();
            Menuke = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            continueToolStripMenuItem = new ToolStripMenuItem();
            gameOverToolStripMenuItem = new ToolStripMenuItem();
            timer = new System.Windows.Forms.Timer(components);
            startB = new Button();
            ScoreL = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            coinL = new Label();
            pictureBox1 = new PictureBox();
            ground = new PictureBox();
            Obstacle = new PictureBox();
            Character = new PictureBox();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Obstacle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Character).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { Menuke });
            resources.ApplyResources(Menu, "Menu");
            Menu.Name = "Menu";
            // 
            // Menuke
            // 
            Menuke.BackgroundImage = Properties.Resources.burger;
            resources.ApplyResources(Menuke, "Menuke");
            Menuke.DropDownItems.AddRange(new ToolStripItem[] { resetToolStripMenuItem, continueToolStripMenuItem, gameOverToolStripMenuItem });
            Menuke.Name = "Menuke";
            Menuke.Click += Menu_Click;
            Menuke.MouseHover += Menuke_MouseHover;
            // 
            // resetToolStripMenuItem
            // 
            resources.ApplyResources(resetToolStripMenuItem, "resetToolStripMenuItem");
            resetToolStripMenuItem.Image = Properties.Resources.arrow;
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // continueToolStripMenuItem
            // 
            resources.ApplyResources(continueToolStripMenuItem, "continueToolStripMenuItem");
            continueToolStripMenuItem.Image = Properties.Resources._continue;
            continueToolStripMenuItem.Name = "continueToolStripMenuItem";
            continueToolStripMenuItem.Click += continueToolStripMenuItem_Click;
            // 
            // gameOverToolStripMenuItem
            // 
            resources.ApplyResources(gameOverToolStripMenuItem, "gameOverToolStripMenuItem");
            gameOverToolStripMenuItem.Image = Properties.Resources.game_over;
            gameOverToolStripMenuItem.Name = "gameOverToolStripMenuItem";
            gameOverToolStripMenuItem.Click += gameOverToolStripMenuItem_Click;
            // 
            // timer
            // 
            timer.Interval = 20;
            timer.Tick += timer_Tick;
            // 
            // startB
            // 
            resources.ApplyResources(startB, "startB");
            startB.Name = "startB";
            startB.UseVisualStyleBackColor = true;
            startB.Click += startB_Click;
            // 
            // ScoreL
            // 
            resources.ApplyResources(ScoreL, "ScoreL");
            ScoreL.Name = "ScoreL";
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
            // coinL
            // 
            resources.ApplyResources(coinL, "coinL");
            coinL.Name = "coinL";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.heart;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // ground
            // 
            resources.ApplyResources(ground, "ground");
            ground.Name = "ground";
            ground.TabStop = false;
            // 
            // Obstacle
            // 
            resources.ApplyResources(Obstacle, "Obstacle");
            Obstacle.Name = "Obstacle";
            Obstacle.TabStop = false;
            Obstacle.Tag = "obstacle";
            // 
            // Character
            // 
            resources.ApplyResources(Character, "Character");
            Character.Name = "Character";
            Character.TabStop = false;
            // 
            // GameBoardForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            ControlBox = false;
            Controls.Add(ground);
            Controls.Add(pictureBox1);
            Controls.Add(coinL);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ScoreL);
            Controls.Add(startB);
            Controls.Add(Menu);
            Controls.Add(Obstacle);
            Controls.Add(Character);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MainMenuStrip = Menu;
            Name = "GameBoardForm";
            Load += GameBoardForm_Load;
            KeyDown += GameBoardForm_KeyDown;
            KeyUp += GameBoardForm_KeyUp;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)Obstacle).EndInit();
            ((System.ComponentModel.ISupportInitialize)Character).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem Menuke;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem gameOverToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private Button startB;
        private Label ScoreL;
        private ToolStripMenuItem continueToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label coinL;
        private PictureBox pictureBox1;
        private PictureBox ground;
        private PictureBox Obstacle;
        private PictureBox Character;
    }
}