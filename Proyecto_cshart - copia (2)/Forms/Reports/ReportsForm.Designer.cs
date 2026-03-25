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
            lstGrades = new ListBox();
            btnShowGrades = new Button();
            cmbStudentGrades = new ComboBox();
            lblGrade = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(482, 126);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(368, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reportes academicos";
            // 
            // lblSubject
            // 
            lblSubject.Anchor = AnchorStyles.None;
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(116, 217);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(47, 15);
            lblSubject.TabIndex = 1;
            lblSubject.Text = "Materia";
            // 
            // cmbSubjectReport
            // 
            cmbSubjectReport.Anchor = AnchorStyles.None;
            cmbSubjectReport.FormattingEnabled = true;
            cmbSubjectReport.Location = new Point(169, 217);
            cmbSubjectReport.Name = "cmbSubjectReport";
            cmbSubjectReport.Size = new Size(121, 23);
            cmbSubjectReport.TabIndex = 2;
            // 
            // btnShowStudents
            // 
            btnShowStudents.Anchor = AnchorStyles.None;
            btnShowStudents.Location = new Point(169, 260);
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
            lstStudentsReport.Location = new Point(12, 288);
            lstStudentsReport.Name = "lstStudentsReport";
            lstStudentsReport.Size = new Size(415, 169);
            lstStudentsReport.TabIndex = 4;
            // 
            // lblStudent
            // 
            lblStudent.Anchor = AnchorStyles.None;
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(531, 214);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(62, 15);
            lblStudent.TabIndex = 5;
            lblStudent.Text = "Estudiante";
            // 
            // cmbStudentReport
            // 
            cmbStudentReport.Anchor = AnchorStyles.None;
            cmbStudentReport.FormattingEnabled = true;
            cmbStudentReport.Location = new Point(596, 211);
            cmbStudentReport.Name = "cmbStudentReport";
            cmbStudentReport.Size = new Size(121, 23);
            cmbStudentReport.TabIndex = 6;
            // 
            // btnShowSubjects
            // 
            btnShowSubjects.Anchor = AnchorStyles.None;
            btnShowSubjects.Location = new Point(596, 260);
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
            lstSubjectsReport.Location = new Point(433, 289);
            lstSubjectsReport.Name = "lstSubjectsReport";
            lstSubjectsReport.Size = new Size(417, 169);
            lstSubjectsReport.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(596, 473);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(89, 32);
            btnBack.TabIndex = 9;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lstGrades
            // 
            lstGrades.Anchor = AnchorStyles.None;
            lstGrades.FormattingEnabled = true;
            lstGrades.ItemHeight = 15;
            lstGrades.Location = new Point(855, 289);
            lstGrades.Name = "lstGrades";
            lstGrades.Size = new Size(444, 169);
            lstGrades.TabIndex = 13;
            // 
            // btnShowGrades
            // 
            btnShowGrades.Anchor = AnchorStyles.None;
            btnShowGrades.Location = new Point(1039, 260);
            btnShowGrades.Name = "btnShowGrades";
            btnShowGrades.Size = new Size(134, 23);
            btnShowGrades.TabIndex = 12;
            btnShowGrades.Text = "Ver materias";
            btnShowGrades.UseVisualStyleBackColor = true;
            btnShowGrades.Click += btnShowGrades_Click;
            // 
            // cmbStudentGrades
            // 
            cmbStudentGrades.Anchor = AnchorStyles.None;
            cmbStudentGrades.FormattingEnabled = true;
            cmbStudentGrades.Location = new Point(1039, 211);
            cmbStudentGrades.Name = "cmbStudentGrades";
            cmbStudentGrades.Size = new Size(121, 23);
            cmbStudentGrades.TabIndex = 11;
            // 
            // lblGrade
            // 
            lblGrade.Anchor = AnchorStyles.None;
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(995, 214);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(38, 15);
            lblGrade.TabIndex = 10;
            lblGrade.Text = "Notas";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 600);
            Controls.Add(lstGrades);
            Controls.Add(btnShowGrades);
            Controls.Add(cmbStudentGrades);
            Controls.Add(lblGrade);
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
        private ListBox lstGrades;
        private Button btnShowGrades;
        private ComboBox cmbStudentGrades;
        private Label lblGrade;
    }
}