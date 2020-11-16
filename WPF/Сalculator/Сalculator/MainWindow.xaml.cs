using System;
using System.Data;
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

namespace Сalculator
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            foreach(UIElement el in MainRoot.Children)
            {
                if (el is Button)
                {
                    ((Button) el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (str == "АС")
                textLabel.Text = "";

            else if (str == "=")
            {
                try
                {
                    new DataTable().Compute(textLabel.Text, "null").ToString();
                }
                catch
                {
                    textLabel.Text = "ERROR";
                }

                if (textLabel.Text.Length > 22)
                {
                    textLabel.Text = "ERROR";
                }

                if (textLabel.Text != "ERROR")
                {
                    string value = new DataTable().Compute(textLabel.Text, "null").ToString();
                    textLabel.Text = value;
                }
            }
            else
            {
                if (textLabel.Text == "ERROR")
                {
                    textLabel.Text = "";
                }
                if (textLabel.Text.Length > 22)
                {
                    textLabel.Text = "ERROR";
                }
                else
                    textLabel.Text += str;
            }
        }
    }
}
