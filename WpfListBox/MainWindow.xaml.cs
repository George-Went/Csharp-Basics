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

        List<string> colours = ["orange", "purple", "cyan", "brown"];

        public MainWindow()
        {
            InitializeComponent();
            List<string> colours = ["orange", "purple", "cyan", "brown"];

            ListBoxNameObjects.ItemsSource = colours;
        }
    }
}