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

namespace Taak1
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

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Taak1.Background = new SolidColorBrush(Colors.Black);
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Taak1.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void klikOpGeel(object sender, MouseButtonEventArgs e)
        {
            info.Text = "#FFFF00";
            informatie.Text = "Geel is de kleur van levenslust";

        }

        private void klikOpBlauw(object sender, MouseButtonEventArgs e)
        {
            info.Text = "#0000FF";
            informatie.Text = "Blauw is de kleur van intelligentie";

        }

        private void klikOpRood(object sender, MouseButtonEventArgs e)
        {
            info.Text = "#FF0000";
            informatie.Text = "Rood is de kleur van warmte";
        }

        private void klikOpGroen(object sender, MouseButtonEventArgs e)
        {
            info.Text = "#008000";
            informatie.Text = "Groen is de kleur van genezing";
        }
    }
}