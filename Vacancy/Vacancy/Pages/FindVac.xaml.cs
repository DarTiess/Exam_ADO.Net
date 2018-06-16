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
using System.Xml.Linq;

namespace Vacancy.Pages
{
    /// <summary>
    /// Interaction logic for FindVac.xaml
    /// </summary>
    public partial class FindVac : Page
    {
        string path = "http://vacancy.kharkov.ua/widgets/rssfeeds/rss/";
        private static VacancysContainer db = new VacancysContainer();
        List<Vacancies> VacancyList = new List<Vacancies>();

        public FindVac()
        {
            InitializeComponent();
          
            categoryName.ItemsSource = db.VacancyTableSet.ToList();
          pubdate.ItemsSource = db.VacanciesSet.ToList();
           
        }

        private void findVacancy_Click(object sender, RoutedEventArgs e)
        {
           foreach(var item in db.VacanciesSet.ToList())
            {

            }
        }
    }
}
