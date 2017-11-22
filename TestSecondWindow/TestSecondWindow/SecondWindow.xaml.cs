using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace TestSecondWindow
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Screen s = Screen.AllScreens.FirstOrDefault(scr => !scr.Primary);
            if (s != null)
            {
                Extension.CenterWindowOnScreen(this, s);
            }
        }
    }
}
