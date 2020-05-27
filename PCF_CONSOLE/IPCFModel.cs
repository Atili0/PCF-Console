namespace PCF_CONSOLE
{
    using ConsoleControl;
    public interface IPCFModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pCMD"></param>
        void InitConsoleControl(ConsoleControl pCMD);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetLastVersion();

        /// <summary>
        /// 
        /// </summary>
        string ChangeDirectory(PcfObject pPCFObject);

        string NPMInstall();
       
        string PACInstall(PcfObject pPCFObject);
    }
}