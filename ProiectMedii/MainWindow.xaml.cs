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

namespace ProiectMedii
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
//--->>Meniul de adaugare si iesire <<---//
        private void MenuItem_AdaugaStudent(object sender, RoutedEventArgs e)
        {
            AdaugareStudent student = new AdaugareStudent();
            student.ShowDialog();
        }
        private void MenuItem_AdaugaClasa(object sender, RoutedEventArgs e)
        {
            AdaugareClasa clasa = new AdaugareClasa();
            clasa.ShowDialog();
        }
        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
//--->>End Meniu<<---//

//--->>Meniu Editare<<---//
        private void MenuItem_Edit(object sender, RoutedEventArgs e)
        {
            EditStudent studenti = new EditStudent();
            studenti.ShowDialog();
        }
//--->>End Editare<<---//

//--->>Meniu Afisare<<---//
        private void MenuItem_AfisareStudent(object sender, RoutedEventArgs e)
        {
            AfisareStudenti studenti = new AfisareStudenti();
            studenti.ShowDialog();
        }

        private void MenuItem_AfisareClasa(object sender, RoutedEventArgs e)
        {
            AfisareClasa clasa = new AfisareClasa();
            clasa.ShowDialog();
        }

//--->>End Afisare<<---//

    }
}
