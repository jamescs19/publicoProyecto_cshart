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
    public partial class StudentManagementForm : Form
    {
        public StudentManagementForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm menu = new MainMenuForm();
            menu.Show();
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm();
            form.Show();
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            ViewStudentsForm form = new ViewStudentsForm();
            form.Show();
        }
    }
}
