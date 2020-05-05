using System;
using System.IO;
using JetBrains.Diagnostics;

namespace JetBrains.ReSharper.Plugins.Spring.Utils
{
    public static class Logger
    {
        public static void Log(String text)
        {
            Util.Logging.Logger.Root.Warn(text);
        }
    }
}