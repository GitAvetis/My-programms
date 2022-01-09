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

namespace AvetisyanTask1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
            string input = indexInput.Text;
            string[] inputMass = input.Split(',');
            int numberOfindexes = inputMass.Length;
            char[] exceptionsForCounting = { '.', ',', '?', '!', '-', '_', '"', ' ', '»', '«', '|' };

            for (var i = 0; i < numberOfindexes; i++)
                {
                string convertedString = stringConverter(inputMass[i], exceptionsForCounting);

                    TextBox txtBox = new TextBox();
                    outputText.Children.Add(txtBox);
                    txtBox.Text = inputMass[i];


                    TextBox txtBoxLetters = new TextBox();
                    outputLetters.Children.Add(txtBox);
                    txtBoxLetters.Text = convertedString.Length.ToString();

                    TextBox txtBoxVowels = new TextBox();
                    outputVowels.Children.Add(txtBox);
                }

        }
        
        public string stringConverter(string str, char[] exceptionsForCounting )
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (exceptionsForCounting.Contains(str[i]) != true)
                    newStr += str[i];             
            }
            return newStr;
        }
    }
}
