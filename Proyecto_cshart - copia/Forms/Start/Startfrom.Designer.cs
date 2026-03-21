namespace Proyecto_cshart
{
    partial class Startfrom
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
            btnStart = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 102);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(704, 86);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA ACADEMICO";
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.None;
            btnStart.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(351, 246);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(193, 53);
            btnStart.TabIndex = 1;
            btnStart.Text = "Iniciar";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(364, 305);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(170, 46);
            btnExit.TabIndex = 6;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Startfrom
            // 
            AutoScaleDimensions = new SizeF(17F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 511);
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Startfrom";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStart;
        private Button btnExit;
    }
}