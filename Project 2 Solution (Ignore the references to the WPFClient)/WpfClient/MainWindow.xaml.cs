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

using DocumentBuilderLibrary.Interfaces;

namespace WpfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDirector
    {
        IBuilder _builder;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddBranch_Click(object sender, RoutedEventArgs e)
        {
            BuildBranch();
        }

        private void BtnCloseBranch_Click(object sender, RoutedEventArgs e)
        {
            CloseBranch();
        }

        private void BtnAddLeaf_Click(object sender, RoutedEventArgs e)
        {
            BuildLeaf();
        }

        private void CmbMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbMode.SelectedIndex == 0)
            {
                _builder = new DocumentBuilderLibrary.Xml.Builder();
            }
            else if(cmbMode.SelectedIndex == 1)
            {
                _builder = new DocumentBuilderLibrary.Json.Builder();
            }
            txtPreview.Text = _builder.GetDocument().Print(0);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            txtPreview.Width = MainGrid.ActualWidth - 20;
            txtPreview.Height = MainGrid.ActualHeight - 51;
        }

        public void BuildBranch()
        {
            _builder.BuildBranch(txtName.Text);
            txtPreview.Text = _builder.GetDocument().Print(0);
        }

        public void BuildLeaf()
        {
            _builder.BuildLeaf(txtName.Text, txtContent.Text);
            txtPreview.Text = _builder.GetDocument().Print(0);
        }

        public void CloseBranch()
        {
            _builder.CloseBranch();
        }
    }
}
