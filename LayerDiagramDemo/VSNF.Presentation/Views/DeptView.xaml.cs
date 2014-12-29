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
using VSNF.Applications.Controllers;

namespace VSNF.Presentation.Views
{
    /// <summary>
    /// Interaction logic for DeptView.xaml
    /// </summary>
    public partial class DeptView : UserControl
    {
        public DeptView()
        {
            InitializeComponent();

            DeptController controller = new DeptController();
        }
    }
}
