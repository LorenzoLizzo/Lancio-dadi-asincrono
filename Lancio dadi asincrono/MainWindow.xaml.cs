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
using System.Threading;

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

        private object a = new object();

        Random r;
        int dado1;
        int dado2;
        public MainWindow()
        {
            InitializeComponent();
            SorteggioDadi();
        }

        private async void SorteggioDadi()
        {
            try
            {
                r = new Random();
                await Task.Run(() =>
                {
                    while (true)
                    {
                        dado1 = r.Next(1, 7);
                        dado2 = r.Next(1, 7);
                        this.Dispatcher.BeginInvoke(new Action(() => {
                            AssegnazioneImmagine(img1, dado1);
                            AssegnazioneImmagine(img2, dado2);
                        }));
                        Thread.Sleep(10);
                    }

                });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void AssegnazioneImmagine(Image img, int dado)
        {
            try
            {
                switch (dado)
                {
                    case 1:
                        img.Source = new BitmapImage(uriFaccia1);
                        break;
                    case 2:
                        img.Source = new BitmapImage(uriFaccia2);
                        break;
                    case 3:
                        img.Source = new BitmapImage(uriFaccia3);
                        break;
                    case 4:
                        img.Source = new BitmapImage(uriFaccia4);
                        break;
                    case 5:
                        img.Source = new BitmapImage(uriFaccia5);
                        break;
                    case 6:
                        img.Source = new BitmapImage(uriFaccia6);
                        break;
                    default:
                        throw new Exception("Errore");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEstrai_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lblPiu.Visibility = Visibility.Visible;
                lblUguale.Visibility = Visibility.Visible;
                img3.Source = img1.Source;
                lblPiu.Visibility = Visibility.Visible;
                img4.Source = img2.Source;
                lblUguale.Visibility = Visibility.Visible;
                lblRisultato.Content = int.Parse(img3.Source.ToString()[img3.Source.ToString().Length - 5].ToString()) + int.Parse( img4.Source.ToString()[img4.Source.ToString().Length - 5].ToString()); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
      
    }
}
