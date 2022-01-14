using System;
using System.IO;
using Dropbox.Api;
using Dropbox.Api.Files;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
namespace LinkClickUpdater
{
    class Program
    {
        static string token = "pHCR9I06XqQAAAAAAAAAARUW9REALIVn4MXFSkd_kEIFQV8mmRCbVQ0Ahk8k5Utd";
        static void Main(string[] args)
        {
            
            Console.WriteLine("Идет обновление программы");
            load_anim();
            try
            {
                var task = Task.Run((Func<Task>)Program.Run);
                task.Wait();
                try
                {
                    Process.Start(Environment.CurrentDirectory + @"\LinkClickNet.exe");
                }
                catch
                {
                    Console.WriteLine("\nЧто то не так с файлом, попробуйте запустить его вручную");
                }
                Console.WriteLine("\nОбновление закончено");
            }
            catch
            {
                Console.WriteLine("\nОбновление не установлено, проверьте соединение");
            }
            Environment.Exit(0);
        }
        static async Task Run()
        {
            using (var dbx = new DropboxClient(token))
            {
                using (var response = await dbx.Files.DownloadAsync("/LinkClickNet.exe"))
                {
                    string path = System.IO.Path.Combine(Environment.CurrentDirectory,
                                     @"..\LinkClickNet.exe");
                    using (var fileStream = File.Create(path))
                    {
                        (await response.GetContentAsStreamAsync()).CopyTo(fileStream);
                    }
                }
                using (var response = await dbx.Files.DownloadAsync("/version.txt"))
                {
                    string path = System.IO.Path.Combine(Environment.CurrentDirectory,
                                     @"..\version.txt");
                    using (var fileStream = File.Create(path))
                    {
                        (await response.GetContentAsStreamAsync()).CopyTo(fileStream);
                    }
                }
            }
        }
        static void load_anim()
        {
            for(int i=0; i<10; i++)
            {
                Console.Write("...");
                Thread.Sleep(200);
            }
            
        }
    }
}
