using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPart2.WorkflowExercise
{
    public class Workflow: IWorkflow
    {
        //it should be readonly but it can't in this c# version
        private List<IActivity> workflowList;

            public Workflow()
        {
            workflowList = new List<IActivity>();
        }

        public void AddStep(IActivity step)
        {
            workflowList.Add(step);
        }

        public void RemoveStep(IActivity step)
        {
            workflowList.Remove(step);
        }

        //It's used an IEnumerable instead of list because you don't want other code to change the state of your list (Adding or removing stuff) you just want to iterate
        public IEnumerable<IActivity> GetActivities()
        {
            return workflowList;
        }

    }
}
