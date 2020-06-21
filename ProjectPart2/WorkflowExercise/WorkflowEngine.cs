using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPart2.WorkflowExercise
{
    public class WorkflowEngine
    {

        public void RunMethod(IWorkflow workflows)
        {
            foreach(var workflow in workflows.GetActivities())
            {
                workflow.Execute();
            }

            Console.ReadLine();
        }
    }
}
