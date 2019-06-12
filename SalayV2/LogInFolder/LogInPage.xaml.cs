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

namespace SalayV2.LogInFolder
{
    /// <summary>
    /// Логика взаимодействия для LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        DataBaseCode.ModelDB ModelDB = new DataBaseCode.ModelDB();

        public LogInPage()
        {
            InitializeComponent();
        }

        private void LogIn(object sender, RoutedEventArgs e)
        {
            if (ModelDB.manager.Where(i => i.login == log.Text && i.password == pass.Password).Count() > 0)
            { NavigationService.Navigate(new Main.ManagerMain()); return; }

            if (ModelDB.executor.Where(i => i.login == log.Text && i.password == pass.Password).Count() > 0)
            { NavigationService.Navigate(new Main.ExecutorMain()); return; }

            MessageBox.Show("Не верный логин или пароль", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
