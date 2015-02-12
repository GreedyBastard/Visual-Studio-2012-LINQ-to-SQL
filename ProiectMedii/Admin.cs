using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMedii
{
    public static class Admin
    {
        #region Student
        //ADD STUDENT
        public static void AddStudent(Student student)
        {
            using (ProiectDataDataContext conn = new ProiectDataDataContext())
            {
                conn.Students.InsertOnSubmit(student);
                conn.SubmitChanges();
            }
        }
        //UPDATE STUDENT
        public static void UpdateStudent(Student student)
        {
            using (ProiectDataDataContext conn = new ProiectDataDataContext())
            {
                Student stu = (from s in conn.Students
                               where s.IdStudent == student.IdStudent
                               select s).FirstOrDefault();
                stu.Nume = student.Nume;
                stu.Prenume = student.Prenume;
                stu.Sex = student.Sex;
                stu.Media = student.Media;
                conn.SubmitChanges();
            }
        }
        //DELETE STUDENT
        public static void DeleteStudent(Student student)
        {
            using (ProiectDataDataContext conn = new ProiectDataDataContext())
            {
                Student stu = (from s in conn.Students
                               where s.IdStudent == student.IdStudent
                               select s).FirstOrDefault();
                conn.Students.DeleteOnSubmit(stu);
                conn.SubmitChanges();
            }
        }
        #endregion

        #region Clasa
        //ADD CLASS
        public static void AddClasa(Clasa clasa)
        {
            using (ProiectDataDataContext con = new ProiectDataDataContext())
            {
                con.Clasas.InsertOnSubmit(clasa);
                con.SubmitChanges();
                
            }
        }
        #endregion
    }
}
