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
//Meili Zheng;
//Lab - Text Boxes, Labels, and Buttons;
//1/15/2023;

namespace Lab___Text_Boxes__Labels__and_Buttons
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

        private void btnADD_Click(object sender, RoutedEventArgs e)
        {
            // use lblAddSubtract.Content transfer the +/- lable to "+" when user choose add;
            lblAddSubtract.Content = "+";
            //declare the variable type; when user enter a value in txtvalue1 textbox, it will hold to "value1" as a string;
            string value1 = txtValue1.Text;
            //declare the variable type; when user enter a value in txtvalue1 textbox, it will hold to "value2" as a string;
            string value2 = txtValue2.Text;
            //declare the variable type;
            double val1, val2 = 0;
            //if user input is double type, It will calculate the result;
            bool ValueisNum = double.TryParse(value1, out val1);
            bool ValueisNum2 = double.TryParse(value2, out val2);
            if (ValueisNum && ValueisNum2)
            {
                double sum = val1 + val2;
                txtAddSubtractResult.Text = sum.ToString();
                MessageBox.Show(sum.ToString());
            }
            //else give the user a notic;
            else
            {
                MessageBox.Show("Invalid information");
            }
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            // use lblAddSubtract.Content transfer the +/- lable to "-" when user choose subtraction;
            lblAddSubtract.Content = "-";
            //declare the variable type; when user enter a value in txtvalue1 textbox, it will hold to "value1" as a string;
            string value1 = txtValue1.Text;
            //declare the variable type; when user enter a value in txtvalue1 textbox, it will hold to "value2" as a string;
            string value2 = txtValue2.Text;
            //declare the variable type;
            double val1, val2 = 0;
            //if user input is double type, It will calculate the result;
            bool ValueisNum = double.TryParse(value1, out val1);
            bool ValueisNum2 = double.TryParse(value2, out val2);
            if (ValueisNum && ValueisNum2)
            {
                double subtract = val1 - val2;
                txtAddSubtractResult.Text = subtract.ToString();
                MessageBox.Show(subtract.ToString());
            }
            //else give the user a notic;
            else
            {
                MessageBox.Show("Invalid information");
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            // use lblMiltiplyDivide.Content transfer the +/- lable to "*" when user choose multiplycation;
            lblMiltiplyDivide.Content = "*";
            //declare the variable type; when user enter a value in txtvalue1 textbox, it will hold to "value3" as a string;
            string value3 = txtValue3.Text;
            //declare the variable type; when user enter a value in txtvalue1 textbox, it will hold to "value4" as a string;
            string value4 = txtValue4.Text;
            //declare the variable type;
            double val1, val2 = 0;
            //if user input is double type, It will calculate the result;
            bool ValueisNum = double.TryParse(value3, out val1);
            bool ValueisNum2 = double.TryParse(value4, out val2);
            if(ValueisNum && ValueisNum2)
            {
                double mutiply = val1 * val2;
                txtMultipDivideResult.Text = mutiply.ToString();
                MessageBox.Show(mutiply.ToString());
            }
            //else give the user a notic;
            else
            {
                MessageBox.Show("Invalid information");
            }
            
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            // use lblMiltiplyDivide.Content transfer the +/- lable to "/" when user choose multiplycation;
            lblMiltiplyDivide.Content = "/";
            //declare the variable type; when user enter a value in txtvalue1 textbox, it will hold to "value3" as a string;
            string value3 = txtValue3.Text;
            //declare the variable type; when user enter a value in txtvalue1 textbox, it will hold to "value4" as a string;
            string value4 = txtValue4.Text;
            //declare the variable type;
            double val1, val2 = 0;
            //if user input is double type, It will calculate the result;
            bool ValueisNum = double.TryParse(value3, out val1);
            bool ValueisNum2 = double.TryParse(value4, out val2);
            if (ValueisNum && ValueisNum2)
            {
                double mutiply = val1 / val2;
                txtMultipDivideResult.Text = mutiply.ToString();
                MessageBox.Show(mutiply.ToString());
            }
            //else give the user a notic;
            else
            {
                MessageBox.Show("Invalid information");
            }
            
        }

        private void btnAverage_Click(object sender, RoutedEventArgs e)
        {
            //declare the variable type; the value in txtAddSubtractResult.Text will hold in "rsult1" as a string;
            string result1 = txtAddSubtractResult.Text;
            //declare the variable type; the value in txtMultipDivideResult.Text will hold in "rsult2" as a string;
            string result2 = txtMultipDivideResult.Text;
            //convert the variable type;           
            double Valueresult1 = double.Parse(result1);
            double Valueresult2 = double.Parse(result2);    
            //calculate the avarage;
            double Average = (Valueresult1 + Valueresult2) / 2;
            txtAverage.Text = Average.ToString();
            //display the result;
            MessageBox.Show(Average.ToString());        

        }
    }
}
