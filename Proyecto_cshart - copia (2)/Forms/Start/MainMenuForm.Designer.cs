namespace Proyecto_cshart
{
    partial class MainMenuForm
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
            btnStudents = new Button();
            btnProfessors = new Button();
            btnSubjects = new Button();
            btnEnrollments = new Button();
            btnReports = new Button();
            btnBack = new Button();
            btnGrades = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(190, 73);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(436, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sistema de Gestión Académica";
            // 
            // btnStudents
            // 
            btnStudents.Anchor = AnchorStyles.None;
            btnStudents.Location = new Point(296, 134);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(220, 27);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "Gestión de estudiantes";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnProfessors
            // 
            btnProfessors.Anchor = AnchorStyles.None;
            btnProfessors.Location = new Point(296, 179);
            btnProfessors.Name = "btnProfessors";
            btnProfessors.Size = new Size(220, 25);
            btnProfessors.TabIndex = 2;
            btnProfessors.Text = "Gestión de docentes";
            btnProfessors.UseVisualStyleBackColor = true;
            btnProfessors.Click += btnProfessors_Click;
            // 
            // btnSubjects
            // 
            btnSubjects.Anchor = AnchorStyles.None;
            btnSubjects.Location = new Point(296, 224);
            btnSubjects.Name = "btnSubjects";
            btnSubjects.Size = new Size(220, 23);
            btnSubjects.TabIndex = 3;
            btnSubjects.Text = "Gestión de materias";
            btnSubjects.UseVisualStyleBackColor = true;
            btnSubjects.Click += btnSubjects_Click;
            // 
            // btnEnrollments
            // 
            btnEnrollments.Anchor = AnchorStyles.None;
            btnEnrollments.Location = new Point(296, 266);
            btnEnrollments.Name = "btnEnrollments";
            btnEnrollments.Size = new Size(220, 23);
            btnEnrollments.TabIndex = 5;
            btnEnrollments.Text = "Inscripciones";
            btnEnrollments.UseVisualStyleBackColor = true;
            btnEnrollments.Click += btnEnrollments_Click;
            // 
            // btnReports
            // 
            btnReports.Anchor = AnchorStyles.None;
            btnReports.Location = new Point(296, 352);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(220, 23);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reportes";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Location = new Point(314, 394);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(185, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnGrades
            // 
            btnGrades.Anchor = AnchorStyles.None;
            btnGrades.Location = new Point(296, 307);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(220, 27);
            btnGrades.TabIndex = 7;
            btnGrades.Text = "Calificaciones";
            btnGrades.UseVisualStyleBackColor = true;
            btnGrades.Click += btnGrades_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGrades);
            Controls.Add(btnReports);
            Controls.Add(btnEnrollments);
            Controls.Add(btnBack);
            Controls.Add(btnSubjects);
            Controls.Add(btnProfessors);
            Controls.Add(btnStudents);
            Controls.Add(lblTitle);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnStudents;
        private Button btnProfessors;
        private Button btnSubjects;
        private Button btnEnrollments;
        private Button btnReports;
        private Button btnBack;
        private Button btnGrades;
    }
}