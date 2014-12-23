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
using VSNewFeatureDemo.Examples.MethodValues;

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

        private void btnMethodValues_Click(object sender, RoutedEventArgs e)
        {
            ShowExample<ExamineReturnValuesOfMethodCalls>();
        }

        private void ShowExample<T>()
            where T : IExample, new()
        {
            var example = new T();
            example.Show();
        }

        private void btnCodeMaps_Click(object sender, RoutedEventArgs e)
        {
            // use thread to show debug map call stack
        }

    }
}
