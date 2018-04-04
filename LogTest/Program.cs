using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HanSL.Log.Log;

namespace LogTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //日志HanSL的Debug信息
            new HanSL.Log.Log.LogFactory().GetLog("HanSL").Debug(true, "Hello");
            new HanSL.Log.Log.LogFactory().GetLog("HanSL").Debug(true, "World");

            //日志HanSl的info信息
            new HanSL.Log.Log.LogFactory().GetLog("HanSL").Info(true, "Hello");
            new HanSL.Log.Log.LogFactory().GetLog("HanSL").Info(true, "HanSL");
            Console.Read();
        }
    }
}
