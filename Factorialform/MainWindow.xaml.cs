using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Numerics;
using System.Windows.Input;


namespace Factorialform
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DoItClick(object sender, RoutedEventArgs e)
        {
            try {
                // Получаем случайное число
                var random = Logic.Logic.Random();
                // Вычисляем факториал
                var fact = Logic.Logic.Factorial(random);
                // Добавляем новый пункт
                factorial_box.Items.Add(random + "! =" + fact.ToString());
            } catch ( Logic.LogicException le )
            {
                MessageBox.Show( le.Message );
            }
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            Application.Current.MainWindow.DragMove();
        }
    }
}
