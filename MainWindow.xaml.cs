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
using System.Data;

namespace calculator_app_2022_autumn
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

        private void NumericButton_Click(object sender, RoutedEventArgs e)
        {           
            Button button = (Button)sender;          

            if(Display.Text == "0")
            {
                Display.Text = (string)button.Content;
            }
            else
            {
                Display.Text += (string)button.Content;
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
            if(this.Background == Brushes.Black)
            {
                this.Background = Brushes.White;
            }
            else
            {
                this.Background = Brushes.Black;
            }    
        }


        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Display.Text += (string)button.Content;

        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            //I must calculate the result
            //Make a lot of comments
            //Continue with comments
            DataTable dt = new DataTable();

            string expression = (string)Display.Text;

            var result = dt.Compute(expression, "");
            Display.Text = result.ToString();
        }

        private void Display_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
