using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimate_TRex_Game_Atestat
{
    public partial class GameBoardForm : Form
    {
        public GameBoardForm()
        {
            InitializeComponent();

            Character.BackColor = Color.Transparent;
            
        }

        int h = 0;
        public static int Speed;
        public static int Lives;
        public static string Talent;
        public static string Name;
        private Point loc;

        bool jump;
        int jumpSpeed;
        int force = 20;
        int obstacleSpeed = Speed * 5;
        Random r = new Random();
        int pos;
        bool isGameOver = false;

        private void GameBoardForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1121, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            loc = this.Location;
            this.LocationChanged += GameBoardForm_LocationChanged;

            if (Name == "Nyaki")
            {
                Character.Image = Image.FromFile(@"D:\\Programozas\\c#\\Atestat\\Ultimate_TRex_Game_Atestat\\bin\\Debug\\Random.png");
            }
            else if (Name == "Triko")
            {
                Character.Image = Image.FromFile(@"D:\\Programozas\\c#\\Atestat\\Ultimate_TRex_Game_Atestat\\bin\\Debug\\triko.gif");
            }
            else if (Name == "Fogyi")
            {
                Character.Image = Image.FromFile(@"D:\\Programozas\\c#\\Atestat\\Ultimate_TRex_Game_Atestat\\bin\\Debug\\fogyika.gif");
            }
            Character.SizeMode = PictureBoxSizeMode.CenterImage;
            Character.Size = new Size(Character.Image.Height, Character.Image.Width);
            Character.BackColor = Color.Transparent;
            //Character.Location = new Point(157, 419);

            ground.ImageLocation = "D:\\Programozas\\c#\\Atestat\\Ultimate_TRex_Game_Atestat\\bin\\Debug\\ground.png";
            ground.SizeMode = PictureBoxSizeMode.StretchImage;

            Obstacle.ImageLocation = "D:\\Programozas\\c#\\Atestat\\Ultimate_TRex_Game_Atestat\\bin\\Debug\\kaktusz.png";
            Obstacle.SizeMode = PictureBoxSizeMode.StretchImage;

            startB.Visible = true;
            Menu.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            ScoreL.Visible = false;
            coinL.Visible = false;
            pictureBox1.Visible = false;
            Character.Visible = false;
            ground.Visible = false;
            Obstacle.Visible = false;

            startB.Location = new Point((this.ClientSize.Width - startB.Width) / 2, (this.ClientSize.Height - startB.Height) / 2);
        }

        private void GameBoardForm_LocationChanged(object? sender, EventArgs e)
        {
            this.Location = loc;
        }

        public static void Karakter_tulajdonsagai(int speed, int lives, string talent, string name)
        {
            Speed = speed;
            Lives = lives;
            Name = name;
            Talent = talent;
        }

        private void gameOverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startB_Click(object sender, EventArgs e)
        {
            GameReset();
            timer.Start();
            startB.Visible = false;
            Menu.Visible = true;
            Menu.Enabled = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            ScoreL.Visible = true;
            coinL.Visible = true;
            pictureBox1.Visible = true;
            Obstacle.Visible = true;
            Character.Visible = true;
            ground.Visible = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            h = 0;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ScoreL.Text = h.ToString();

            Character.Top += jumpSpeed;

            if (jump == true && force < 0)
            {
                jump = false;
            }

            if (jump == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (Character.Top > 420 && jump == false)
            {
                force = 20;
                Character.Top = 421;
                jumpSpeed = 0;
            }

            foreach(Control c in this.Controls)
            {
                if(c is PictureBox && (string)c.Tag == "obstacle")
                {
                    c.Left -= obstacleSpeed;

                    if(c.Left < -100)
                    {
                        c.Left = this.ClientSize.Width + r.Next(200, 500) + (c.Width * 15);
                        h++;
                    }

                    if(Character.Bounds.IntersectsWith(c.Bounds))
                    {
                        timer.Stop();
                        Character.Image = Image.FromFile(@"D:\\Programozas\\c#\\Atestat\\Ultimate_TRex_Game_Atestat\\bin\\Debug\\Fogyikamikorkivalasztod.png");
                        Character.SizeMode = PictureBoxSizeMode.StretchImage;
                        MessageBox.Show("FOGYIKA BESZT");
                        isGameOver = true;
                    }
                }
            }
        }

        

        private void GameReset()
        {
            force = 20;
            jumpSpeed = 0;
            jump = false;
            ScoreL.Text = "";
            obstacleSpeed = Speed * 5;
            Character.Image = Properties.Resources.fogyika;
            isGameOver = false;
            Character.Top = 421;
            timer.Start();

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && (string)c.Tag == "obstacle")
                {
                    pos = this.ClientSize.Width + r.Next(500, 800) + (c.Width * 10);

                    c.Left = pos;
                }
            }
        }

        private void GameBoardForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) && jump == false)
            {
                jump = true;
                Character.Image = Image.FromFile(@"D:\\Programozas\\c#\\Atestat\\Ultimate_TRex_Game_Atestat\\bin\\Debug\\Repulofogyi.png");
                Character.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void GameBoardForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (jump==true)
            {
                jump = false;
                Character.Image = Image.FromFile(@"D:\\Programozas\\c#\\Atestat\\Ultimate_TRex_Game_Atestat\\bin\\Debug\\fogyika.gif");
                Character.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            if ((e.KeyCode == Keys.R) && (isGameOver == true))
            {
                MessageBox.Show("gg " + ScoreL.ToString());
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void continueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Menuke_MouseHover(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
