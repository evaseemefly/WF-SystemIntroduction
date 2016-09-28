using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace controlActivitySample2
{

    class Program
    {
        static void Main(string[] args)
        {
          //  WorkflowInvoker.Invoke(new ParallelWorkflow());

          //  WorkflowInvoker.Invoke(new ParallelCompletionConditionWorkflow());

           // WorkflowInvoker.Invoke(new ParallelForEachWorkflow());
         
            WorkflowInvoker.Invoke(new PickWorkflow());
            System.Console.Read();
        }
    }
}
