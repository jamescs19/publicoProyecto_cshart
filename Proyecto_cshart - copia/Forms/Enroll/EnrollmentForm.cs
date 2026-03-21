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

namespace Proyecto_cshart.Forms
{
    public partial class EnrollmentForm : Form
    {
        public EnrollmentForm()
        {
            InitializeComponent();
            cmbStudent.DataSource = Program.manager.Students;
            cmbSubject.DataSource = Program.manager.Subjects;
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = (Student)cmbStudent.SelectedItem;
                Subject subject = (Subject)cmbSubject.SelectedItem;

                Program.manager.EnrollStudentInSubject(student, subject);
                Program.manager.SaveData();

                MessageBox.Show("Estudiante inscrito correctamente");

                cmbStudent.SelectedIndex = -1;
                cmbSubject.SelectedIndex = -1;
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
