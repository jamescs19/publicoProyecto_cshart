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
    public partial class ProfessorManagementForm : Form
    {
        public ProfessorManagementForm()
        {
            InitializeComponent();
        }

        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            AddTeacherForm form = new AddTeacherForm();
            form.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnViewTeachers_Click(object sender, EventArgs e)
        {
            ViewTeachersForm form = new ViewTeachersForm();
            form.Show();
        }
    }
}
