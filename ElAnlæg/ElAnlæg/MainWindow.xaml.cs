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

namespace ElAnlæg
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

        private void S6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (S6.Opacity == 0)
            {
                S6.Opacity = 1;
            }
            else if (S6.Opacity == 1)
            {
                S6.Opacity = 0;
            }
        }

        private void S4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (S4.Opacity == 0)
            {
                S4.Opacity = 1;
            }
            else if (S4.Opacity == 1)
            {
                S4.Opacity = 0;
            }
        }

        private void AC_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (AC.Opacity == 0)
            {
                AC.Opacity = 1;
            }
            else if (AC.Opacity == 1)
            {
                AC.Opacity = 0;
            }
        }

        private void småOp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (småOp.Opacity == 0)
            {
                småOp.Opacity = 1;
            }
            else if (småOp.Opacity == 1)
            {
                småOp.Opacity = 0;
            }
        }

        private void storOp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (storOp.Opacity == 0)
            {
                storOp.Opacity = 1;
            }
            else if (storOp.Opacity == 1)
            {
                storOp.Opacity = 0;
            }
        }

        private void småOp1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (småOp1.Opacity == 0)
            {
                småOp1.Opacity = 1;
            }
            else if (småOp1.Opacity == 1)
            {
                småOp1.Opacity = 0;
            }
        }
    }
}
