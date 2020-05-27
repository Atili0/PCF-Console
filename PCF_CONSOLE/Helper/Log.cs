namespace PCF_CONSOLE.Utils
{
    using NLog;
    using System;

    public class Log
    {

        public static void InitLog()
        {
            string _FileName = $"Log_File {DateTime.Now.ToShortDateString()}";

            var config = new NLog.Config.LoggingConfiguration();

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = _FileName };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

            // Rules for mapping loggers to targets            
            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            // Apply config           
            NLog.LogManager.Configuration = config;
        }
    }
}
