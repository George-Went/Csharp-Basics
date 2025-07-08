using System.Text;
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
using Microsoft.Data.SqlClient;

namespace WpfDatabase_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class SfAuthor
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Birth_year { get; set; }
        public string Nationality { get; set; }
        public string Notable_work { get; set; }
    }

    public class 

    public partial class MainWindow : Window
    {
        
        // Creating a list 
        public List<Person> People = new List<Person>
        {
            new Person{Name="Homer", Age=45},
            new Person{Name="Marge", Age=44},
            new Person{Name="Lisa", Age=8},
            new Person{Name="Bart", Age=10}
        };

        public MainWindow()
        {
            InitializeComponent()

            // Column 1 - No external data
            //people_list.ItemsSource = People;s
            people_list.ItemsSource = People.Select(p => p.Name).ToList();

            // Column 2 - external data
            string connectionString = "Server=GWENTSURFACE;Database=sf_authors;Trusted_Connection=True;"


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        
   

       

    }
}