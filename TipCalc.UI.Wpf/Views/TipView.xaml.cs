using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Cirrious.MvvmCross.Wpf.Views;
using TipCalc.Core.ViewModels;


namespace TipCalc.UI.Wpf.Views
{
    /// <summary>
    /// Interaction logic for TipView.xaml
    /// </summary>
    public partial class TipView : MvxWpfView
    {
        public new TipViewModel ViewModel
        {
            get { return (TipViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public TipView()
        {
            InitializeComponent();
        }
    }
}
