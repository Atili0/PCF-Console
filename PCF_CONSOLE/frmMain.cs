namespace PCF_CONSOLE
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Utils;
    using Helper;
    

    public partial class frmMain : Form, IPCFView
    {
        private IPCFController _controllers;
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public void SetController(IPCFController cont)
        {
            _controllers = cont;
        }
    

        public frmMain()
        {
            InitializeComponent();

            //Eventos del formulario
            this.btnBrowserFolder.Click += BtnBrowserFolder_Click;
            this.btnCreateFolder.Click += BtnCreateFolder_Click;
            this.btnCheck.Click += BtnCheck_Click;
            
            Log.InitLog();
            Logger.Info("Init app for PCF");
                                 
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                _controllers.InitConsoleControl(ccCMD);

                RunCommandLine(_controllers.GetLastVersion());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnCreateFolder_Click(object sender, EventArgs e)
        {
            //ccCMD.StartProcess("cd", "C:/Users/arosases/Documents/arosas/CODE/consolecontrol/source");

            //ccCMD.StartProcess("cmd", $"/K powershell");

            _controllers._PcfObject = new PcfObject() { 
                sName = txtName.Text,
                sNamespace = txtNamespace.Text,
                sTemplate = cbTemplate.SelectedItem.ToString(),
                sFolder = txtFolder.Text
            };


            //string _RootFolder = Comandos.Cmd.ChangeDirectory($"{txtFolder.Text}");
            string _RootFolder = _controllers.ChangeDirectory();
            //string _NpmComando = Comandos.ComandoNpm.Install();
            
            string _InstallPacPcf = _controllers.PACInstall();
            string _InstallNpm = _controllers.NPMInstall();

            RunCommandLine(_RootFolder, _InstallPacPcf, _InstallNpm);
        }

        //"C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\"
        //%comspec% /k "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\Common7\Tools\VsDevCmd.bat"
        private void BtnCreateMainFolder_Click(object sender, EventArgs e)
        {

           
        }

        //public static string GetWindowsVersion()
        //{
        //    return ConsoleApp.Run("cmd", "/c ver").Output.Trim();
        //}

        private void RunCommandLine(params string[] commands)
        {
            // Make sure display is not corrupted when clicked anywhere on the console
            ccCMD.InternalRichTextBox.SelectionStart = ccCMD.InternalRichTextBox.Text.Length;
            ccCMD.InternalRichTextBox.SelectionLength = 0;

            //CurrentCommandOutput = string.Empty;
            //if (commands.Contains(Commands.Npm.RunBuild())
            //    || commands.Contains(Commands.Msbuild.Rebuild())
            //    || commands.Contains(Commands.Msbuild.BuildRelease())
            //    || commands.Contains(Commands.Msbuild.RebuildRelease())
            //    || commands.Contains(Commands.Npm.Start())
            //    || commands.Contains(Commands.Npm.StartWatch()))
            //{
            //    StatusCheckExecution = true;
            //}

            //if (commands.Contains(Commands.Pac.ListProfiles()))
            //{
            //    ListProfileExecution = true;
            //}
            //else
            //{
            //    ListProfileExecution = false;
            //}

            //// If any pac auth command found then refrsh the current auth profile details on form
            //if (commands.Any(s => s.Contains("pac auth")))
            //{
            //    _mainPluginLocalWorker = new BackgroundWorker();
            //    _mainPluginLocalWorker.DoWork += CheckDefaultAuthenticationProfile;
            //    _mainPluginLocalWorker.RunWorkerAsync();
            //}

            foreach (var cmd in commands)
            {
                ccCMD.WriteInput(cmd, Color.White, true);
            }

            ccCMD.WriteInput("\r\n", Color.Green, true);
            ccCMD.InternalRichTextBox.ScrollToCaret();
        }

        private void BtnBrowserFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFolder.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void btnBrowserFolder_Click_1(object sender, EventArgs e)
        {

        }

      
    }
}
