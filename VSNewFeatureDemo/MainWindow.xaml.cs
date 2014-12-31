using System;
using System.Collections.Generic;
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
using VSNewFeatureDemo.Examples;
using VSNewFeatureDemo.Examples.CodeMap;
using VSNewFeatureDemo.Examples.MethodValues;
using VSNewFeatureDemo.Examples.MultipleThread;

namespace VSNewFeatureDemo
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

        private void ShowExample<T>()
            where T : IExample, new()
        {
            new T().Show();
        }

        private void btnMethodValues_Click(object sender, RoutedEventArgs e)
        {
            ShowExample<ExamineReturnValuesOfMethodCallsExample>();
        }

        private void btnCodeMaps_Click(object sender, RoutedEventArgs e)
        {
            ShowExample<DebugCallStackExample>();
        }

        private void btnMulThread_Click(object sender, RoutedEventArgs e)
        {
            ShowExample<DebugThreadExample>();
        }

        private void btnMulThreadTask_Click(object sender, RoutedEventArgs e)
        {
            ShowExample<ThreadTaskExample>();
        }

    }
}
