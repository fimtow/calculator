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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    enum Operation
    {
        ADD,
        MULTI,
        SUBS,
        DIV,
    }
    public partial class MainWindow : Window
    {
        double buff = 0.0;
        Operation operation = Operation.ADD;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CButton_Click(object sender, RoutedEventArgs e)
        {
            this.screen.Text = "";
            buff = 0.0;
        }

        private void EButton_Click(object sender, RoutedEventArgs e)
        {
            this.screen.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.screen.Text += (string)((Button)sender).Content;
        }

        private void OpButton_Click(object sender, RoutedEventArgs e)
        {
            buff = Convert.ToDouble(this.screen.Text);
            switch ((string)((Button)sender).Content)
            {
                case "*": operation = Operation.MULTI; break;
                case "-": operation = Operation.SUBS; break;
                case "/": operation = Operation.DIV; break;
                case "+": operation = Operation.ADD; break;
            }
            //this.screen.Text = Convert.ToString(buff);
            this.screen.Text = "";
        }

        private void EqButton_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case Operation.ADD: buff += Convert.ToDouble(this.screen.Text); break;
                case Operation.MULTI: buff *= Convert.ToDouble(this.screen.Text); break;
                case Operation.SUBS: buff -= Convert.ToDouble(this.screen.Text); break;
                case Operation.DIV: buff /= Convert.ToDouble(this.screen.Text); break;
            }
            this.screen.Text = Convert.ToString(buff);
        }
    }
}
