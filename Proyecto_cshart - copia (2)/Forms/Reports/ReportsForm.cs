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

namespace Proyecto_cshart.Forms.Reports
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            cmbSubjectReport.DataSource = Program.manager.Subjects;
            cmbStudentReport.DataSource = Program.manager.Students;
            cmbStudentGrades.DataSource = Program.manager.Students;
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            try
            {
                Subject subject = (Subject)cmbSubjectReport.SelectedItem;

                var students = Program.manager.GetStudentsInSubject(subject.Code);

                lstStudentsReport.Items.Clear();

                foreach (var s in students)
                {
                    lstStudentsReport.Items.Add(s.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowSubjects_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = (Student)cmbStudentReport.SelectedItem;

                var subjects = Program.manager.GetSubjectsInStudents(student.Id);

                lstSubjectsReport.Items.Clear();

                foreach (var s in subjects)
                {
                    lstSubjectsReport.Items.Add(s.ToString());
                }
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

        private void btnShowGrades_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStudentGrades.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un estudiante");
                    return;
                }

                Student student = (Student)cmbStudentGrades.SelectedItem;

                var grades = Program.manager.Grades
                .Where(g => g.Student.Id == student.Id)
                .ToList();

                lstGrades.Items.Clear();

                if (grades.Count == 0)
                {
                    lstGrades.Items.Add("No hay calificaciones");
                    return;
                }

                foreach (var g in grades)
                {
                    lstGrades.Items.Add(g.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
