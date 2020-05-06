using System;
using System.Diagnostics;
using JetBrains.Util;
using JetBrains.Util.Logging;

namespace JetBrains.ReSharper.Plugins.Spring.Utils
{
    public static class PLogger
    {
        private static readonly ILogger Log = Logger.GetLogger("PascalLogger");

        public static void Info(String text)
        {
            Log.Info(text);
        }

        public static void StackTrace()
        {
            Log.Info(new StackTrace().ToString());
        }
    }
}