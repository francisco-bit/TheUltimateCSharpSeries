using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPart2.WorkflowExercise
{
    public interface IWorkflow
    {
        void AddStep(IActivity step);
        void RemoveStep(IActivity step);
        IEnumerable<IActivity> GetActivities();
    }
}
