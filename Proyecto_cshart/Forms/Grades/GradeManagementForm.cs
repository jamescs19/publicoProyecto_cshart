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
    public partial class GradeManagementForm : Form
    {
        public GradeManagementForm()
        {
            InitializeComponent();
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            AddGradeForm form = new AddGradeForm();
            form.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
