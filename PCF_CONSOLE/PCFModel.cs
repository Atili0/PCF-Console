namespace PCF_CONSOLE
{
    using ConsoleControl;
    using Helper;

    public class PCFModel: IPCFModel
    {
        public void InitConsoleControl(ConsoleControl pCMD ) {
            pCMD.StartProcess("cmd", $"/K powershell");
        }

        public string GetLastVersion() {
            return Comandos.ComandoPac.PacInstallLatest();
        }


        public string ChangeDirectory(PcfObject pPCFObject)
        {
            return Comandos.Cmd.ChangeDirectory($"{pPCFObject.sFolder}");
        }

        public string NPMInstall()
        {
            return Comandos.ComandoNpm.Install();
        }

        #region PAC
        public string PACInstall(PcfObject pPCFObject) {
            return Comandos.ComandoPac.PacPcfInit(pPCFObject.sNamespace,pPCFObject.sName, pPCFObject.sTemplate);
        }
        #endregion
    }
}
