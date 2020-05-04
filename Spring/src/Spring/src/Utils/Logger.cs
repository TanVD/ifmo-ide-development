using System;
using System.IO;

namespace JetBrains.ReSharper.Plugins.Spring.Utils
{
    public static class Logger
    {
        private static readonly String log = "/home/tanvd/log.txt";

        public static void Log(String text)
        {
            var writer = File.AppendText(log);
            writer.WriteLine(text);
            writer.Close();
        }
    }
}