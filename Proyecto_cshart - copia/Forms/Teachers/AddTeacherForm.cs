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

namespace Proyecto_cshart
{
    public partial class AddTeacherForm : Form
    {
        public AddTeacherForm()
        {
            InitializeComponent();
            cmbDepartment.DataSource = Teacher.allDepartments;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher teacher = new Teacher(
                    txtId.Text,
                    txtName.Text,
                    txtEmail.Text,
                    txtTeacherCode.Text,
                    cmbDepartment.Text,
                    (int)numExperience.Value
                );

                Program.manager.AddTeacher(teacher);
                Program.manager.SaveData();

                MessageBox.Show("Docente registrado correctamente");

                // limpiar
                txtId.Clear();
                txtName.Clear();
                txtEmail.Clear();
                txtTeacherCode.Clear();
                cmbDepartment.SelectedIndex = -1;
                numExperience.Value = 0;
                txtId.Focus();
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
