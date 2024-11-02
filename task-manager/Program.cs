using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Windows.Forms;

namespace task_manager
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; private set; }

        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddIniFile("D:/task-manager/appsettings.ini", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Login());
        }
    }
}
