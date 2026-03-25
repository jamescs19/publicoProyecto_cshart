namespace Proyecto_cshart
{
    partial class AddStudentForm
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
            lblName = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblStudentCode = new Label();
            txtStudentCode = new TextBox();
            lblCareer = new Label();
            cmbCareer = new ComboBox();
            lblSemester = new Label();
            numSemester = new NumericUpDown();
            btnRegister = new Button();
            btnBack = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numSemester).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Location = new Point(352, 116);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Location = new Point(265, 144);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Nombre completo";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.Location = new Point(376, 113);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Location = new Point(376, 141);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(327, 173);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(43, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Correo";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(376, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblStudentCode
            // 
            lblStudentCode.Anchor = AnchorStyles.None;
            lblStudentCode.AutoSize = true;
            lblStudentCode.Location = new Point(265, 202);
            lblStudentCode.Name = "lblStudentCode";
            lblStudentCode.Size = new Size(104, 15);
            lblStudentCode.TabIndex = 6;
            lblStudentCode.Text = "Codigo estudiante";
            // 
            // txtStudentCode
            // 
            txtStudentCode.Anchor = AnchorStyles.None;
            txtStudentCode.Location = new Point(376, 199);
            txtStudentCode.Name = "txtStudentCode";
            txtStudentCode.Size = new Size(100, 23);
            txtStudentCode.TabIndex = 7;
            // 
            // lblCareer
            // 
            lblCareer.Anchor = AnchorStyles.None;
            lblCareer.AutoSize = true;
            lblCareer.Location = new Point(313, 231);
            lblCareer.Name = "lblCareer";
            lblCareer.Size = new Size(45, 15);
            lblCareer.TabIndex = 8;
            lblCareer.Text = "Carrera";
            // 
            // cmbCareer
            // 
            cmbCareer.Anchor = AnchorStyles.None;
            cmbCareer.FormattingEnabled = true;
            cmbCareer.Location = new Point(364, 228);
            cmbCareer.Name = "cmbCareer";
            cmbCareer.Size = new Size(121, 23);
            cmbCareer.TabIndex = 9;
            // 
            // lblSemester
            // 
            lblSemester.Anchor = AnchorStyles.None;
            lblSemester.AutoSize = true;
            lblSemester.Location = new Point(303, 259);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(55, 15);
            lblSemester.TabIndex = 10;
            lblSemester.Text = "Semestre";
            // 
            // numSemester
            // 
            numSemester.Anchor = AnchorStyles.None;
            numSemester.Location = new Point(365, 257);
            numSemester.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numSemester.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSemester.Name = "numSemester";
            numSemester.Size = new Size(120, 23);
            numSemester.TabIndex = 11;
            numSemester.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.Location = new Point(327, 319);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Location = new Point(446, 319);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 13;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 49);
            label1.Name = "label1";
            label1.Size = new Size(141, 40);
            label1.TabIndex = 14;
            label1.Text = "Registrar";
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(numSemester);
            Controls.Add(lblSemester);
            Controls.Add(cmbCareer);
            Controls.Add(lblCareer);
            Controls.Add(txtStudentCode);
            Controls.Add(lblStudentCode);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            ((System.ComponentModel.ISupportInitialize)numSemester).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private TextBox txtId;
        private TextBox txtName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblStudentCode;
        private TextBox txtStudentCode;
        private Label lblCareer;
        private ComboBox cmbCareer;
        private Label lblSemester;
        private NumericUpDown numSemester;
        private Button btnRegister;
        private Button btnBack;
        private Label label1;
    }
}