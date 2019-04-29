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
        float grønX = 284;
        float grønY = 10;
        float heigt = 18;
        float width = 36;
        private void MoveGrøn()
        {
            grønNode.Opacity = 1;
            if (grønX > 115)
            {
                Canvas.SetLeft(grønNode, grønX);
                grønX = grønX - 5;
            }
            if (grønY < 380)
            {
                Canvas.SetTop(grønNode, grønY);
                grønY = grønY + 10;
            }
            if (heigt < 38)
            {
                grønNode.Height = heigt += 1.02f;
            }
            if (width < 96)
            {
                grønNode.Width = width += 2.59f;
            }
        }
        float rødX = 325;
        float rødY = 10;
        private void MoveRød()
        {
            rødNode.Opacity = 1;
            if (rødX > 225)
            {
                Canvas.SetLeft(rødNode, rødX);
                rødX = rødX - 5;
            }
            if (rødY < 380)
            {
                Canvas.SetTop(rødNode, rødY);
                rødY = rødY + 10;
            }
            if (heigt < 38)
            {
                rødNode.Height = heigt += 1.02f;
            }
            if (width < 96)
            {
                rødNode.Width = width += 2.59f;
            }
        }
        float gulX = 378;
        float gulY = 10;
        private void MoveGul()
        {
            gulNode.Opacity = 1;
            if (gulX > 350)
            {
                Canvas.SetLeft(gulNode, gulX);
                gulX = gulX - 5;
            }
            if (gulY < 380)
            {
                Canvas.SetTop(gulNode, gulY);
                gulY = gulY + 10;
            }
            if (heigt < 38)
            {
                gulNode.Height = heigt += 1.02f;
            }
            if (width < 96)
            {
                gulNode.Width = width += 2.59f;
            }
        }
        float blåX = 428;
        float blåY = 10;
        private void MoveBlå()
        {
            blåNode.Opacity = 1;
            if (blåX < 450)
            {
                Canvas.SetLeft(blåNode, blåX);
                blåX = blåX + 5;
            }
            if (blåY < 380)
            {
                Canvas.SetTop(blåNode, blåY);
                blåY = blåY + 10;
            }
            if (heigt < 38)
            {
                blåNode.Height = heigt += 1.02f;
            }
            if (width < 96)
            {
                blåNode.Width = width += 2.59f;
            }
        }
        float orangeX = 469;
        float orangeY = 10;
        private void MoveOrange()
        {
            orangeNode.Opacity = 1;
            if (orangeX < 575)
            {
                Canvas.SetLeft(orangeNode, orangeX);
                orangeX = orangeX + 5;
            }
            if (orangeY < 380)
            {
                Canvas.SetTop(orangeNode, orangeY);
                orangeY = orangeY + 10;
            }
            if (heigt < 38)
            {
                orangeNode.Height = heigt += 1.02f;
            }
            if (width < 96)
            {
                orangeNode.Width = width += 2.59f;
            }
            test.Text = "x " + Convert.ToString(orangeX) + "y " + Convert.ToString(orangeY);
            test1.Text = "h " + Convert.ToString(heigt) + "b " + Convert.ToString(width);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MoveGrøn();
            //MoveGrøn();
            //MoveRød();
            //MoveGul();
            //MoveBlå();
            //MoveOrange();
        }
    }
}

 //Height="38" Width="96"