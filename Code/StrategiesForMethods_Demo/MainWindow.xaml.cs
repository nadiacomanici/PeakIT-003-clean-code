﻿using System;
using System.Windows;

namespace StrategiesForMethods_Demo
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

        private void btnAddNumbers_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int firstNumber;
                int secondNumber;
                int sum;

                if (string.IsNullOrEmpty(txtFirstNumber.Text) == false)
                {
                    firstNumber = int.Parse(txtFirstNumber.Text);

                    if (string.IsNullOrEmpty(txtSecondNumber.Text) == false)
                    {
                        secondNumber = int.Parse(txtSecondNumber.Text);

                        sum = firstNumber + secondNumber;
                        textBlockSum.Text = sum.ToString();
                    }
                    else
                    {
                        throw new Exception("You must specify a value for the input numbers");
                    }
                }
                else
                {
                    throw new Exception("You must specify a value for the input numbers");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

