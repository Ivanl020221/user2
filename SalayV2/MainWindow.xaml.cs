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

namespace SalayV2
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

        private void SetTitle(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            if (sender is Page page)
            {
                this.Title = $"Распределение зарплат - {page.Title}";
            }
        }

        private void ExitThis(object sender, RoutedEventArgs e)
        {
            if (MessageBox.
                Show(
                "Вы уверены, " +
                "что хотите выйти?",
                "Выход",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) ==
                MessageBoxResult.Yes)
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }
    }
}
