using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace HandyTool
{
    public partial class form : Form
    {
        public Process startHubProcess = new Process();
        public Process startNodeProcess = new Process();
        public Process adbDevicesProcess = new Process();
        public Process appwizProcess = new Process();
        public Process hostsFileProcess = new Process();
        public Process eventViewerProcess = new Process();

        //set to true to hide cmd windows, false is useful for testing
        public Boolean createNoProcessWindows = true;

        public string pathToNotepad = "C:\\Windows\\Notepad.exe";
        public string hostsFilepath = "C:\\Windows\\System32\\Drivers\\etc\\hosts";

        string geckodriver = "geckodriver-0.18.0.exe";
        string chromedriver = "chromedriver-2.31";
        string iedriver = "IEDriverServer";

        public form()
        {
            InitializeComponent();

            string seleniumServerPath = Common.Common.returnAssetsPath() + "selenium-server-3.5.0.jar";

            #region HUB PROCESS
            //set properties for Hub process
            string hubJarParameters = " -role hub -timeout 86400 -browserTimeout 86400";
            startHubProcess.StartInfo.FileName = "java";
            startHubProcess.StartInfo.Arguments = @"-jar " + seleniumServerPath + " " + hubJarParameters;
            Console.WriteLine(startHubProcess.StartInfo.Arguments);
            //startHubProcess.StartInfo.Arguments = @"-Dwebdriver.server.session.timeout=86400 -jar " + seleniumServerPath + " " + hubJarParameters;
            startHubProcess.StartInfo.UseShellExecute = false;
            startHubProcess.StartInfo.CreateNoWindow = createNoProcessWindows;
            #endregion

            #region NODE PROCESS
            //set properties for Node process
            string chromeDriverPath = Common.Common.returnAssetsPath() + chromedriver;
            string ieDriverPath = Common.Common.returnAssetsPath() + iedriver;
            string firefoxDriverPath = Common.Common.returnAssetsPath() + geckodriver;
            string webDriverParameters = "-Dwebdriver.gecko.driver=" + firefoxDriverPath + " -Dwebdriver.chrome.driver=" + chromeDriverPath + " -Dwebdriver.ie.driver=" + ieDriverPath;
            string nodeConfigPath = Common.Common.returnAssetsPath() + "nodeconfig.json";
            string nodeConfigParameters = " -nodeConfig " + nodeConfigPath;            
            string ipAddress = Common.Common.GetLocalIPAddress();

            //selenium 2 settings
            //string nodeJarParameters = " -role webdriver -hub http://" + ipAddress + ":4444 /grid/register -port 5556 -browser browserName=firefox,platform=WINDOWS -browser browserName=chrome,platform=WINDOWS -Dwebdriver.chrome.driver=" + chromeDriverPath + " -browser browserName=\"internet explorer\",platform=WINDOWS -Dwebdriver.ie.driver=" + ieDriverPath + " -timeout  86400";
            //startNodeProcess.StartInfo.Arguments = @"-jar " + seleniumServerPath + " " + nodeJarParameters;
            
            //selenium 3 settings
            string nodeJarParameters = " -role node"; 
            startNodeProcess.StartInfo.Arguments = @"" + webDriverParameters + " -jar " + seleniumServerPath + " " + nodeJarParameters + nodeConfigParameters;
                                
            Console.WriteLine(startNodeProcess.StartInfo.Arguments);

            startNodeProcess.StartInfo.FileName = "java";
            startNodeProcess.StartInfo.UseShellExecute = false;
            startNodeProcess.StartInfo.CreateNoWindow = createNoProcessWindows;
            #endregion

            //set properties for adb devices            
            adbDevicesProcess.StartInfo.FileName = "cmd.exe";            
            adbDevicesProcess.StartInfo.Arguments = "/c adb devices";
            adbDevicesProcess.StartInfo.UseShellExecute = false;            
            adbDevicesProcess.StartInfo.RedirectStandardOutput = true;
            adbDevicesProcess.StartInfo.CreateNoWindow = createNoProcessWindows;

            //set properties for appwiz           
            appwizProcess.StartInfo.FileName = "cmd.exe";
            appwizProcess.StartInfo.Arguments = "/c appwiz.cpl";
            appwizProcess.StartInfo.UseShellExecute = false;
            appwizProcess.StartInfo.RedirectStandardOutput = true;
            appwizProcess.StartInfo.CreateNoWindow = createNoProcessWindows;

            //set properties for hosts file
            hostsFileProcess.StartInfo.FileName = pathToNotepad;         
            hostsFileProcess.StartInfo.Arguments = hostsFilepath;
            hostsFileProcess.StartInfo.Verb = "runas"; //run as administrator           
            hostsFileProcess.StartInfo.UseShellExecute = true;           
            hostsFileProcess.StartInfo.CreateNoWindow = createNoProcessWindows;

            //set properties for event viewer           
            eventViewerProcess.StartInfo.FileName = "cmd.exe";
            eventViewerProcess.StartInfo.Arguments = "/c eventvwr";
            eventViewerProcess.StartInfo.UseShellExecute = false;
            eventViewerProcess.StartInfo.RedirectStandardOutput = true;
            eventViewerProcess.StartInfo.CreateNoWindow = createNoProcessWindows;
        }

        #region BUTTON CLICKS

        private void btnStartHub_Click(object sender, EventArgs e)
        {
            startHubProcess.Start();
            this.btnStartHub.Enabled = false;
            this.btnStopHub.Enabled = true;
            this.btnStartNode.Enabled = true;

        }

        private void btnStopHub_Click(object sender, EventArgs e)
        {
            closeSeleniumNodeProcess();
            closeSeleniumHubProcess();
            this.btnStopHub.Enabled = false;
            this.btnStartHub.Enabled = true;
            this.btnStopNode.Enabled = false;
            this.btnStartNode.Enabled = false;
        }        

        private void btnStartNode_Click(object sender, EventArgs e)
        {
            startNodeProcess.Start();
            btnStartNode.Enabled = false;
            btnStopNode.Enabled = true;
        }

        private void btnStopNode_Click(object sender, EventArgs e)
        {
            closeSeleniumNodeProcess();
            btnStartNode.Enabled = true;
            btnStopNode.Enabled = false;
        }

        private void btnADBDevices_Click(object sender, EventArgs e)
        {
            adbDevicesProcess.Start();
            string output = adbDevicesProcess.StandardOutput.ReadToEnd();
            Console.WriteLine(output);            
            this.txtAdbDevices.Text = output;
        }

        private void btnAddRemovePrograms_Click(object sender, EventArgs e)
        {
            appwizProcess.Start();
        }

        private void btnHostsFile_Click(object sender, EventArgs e)
        {
            hostsFileProcess.Start();
        }

        private void btnEventViewer_Click(object sender, EventArgs e)
        {
            eventViewerProcess.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeAllProcesses();
        }

        #region FUNCTIONS

        private void closeAllProcesses()
        {
            closeSeleniumHubProcess();
            closeSeleniumNodeProcess();
        }


        private void closeSeleniumHubProcess()
        {
            if (Common.Common.IsRunning(startHubProcess))
            {
                startHubProcess.Kill();
            }
        }

        private void closeSeleniumNodeProcess()
        {
            if (Common.Common.IsRunning(startNodeProcess))
            {
                startNodeProcess.Kill();
            }
        }       
        
        #endregion

        

        
    }
}
