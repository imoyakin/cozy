﻿using CozyAnywhere.Protocol;

namespace CozyAnywhere.Plugin.WinProcess.Args
{
    public class ProcessTerminateWithTimeOutArgs : IPluginCommandMethodArgs
    {
        public uint Pid { get; set; }

        public uint TimeOut { get; set; }

        public string Execute(IPluginCommandArgsDispatch dispatch)
        {
            var plugin = (ProcessPlugin)dispatch;
            return plugin.Shell(this);
        }
    }
}