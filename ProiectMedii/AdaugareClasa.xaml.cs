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
    /// Interaction logic for AdaugareClasa.xaml
    /// </summary>
    public partial class AdaugareClasa : Window
    {
        public AdaugareClasa()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void AdaugaClasa_Click(object sender, RoutedEventArgs e)
        {
            int credit;
            if (Clasa.Text.Trim() == "")                    //verifica daca a fost introdusa materia
                MessageBox.Show("Introduceti clasa!");
            if (Descriere.Text.Trim() == "")                 //verifica daca a fost introdusa descrierea clasei
                MessageBox.Show("Introduceti descrierea!");
            if (int.TryParse(Credite.Text, out credit) == false)    //verifica daca este introdus un numar corect de credite
                MessageBox.Show("Introduceti un numar valid de credite!");
            else if (int.TryParse(Credite.Text, out credit) == true)
            {
                if (credit < 0 || credit > 30)                  //constrange ca creditele sa fie intre 0 si 30
                    MessageBox.Show("Eroare, creditele trebuie sa fie intre 0 si 30!");
                else
                {
                    Clasa clasa = new Clasa();       //adaugarea datelor in baza de date
                    clasa.Nume_Clasa = Clasa.Text.Trim();
                    clasa.Descriere = Descriere.Text.Trim();
                    clasa.Credite = credit;

                    Admin.AddClasa(clasa);            //apelare clasa Admin
                    MessageBox.Show(clasa.Nume_Clasa + " a fost adaugat."); //afiseaza mesaj de confirmare dupa adaugare
                    DialogResult = true;                   //inchide fereastra dupa ce clasa a fost adaugata
                }
            }
        }
    }
}
