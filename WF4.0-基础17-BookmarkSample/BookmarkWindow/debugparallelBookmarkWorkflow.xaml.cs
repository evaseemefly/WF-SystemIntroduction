using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Activities;

namespace BookmarkWindow
{
    /// <summary>
    /// Interaction logic for debugparallelBookmarkWorkflow.xaml
    /// </summary>
    public partial class debugparallelBookmarkWorkflow : Window
    {
        public debugparallelBookmarkWorkflow()
        {
            InitializeComponent();
        }
        void workflowCompleted(WorkflowApplicationCompletedEventArgs e)
        {
            instance = null;
            System.Console.WriteLine("workflowCompleted:{0}", e.CompletionState.ToString());
        }

        void aborted(WorkflowApplicationAbortedEventArgs e)
        {
            instance = null;
            System.Console.WriteLine("aborted ,Reason:{0}", e.Reason.Message);
        }

        UnhandledExceptionAction unhandledExceptionl(WorkflowApplicationUnhandledExceptionEventArgs e)
        {
            System.Console.WriteLine("unhandledException:{0}", e.UnhandledException.Message);
            return UnhandledExceptionAction.Cancel;
        }
        void workflowIdel(WorkflowApplicationIdleEventArgs e)
        {
            System.Console.WriteLine("Idle:{0}", e.InstanceId);

            System.Console.WriteLine("--------BookmarkName---------------------------");
            foreach (var item in e.Bookmarks)
            {
                System.Console.WriteLine("{0}", item.BookmarkName);
            }
            System.Console.WriteLine("================================");
        }
        WorkflowApplication instance = null;
        private void button_Run_Click(object sender, RoutedEventArgs e)
        {
            instance = new WorkflowApplication(new WFLibrary.parallelBookmarkWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledExceptionl;
            instance.Aborted = aborted;
            instance.Idle = workflowIdel;
            instance.Run();

        }

        private void button_triggering_Click(object sender, RoutedEventArgs e)
        {
            string bookName = textBoxBookmark.Text;
            string inputValue = textBox_Value.Text;

            if (instance != null)
            {
                if (instance.GetBookmarks().Count(p => p.BookmarkName == bookName) == 1)
                {
                    instance.ResumeBookmark(bookName, inputValue);
                }
                else
                {
                    foreach (var v in instance.GetBookmarks())
                    {
                        System.Console.WriteLine("--------请从下面选项中选择一个BookmarkName---------------------------");
                        System.Console.WriteLine("BookmarkName:{0}:,OwnerDisplayName:{1}", v.BookmarkName, v.OwnerDisplayName);
                        System.Console.WriteLine("================================");
                    }
                }
            }
            else
            {
                MessageBox.Show("没有创建实例");
            }
        }
    }
}
