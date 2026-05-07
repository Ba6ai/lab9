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
            txtX1a.Text = p.X.ToString();
        }
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            double x = Enter(txtX1);
            double y = Enter(txtY1);

            ex2.Point p = new ex2.Point(x, y);
            p--;
            txtX1.Text = p.X.ToString();
            txtX1a.Text = p.X.ToString();
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
            txtX1a.Text = p1.X.ToString();
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
            txtX1a.Text = p.X.ToString();
        }
        private void btnPlusAA_Click(object sender, RoutedEventArgs e)
        {
            double x1 = Enter(txtX1);
            double y1 = Enter(txtY1);

            ex2.Point p1 = new ex2.Point(x1, y1);

            double AA = Enter(txtForSum);
            
            p1 = p1 + AA;

            txtInfoSum.Text = p1.X.ToString();
        }
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtForSum.Text = "";
            txtInfoSum.Text = "";
            txtResult.Text = "";
            txtX1.Text = "";
            txtY1.Text = "";
            txtX2.Text = "";
            txtY2.Text = "";
            txtX1a.Text = "";
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