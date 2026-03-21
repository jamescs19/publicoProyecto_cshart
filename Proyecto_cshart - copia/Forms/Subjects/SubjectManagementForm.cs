using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_cshart.Forms.Subjects
{
    public partial class SubjectManagementForm : Form
    {
        public SubjectManagementForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            AddSubjectForm form = new AddSubjectForm();
            form.Show();
        }
    }
}
