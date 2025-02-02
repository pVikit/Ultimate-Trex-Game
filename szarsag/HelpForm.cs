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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private Point loc;

        private void Help_Load(object sender, EventArgs e)
        {
            HelpText.LoadFile("D:\\Programozas\\c#\\Ultimate_TRex_Game_Atestat\\help.rtf");
            HelpText.Font = new Font("Times New Roman", 14);
            HelpText.BackColor = Color.FloralWhite;
            loc = this.Location;
            this.LocationChanged += HelpForm_LocationChanged; ;
        }

        private void HelpForm_LocationChanged(object? sender, EventArgs e)
        {
            this.Location = loc;
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HelpText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
