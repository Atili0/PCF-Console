namespace PCF_CONSOLE
{
    using ConsoleControl;

    public interface IPCFController
    {
        PcfObject _PcfObject { get; set; }

        void InitConsoleControl(ConsoleControl pCMD);

        string GetLastVersion();

        string ChangeDirectory();

        string NPMInstall();
        string PACInstall();
    }
}