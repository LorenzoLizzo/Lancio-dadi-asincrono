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

namespace Lancio_dadi_asincrono
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Uri uriFaccia1 = new Uri("faccia1.png", UriKind.Relative);
        readonly Uri uriFaccia2 = new Uri("faccia2.png", UriKind.Relative);
        readonly Uri uriFaccia3 = new Uri("faccia3.png", UriKind.Relative);
        readonly Uri uriFaccia4 = new Uri("faccia4.png", UriKind.Relative);
        readonly Uri uriFaccia5 = new Uri("faccia5.png", UriKind.Relative);
        readonly Uri uriFaccia6 = new Uri("faccia6.png", UriKind.Relative);

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
