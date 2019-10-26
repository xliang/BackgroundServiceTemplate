using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundServiceTemplate.Interfaces
{
	[DisallowConcurrentExecution]
	public abstract class BackgroundServiceJob : IJob
    {
		Task IJob.Execute(IJobExecutionContext context)
		{
			return ExecuteInner(context);
		}

		public abstract TriggerBuilder GetSchedule(TriggerBuilder triggerBuilder);
		protected abstract Task ExecuteInner(IJobExecutionContext context);

		
    }
}
