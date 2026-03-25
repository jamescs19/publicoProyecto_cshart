using Proyecto_cshart.Forms;
using Proyecto_cshart.Forms.Grades;
using Proyecto_cshart.Forms.Reports;
using Proyecto_cshart.Forms.Subjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_cshart
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Startfrom start = new Startfrom();
            start.Show();
            this.Close();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentManagementForm form = new StudentManagementForm();
            form.Show();
            this.Close();

        }

        private void btnProfessors_Click(object sender, EventArgs e)
        {
            ProfessorManagementForm form = new ProfessorManagementForm();
            form.Show();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            SubjectManagementForm form = new SubjectManagementForm();
            form.Show();
        }

        private void btnEnrollments_Click(object sender, EventArgs e)
        {
            EnrollmentForm form = new EnrollmentForm();
            form.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm form = new ReportsForm();
            form.Show();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            GradeManagementForm form = new GradeManagementForm();
            form.Show();
        }
    }
}
