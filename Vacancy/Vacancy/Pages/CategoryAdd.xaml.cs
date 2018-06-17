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
    /// Interaction logic for CategoryAdd.xaml
    /// </summary>
    public partial class CategoryAdd : Page
    {
        private static string path;
        private static VacancysContainer db = new VacancysContainer();
        private static List<Vacancies> VacancyList = new List<Vacancies>();
        public CategoryAdd()
        {
            InitializeComponent();


        }



        private void SaveCategoty_Click(object sender, RoutedEventArgs e)
        {
            VacancyTable vc = new VacancyTable();
            try
            {

                vc.CategoryName = _nameCategory.Text;
                vc.linkCategory = _linkCategory.Text;
                db.VacancyTableSet.Add(vc);
                db.SaveChanges();
                MessageBox.Show("Категория добавлена");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
                MessageBox.Show(ex.Message);
            }
            path = vc.linkCategory;
            XDocument doc = new XDocument();


            doc = XDocument.Load(path);

            VacancyList = doc.Element("rss")
                .Element("channel")
                //.Element("link")
                .Elements()
                .Where(w => w.Name == "item")
                .Select(s =>
                new Vacancies
                {

                    VacancyName = s.Element("title").Value,
                    Description = s.Element("description").Value,
                    pubDate = DateTime.Parse(s.Element("pubDate").Value),
                    CategodyId = int.Parse(vc.CategoryId.ToString())
                }

                ).OrderByDescending(o => o.pubDate).ToList();
            foreach (var item in VacancyList)
            {
                db.VacanciesSet.SkipWhile(s => s.pubDate > DateTime.Parse("2018-01-01"));
                db.VacanciesSet.Add(item);

            }
            db.SaveChanges();
            MainWindow.fr.Source = new Uri(@"Pages\CategoryList.xaml", UriKind.RelativeOrAbsolute);
        }


        

    
    }
}
