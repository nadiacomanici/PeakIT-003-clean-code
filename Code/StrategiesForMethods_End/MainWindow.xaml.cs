using System;
using System.Windows;

namespace StrategiesForMethods_End
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

        private bool AreInputFieldsMissing()
        {
            return (string.IsNullOrEmpty(txtFirstNumber.Text) == false
                || string.IsNullOrEmpty(txtSecondNumber.Text) == false);
        }

        private int ComputeSum()
        {
            int firstNumber = int.Parse(txtFirstNumber.Text);
            int secondNumber = int.Parse(txtSecondNumber.Text);
            return firstNumber + secondNumber;
        }

        private void btnAddNumbers_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AreInputFieldsMissing())
                {
                    throw new Exception("You must specify a value for the input numbers");
                }

                var sum = ComputeSum();
                textBlockSum.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
