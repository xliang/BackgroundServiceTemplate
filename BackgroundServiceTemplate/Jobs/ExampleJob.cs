﻿using BackgroundServiceTemplate.Interfaces;
using Quartz;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundServiceTemplate.Jobs
{
    public class ExampleJob : BackgroundServiceJob
    {
		protected override Task ExecuteInner(IJobExecutionContext context)
		{
			//Trace.WriteLine("Example job executing...");
			Console.WriteLine("Job one is running");
			
			return Task.FromResult(true);

		}

		public override TriggerBuilder GetSchedule(TriggerBuilder trigger)
        {
            return trigger.WithSimpleSchedule(x => x.WithIntervalInSeconds(2).WithRepeatCount(5));
        }
    }
}
