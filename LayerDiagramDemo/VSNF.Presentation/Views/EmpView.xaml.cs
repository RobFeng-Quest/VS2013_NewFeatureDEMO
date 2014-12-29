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
using VSNF.Applications.ViewModels;
using VSNF.Applications.Views;

namespace VSNF.Presentation.Views
{
    /// <summary>
    /// Interaction logic for EmpView.xaml
    /// </summary>
    public partial class EmpView : UserControl, IEmpView
    {
        public EmpView()
        {
            InitializeComponent();

            EmpViewModel evm = this.Content as EmpViewModel;
            var data = evm.Data;
            var models = data.Employees;
            var model = models[0];
        }
    }
}
