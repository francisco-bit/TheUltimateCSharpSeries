using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPart2.WorkflowExercise
{
    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uplaoding a video");
        }
    }
}
