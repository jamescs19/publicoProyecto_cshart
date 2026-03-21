namespace Proyecto_cshart.Forms
{
    partial class EnrollmentForm
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
            lblStudent = new Label();
            cmbStudent = new ComboBox();
            lblSubject = new Label();
            cmbSubject = new ComboBox();
            btnEnroll = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(152, 95);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(553, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inscribir estudiante en materia";
            // 
            // lblStudent
            // 
            lblStudent.Anchor = AnchorStyles.None;
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(290, 175);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(62, 15);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Estudiante";
            // 
            // cmbStudent
            // 
            cmbStudent.Anchor = AnchorStyles.None;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(358, 172);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(121, 23);
            cmbStudent.TabIndex = 2;
            // 
            // lblSubject
            // 
            lblSubject.Anchor = AnchorStyles.None;
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(305, 204);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(47, 15);
            lblSubject.TabIndex = 3;
            lblSubject.Text = "Materia";
            // 
            // cmbSubject
            // 
            cmbSubject.Anchor = AnchorStyles.None;
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(358, 201);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(121, 23);
            cmbSubject.TabIndex = 4;
            // 
            // btnEnroll
            // 
            btnEnroll.Anchor = AnchorStyles.None;
            btnEnroll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnroll.Location = new Point(290, 252);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(89, 33);
            btnEnroll.TabIndex = 5;
            btnEnroll.Text = "Inscribir";
            btnEnroll.UseVisualStyleBackColor = true;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(459, 254);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(89, 31);
            btnBack.TabIndex = 6;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // EnrollmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnEnroll);
            Controls.Add(cmbSubject);
            Controls.Add(lblSubject);
            Controls.Add(cmbStudent);
            Controls.Add(lblStudent);
            Controls.Add(lblTitle);
            Name = "EnrollmentForm";
            Text = "EnrollmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStudent;
        private ComboBox cmbStudent;
        private Label lblSubject;
        private ComboBox cmbSubject;
        private Button btnEnroll;
        private Button btnBack;
    }
}