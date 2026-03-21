namespace Proyecto_cshart
{
    partial class ViewTeachersForm
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
            lstTeachers = new ListBox();
            btnLoad = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(295, 77);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(254, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Lista de docentes";
            // 
            // lstTeachers
            // 
            lstTeachers.Anchor = AnchorStyles.None;
            lstTeachers.FormattingEnabled = true;
            lstTeachers.ItemHeight = 15;
            lstTeachers.Location = new Point(135, 140);
            lstTeachers.Name = "lstTeachers";
            lstTeachers.Size = new Size(579, 124);
            lstTeachers.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.None;
            btnLoad.Font = new Font("Segoe UI", 9.75F);
            btnLoad.Location = new Point(306, 306);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(88, 29);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Cargar docentes";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Font = new Font("Segoe UI", 9.75F);
            btnBack.Location = new Point(422, 306);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ViewTeachersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnLoad);
            Controls.Add(lstTeachers);
            Controls.Add(lblTitle);
            Name = "ViewTeachersForm";
            Text = "ViewTeachersForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox lstTeachers;
        private Button btnLoad;
        private Button btnBack;
    }
}