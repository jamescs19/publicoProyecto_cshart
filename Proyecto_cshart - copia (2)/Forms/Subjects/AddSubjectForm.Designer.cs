namespace Proyecto_cshart.Forms.Subjects
{
    partial class AddSubjectForm
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
            lblCode = new Label();
            txtCode = new TextBox();
            llblName = new Label();
            txtName = new TextBox();
            lblredits = new Label();
            numCredits = new NumericUpDown();
            lblTeacher = new Label();
            cmbTeacher = new ComboBox();
            btnRegister = new Button();
            btnBack = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numCredits).BeginInit();
            SuspendLayout();
            // 
            // lblCode
            // 
            lblCode.Anchor = AnchorStyles.None;
            lblCode.AutoSize = true;
            lblCode.Location = new Point(317, 128);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(46, 15);
            lblCode.TabIndex = 0;
            lblCode.Text = "Codigo";
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.None;
            txtCode.Location = new Point(369, 125);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(100, 23);
            txtCode.TabIndex = 1;
            // 
            // llblName
            // 
            llblName.Anchor = AnchorStyles.None;
            llblName.AutoSize = true;
            llblName.Location = new Point(312, 167);
            llblName.Name = "llblName";
            llblName.Size = new Size(51, 15);
            llblName.TabIndex = 2;
            llblName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Location = new Point(369, 164);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // lblredits
            // 
            lblredits.Anchor = AnchorStyles.None;
            lblredits.AutoSize = true;
            lblredits.Location = new Point(304, 210);
            lblredits.Name = "lblredits";
            lblredits.Size = new Size(51, 15);
            lblredits.TabIndex = 4;
            lblredits.Text = "Creditos";
            // 
            // numCredits
            // 
            numCredits.Anchor = AnchorStyles.None;
            numCredits.Location = new Point(361, 208);
            numCredits.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numCredits.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCredits.Name = "numCredits";
            numCredits.Size = new Size(120, 23);
            numCredits.TabIndex = 5;
            numCredits.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTeacher
            // 
            lblTeacher.Anchor = AnchorStyles.None;
            lblTeacher.AutoSize = true;
            lblTeacher.Location = new Point(304, 252);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(51, 15);
            lblTeacher.TabIndex = 6;
            lblTeacher.Text = "Profesor";
            // 
            // cmbTeacher
            // 
            cmbTeacher.Anchor = AnchorStyles.None;
            cmbTeacher.FormattingEnabled = true;
            cmbTeacher.Location = new Point(361, 249);
            cmbTeacher.Name = "cmbTeacher";
            cmbTeacher.Size = new Size(121, 23);
            cmbTeacher.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.Location = new Point(312, 318);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Registrar materia";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Location = new Point(441, 318);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 9;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 60);
            label1.Name = "label1";
            label1.Size = new Size(141, 40);
            label1.TabIndex = 10;
            label1.Text = "Registrar";
            // 
            // AddSubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(cmbTeacher);
            Controls.Add(lblTeacher);
            Controls.Add(numCredits);
            Controls.Add(lblredits);
            Controls.Add(txtName);
            Controls.Add(llblName);
            Controls.Add(txtCode);
            Controls.Add(lblCode);
            Name = "AddSubjectForm";
            Text = "AddSubjectForm";
            ((System.ComponentModel.ISupportInitialize)numCredits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCode;
        private TextBox txtCode;
        private Label llblName;
        private TextBox txtName;
        private Label lblredits;
        private NumericUpDown numCredits;
        private Label lblTeacher;
        private ComboBox cmbTeacher;
        private Button btnRegister;
        private Button btnBack;
        private Label label1;
    }
}