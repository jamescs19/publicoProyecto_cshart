namespace Proyecto_cshart
{
    partial class AddTeacherForm
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
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblTeacherCode = new Label();
            txtTeacherCode = new TextBox();
            lblDepartment = new Label();
            cmbDepartment = new ComboBox();
            lblExperience = new Label();
            numExperience = new NumericUpDown();
            btnRegister = new Button();
            btnBack = new Button();
            lblEmail = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numExperience).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Location = new Point(345, 128);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.Location = new Point(368, 125);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Location = new Point(258, 162);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Nombre completo";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Location = new Point(368, 159);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // lblTeacherCode
            // 
            lblTeacherCode.Anchor = AnchorStyles.None;
            lblTeacherCode.AutoSize = true;
            lblTeacherCode.Location = new Point(271, 233);
            lblTeacherCode.Name = "lblTeacherCode";
            lblTeacherCode.Size = new Size(92, 15);
            lblTeacherCode.TabIndex = 4;
            lblTeacherCode.Text = "Codigo docente";
            // 
            // txtTeacherCode
            // 
            txtTeacherCode.Anchor = AnchorStyles.None;
            txtTeacherCode.Location = new Point(368, 230);
            txtTeacherCode.Name = "txtTeacherCode";
            txtTeacherCode.Size = new Size(100, 23);
            txtTeacherCode.TabIndex = 5;
            // 
            // lblDepartment
            // 
            lblDepartment.Anchor = AnchorStyles.None;
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(279, 268);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(83, 15);
            lblDepartment.TabIndex = 6;
            lblDepartment.Text = "Departamento";
            // 
            // cmbDepartment
            // 
            cmbDepartment.Anchor = AnchorStyles.None;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(368, 265);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(121, 23);
            cmbDepartment.TabIndex = 7;
            // 
            // lblExperience
            // 
            lblExperience.Anchor = AnchorStyles.None;
            lblExperience.AutoSize = true;
            lblExperience.Location = new Point(250, 303);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(112, 15);
            lblExperience.TabIndex = 8;
            lblExperience.Text = "Años de experiencia";
            // 
            // numExperience
            // 
            numExperience.Anchor = AnchorStyles.None;
            numExperience.Location = new Point(368, 301);
            numExperience.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numExperience.Name = "numExperience";
            numExperience.Size = new Size(120, 23);
            numExperience.TabIndex = 9;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.Location = new Point(306, 347);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Location = new Point(459, 347);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 11;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(320, 199);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(43, 15);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Correo";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(368, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 54);
            label1.Name = "label1";
            label1.Size = new Size(141, 40);
            label1.TabIndex = 14;
            label1.Text = "Registrar";
            // 
            // AddTeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(numExperience);
            Controls.Add(lblExperience);
            Controls.Add(cmbDepartment);
            Controls.Add(lblDepartment);
            Controls.Add(txtTeacherCode);
            Controls.Add(lblTeacherCode);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "AddTeacherForm";
            Text = "AddTeacherForm";
            ((System.ComponentModel.ISupportInitialize)numExperience).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Label lblName;
        private TextBox txtName;
        private Label lblTeacherCode;
        private TextBox txtTeacherCode;
        private Label lblDepartment;
        private ComboBox cmbDepartment;
        private Label lblExperience;
        private NumericUpDown numExperience;
        private Button btnRegister;
        private Button btnBack;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label label1;
    }
}