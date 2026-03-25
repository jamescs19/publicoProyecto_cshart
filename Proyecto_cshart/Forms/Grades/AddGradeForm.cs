using Proyecto_cshart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_cshart.Forms.Grades
{
    public partial class AddGradeForm : Form
    {
        public AddGradeForm()
        {
            InitializeComponent();
            cmbStudent.DataSource = Program.manager.Students;
            cmbSubject.DataSource = Program.manager.Subjects;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStudent.SelectedItem == null || cmbSubject.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione estudiante y materia");
                    return;
                }

                Student student = (Student)cmbStudent.SelectedItem;
                Subject subject = (Subject)cmbSubject.SelectedItem;

                // VALIDACIÓN DE ESTUDIANTE EN MATERA
                if (!subject.Students.Contains(student))
                {
                    MessageBox.Show("El estudiante no está inscrito en esta materia");
                    return;
                }


                Grade grade = new Grade(
                    student,
                    subject,
                    (double)numGrade1.Value,
                    (double)numGrade2.Value,
                    (double)numGrade3.Value
                 );

                Program.manager.AddGrade(grade);
                Program.manager.SaveData();

                MessageBox.Show("Notas guardadas correctamente");

                numGrade1.Value = 0;
                numGrade2.Value = 0;
                numGrade3.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
