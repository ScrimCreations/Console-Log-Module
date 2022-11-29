using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleLog_Module;
using ConsoleLog_Module.LogUtils;
using Colors = ConsoleLog_Module.LogUtils.CustomLog.Colors;

namespace ConsoleLog_Module
{
    public class Test
    {
        public static void Initialize()
        {
            //Set the name of your Application
            CustomLog.AppName = "MyApp";

            //Log to console
            CustomLog.Log(Colors.Blue, "Hello World!");

            //Send a message, choose whether to print time, type your string
            CustomLog.Msg(Colors.Blue, true, "Hello World!");
            CustomLog.Msg(Colors.Blue, false, "Hello World!");

            //Send a warning
            CustomLog.Warn(Colors.Blue, "Hello World??");

            //Send an error
            CustomLog.Error(Colors.Blue, "Uh Oh!");

            //Send a beep and choose how many beeps
            CustomLog.Beep(1);
        }
    }
}
