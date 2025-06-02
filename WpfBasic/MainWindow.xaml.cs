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

namespace WpfBasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // This creates a element dynamically (on the fly) 
            // Creating a version of a button in c# instead of xaml file
            Button myButton = new Button();
            myButton.Content = "B";

            // Set the location of the button 
            Grid.SetRow(myButton, 3);
            Grid.SetColumn(myButton, 4);

            // "pointing out" the grid that your using 
            Grid myGrid = (Grid)FindName("myGrid");
            myGrid.Children.Add(myButton);

            

        }

        // Theses can be generated when you add a click funciton to an xaml element 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}