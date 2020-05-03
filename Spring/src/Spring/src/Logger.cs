using System;
using System.IO;
using JetBrains.Diagnostics;

namespace JetBrains.ReSharper.Plugins.Spring
{
    public class Logger
    {
        private static String log = "/home/tanvd/log.txt";

        public static void Log(String text)
        {
            StreamWriter writer = File.AppendText(log);
            writer.WriteLine(text);
            writer.Close();
        }
    }
}