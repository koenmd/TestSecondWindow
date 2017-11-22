using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace TestSecondWindow
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
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Screen s = Screen.AllScreens.FirstOrDefault(scr => scr.Primary);
            if (s != null)
            {
                Extension.CenterWindowOnScreen(this, s);
            }

            Screen ss = Screen.AllScreens.FirstOrDefault(scr => !scr.Primary);
            if (ss != null)
            {
                SecondWindow sw = new SecondWindow();
                sw.Show();
            }

        }
    }
}
