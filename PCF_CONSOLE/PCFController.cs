namespace PCF_CONSOLE
{
    using ConsoleControl;

    public class PCFController : IPCFController
    {
        IPCFView _view;
        IPCFModel _model;

        public PcfObject _PcfObject { get; set; }

        public PCFController(IPCFView pView, IPCFModel pModel)
        {
            _view = pView;
            _model = pModel;
            pView.SetController(this);
        }

        public void InitConsoleControl(ConsoleControl pCMD) {
            _model.InitConsoleControl(pCMD);
        }

        public string GetLastVersion()
        {
            return _model.GetLastVersion();
        }

        public string ChangeDirectory() {
            return _model.ChangeDirectory(this._PcfObject);
        }

        public string NPMInstall() {
            return _model.NPMInstall();
        }

        #region PAC
        public string PACInstall()
        {
            return _model.PACInstall(this._PcfObject);
        }
        #endregion

    }
}
