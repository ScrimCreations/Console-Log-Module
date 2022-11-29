using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLog_Module.LogUtils
{
    internal class CustomLog
    {
        public static string AppName = "Application";
        public static void Msg(Colors colors, bool time , string text)
        {
            if (time)
            {
                Console.ForegroundColor= ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(DateTime.UtcNow.ToString("HH:mm:ss.fff"));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("[");
            Console.ForegroundColor = getColor(colors);
            Console.Write(AppName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]" + " ");

            Console.Write(text + "\n");

            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Log(Colors colors, string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(DateTime.UtcNow.ToString("HH:mm:ss.fff"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" " + "[");
            Console.ForegroundColor = getColor(colors);
            Console.Write(AppName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]" + " ");

            Console.Write(text + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Warn(Colors colors, string text) 
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(DateTime.UtcNow.ToString("HH:mm:ss.fff"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" " + "[");
            Console.ForegroundColor = getColor(colors);
            Console.Write(AppName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]" + " ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WARN");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]" + " ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(text + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Error(Colors colors, string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(DateTime.UtcNow.ToString("HH:mm:ss.fff"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" " + "[");
            Console.ForegroundColor = getColor(colors);
            Console.Write(AppName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]" + " ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("ERROR");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]" + " ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Beep(int numberofbeeps)
        {
            switch (numberofbeeps)
            {
                case 1:
                    Console.Beep();
                    break;
                case 2:
                    Console.Beep();
                    Console.Beep();
                    break;
                case 3:
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    break;
                default:
                    Console.Beep();
                    break;
            }
        }

        //Helped from Fish
        public static ConsoleColor getColor(Colors color)
        {
            if (color == Colors.Default)
            {
                return ConsoleColor.White;
            }
            switch (color)
            {
                case Colors.Red:
                    return ConsoleColor.Red;
                case Colors.Blue:
                    return ConsoleColor.Blue;
                case Colors.Black:
                    return ConsoleColor.Black;
                case Colors.Green:
                    return ConsoleColor.Green;
                case Colors.Yellow:
                    return ConsoleColor.Yellow;
                case Colors.Cyan:
                    return ConsoleColor.Cyan;
                case Colors.DarkRed:
                    return ConsoleColor.DarkRed;
                case Colors.DarkGreen:
                    return ConsoleColor.DarkGreen;
                case Colors.DarkBlue:
                    return ConsoleColor.DarkBlue;
                case Colors.Grey:
                    return ConsoleColor.Gray;
            }
            return ConsoleColor.White;
        }
        public enum Colors
        {
            Red,
            Blue,
            Black,
            White,
            Green,
            Yellow,
            Cyan,
            DarkRed,
            DarkGreen,
            DarkBlue,
            Default,
            Grey
        }
    }
}
