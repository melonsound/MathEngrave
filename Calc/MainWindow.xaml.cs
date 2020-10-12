using System;
using System.Windows;
using System.Windows.Controls;

namespace Calc
{
    /// <summary>
    /// Обработка данных введенных пользователем
    /// </summary>
    public partial class MainWindow : Window
    {
        public readonly string messageTitle = "Ошибка!";
        public MainWindow()
        {
            InitializeComponent();
            txtDisplayY.Text = "";
            txtDisplayX.Text = "";
        }

        private void txtDisplayX_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDisplayY_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Расчет и вывод на label результат расчетов

            MathEngrave math = new MathEngrave
            {
                height = txtDisplayY.Text,
                length = txtDisplayX.Text
            };

            if (math.height.Length <= 0 || math.length.Length <= 0)
            {
                MessageBox.Show("Поля пустые", messageTitle, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (Convert.ToInt32(math.height) > 400 || Convert.ToInt32(math.length) > 1000)
            {
                MessageBox.Show("Максимальная высота рабочей области - 400мм, длина 1000мм", messageTitle, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (Convert.ToInt32(math.height) <= 0 || Convert.ToInt32(math.length) <= 0)
            {
                MessageBox.Show("Укажите данные больше нуля", messageTitle, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                math.EngraveTime();
                TextResult.Text = Convert.ToString(Math.Round(math.timeResult));
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtDisplayX.Clear();
            txtDisplayY.Clear();
            TextResult.Clear();
            txtDisplayY.Text = "";
            txtDisplayX.Text = "";
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void MaterialsShow(object sender, RoutedEventArgs e)
        {
            //TODO: Добавить дополнительное окно с БД материалов
            //TODO: Произвести рефакторинг в XAML файле главного окна
        }
    }
}
