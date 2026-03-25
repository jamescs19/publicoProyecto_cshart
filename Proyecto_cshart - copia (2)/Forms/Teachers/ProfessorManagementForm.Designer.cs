namespace Proyecto_cshart
{
    partial class ProfessorManagementForm
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
            btnAddProfessor = new Button();
            btnBack = new Button();
            btnViewTeachers = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(246, 113);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(296, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gestión de docentes";
            // 
            // btnAddProfessor
            // 
            btnAddProfessor.Anchor = AnchorStyles.None;
            btnAddProfessor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnAddProfessor.Location = new Point(284, 167);
            btnAddProfessor.Name = "btnAddProfessor";
            btnAddProfessor.Size = new Size(223, 40);
            btnAddProfessor.TabIndex = 1;
            btnAddProfessor.Text = "Registrar docente";
            btnAddProfessor.UseVisualStyleBackColor = true;
            btnAddProfessor.Click += btnAddProfessor_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnBack.Location = new Point(306, 257);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(165, 40);
            btnBack.TabIndex = 2;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnViewTeachers
            // 
            btnViewTeachers.Anchor = AnchorStyles.None;
            btnViewTeachers.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnViewTeachers.Location = new Point(306, 213);
            btnViewTeachers.Name = "btnViewTeachers";
            btnViewTeachers.Size = new Size(165, 40);
            btnViewTeachers.TabIndex = 3;
            btnViewTeachers.Text = "Ver docentes";
            btnViewTeachers.UseVisualStyleBackColor = true;
            btnViewTeachers.Click += btnViewTeachers_Click;
            // 
            // ProfessorManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewTeachers);
            Controls.Add(btnBack);
            Controls.Add(btnAddProfessor);
            Controls.Add(lblTitle);
            Name = "ProfessorManagementForm";
            Text = "ProfessorManagementForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnAddProfessor;
        private Button btnBack;
        private Button btnViewTeachers;
    }
}