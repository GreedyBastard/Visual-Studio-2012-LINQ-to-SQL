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
using System.Windows.Shapes;

namespace ProiectMedii
{
    /// <summary>
    /// Interaction logic for AfisareStudenti.xaml
    /// </summary>
    public partial class AfisareStudenti : Window
    {
        public AfisareStudenti()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ProiectDataDataContext data = new ProiectDataDataContext();
            List <Student> studenti = (from s in data.Students
                                      select s).ToList();
            StudentGrid.ItemsSource = studenti;
        }

    }
}
