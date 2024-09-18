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

namespace ReymondNolanCalculator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //declration variable 
        int first_no;
        int second_no;
        double result;
        char operation;

        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            display("1");
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            display("2");
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            display("3");
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            display("4");
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            display("5");
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            display("6");
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            display("7");
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            display("8");
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            display("9");
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            display("0");
        }

        private void BTN_PLus_Click(object sender, RoutedEventArgs e)
        {
            first_no = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '+';
        }

        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {
            first_no = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '-';
        }

        private void BTN_Mult_Click(object sender, RoutedEventArgs e)
        {
            first_no = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '*';
        }

        private void BTN_Devise_Click(object sender, RoutedEventArgs e)
        {
            first_no = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '/';
        }

        private void BTN_CLEAR_Click(object sender, RoutedEventArgs e)
        {
            first_no = 0;
            second_no = 0;
            TB_Display.Text = "0";
        }

        private void BTN_COS_Click(object sender, RoutedEventArgs e)
        {
            first_no = Int32.Parse(TB_Display.Text);
            operation = 'c';
        }

        private void BTN_SIN_Click(object sender, RoutedEventArgs e)
        {
            first_no = Int32.Parse(TB_Display.Text);
            operation = 's';
        }

        private void BTN_TAN_Click(object sender, RoutedEventArgs e)
        {
            first_no = Int32.Parse(TB_Display.Text);
            operation = 't';
        }

        private void BTN_POWER_Click(object sender, RoutedEventArgs e)
        {
            first_no = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '^';
        }

        private void BTN_Equals_Click(object sender, RoutedEventArgs e)
        {
            second_no = Int32.Parse(TB_Display.Text);
            switch (operation)
            {
                case '+': 
                    result = first_no + second_no;
                    TB_Display.Text = result.ToString();
                    break;

                case '-':
                    result = first_no - second_no;
                    TB_Display.Text = result.ToString();
                    break;

                case '*':
                    result =  first_no * second_no;
                    TB_Display.Text = result.ToString();
                    break;

                case '/':
                    result = first_no / second_no;
                    TB_Display.Text = result.ToString();
                    break;

                case 's':
                    TB_Display.Text = Math.Sin(first_no).ToString();
                    break;

                case 'c':
                    TB_Display.Text = Math.Cos(first_no).ToString();
                    break;

                case 't':
                    TB_Display.Text = Math.Tan(first_no).ToString();
                    break;

                case '^':
                    TB_Display.Text = Math.Pow(first_no, second_no).ToString();
                    break;
            }
        }

        public void display(string num)
        {
            if (TB_Display.Text == "0")
            {
                TB_Display.Text = num;
            }
            else
            {
                TB_Display.Text = TB_Display.Text + num;
            }
        }
    }
}
