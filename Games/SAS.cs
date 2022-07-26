using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LittleGames.Games
{
    public partial class SAS : Form
    {
        public SAS()
        {
            InitializeComponent();
        }
        string[] log = new string[0];
        private void Send_Click(object sender, EventArgs e)
        {
            if (Console_window.PreferredHeight >= Console_window.Height) 
            {
                Array.Resize(ref log, log.Length + 1);
                log[log.Length - 1] = Console_window.Items[0].ToString();
                Console.WriteLine(log[log.Length - 1]);
                Console_window.Items.RemoveAt(0);
            }
            if (InputLine.Text.Trim() != "") Console_window.Items.Add(InputLine.Text.Trim());
            InputLine.Text = "";
        }
        bool MailOpened = false;
        private void Mail_Click(object sender, EventArgs e)
        {
            string resX = @"Resources.resx";
            using ResXResourceSet resxSet = new(resX);
            Image opened = (Image)resxSet.GetObject(@"Mail_Opened");
            Image closed = (Image)resxSet.GetObject(@"Mail_Closed");
            if (MailOpened)
            {
                MailOpened = false;
                Mail.Image = closed;
            }
            else
            {
                MailOpened = true;
                Mail.Image = opened;
            }

        }

        private void Close_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Console_window.Items.Count; i++)
            {
                Array.Resize(ref log, log.Length + 1);
                log[log.Length - 1] = Console_window.Items[0].ToString();
                Console.WriteLine(log[log.Length - 1]);
            }
            string path = @"logs/";
            Directory.CreateDirectory(path);
            DateTime date = DateTime.Now;
            string filePath = path + date.Year + "-" + date.Month + "-" + date.Day + "_" + date.Hour + "." + date.Minute + "." + date.Second + ".log";
            using (StreamWriter sw = File.CreateText(filePath))
            {
                for(int i = 0; i < log.Length; i++)
                {
                    sw.WriteLine(log[i]);
                }
            }
            Close();
        }
    }
}
