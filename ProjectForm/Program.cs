using System.Diagnostics;

namespace ProjectForm
{
    internal static class Program
    {
        static Process? webApiProcess;

        [STAThread]
        static void Main()
        {
            string apiPath = Path.Combine(Application.StartupPath, "ProjectAPI", "Project.API.exe");
            //try
            //{
            //    if (File.Exists(apiPath))
            //    {
            //        webApiProcess = Process.Start(new ProcessStartInfo
            //        {
            //            FileName = apiPath, // Use full path
            //            WorkingDirectory = Path.GetDirectoryName(apiPath)!,
            //            CreateNoWindow = true,
            //            UseShellExecute = false,
            //        });

            //        Application.ApplicationExit += (s, e) =>
            //        {
            //            try { if (webApiProcess is { HasExited: false }) webApiProcess.Kill(); }
            //            catch { }
            //        };
            //    }

            //    else
            //    {
            //        MessageBox.Show("Web API executable not found!" + apiPath);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error starting Web API: " + ex.Message + apiPath);
            //}

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }
    }
}
