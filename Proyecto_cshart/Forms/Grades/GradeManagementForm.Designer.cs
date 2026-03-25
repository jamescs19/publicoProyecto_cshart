namespace Proyecto_cshart.Forms.Grades
{
    partial class GradeManagementForm
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
            label1 = new Label();
            btnAddGrade = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 117);
            label1.Name = "label1";
            label1.Size = new Size(203, 40);
            label1.TabIndex = 0;
            label1.Text = "Calificaciones";
            // 
            // btnAddGrade
            // 
            btnAddGrade.Anchor = AnchorStyles.None;
            btnAddGrade.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAddGrade.Location = new Point(322, 185);
            btnAddGrade.Name = "btnAddGrade";
            btnAddGrade.Size = new Size(142, 40);
            btnAddGrade.TabIndex = 1;
            btnAddGrade.Text = "Registrar notas";
            btnAddGrade.UseVisualStyleBackColor = true;
            btnAddGrade.Click += btnAddGrade_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.Location = new Point(322, 242);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(142, 40);
            btnBack.TabIndex = 2;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // GradeManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnAddGrade);
            Controls.Add(label1);
            Name = "GradeManagementForm";
            Text = "GradeManagementForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddGrade;
        private Button btnBack;
    }
}