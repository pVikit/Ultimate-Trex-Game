namespace Ultimate_TRex_Game_Atestat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Point initialLocation;
        private void Main_Load(object sender, EventArgs e)
        {
            initialLocation = this.Location;
            this.LocationChanged += MainForm_LocationChanged;
        }

        public void MainForm_LocationChanged(object? sender, EventArgs e)
        {
            this.Location = initialLocation;
        }

        private void HelpB_Click(object sender, EventArgs e)
        {
            HelpForm f = new HelpForm();
            f.Show();
        }

        private void PlayB_Click(object sender, EventArgs e)
        {
            ChooseForm f = new ChooseForm();
            f.Location = initialLocation;
            f.Show();
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
