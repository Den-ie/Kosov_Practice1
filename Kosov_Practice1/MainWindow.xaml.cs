﻿using Lib_4;
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

namespace Kosov_Practice1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Косов Даниил ИСП-34 \nПрактическая №1 \nСгенерировать массив заполненный случайными целыми числами, распределенных в диапазоне от 10 до 40.\r\nНайти минимальное значение. Вывести на экран на одной строке сгенерированные числа, на другой строке результат. \nВ классе реализовать статический метод с именем Min");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CreateMas(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(MassLenght.Text);
            int[] Array = Calculating.ArrayCreate(x);
            Answer.Text = string.Join(" ",Array);
        }

        private void SpanCheck(object sender, RoutedEventArgs e)
        {
            From.IsEnabled = true;
            To.IsEnabled = true;
            LabelFrom.IsEnabled = true;
            LabelTo.IsEnabled = true;
        }

        private void SpanUncheck(object sender, RoutedEventArgs e)
        {
            From.IsEnabled = false;
            To.IsEnabled = false;
            LabelFrom.IsEnabled = false;
            LabelTo.IsEnabled = false;

            From.Text = null;
            To.Text = null;
        }

    }
}
