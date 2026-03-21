namespace Proyecto_cshart.Forms.Subjects
{
    partial class SubjectManagementForm
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
            btnAddSubject = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(242, 126);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(348, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gestión de materias";
            // 
            // btnAddSubject
            // 
            btnAddSubject.Anchor = AnchorStyles.None;
            btnAddSubject.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddSubject.Location = new Point(319, 190);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(177, 37);
            btnAddSubject.TabIndex = 1;
            btnAddSubject.Text = "Registrar materia";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(364, 246);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // SubjectManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnAddSubject);
            Controls.Add(lblTitle);
            Name = "SubjectManagementForm";
            Text = "SubjectManagementForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnAddSubject;
        private Button btnBack;
    }
}