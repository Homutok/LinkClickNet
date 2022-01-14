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

namespace LinkClickNetDev
{
    public partial class LinkClickNetDev : Form
    {
        static string version = "0.96";
        public LinkClickNetDev()
        {
            InitializeComponent();
        }

        private void open_project_Click(object sender, EventArgs e)
        {

            System.Console.WriteLine("Кхм-кхм");
        }
        static string token = "pHCR9I06XqQAAAAAAAAAARUW9REALIVn4MXFSkd_kEIFQV8mmRCbVQ0Ahk8k5Utd";
        private void upload_update_Click(object sender, EventArgs e)
        {
            var task = Task.Run((Func<Task>)LinkClickNetDev.Run);
            task.Wait();
        }
        static async Task Run()
        {
            if (version !="0.96")
            using (var dbx = new DropboxClient(token))
            {
                using (var fileStream = File.Open(@"C:\Users\sanya\source\repos\LinkClickNet\LinkClickNet\bin\Debug\LinkClickNet.exe", FileMode.Open))
                {
                    await dbx.Files.DeleteAsync("/LinkClickNet.exe");
                    await dbx.Files.UploadAsync("/LinkClickNet.exe", body: fileStream);
                    using (var mem = new MemoryStream(Encoding.UTF8.GetBytes(version)))
                    {
                        var updated = await dbx.Files.UploadAsync(
                            "/version.txt",
                            WriteMode.Overwrite.Instance,
                            body: mem);
                        Console.WriteLine("Saved ", updated.Rev);
                    }
                }
            }
            else
            {
                MessageBox.Show("Версия должна быть другой", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void version_box_TextChanged(object sender, EventArgs e)
        {
            version = version_box.Text;
        }

        private void Выход_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
