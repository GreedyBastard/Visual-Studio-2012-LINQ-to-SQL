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
    /// Interaction logic for AdaugareStudent.xaml
    /// </summary>
    public partial class AdaugareStudent : Window
    {
        public AdaugareStudent()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void AdaugaStudent_Click(object sender, RoutedEventArgs e)
        {
            float nota;                                    //declaram variabila ce o v-om folosi ca sa verificam Media
            if (Nume.Text.Trim() == "")                    //verifica daca a fost introdus numele
                MessageBox.Show("Introduceti numele!");
            if (Prenume.Text.Trim() == "")                 //verifica daca a fost introdus prenumele
                MessageBox.Show("Introduceti prenumele!");
            if (Masculin.IsChecked == false && Feminin.IsChecked == false) //verifica daca a fost selectat genul
                MessageBox.Show("Trebuie sa selectati genul!");
            if (float.TryParse(Media.Text, out nota) == false)    //verifica daca media introdusa este de tip float
                MessageBox.Show("Introduceti o medie valida!");
            else if (float.TryParse(Media.Text, out nota) == true)
            {
                if (nota < 0 || nota > 10)                  //constrange ca nota sa fie intre 0 si 10
                    MessageBox.Show("Eroare, media trebuie sa fie intre 0 si 10!");
                else
                {
                    Student student = new Student();       //adaugarea datelor in baza de date
                    student.Nume = Nume.Text.Trim();
                    student.Prenume = Prenume.Text.Trim();
                    if (Masculin.IsChecked == true)
                        student.Sex = "M";
                    else
                        student.Sex = "F";
                    student.Media = nota;

                    Admin.AddStudent(student);            //apelare clasa Admin
                    MessageBox.Show(student.Nume + " a fost adaugat."); //afiseaza mesaj de confirmare dupa adaugare
                    DialogResult = true;                   //inchide fereastra dupa ce studentul a fost adaugat
                }
            }
        }
        
    }
}
