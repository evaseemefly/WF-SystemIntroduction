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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookmarkWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_debugnoResultBookmarkWorkflow_Click(object sender, RoutedEventArgs e)
        {
            (new debugnoResultBookmarkWorkflow()).Show();
        }

        private void button_debugresultBookmarkWorkflow_Click(object sender, RoutedEventArgs e)
        {
            (new debugresultBookmarkWorkflow()).Show();
        }

        private void button_debugparallelBookmarkWorkflow_Click(object sender, RoutedEventArgs e)
        {
            (new debugparallelBookmarkWorkflow()).Show();
        }

        private void button_debugParallelForEachWorkflow_Click(object sender, RoutedEventArgs e)
        {
            (new debugParallelForEachWorkflow()).Show();
        }

        private void button_debugforEachWorkflow_Click(object sender, RoutedEventArgs e)
        {
            (new debugforEachWorkflow()).Show();
        }
    }
}
