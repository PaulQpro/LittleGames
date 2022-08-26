using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LittleGames
{
    public partial class Options : Form
    {
        ResXResourceSet DefaultLang;
        ResXResourceSet OptionsLang;
        string lang;
        public Options(string lang)
        {
            this.lang = lang;
            DefaultLang = new($"Lang\\{lang}.resx");
            OptionsLang = new($"Lang\\Options\\{lang}.resx");
            InitializeComponent();
            LanguageLabel.Text = OptionsLang.GetString("Language");
            Apply_btn.Text = DefaultLang.GetString("Apply");
            if(lang == "RU-RU")
            {
                Rus.Checked = true;
                Eng.Checked = false;
            }
        }

        private void Apply_btn_Click(object sender, EventArgs e)
        {
            string LangApply;
            if (Eng.Checked)
            {
                LangApply = "EN-US";
            }
            else if (Rus.Checked)
            {
                LangApply = "RU-RU";
            }
            else
            {
                LangApply = lang;
            }
            MessageBox.Show(OptionsLang.GetString("language_change"),DefaultLang.GetString("Apply"),MessageBoxButtons.OK,MessageBoxIcon.Warning);
            using (StreamWriter sw = File.CreateText(@"Lang/Lang.lang"))
            {
                sw.WriteLine($"{{\"Lang\":\"{LangApply}\"}}");
                Close();
            }
        }
    }
}
