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

        private int speed, lives;
        private string talent, nume;
        private Point loc;
        private bool selectedA = false, selectedB = false, selectedC = false;
        private void ChooseForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1121, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            loc = this.Location;
            ContinueB.Enabled = false;
            this.LocationChanged += ChooseForm_LocationChanged;

            Char1.BackgroundImage = Image.FromFile(@"D:\Programozas\c#\Atestat\Ultimate_TRex_Game_Atestat\bin\Debug\Random.png");
            Char1.SizeMode = PictureBoxSizeMode.StretchImage;
            Char1.Location = new Point((this.ClientSize.Width - Char2.Width) / 2 - 250, (this.ClientSize.Height - Char2.Height) / 2 - 50);

            Char2.BackgroundImage = Image.FromFile(@"D:\Programozas\c#\Atestat\Ultimate_TRex_Game_Atestat\bin\Debug\Proba2csukott.png");
            Char2.SizeMode = PictureBoxSizeMode.StretchImage;
            Char2.Location = new Point((this.ClientSize.Width - Char2.Width) / 2, (this.ClientSize.Height - Char2.Height) / 2 - 50);

            Char3.BackgroundImage = Image.FromFile(@"D:\Programozas\c#\Atestat\Ultimate_TRex_Game_Atestat\bin\Debug\Proba3nyugodt.png");
            Char3.SizeMode = PictureBoxSizeMode.StretchImage;
            Char3.Location = new Point((this.ClientSize.Width - Char2.Width) / 2 + 250, (this.ClientSize.Height - Char2.Height) / 2 - 50);

            notes.Visible = false;
            name.Visible = false;
        }

        private void ChooseForm_LocationChanged(object? sender, EventArgs e)
        {
            this.Location = loc;
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ContinueB_Click(object sender, EventArgs e)
        {
            GameBoardForm f = new GameBoardForm();
            GameBoardForm.Karakter_tulajdonsagai(speed, lives, talent, nume);
            f.ShowDialog();
            
        }

        private void Char2_Click(object sender, EventArgs e)
        {
            ContinueB.Enabled = true;
            selectedA = selectedB = selectedC = false;
            Char3_MouseLeave(sender, e);

            foreach(Control control in this.Controls)
            {
                if(control is PictureBox)
                {
                    ((PictureBox)control).BorderStyle = BorderStyle.None;
                }
            }

            (sender as PictureBox).BorderStyle = BorderStyle.FixedSingle;
            
            if((sender as PictureBox).Name == "Char1" && (sender as PictureBox).BorderStyle == BorderStyle.FixedSingle)
            {
                selectedA = true;
                Char1.BackgroundImage = Image.FromFile(@"D:\Programozas\c#\Atestat\Ultimate_TRex_Game_Atestat\bin\Debug\Randomje.png");
                Char1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((sender as PictureBox).Name == "Char2" && (sender as PictureBox).BorderStyle == BorderStyle.FixedSingle)
            {
                selectedB = true;
                Char2.BackgroundImage = Image.FromFile(@"D:\Programozas\c#\Atestat\Ultimate_TRex_Game_Atestat\bin\Debug\Proba2ul.png");
                Char2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((sender as PictureBox).Name == "Char3" && (sender as PictureBox).BorderStyle == BorderStyle.FixedSingle)
            {
                selectedC = true;
                Char3.BackgroundImage = Image.FromFile(@"D:\Programozas\c#\Atestat\Ultimate_TRex_Game_Atestat\bin\Debug\Proba3sikit.png");
                Char3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Char2_MouseHover(object sender, EventArgs e)
        {
            notes.Visible = true;
            name.Visible = true;

            if((sender as PictureBox).Name == "Char1")
            {
                name.Text = "Nyaki";
                Char1.BackgroundImage = Image.FromFile(@"D:\Programozas\c#\Atestat\Ultimate_TRex_Game_Atestat\bin\Debug\Randomje.png");
                Char1.SizeMode = PictureBoxSizeMode.StretchImage;
                speed = 3;
                lives = 2;
                talent = "invisibility";
                nume = "Nyaki";
            }
            else if ((sender as PictureBox).Name == "Char2")
            {
                name.Text = "Triko";
                Char2.BackgroundImage = Image.FromFile(@"D:\Programozas\c#\Atestat\Ultimate_TRex_Game_Atestat\bin\Debug\Proba2ul.png");
                Char2.SizeMode = PictureBoxSizeMode.StretchImage;
                speed = 6;
                lives = 4;
                talent = "destroying";
                nume = "Triko";
            }
            else if ((sender as PictureBox).Name == "Char3")
            {
                name.Text = "Dini";
                notes.Text = "speed: 5\nlives: 3\ntalent: skateboard";
                Char3.BackgroundImage = Image.FromFile(@"D:\Programozas\c#\Atestat\Ultimate_TRex_Game_Atestat\bin\Debug\Proba3sikit.png");
                Char3.SizeMode = PictureBoxSizeMode.StretchImage;
                speed = 5;
                lives = 3;
                talent = "skateboard";
                nume = "Dini";
                
            }

            notes.Text = speed.ToString() + '\n' + lives.ToString() + '\n' + talent;
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

            if (!selectedA)
            {
                Char1.BackgroundImage = Image.FromFile(@"D:\Programozas\c#\Atestat\Ultimate_TRex_Game_Atestat\bin\Debug\Random.png");
                Char1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (!selectedB)
            {
                Char2.BackgroundImage = Image.FromFile(@"D:\Programozas\c#\Atestat\Ultimate_TRex_Game_Atestat\bin\Debug\Proba2csukott.png");
                Char2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (!selectedC)
            {
                Char3.BackgroundImage = Image.FromFile(@"D:\Programozas\c#\Atestat\Ultimate_TRex_Game_Atestat\bin\Debug\Proba3nyugodt.png");
                Char3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
