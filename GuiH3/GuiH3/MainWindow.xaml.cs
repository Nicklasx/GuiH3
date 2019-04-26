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
using System.Threading;
using System.Windows.Threading;

namespace GuiH3
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

        private void GrønTryk_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            grønTryk.Opacity = 1;
        }
        private void GrønTryk_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            grønTryk.Opacity = 0;
        }
        private void GrønTryk_MouseLeave(object sender, MouseEventArgs e)
        {
            grønTryk.Opacity = 0;
        }

        private void RødTryk_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            rødTryk.Opacity = 1;
        }
        private void RødTryk_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            rødTryk.Opacity = 0;
        }
        private void RødTryk_MouseLeave(object sender, MouseEventArgs e)
        {
            rødTryk.Opacity = 0;
        }
        private void GulTryk_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            gulTryk.Opacity = 1;
        }
        private void GulTryk_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            gulTryk.Opacity = 0;
        }
        private void GulTryk_MouseLeave(object sender, MouseEventArgs e)
        {
            gulTryk.Opacity = 0;
        }
        private void BlåTryk_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            blåTryk.Opacity = 1;
        }
        private void BlåTryk_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            blåTryk.Opacity = 0;
        }
        private void BlåTryk_MouseLeave(object sender, MouseEventArgs e)
        {
            blåTryk.Opacity = 0;
        }
        private void OrangeTryk_MouseDown(object sender, MouseButtonEventArgs e)
        {
            orangeTryk.Opacity = 1;
        }
        private void OrangeTryk_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            orangeTryk.Opacity = 0;
        }
        private void OrangeTryk_MouseLeave(object sender, MouseEventArgs e)
        {
            orangeTryk.Opacity = 0;
        }

        float x = 284;
        float y = 10;
        private void MoveGrøn()
        {
                grønNode.Opacity = 1;
                Canvas.SetLeft(grønNode, x);
                Canvas.SetTop(grønNode, y);
                x = x - 4;
                y = y + 10;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                MoveGrøn();
        }
    }
}
