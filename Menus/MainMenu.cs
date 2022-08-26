using System.Threading;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace LittleGames
{
    public partial class MainMenu : Form
    {
        string lang;
        void checkDefaultLangResX(string key)
        {
            if (DefaultLang.GetString(key) == null) { MessageBox.Show("'" + key + "' Value doesn't exists in Lang\\" + lang + ".resx\nPlease repair file or reinstall game", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Close(); }
        }
        void checkMenuLangResX(string key)
        {
            if (MenuLang.GetString(key) == null) { MessageBox.Show("'" + key + "' Value doesn't exists in Lang\\" + lang + ".resx\nPlease repair file or reinstall game", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Close(); }
        }
        public MainMenu(String lang)
        {
            this.lang = lang;
            try
            {
                DefaultLang = new($"Lang\\{lang}.resx");
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e);
                MessageBox.Show("File not found \"Lang\\" + lang + ".resx\"\nPlease repair file or reinstall game", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Close();
            }
            finally
            {
                DefaultLang = new($"Lang\\{lang}.resx");
            }
            try
            {
                MenuLang = new($"Lang\\Menu\\{lang}.resx");
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e);
                MessageBox.Show("File not found \"Lang\\Menu\\" + lang + ".resx\"\nPlease repair file or reinstall game", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Close();
            }
            finally
            {
                MenuLang = new($"Lang\\Menu\\{lang}.resx");
            }
            checkDefaultLangResX("About");checkDefaultLangResX("Accept");checkDefaultLangResX("Apply");checkDefaultLangResX("Back");checkDefaultLangResX("Cancel");checkDefaultLangResX("Check");checkDefaultLangResX("Close");checkDefaultLangResX("Continue");checkDefaultLangResX("Exit");checkDefaultLangResX("Finish");checkDefaultLangResX("Options");checkDefaultLangResX("Play");checkDefaultLangResX("Reset");checkDefaultLangResX("Send");
            checkMenuLangResX("about_window");
            InitializeComponent();
            PlayBtn.Text = DefaultLang.GetString("Play");
            OptionsBtn.Text = DefaultLang.GetString("Options");
            ExitBtn.Text = DefaultLang.GetString("Exit");
        }
        ResXResourceSet DefaultLang;
        ResXResourceSet MenuLang;

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Visible = false;
            if (new SelectionMenu(lang).ShowDialog(this) != DialogResult.None)
            {
                ShowInTaskbar = true;
                Visible = true;
            }
        }

        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            new Options(lang).ShowDialog(this);
            StreamReader sr = File.OpenText("Lang\\Lang.lang");
            if (!sr.ReadToEnd().Contains(lang))
            {
                Close();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NFO_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MenuLang.GetString("about_window"), DefaultLang.GetString("About"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
        }
    }
}
