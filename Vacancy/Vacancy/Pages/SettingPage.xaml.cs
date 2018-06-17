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
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data.Entity.Core.EntityClient;

namespace Vacancy.Pages
{
    /// <summary>
    /// Логика взаимодействия для SettingPage.xaml
    /// </summary>
    public partial class SettingPage : Page
    {
      

        public SettingPage()
        {
            InitializeComponent();
             string connectionString = ConfigurationManager.ConnectionStrings["VacancysContainer"].ConnectionString;
            if (connectionString.ToLower().StartsWith("metadata="))
            {
                System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder efBuilder = new System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder(connectionString);
                connectionString = efBuilder.ProviderConnectionString;
            }

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
            Server.Text = builder.DataSource;            
            DBName.Text = builder.InitialCatalog;         
            UserPass.Text = builder.Password;
            UserName.Text= builder.UserID;

        }

        private void editPage_Click(object sender, RoutedEventArgs e)
        {
            
            SqlConnectionStringBuilder sqlBuilder =
                new SqlConnectionStringBuilder();


            sqlBuilder.DataSource = _server.Text;
            sqlBuilder.InitialCatalog = _dbName.Text;
            sqlBuilder.IntegratedSecurity = true;
            
            string providerString = sqlBuilder.ToString();

            EntityConnectionStringBuilder entityBuilder =
                new EntityConnectionStringBuilder();
            
            entityBuilder.Provider = "System.Data.SqlClient";
            
            entityBuilder.ProviderConnectionString = providerString;

         
            entityBuilder.Metadata = @" metadata = res://*/Vacancys.csdl|res://*/Vacancys.ssdl|res://*/Vacancys.msl";
            MessageBox.Show( entityBuilder.ToString());

            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
