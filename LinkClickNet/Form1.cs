using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Dropbox.Api;
using Dropbox.Api.Files;
//using Microsoft.Toolkit.Uwp.Notifications;

namespace LinkClickNet
{

    public partial class Form1 : Form
    {
        static string token = "pHCR9I06XqQAAAAAAAAAARUW9REALIVn4MXFSkd_kEIFQV8mmRCbVQ0Ahk8k5Utd";
        static string someText = "";
        static string new_ver;
        public Form1()
        {
            InitializeComponent();
            /*DROPBOX
            Login: tofamo8882@cyadp.com.
            Password: Lolkek228 */
            /*
            new ToastContentBuilder()
            .AddText("Adaptive Tiles Meeting", hintMaxLines: 1)
            .AddText("Conf Room 2001 / Building 135")
            .AddText("10:00 AM - 10:30 AM");
            */
            StreamReader version = new StreamReader(Environment.CurrentDirectory+
                                     @"\version.txt");
            
            new_ver = version.ReadLine();
            //Properties.Settings.Default.Version = new_ver;
            try
            { 
                var task = Task.Run((Func<Task>)Form1.Run);
                task.Wait();

            }
            catch 
            {
                MessageBox.Show("У вас ошибка с подключением, попробуйте еще раз");
                Environment.Exit(0);
            }

        }
        static async Task Run()
        {
            
            using (var dbx = new DropboxClient(token))
            {
                var full = await dbx.Users.GetCurrentAccountAsync();
                Console.WriteLine("{0} - {1}", full.Name.DisplayName, full.Email);
            }
        }
        static async Task Download()
        {
            using (var dbx = new DropboxClient(token))
            {
                using (var response = await dbx.Files.DownloadAsync("/link.txt"))
                {
                    Open_Link(await response.GetContentAsStringAsync());
                }
            }
        }
        static async Task Upload()
        {
            using (var dbx = new DropboxClient(token))
            {
                using (var mem = new MemoryStream(Encoding.UTF8.GetBytes(someText)))
                {
                    var updated = await dbx.Files.UploadAsync(
                        "/link.txt",
                        WriteMode.Overwrite.Instance,
                        body: mem);
                    Console.WriteLine("Saved / link.txt", updated.Rev);
                }
            } 
        }

        private void Link_button_Click(object sender, EventArgs e)
        {
            try
            {
                var task = Task.Run((Func<Task>)Form1.Download);
                task.Wait();
            }
            catch
            {
                MessageBox.Show("У вас ошибка с браузером, возможно вы указали тот, которого нет \n Или проблема с ссылкой))");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText() == true)
            {
                someText = Clipboard.GetText();

                var task = Task.Run((Func<Task>)Form1.Upload);
                task.Wait();

            }
            else
            {
                MessageBox.Show(this, "В буфере обмена нет текста", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Setting_button_Click(object sender, EventArgs e)
        {
            Setting_Form newForm = new Setting_Form();
            newForm.Show();
        }

        private static void Open_Link(string url)
        {
            var process = new Process();
            string browser = "", mode = "", beginUrl = "";
            switch (Properties.Settings.Default.DefaultBrowser)
            {
                case "Chrome":
                    {
                        browser = "\\Google\\Chrome\\Application\\chrome.exe";
                        beginUrl = @"C:\Program Files";
                        if (Properties.Settings.Default.DefaultMode == "Normal")
                        {
                            mode = "";
                        }    
                        else
                        {
                            mode = " --incognito";
                        }
                        break;
                    }
                case "mozilla":
                    {
                        browser = @"\Mozilla Firefox\firefox.exe";
                        beginUrl = @"C:\Program Files";
                        if (Properties.Settings.Default.DefaultMode == "Normal")
                            mode = "";
                        else
                            mode = " -private-window";
                        break;
                    }
                case "Explorer":
                    {
                        browser = @"iexplore.exe";
                        beginUrl = "";
                        break;
                    }
                case "Yandex":
                    {
                        browser = @"\Yandex\YandexBrowser\Application\browser.exe";
                        beginUrl = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) ;
                        if (Properties.Settings.Default.DefaultMode == "Normal")
                        {
                            mode = "";
                        }
                        else
                        {
                            mode = " --incognito";
                        }
                        break;
                    }
                case "Opera":
                    {
                        browser = @"\Opera\launcher.exe";
                        beginUrl = @"C:\Program Files";
                        break;
                    }
                case "Edge":
                    {
                        browser = "msedge";
                        beginUrl = "";
                        if (Properties.Settings.Default.DefaultMode == "Normal")
                            mode = "";
                        else
                            mode = " -inprivate";
                        break;
                    }
                default:
                    {
                        System.Diagnostics.Process.Start(url);
                        break;
                    }
            }
            try
            {

                if (browser != "")
                {
                    process.StartInfo.FileName = beginUrl + browser;
                    process.StartInfo.Arguments = url + mode;
                    process.Start();
                }
            }
            catch
            {
                process.StartInfo.FileName = @"C:\Program Files (x86)" + browser;
                process.StartInfo.Arguments = url + mode;
                process.Start();
            }
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                var task = Task.Run((Func<Task>)Form1.Update_check);
                task.Wait();
                if (Properties.Settings.Default.Version != new_ver)
                {
                    MessageBox.Show("Вышла новая версия !!!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    update_win newForm = new update_win();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("У вас актуальная версия " + Properties.Settings.Default.Version + "   " + new_ver, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                MessageBox.Show("У вас ошибка с браузером, возможно вы указали тот, которого нет \n Или проблема с ссылкой))");
            }

        }

        static async Task Update_check()
        {
            
            using (var dbx = new DropboxClient(token))
            {
                using (var response = await dbx.Files.DownloadAsync("/version.txt"))
                {
                    new_ver = await response.GetContentAsStringAsync();
                }
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
