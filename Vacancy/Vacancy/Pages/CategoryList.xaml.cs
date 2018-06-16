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
    /// Interaction logic for CategoryList.xaml
    /// </summary>
    /// 
    
    public partial class CategoryList : Page
    {
        private static VacancysContainer db = new VacancysContainer();
        public CategoryList()
        {
            InitializeComponent();

            ListCategory.ItemsSource = db.VacancyTableSet.OrderBy(o => o.CategoryId).ToList();

        }
    }
}
