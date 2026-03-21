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

namespace Proyecto_cshart.Forms.Subjects
{
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
            cmbTeacher.DataSource = Program.manager.Teachers;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Subject subject = new Subject(
                    txtCode.Text,
                    txtName.Text,
                    (Teacher)cmbTeacher.SelectedItem,
                    (int)numCredits.Value
                );

                Program.manager.AddSubject(subject);
                Program.manager.SaveData();

                MessageBox.Show("Materia registrada correctamente");

                txtCode.Clear();
                txtName.Clear();
                cmbTeacher.SelectedIndex = -1;
                numCredits.Value = 1;
                txtCode.Focus();
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
