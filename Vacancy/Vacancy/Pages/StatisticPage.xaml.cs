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

namespace Vacancy.Pages
{
    /// <summary>
    /// Логика взаимодействия для StatisticPage.xaml
    /// </summary>
    public partial class StatisticPage : Page
    {
       private static VacancysContainer db = new VacancysContainer();
        public StatisticPage()
        {
            InitializeComponent();

            _category.Text = db.VacancyTableSet.Count().ToString();
            _vacancy.Text = db.VacanciesSet.Count().ToString();
        }

        private void _count_Click(object sender, RoutedEventArgs e)
        {
            VacancyTable vc = db.VacancyTableSet.FirstOrDefault(f => f.CategoryId.ToString() ==_catFind.Text);
            _chVac.Text = db.VacanciesSet.Where(w => w.CategodyId == vc.CategoryId).Count().ToString();

        }
    }
}
