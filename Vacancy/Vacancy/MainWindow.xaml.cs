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

namespace Vacancy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame fr;
        private static VacancysContainer db = new VacancysContainer();
        private static string path = "http://vacancy.kharkov.ua/widgets/rssfeeds/";

        public MainWindow()
        {
            InitializeComponent();
            fr = CentralFrame;
            

        }

        private void category_Click(object sender, RoutedEventArgs e)
        {
            CentralFrame.Source= new Uri(@"Pages\CategoryAdd.xaml", UriKind.RelativeOrAbsolute);
        }

        private void find_Click(object sender, RoutedEventArgs e)
        {
            CentralFrame.Source = new Uri(@"Pages\FindVac.xaml", UriKind.RelativeOrAbsolute);
        }

        private void setting_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
