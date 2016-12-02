﻿using System;
using EloBuddy;

namespace AramBuddy.MainCore.Utility.MiscUtil
{
    internal class Logger
    {
        public enum LogLevel
        {
            Error,
            Info,
            Warn,
            Event
        }

        public static bool Send(string str, LogLevel level = LogLevel.Info)
        {
            var date = DateTime.Now.ToString("[H:mm:ss - ") + "AramBuddy";
            var text = string.Empty;
            switch (level)
            {
                case LogLevel.Event:
                    Console.ForegroundColor = ConsoleColor.Green;
                    text = date + " Event] ";
                    break;
                case LogLevel.Info:
                    Console.ForegroundColor = ConsoleColor.White;
                    text = date + " Info] ";
                    break;
                case LogLevel.Warn:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    text = date + " Warn] ";
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    text = date + " Error] ";
                    break;
            }
            if (level == LogLevel.Event)
            {
                Chat.Print("<b>AramBuddy: " + str + "</b>");
            }
            Console.WriteLine(text + str);
            Console.ResetColor();
            Misc.SaveLogs(text + str, Misc.AramBuddyDirectories.AramBuddyLogs);
            return true;
        }

        public static void Send(string str, Exception ex, LogLevel level)
        {
            var date = DateTime.Now.ToString("[H:mm:ss - ") + "AramBuddy";
            var text = string.Empty;
            switch (level)
            {
                case LogLevel.Event:
                    Console.ForegroundColor = ConsoleColor.Green;
                    text = date + " Event] ";
                    break;
                case LogLevel.Info:
                    Console.ForegroundColor = ConsoleColor.White;
                    text = date + " Info] ";
                    break;
                case LogLevel.Warn:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    text = date + " Warn] ";
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    text = date + " Error] ";
                    break;
            }
            Console.WriteLine(text + str);
            Console.WriteLine(ex);
            Console.ResetColor();
            Misc.SaveLogs(text + str, Misc.AramBuddyDirectories.AramBuddyLogs);
        }
    }
}
