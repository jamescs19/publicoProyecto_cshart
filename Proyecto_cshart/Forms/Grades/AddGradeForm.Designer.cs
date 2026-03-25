namespace Proyecto_cshart.Forms.Grades
{
    partial class AddGradeForm
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
            cmbStudent = new ComboBox();
            cmbSubject = new ComboBox();
            numGrade1 = new NumericUpDown();
            numGrade2 = new NumericUpDown();
            numGrade3 = new NumericUpDown();
            btnSave = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numGrade1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGrade2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGrade3).BeginInit();
            SuspendLayout();
            // 
            // cmbStudent
            // 
            cmbStudent.Anchor = AnchorStyles.None;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(351, 99);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(121, 23);
            cmbStudent.TabIndex = 0;
            // 
            // cmbSubject
            // 
            cmbSubject.Anchor = AnchorStyles.None;
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(351, 138);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(121, 23);
            cmbSubject.TabIndex = 1;
            // 
            // numGrade1
            // 
            numGrade1.Anchor = AnchorStyles.None;
            numGrade1.Location = new Point(351, 207);
            numGrade1.Name = "numGrade1";
            numGrade1.Size = new Size(120, 23);
            numGrade1.TabIndex = 2;
            // 
            // numGrade2
            // 
            numGrade2.Anchor = AnchorStyles.None;
            numGrade2.Location = new Point(351, 245);
            numGrade2.Name = "numGrade2";
            numGrade2.Size = new Size(120, 23);
            numGrade2.TabIndex = 3;
            // 
            // numGrade3
            // 
            numGrade3.Anchor = AnchorStyles.None;
            numGrade3.Location = new Point(351, 283);
            numGrade3.Name = "numGrade3";
            numGrade3.Size = new Size(120, 23);
            numGrade3.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnSave.Location = new Point(193, 378);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(196, 27);
            btnSave.TabIndex = 5;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnBack.Location = new Point(425, 378);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(196, 27);
            btnBack.TabIndex = 6;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 211);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 7;
            label1.Text = "Nota 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 247);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 8;
            label2.Text = "Nota 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 285);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 9;
            label3.Text = "Nota 3";
            // 
            // AddGradeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(numGrade3);
            Controls.Add(numGrade2);
            Controls.Add(numGrade1);
            Controls.Add(cmbSubject);
            Controls.Add(cmbStudent);
            Name = "AddGradeForm";
            Text = "AddGradeForm";
            ((System.ComponentModel.ISupportInitialize)numGrade1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGrade2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGrade3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStudent;
        private ComboBox cmbSubject;
        private NumericUpDown numGrade1;
        private NumericUpDown numGrade2;
        private NumericUpDown numGrade3;
        private Button btnSave;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}