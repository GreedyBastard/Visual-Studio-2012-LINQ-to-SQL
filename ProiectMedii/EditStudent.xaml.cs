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
    /// Interaction logic for EditStudent.xaml
    /// </summary>
    public partial class EditStudent : Window
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
        //Afisarea Grid-ului
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ProiectDataDataContext data = new ProiectDataDataContext();
            List<Student> studenti = (from s in data.Students
                                      select s).ToList();
            EditGrid.ItemsSource = studenti;
        }
        //Buton Adaugare Student
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Student selected = EditGrid.SelectedItem as Student;
            if (selected == null)
                MessageBox.Show("Trebuie sa selectezi un student!");
            else
            {
                UpdateStudent student = new UpdateStudent(selected);
                student.ShowDialog();
                Window_Loaded(null, null);
            }
        }
        //Buton Stergere Student
        private void StergeStudent_Click(object sender, RoutedEventArgs e)
        {
            Student selected = EditGrid.SelectedItem as Student;
            if (selected == null)
                MessageBox.Show("Trebuie sa selectezi un student!");
            else
            {
                if (MessageBoxResult.Yes == MessageBox.Show("Esti sigur?", "sterge student",
                    MessageBoxButton.YesNo, MessageBoxImage.Warning))
                {
                    Admin.DeleteStudent(selected);
                    Window_Loaded(null, null);
                }
            }
        }

    }
}
