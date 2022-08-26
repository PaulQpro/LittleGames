using System.Text.Json;
using System.Collections;
using System.Resources;
namespace LittleGames
{
    internal static class Program
    {
        static void checkLangResX(string path)
        {
            ResXResourceReader langRes = new(path);
            Console.WriteLine(path);
            foreach (DictionaryEntry entry in langRes)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }
        }
        class jsonLang
        {
            public string? Lang { get; set; }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            App();
        }
        static void App()
        {
            string lang;
            string path = @"Lang/";
            Directory.CreateDirectory(path);
            string filePath = path + "Lang.lang";
            if (!File.Exists(filePath))
            {
                using(StreamWriter sw = File.CreateText(filePath)) { sw.WriteLine($"{{\"Lang\":\"EN-US\"}}"); }
            }
            using (StreamReader sr = File.OpenText(filePath))
            {
                string data = sr.ReadToEnd();
                Console.WriteLine(data);
                jsonLang json = JsonSerializer.Deserialize<jsonLang>(data);
                Console.WriteLine(json.Lang);
                lang = json.Lang;
                Console.WriteLine(lang);
            }
            /*DirectoryInfo di = new DirectoryInfo("Lang");
            foreach(var resx in di.EnumerateFiles(lang+".resx",SearchOption.AllDirectories))
            {

                checkLangResX(resx.FullName);
            }*/
            /*if (new Account().ShowDialog() == DialogResult.OK)*/Application.Run(new MainMenu(lang));
            using (StreamReader sr = File.OpenText("Lang\\Lang.lang"))
            {
                if (!sr.ReadToEnd().Contains(lang))
                {
                    App();
                }
            }
        }
    }
}