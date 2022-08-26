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
        void DDoSAttack()
        {
            Console_window.Items.Add("DDoS"); Thread.Sleep(100);
            if (closing) return;
        }
        class ServerEvent
        {
            public EventType type;
            public bool happening = false;
        }

        enum EventType
        {
            DDoS,
            Users,
            Crash
        }

        ServerEvent serverEvent = new();
        string lang;
        ResXResourceSet DefaultLang;
        ResXResourceSet SASLang;
        public SAS(string lang)
        {
            this.lang = lang;
            DefaultLang = new($"Lang\\{lang}.resx");
            SASLang = new($"Lang\\SAS\\{lang}.resx");
            InitializeComponent();
            Mail.Text = SASLang.GetString("Mail");
            Close_btn.Text = SASLang.GetString("Shutdown");
            Console_window.Items.Clear();
            string[] consoleStart = SASLang.GetString("Welcome_Console").Split("\\n");
            Text = "Paul's Software© Server System™ 2022";
            foreach(string s in consoleStart)
            {
                Console_window.Items.Add(s);
            }
        }
        string[] log = new string[0];
        bool ServerOpened = false;
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
            if (InputLine.Text.Trim().ToUpper() == "OPEN" && !ServerOpened)
            {
                ServerOpened = true;
                Action ddos = DDoSAttack;
                Task.Run(() =>
                {
                    Random random = new Random();
                    while (true)
                    {
                        while (serverEvent.happening)
                        {
                            if(serverEvent.type == EventType.DDoS)
                            {
                                Invoke(ddos);
                                Thread.Sleep(400);
                                if (closing) { ServerOpened = false; break; }
                            }
                        }
                        int r = random.Next(1,101);
                        if(r >= 10 && r <=15)
                        {
                            Console.WriteLine("DDoS!!");
                            serverEvent.happening = true;
                            serverEvent.type = EventType.DDoS;
                        }
                        else if(r == 20)
                        {
                            Console.WriteLine("Lot of Users!!!");
                            //serverEvent.happening = true;
                            //serverEvent.type = EventType.Users;
                        }
                        else if (!ServerOpened)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(r+"Nothing");
                        }
                        Thread.Sleep(1000);
                    }
                });
            }
            else if (InputLine.Text.Trim().ToUpper() == "OPEN")
            {
                Console_window.Items.Add("Server is already opened");
            }
            else if (InputLine.Text.Trim().ToUpper() == "DDOS")
            {
                serverEvent.happening = false;
                Console_window.Items.Add("You Avoided DDoS Attack");
            }
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
            /*Mail.Image = opened;
            new MailWindow().ShowDialog();
            Mail.Image = closed;*/
        }

        private void Close_Click(object sender, EventArgs e)
        {
            ServerOpened = false;
            for(int i = 0; i < Console_window.Items.Count; i++)
            {
                Array.Resize(ref log, log.Length + 1);
                log[log.Length - 1] = Console_window.Items[i].ToString();
                Console.WriteLine(log[log.Length - 1]);
            }
            string path = @"logs/";
            if (logged)
            {
                Directory.CreateDirectory(path);
                DateTime date = DateTime.Now;
                string filePath = path + date.Year + "-" + date.Month + "-" + date.Day + "_" + date.Hour + "." + date.Minute + "." + date.Second + ".log";
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    for (int i = 0; i < log.Length; i++)
                    {
                        sw.WriteLine(log[i]);
                    }
                }
                closing = true;
                Close();
            }
        }
        bool closing = false;
        bool logged = false;
        private void SAS_Load(object sender, EventArgs e)
        {
            if(new Beta(this.lang).ShowDialog() == DialogResult.OK)
            {
                logged = true;
            }
            else
            {
                Close();
            }
        }
    }
}
