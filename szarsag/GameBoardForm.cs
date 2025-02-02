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
        }

        int h = 0;
        private Point loc;
        private void GameBoardForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1121, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            loc = this.Location;
            this.LocationChanged += GameBoardForm_LocationChanged;
            startB.Visible = true;
            Menu.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            ScoreL.Visible = false;
            coinL.Visible = false;
            pictureBox1.Visible = false;
            startB.Location = new Point((this.ClientSize.Width - startB.Width) / 2, (this.ClientSize.Height - startB.Height) / 2);
        }

        private void GameBoardForm_LocationChanged(object? sender, EventArgs e)
        {
            this.Location = loc;
        }


        private void gameOverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startB_Click(object sender, EventArgs e)
        {
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
        }


        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            h = 0;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            h++;
            ScoreL.Text = h.ToString();
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
