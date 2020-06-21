using ProjectPart2.WorkflowExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //stopweatch exercise
            //var testStopwatch = new StopWatch();
            //TimeSpan duration = new TimeSpan();
            //while (true)
            //{
            //    Console.WriteLine("You can start the stopwatch");
            //    Console.ReadLine();
            //    testStopwatch.Start();
            //    Console.WriteLine("Insert the next command");
            //    var command1 = Console.ReadLine();
            //    if (command1 == "start")
            //        testStopwatch.Start();
            //    else
            //        duration=testStopwatch.Stop();
            //        Console.WriteLine(duration.ToString("g"));
            //}

            //stack overflow post exercise
            //var newPost = new Post("This is a post", "example of the description");
            //newPost.UpVote();
            //newPost.UpVote();
            //newPost.UpVote();
            //newPost.UpVote();
            //newPost.DownVote();
            //Console.WriteLine(newPost.createdTime);
            //Console.WriteLine(newPost.votesNumber);

            //Interfaces and testability

            //the dependency about concrete methods in only here
            //var orderProcessor = new OrderProcessor(new ShippingCalculator());
            //var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            //orderProcessor.Process(order);

            //Workflow exercise

            //var callWebService = new CallWebService();
            //var uploadVideo = new UploadVideo();

            //var workflowEngine = new WorkflowEngine();
            //var workflow = new Workflow();
            //workflow.AddStep(callWebService);
            //workflow.AddStep(uploadVideo);

            //workflowEngine.RunMethod(workflow);

        }
    }
}
