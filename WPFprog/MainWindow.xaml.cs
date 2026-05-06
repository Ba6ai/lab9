using System.Windows;
using System.Windows.Controls;
using ex2;

namespace WPFprog
{ 
    public partial class MainWindow : Window
    {
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(txtX1.Text);
            double y = double.Parse(txtY1.Text);

            ex2.Point p = new ex2.Point(x, y);
            p++;
            txtX1.Text = p.X.ToString();
        }
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            double x = Enter(txtX1);
            double y = Enter(txtY1);

            ex2.Point p = new ex2.Point(x, y);
            p--;
            txtX1.Text = p.X.ToString();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double x1 = Enter(txtX1);
            double y1 = Enter(txtY1);
            double x2 = Enter(txtX2);
            double y2 = Enter(txtY2);

            ex2.Point p1 = new ex2.Point(x1, y1);
            ex2.Point p2 = new ex2.Point(x2, y2);

            double dist = p1 + p2;

            txtResult.Text = dist.ToString();
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
        private void btnPlusAA_Click(object sender, RoutedEventArgs e)
        {
            double x = Enter(txtX1);
            txtX1a.Text = x.ToString();
            double y = Enter(txtY1);

            

            txtInfo.Text = x.ToString();
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
                txtResult.Text = "Ошибка ввода: все поля точек должны быть заполнены";
                return 0;
            }
        }
    }
}