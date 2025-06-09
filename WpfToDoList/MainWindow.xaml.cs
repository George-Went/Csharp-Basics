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

namespace WpfToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("create task button event triggered!");
            string todoText = TodoInput.Text; // match string to text input with x:Name "todoInput"

            // If string is not empty
            if (!string.IsNullOrEmpty(todoText))
            {
                TextBlock todoItem = new TextBlock
                {
                    Text = todoText, // set text to todoItem string
                    Margin = new Thickness(10), // set margin for text
                    Foreground = new SolidColorBrush(Colors.Black) // set color
                };
                TodoList.Children.Add(todoItem);
                TodoInput.Clear();
            }
        }
    }
}