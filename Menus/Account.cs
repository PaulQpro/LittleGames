using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LittleGames
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        class Data
        {
            public string? Name { get; set; }
            public string? Password { get; set; }
        }
        private void Continue_Click(object sender, EventArgs e)
        {
            
        }

        private void Register_click(object sender, EventArgs e)
        {
            if (UsernameBox.Text.Trim() != "" && PasswordBox.Text.Trim() != "")
            {
                Data data = new()
                {
                    Name = UsernameBox.Text,
                    Password = PasswordBox.Text
                };
                string JSONdata = JsonSerializer.Serialize(data);
                string path = @"Accounts";
                Directory.CreateDirectory(path);
                string filePath = $"{path}/{data.Name}.pgaccount";
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(JSONdata);
                }
                DialogResult = DialogResult.OK;
                Thread.Sleep(1000);
                Close();
            }
            else
            {
                MessageBox.Show("Emtry Username and/or Password");
            }
        }
    }
}
