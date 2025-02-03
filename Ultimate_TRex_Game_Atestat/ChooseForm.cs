using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimate_TRex_Game_Atestat
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();

        }

        private Point loc;
        private void ChooseForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1121, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            loc = this.Location;
            ContinueB.Enabled = false;
            this.LocationChanged += ChooseForm_LocationChanged;

            Char1.ImageLocation = "D:\\Programozas\\c#\\Ultimate_TRex_Game_Atestat\\bin\\Debug\\cat.jpg";
            Char1.SizeMode = PictureBoxSizeMode.StretchImage;
            Char1.Location = new Point((this.ClientSize.Width - Char2.Width) / 2 - 250, (this.ClientSize.Height - Char2.Height) / 2 - 50);

            Char2.ImageLocation = "D:\\Programozas\\c#\\Ultimate_TRex_Game_Atestat\\bin\\Debug\\frog.jpg";
            Char2.SizeMode = PictureBoxSizeMode.StretchImage;
            Char2.Location = new Point((this.ClientSize.Width - Char2.Width) / 2, (this.ClientSize.Height - Char2.Height) / 2 - 50);

            Char3.ImageLocation = "D:\\Programozas\\c#\\Ultimate_TRex_Game_Atestat\\bin\\Debug\\potato.jpg";
            Char3.SizeMode = PictureBoxSizeMode.StretchImage;
            Char3.Location = new Point((this.ClientSize.Width - Char2.Width) / 2 + 250, (this.ClientSize.Height - Char2.Height) / 2 - 50);

            notes.Visible = false;
            name.Visible = false;
        }

        private void ChooseForm_LocationChanged(object? sender, EventArgs e)
        {
            this.Location = loc;
        }
        int c;

        private void BackB_Click(object sender, EventArgs e)
        {
            Close();
            c = 0;
        }

        private void ContinueB_Click(object sender, EventArgs e)
        {
            GameBoardForm f = new GameBoardForm();
            f.ShowDialog();
        }

        private void Char2_Click(object sender, EventArgs e)
        {
            ContinueB.Enabled = true;

            foreach(Control control in this.Controls)
            {
                if(control is PictureBox)
                {
                    ((PictureBox)control).BorderStyle = BorderStyle.None;
                }
            }
            (sender as PictureBox).BorderStyle = BorderStyle.FixedSingle;
        }

        private void Char2_MouseHover(object sender, EventArgs e)
        {
            notes.Visible = true;
            name.Visible = true;
            if((sender as PictureBox).Name == "Char1")
            {
                name.Text = "Nyaki";
                notes.Text = "speed: 3\nlives: 2\ntalent: invisibility";
            }
            else if ((sender as PictureBox).Name == "Char2")
            {
                name.Text = "Triko";
                notes.Text = "speed: 6\nlives: 4\ntalent: destroying";
            }
            else if ((sender as PictureBox).Name == "Char3")
            {
                name.Text = "Dini";
                notes.Text = "speed: 5\nlives: 3\ntalent: skateboard";
            }
            notes.BackColor = Color.White;
            notes.ForeColor = Color.Green;
            name.ForeColor = Color.Green;
            notes.Font = new Font("Times New Roman", 14);
            name.Font = new Font("Times New Roman", 16);
            notes.Location = new Point((sender as PictureBox).Left + 10, (sender as PictureBox).Height + 2 * notes.Height);
            name.Location = new Point((sender as PictureBox).Left + 10, (sender as PictureBox).Height - 15 - notes.Height);
        }

        private void Char3_MouseLeave(object sender, EventArgs e)
        {
            notes.Visible = false;
            name.Visible = false;
        }
    }
}
