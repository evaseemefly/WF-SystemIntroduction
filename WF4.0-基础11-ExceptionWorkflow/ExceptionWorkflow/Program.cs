using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace ExceptionWorkflow
{

    class Program
    {
        static void Main(string[] args)
        {
     
            System.Console.WindowWidth = 100;

           // exceptionActivityWorkflow_None(); //处理Code异常,无[UnhandledExceptionAction]方式例子

          //  exceptionActivityWorkflow_Abort();  //处理Code异常,[UnhandledExceptionAction.Abort]方式例子

           // exceptionActivityWorkflow_Terminate();  //处理Code异常,[UnhandledExceptionAction.Terminate]方式例子

          //  throwWorkflow_None();  //处理[Throw Activity]异常,无[UnhandledExceptionAction]方式例子

          //  throwWorkflow_Abort();  //处理[Throw Activity]异常,[UnhandledExceptionAction.Abort]方式例子

          //  throwWorkflow_Terminate();  //处理[Throw Activity]异常,[UnhandledExceptionAction.Terminate]方式例子

         //   tryCatchWorkflow();  //TryCatch例子

          //  rethrowWorkflow();   //Rethrow例子

            terminateWorkflow();  //TerminateWorkflow例子

           System.Console.Read();
        }
       //==============================================================
        static void workflowCompleted(WorkflowApplicationCompletedEventArgs e)
        {
          
            System.Console.WriteLine("完成,实例编号:{0},状态:{1}", e.InstanceId, e.CompletionState.ToString());
        }

        static void aborted(WorkflowApplicationAbortedEventArgs e)
        {
            System.Console.WriteLine("aborted ,实例编号:{1},Reason:{0}", e.Reason.Message, e.InstanceId);
        }
        //==============================================================

        #region  //处理Code异常,无[UnhandledExceptionAction]方式例子

          static void exceptionActivityWorkflow_None()
        {
            WorkflowApplication instance = new WorkflowApplication(new ExceptionActivityWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
         
            instance.Aborted = aborted;

            instance.Run();
        }

        #endregion

        #region   //处理Code异常,[UnhandledExceptionAction.Abort]方式例子
          static void exceptionActivityWorkflow_Abort()
        {
            WorkflowApplication instance = new WorkflowApplication(new ExceptionActivityWorkflow());
           
            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
           instance.OnUnhandledException = unhandledException_Abort;
            instance.Aborted = aborted;
        
            instance.Run();
        }

        static UnhandledExceptionAction unhandledException_Abort(WorkflowApplicationUnhandledExceptionEventArgs e)
        {
            System.Console.WriteLine("unhandledException_Abort:{0}", e.UnhandledException.Message);
            return UnhandledExceptionAction.Abort;
        }
      #endregion

        #region   //处理Code异常,[UnhandledExceptionAction.Terminate]方式例子
        static void exceptionActivityWorkflow_Terminate()
        {
            WorkflowApplication instance = new WorkflowApplication(new ExceptionActivityWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException_Terminate;
            instance.Aborted = aborted;

            instance.Run();
        }

        static UnhandledExceptionAction unhandledException_Terminate(WorkflowApplicationUnhandledExceptionEventArgs e)
        {
            System.Console.WriteLine("unhandledException_Abort:{0}", e.UnhandledException.Message);
            return UnhandledExceptionAction.Terminate;
        }
      #endregion

        #region  //处理[Throw Activity]异常,无[UnhandledExceptionAction]方式例子

        static void throwWorkflow_None()
        {
            WorkflowApplication instance = new WorkflowApplication(new ThrowWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);

            instance.Aborted = aborted;

            instance.Run();
        }

        #endregion

        #region  //处理[Throw Activity]异常,[UnhandledExceptionAction.Abort]方式例子

        static void throwWorkflow_Abort()
        {
            WorkflowApplication instance = new WorkflowApplication(new ThrowWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException_Abort;
            instance.Aborted = aborted;

            instance.Run();
        }

        #endregion

        #region  //处理[Throw Activity]异常,[UnhandledExceptionAction.Terminate]方式例子

        static void throwWorkflow_Terminate()
        {
            WorkflowApplication instance = new WorkflowApplication(new ThrowWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException_Terminate;
            instance.Aborted = aborted;

            instance.Run();
        }

        #endregion //TryCatch例子

        #region  //TryCatch例子

        static void  tryCatchWorkflow()
        {
            WorkflowApplication instance = new WorkflowApplication(new TryCatchWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException_Terminate;
            instance.Aborted = aborted;

            instance.Run();
        }

        #endregion 

       #region  //Rethrow例子
         static void rethrowWorkflow()
        {
            WorkflowApplication instance = new WorkflowApplication(new RethrowWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException_Terminate;
            instance.Aborted = aborted;

            instance.Run();
        }
       #endregion

       #region  //TerminateWorkflow例子
         static void terminateWorkflow()
         {
             WorkflowApplication instance = new WorkflowApplication(new TerminateWorkflow());

             instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(terminateWorkflowCompleted);
               
             instance.Run();
         }

         static void terminateWorkflowCompleted(WorkflowApplicationCompletedEventArgs e)
         {
             System.Console.WriteLine("完成,实例编号:{0},状态:{1}", e.InstanceId, e.CompletionState.ToString());
             System.Console.WriteLine("Message:{0}", e.TerminationException.Message);
         }
         #endregion
    }
}
