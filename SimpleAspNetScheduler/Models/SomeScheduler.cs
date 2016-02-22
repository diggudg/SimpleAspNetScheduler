using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAspNetScheduler.Models
{
    public class SomeScheduler
    {
        public static void Start()
        {
            try
            {
                IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
                scheduler.Start();

                IJobDetail job = JobBuilder.Create<LoggingJob>().Build();

                ITrigger trigger = TriggerBuilder.Create()
                    .WithDailyTimeIntervalSchedule
                      (s =>
                        // s.WithIntervalInHours(24)
                        s.WithIntervalInMinutes(03)
                       // s.WithIntervalInSeconds(60)
                        .OnEveryDay()
                        .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(0, 0))
                      )
                    .Build();

                scheduler.ScheduleJob(job, trigger);
            }
            catch (ArgumentException e)
            {
               // Utilities.WriteLog(e.ToString());
            }
        }
    }
}