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


using WpfDataBinding.Data; // Import in class from Data/Person

namespace WpfListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        {
            new Person{Name="Homer", Age=45},
            new Person{Name="Marge", Age=44},
            new Person{Name="Lisa", Age=8},
            new Person{Name="Bart", Age=10}
        };

        public MainWindow()
        {
            InitializeComponent();
            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // bind the valeue to a UI item
            var selectedItems = ListBoxPeople.SelectedItems;
            foreach (var item in selectedItems)
            {
                // Just show UI object 
                //MessageBox.Show(item.GetType().ToString());
                //or 
                // casted the item object into Person class
                var person = (Person)item;
                MessageBox.Show(person.Name + " : " + person.Age);

                
            }
        }
    }
}