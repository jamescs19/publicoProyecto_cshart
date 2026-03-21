namespace Proyecto_cshart.Forms.Reports
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubject = new Label();
            cmbSubjectReport = new ComboBox();
            btnShowStudents = new Button();
            lstStudentsReport = new ListBox();
            lblStudent = new Label();
            cmbStudentReport = new ComboBox();
            btnShowSubjects = new Button();
            lstSubjectsReport = new ListBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(232, 51);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(368, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reportes academicos";
            // 
            // lblSubject
            // 
            lblSubject.Anchor = AnchorStyles.None;
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(102, 139);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(47, 15);
            lblSubject.TabIndex = 1;
            lblSubject.Text = "Materia";
            // 
            // cmbSubjectReport
            // 
            cmbSubjectReport.Anchor = AnchorStyles.None;
            cmbSubjectReport.FormattingEnabled = true;
            cmbSubjectReport.Location = new Point(155, 136);
            cmbSubjectReport.Name = "cmbSubjectReport";
            cmbSubjectReport.Size = new Size(121, 23);
            cmbSubjectReport.TabIndex = 2;
            // 
            // btnShowStudents
            // 
            btnShowStudents.Anchor = AnchorStyles.None;
            btnShowStudents.Location = new Point(146, 181);
            btnShowStudents.Name = "btnShowStudents";
            btnShowStudents.Size = new Size(139, 23);
            btnShowStudents.TabIndex = 3;
            btnShowStudents.Text = "Ver estudiantes";
            btnShowStudents.UseVisualStyleBackColor = true;
            btnShowStudents.Click += btnShowStudents_Click;
            // 
            // lstStudentsReport
            // 
            lstStudentsReport.Anchor = AnchorStyles.None;
            lstStudentsReport.FormattingEnabled = true;
            lstStudentsReport.ItemHeight = 15;
            lstStudentsReport.Location = new Point(73, 214);
            lstStudentsReport.Name = "lstStudentsReport";
            lstStudentsReport.Size = new Size(261, 94);
            lstStudentsReport.TabIndex = 4;
            // 
            // lblStudent
            // 
            lblStudent.Anchor = AnchorStyles.None;
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(452, 139);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(62, 15);
            lblStudent.TabIndex = 5;
            lblStudent.Text = "Estudiante";
            // 
            // cmbStudentReport
            // 
            cmbStudentReport.Anchor = AnchorStyles.None;
            cmbStudentReport.FormattingEnabled = true;
            cmbStudentReport.Location = new Point(520, 136);
            cmbStudentReport.Name = "cmbStudentReport";
            cmbStudentReport.Size = new Size(121, 23);
            cmbStudentReport.TabIndex = 6;
            // 
            // btnShowSubjects
            // 
            btnShowSubjects.Anchor = AnchorStyles.None;
            btnShowSubjects.Location = new Point(520, 181);
            btnShowSubjects.Name = "btnShowSubjects";
            btnShowSubjects.Size = new Size(134, 23);
            btnShowSubjects.TabIndex = 7;
            btnShowSubjects.Text = "Ver materias";
            btnShowSubjects.UseVisualStyleBackColor = true;
            btnShowSubjects.Click += btnShowSubjects_Click;
            // 
            // lstSubjectsReport
            // 
            lstSubjectsReport.Anchor = AnchorStyles.None;
            lstSubjectsReport.FormattingEnabled = true;
            lstSubjectsReport.ItemHeight = 15;
            lstSubjectsReport.Location = new Point(452, 214);
            lstSubjectsReport.Name = "lstSubjectsReport";
            lstSubjectsReport.Size = new Size(261, 94);
            lstSubjectsReport.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(347, 374);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(89, 32);
            btnBack.TabIndex = 9;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(lstSubjectsReport);
            Controls.Add(btnShowSubjects);
            Controls.Add(cmbStudentReport);
            Controls.Add(lblStudent);
            Controls.Add(lstStudentsReport);
            Controls.Add(btnShowStudents);
            Controls.Add(cmbSubjectReport);
            Controls.Add(lblSubject);
            Controls.Add(lblTitle);
            Name = "ReportsForm";
            Text = "ReportsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubject;
        private ComboBox cmbSubjectReport;
        private Button btnShowStudents;
        private ListBox lstStudentsReport;
        private Label lblStudent;
        private ComboBox cmbStudentReport;
        private Button btnShowSubjects;
        private ListBox lstSubjectsReport;
        private Button btnBack;
    }
}