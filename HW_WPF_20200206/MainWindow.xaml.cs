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

namespace HW_WPF_20200206
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement elem in btnBox.Children)
            {
                ((Button)elem).Click += BtnTask_Click;
            }
        }

        private void BtnTask_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Background = Brushes.Lime;
            string windowName = (((Button)sender).Content).ToString();
            windowName = windowName.Substring(windowName.IndexOf('-') + 2);

            //MessageBox.Show(windowName);

            switch (windowName)
            {
                case "TabularGrid":
                    {
                        TabularGrid task = new TabularGrid();
                        task.Show();
                    }
                    break;

                case "GridUnits":
                    {
                        GridUnits task = new GridUnits();
                        task.Show();
                    }
                    break;

                case "GridUnits1":
                    {
                        GridUnits1 task = new GridUnits1();
                        task.Show();
                    }
                    break;


                case "GridUnits2":
                    {
                        GridUnits2 task = new GridUnits2();
                        task.Show();
                    }
                    break;

                case "GridColRowSpan":
                    {
                        GridColRowSpan task = new GridColRowSpan();
                        task.Show();
                    }
                    break;

                case "Grid":
                    {
                        Grid task = new Grid();
                        task.Show();
                    }
                    break;

                case "StackPanel":
                    {
                        StackPanel task = new StackPanel();
                        task.Show();
                    }
                    break;

                case "StackPanel1":
                    {
                        StackPanel1 task = new StackPanel1();
                        task.Show();
                    }
                    break;

                case "StackPanel2":
                    {
                        StackPanel2 task = new StackPanel2();
                        task.Show();
                    }
                    break;

                case "StackPanel3":
                    {
                        StackPanel3 task = new StackPanel3();
                        task.Show();
                    }
                    break;

                case "DockPanel":
                    {
                        DockPanel task = new DockPanel();
                        task.Show();
                    }
                    break;

                case "DockPanel1":
                    {
                        DockPanel1 task = new DockPanel1();
                        task.Show();
                    }
                    break;

                case "DockPanel2":
                    {
                        DockPanel2 task = new DockPanel2();
                        task.Show();
                    }
                    break;

                case "WrapPanel":
                    {
                        WrapPanel task = new WrapPanel();
                        task.Show();
                    }
                    break;

                case "WrapPanel1":
                    {
                        WrapPanel1 task = new WrapPanel1();
                        task.Show();
                    }
                    break;

                case "WrapPanel2":
                    {
                        WrapPanel2 task = new WrapPanel2();
                        task.Show();
                    }
                    break;

                case "WrapPanel3":
                    {
                        WrapPanel3 task = new WrapPanel3();
                        task.Show();
                    }
                    break;

            }
        }
    }
}
