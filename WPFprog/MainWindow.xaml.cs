using System.Windows;
using System.Windows.Controls;
using ex2;

namespace WPFprog
{ 
    public partial class MainWindow : Window
    {
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            double x = Enter(txtX1);
            double y = Enter(txtY1);

            ex2.Point p = new ex2.Point(x, y);
            p++;
            txtX1.Text = p.X.ToString();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            double x = 0;
            double y = 0;
            if (double.TryParse(txtX1.Text, out x) && double.TryParse(txtY1.Text, out y))
            {
                ex2.Point p = new ex2.Point(x, y);
                p--;
                txtX1.Text = p.X.ToString();
            }
            else
            {
                txtResult.Text = "Ошибка ввода: введите числа";
            }
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtX1.Text, out double x1) && 
                double.TryParse(txtY1.Text, out double y1) &&
                double.TryParse(txtX2.Text, out double x2) && 
                double.TryParse(txtY2.Text,out double y2))
            {
                ex2.Point p1 = new ex2.Point(x1, y1);
                ex2.Point p2 = new ex2.Point(x2, y2);

                double dist = p1 + p2;

                txtResult.Text = dist.ToString();
            }
            else
            {
                txtResult.Text = "Ошибка: заполните все поля";
            }
        }
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            double x = Enter(txtX1);
            double y = Enter(txtY1);

            ex2.Point p = new ex2.Point(x, y);

            int Xint = (int)p;
            double Yd = p;

            InfoX.Text = Xint.ToString();
            InfoY.Text = Yd.ToString();
        }
        private double Enter(TextBox text)
        {
            double x = 0;
            if (double.TryParse(text.Text, out x))
            {
                return x;
            }
            else
            {
                txtResult.Text = "Ошибка ввода: введите числа";
                return -1;
            }
        }
    }
}