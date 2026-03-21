namespace Proyecto_cshart
{
    partial class StudentManagementForm
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
            btnAddStudent = new Button();
            btnViewStudents = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(212, 90);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(415, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gestión de estudiantes";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Anchor = AnchorStyles.None;
            btnAddStudent.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.Location = new Point(303, 172);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(202, 37);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Registrar estudiante";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnViewStudents
            // 
            btnViewStudents.Anchor = AnchorStyles.None;
            btnViewStudents.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewStudents.Location = new Point(292, 224);
            btnViewStudents.Name = "btnViewStudents";
            btnViewStudents.Size = new Size(226, 37);
            btnViewStudents.TabIndex = 2;
            btnViewStudents.Text = "Consultar estudiantes";
            btnViewStudents.UseVisualStyleBackColor = true;
            btnViewStudents.Click += btnViewStudents_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(329, 281);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(146, 30);
            btnBack.TabIndex = 5;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // StudentManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnViewStudents);
            Controls.Add(btnAddStudent);
            Controls.Add(lblTitle);
            Name = "StudentManagementForm";
            Text = "StudentManagementForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnAddStudent;
        private Button btnViewStudents;
        private Button btnBack;
    }
}