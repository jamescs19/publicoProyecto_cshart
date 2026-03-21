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
    public partial class ViewTeachersForm : Form
    {
        public ViewTeachersForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lstTeachers.Items.Clear();

            foreach (var teacher in Program.manager.Teachers)
            {
                lstTeachers.Items.Add(teacher.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
