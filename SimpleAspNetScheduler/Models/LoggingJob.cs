using Quartz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SimpleAspNetScheduler.Models
{
    public class LoggingJob:IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            //File.AppendAllText(@"D:\ServiceLog\log.txt", Environment.NewLine + "Job has been started from visual studio.." + " :" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
            //var path = HttpContext.Current.Server.MapPath("~/Logs/logs.txt");
            //File.AppendAllText(path, "=================================" + DateTime.Now + "====================================" + Environment.NewLine);

            //File.AppendAllText(path, "Job has been started.." + DateTime.Now + Environment.NewLine);
            Utilities.WriteLog("from visual studio..");
        }
    }
    public class Utilities
    {
        internal static void WriteLog(string MessgaeToWrite)
        {
            //var path = HttpContext.Current.Server.MapPath("~/Logs/logs.txt");
            //File.AppendAllText(path, "=================================" + DateTime.Now + "====================================" + Environment.NewLine);

            //File.AppendAllText(path, MessgaeToWrite + DateTime.Now  + Environment.NewLine);
            File.AppendAllText(@"D:\ServiceLog1\logforscheduler.txt", Environment.NewLine + "Job has been started from WriteLog studio.." + " :" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));

        }
    }
}