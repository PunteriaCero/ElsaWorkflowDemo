using Elsa.Workflows;
using Elsa.Workflows.Api.RealTime.Contracts;
using Elsa.Workflows.Attributes;
using Elsa.Workflows.Contracts;
using Elsa.Workflows.Runtime.Contracts;
using System.Diagnostics;

namespace ElsaServer.Activities
{
    [Activity("Custom", "LogFilePausable", Description = "Actividad que se pausa a la espera de input.")]
    public class LogFilePausable : CodeActivity
    {
        protected override void Execute(ActivityExecutionContext context)
        {
            //var logger = context.GetRequiredService<ILogger<LogFilePausable>>();
            //context.Get()
            var instanceId = context.WorkflowExecutionContext.Id;
            var activityName = context.Activity.Name;
            //var workflowRunner = context.GetRequiredService<IWorkflowRuntime>();
            using (StreamWriter w = File.AppendText($"{instanceId}.txt"))
            {
                w.WriteLine($"Actividad {activityName} waiting...");
            }
            context.CreateBookmark();
        }
    }
}
