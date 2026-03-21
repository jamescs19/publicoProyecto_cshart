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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();

            cmbCareer.DataSource = Student.typeCareers;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(
                    txtId.Text,
                    txtName.Text,
                    txtEmail.Text,
                    txtStudentCode.Text,
                    cmbCareer.Text,
                    (int)numSemester.Value
                );
                //Guardar 
                Program.manager.AddStudent(student);
                Program.manager.SaveData();

                MessageBox.Show("Estudiante registrado correctamente");

                //Limpiar 
                txtId.Clear();
                txtName.Clear();
                txtEmail.Clear();
                txtStudentCode.Clear();
                cmbCareer.SelectedIndex = -1;
                numSemester.Value = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
