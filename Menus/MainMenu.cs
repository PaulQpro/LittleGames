using System.Threading;
namespace LittleGames
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Visible = false;
            if (new SelectionMenu().ShowDialog(this) != DialogResult.None)
            {
                ShowInTaskbar = true;
                Visible = true;
            }
        }

        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("No Options :(");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NFO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paul's Little Games Collection\nAuthor: PaulQpro\nVersion: 0.2.2\nMade using: Microsoft© Visual Studio™ 2022", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
