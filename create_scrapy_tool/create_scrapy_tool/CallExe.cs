using System;
using System.Diagnostics;

namespace create_scrapy_tool
{
    public class CallExe
    {

        public static void RunExe(string strProjectName, string strDomain)
        {
            string strBatName = "create_scrapy_project.bat";
            Process p = new Process();
            p.StartInfo.FileName = strBatName;
            string sArguments = strProjectName + " " + strDomain;
            // MessageBox.Show(sArguments);
            p.StartInfo.Arguments = sArguments;
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.Verb = "runas";
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.RedirectStandardInput = true;
            //p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = false;
            p.Start();
            p.CloseMainWindow();
            p.WaitForExit();
            p.Close();
            p.Dispose();
        }
    }
}