﻿using System;
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

namespace CookieClicker
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

        int moneyCounter = 0;
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MoneyClicked();
            ImgEuro.Width *= 1.1;
            

        }
        private void MoneyClicked()
        {
            moneyCounter++;
            LblMoneyCounter.Content = moneyCounter.ToString("c");
        }

        private void ImgEuro_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ImgEuro.Width *= 0.9;

        }


    }
}
