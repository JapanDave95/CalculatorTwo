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

namespace Calculator2
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
        double _double1 = 0;
        double _double2 = 0;
        string _value1 = "";
        string _value2 = "";
        string _value3 = "";
        int i = 1;
        double _result = 0;
        string _multi = "";
        
        //add soome comments

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {
                _value1 = _value1 + 1;
                txtBoutput.Text = _value1;
            }
            else
            {
                _value2 = _value2 + 1;
                txtBoutput.Text = _value1 + _value3 + _value2;
            }
            
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {
                _value1 = _value1 + 2;
                txtBoutput.Text = _value1;
            }
            else
            {
                _value2 = _value2 + 2;
                txtBoutput.Text = _value1 + _value3 + _value2;
            }
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {
                _value1 = _value1 + 3;
                txtBoutput.Text = _value1;
            }
            else
            {
                _value2 = _value2 + 3;
                txtBoutput.Text = _value1 + _value3 + _value2;
            }
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {
                _value1 = _value1 + 4;
                txtBoutput.Text = _value1;
            }
            else
            {
                _value2 = _value2 + 4;
                txtBoutput.Text = _value1 + _value3 + _value2;
            }
        }
        //add something
        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {
                _value1 = _value1 + 5;
                txtBoutput.Text = _value1;
            }
            else
            {
                _value2 = _value2 + 5;
                txtBoutput.Text = _value1 + _value3 + _value2;
                
            }
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {
                _value1 = _value1 + 6;
                txtBoutput.Text = _value1;
            }
            else
            {
                _value2 = _value2 + 6;
                txtBoutput.Text = _value1 + _value3 + _value2;
            }
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {
                _value1 = _value1 + 7;
                txtBoutput.Text = _value1;
            }
            else
            {
                _value2 = _value2 + 7;
                txtBoutput.Text = _value1 + _value3 + _value2;
            }
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {
                _value1 = _value1 + 8;
                txtBoutput.Text = _value1;
            }
            else
            {
                _value2 = _value2 + 8;
                txtBoutput.Text = _value1 + _value3 + _value2;
            }
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {
                _value1 = _value1 + 9;
                txtBoutput.Text = _value1;
            }
            else
            {
                _value2 = _value2 + 9;
                txtBoutput.Text = _value1 + _value3 + _value2;                
            }
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {
                _value1 = _value1 + 0;
                txtBoutput.Text = _value1;
            }
            else
            {
                _value2 = _value2 + 0;
                txtBoutput.Text = _value1 + _value3 + _value2;
            }
        }

        private void btn_Deci_Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {
                _value1 = _value1 + ".";
                txtBoutput.Text = _value1;
            }
            else
            {
                _value2 = _value2 + ".";
                txtBoutput.Text = _value1 + _value3 + _value2;
            }
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            _multi = "A";
            _value3 = _value3 + " + ";
            txtBoutput.Text = _value1 + _value3;
            i++;
        }

        private void btn_sub_Click(object sender, RoutedEventArgs e)
        {
            _multi = "S";
            _value3 = _value3 + " - ";
            txtBoutput.Text = _value1 + _value3;
            i++;
        }

        private void btn_multi_Click(object sender, RoutedEventArgs e)
        {
            _multi = "M";
            _value3 = _value3 + " * ";
            txtBoutput.Text = _value1 + _value3;
            i++;
        }

        private void btn_div_Click(object sender, RoutedEventArgs e)
        {
            _multi = "D";
            _value3 = _value3 + " ÷ ";
            txtBoutput.Text = _value1 + _value3;
            i++;
        }

        private void btn_Answer_Click(object sender, RoutedEventArgs e)
        {
            if (_multi == "A")
            {
                _double1 = double.Parse(_value1);
                _double2 = double.Parse(_value2);
                _result = CalcUtilities.Add(_double1, _double2);
                txtBoutput.Text = "" + _result;
            }
            else if (_multi == "S")
            {
                _double1 = double.Parse(_value1);
                _double2 = double.Parse(_value2);
                _result = CalcUtilities.Subtract(_double1, _double2);
                txtBoutput.Text = "" + _result;
            }
            else if (_multi == "M")
            {
                _double1 = double.Parse(_value1);
                _double2 = double.Parse(_value2);
                _result = CalcUtilities.Multiply(_double1, _double2);
                txtBoutput.Text = "" + _result;
            }
            else
            {
                _double1 = double.Parse(_value1);
                _double2 = double.Parse(_value2);
                _result = CalcUtilities.Subtract(_double1, _double2);
                txtBoutput.Text = "" + _result;
            }
            

        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            txtBoutput.Text = "";
            _value1 = "";
            _value2 = "";
            _value3 = "";
            i = 1;
        }
    }
    
}
