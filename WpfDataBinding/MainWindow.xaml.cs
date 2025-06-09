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


// This is an example of both a 1 way data binding (code to UI  window) 
// And two way data binid
namespace WpfDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Instansiate Classes
        Person person1 = new Person{ Name = "Greg",Age = 30 };
        DataObjectExample dataObject1 = new DataObjectExample { OneWay = "one", TwoWay = "two", OneWaySource = "onesourec" };




        private void Button_Click_Person(object sender, RoutedEventArgs e)
        {
            string message = person1.Name + " is " + person1.Age + "years old";
            MessageBox.Show(message);
        }

        private void Button_Click_Object(object sender, RoutedEventArgs e)
        {
            string message = "One Way : " + dataObject1.OneWay + " Two Way : " + dataObject1.TwoWay + " One Way Source : " + dataObject1.OneWaySource;
            MessageBox.Show(message);
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person1; // This will try to find elements in the window that match the values set in person1
            this.DataContext = dataObject1; // For example person1.Age value will try to find a UI element called "Age" 
        }
    }
}