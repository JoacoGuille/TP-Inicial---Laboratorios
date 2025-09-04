namespace Parte_C
{
    partial class Form3
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
            btnejecutar = new Button();
            btnsalir = new Button();
            Chk1 = new CheckBox();
            Chk2 = new CheckBox();
            Lbl1 = new Label();
            Lbl2 = new Label();
            Lbl3 = new Label();
            SuspendLayout();
            // 
            // btnejecutar
            // 
            btnejecutar.Location = new Point(109, 388);
            btnejecutar.Name = "btnejecutar";
            btnejecutar.Size = new Size(111, 29);
            btnejecutar.TabIndex = 0;
            btnejecutar.Text = "Ejecutar";
            btnejecutar.UseVisualStyleBackColor = true;
            btnejecutar.Click += btnejecutar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(337, 388);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(115, 29);
            btnsalir.TabIndex = 1;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // Chk1
            // 
            Chk1.AutoSize = true;
            Chk1.Location = new Point(109, 335);
            Chk1.Name = "Chk1";
            Chk1.Size = new Size(111, 24);
            Chk1.TabIndex = 2;
            Chk1.Text = "1ra elección";
            Chk1.UseVisualStyleBackColor = true;
            // 
            // Chk2
            // 
            Chk2.AutoSize = true;
            Chk2.Location = new Point(337, 335);
            Chk2.Name = "Chk2";
            Chk2.Size = new Size(115, 24);
            Chk2.TabIndex = 3;
            Chk2.Text = "2da elección";
            Chk2.UseVisualStyleBackColor = true;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.BackColor = Color.Red;
            Lbl1.Location = new Point(240, 109);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(81, 20);
            Lbl1.TabIndex = 4;
            Lbl1.Text = "------------";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.BackColor = Color.Red;
            Lbl2.Location = new Point(240, 182);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(81, 20);
            Lbl2.TabIndex = 5;
            Lbl2.Text = "------------";
            Lbl2.Click += Lbl2_Click;
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.BackColor = Color.Red;
            Lbl3.Location = new Point(240, 274);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(81, 20);
            Lbl3.TabIndex = 6;
            Lbl3.Text = "------------";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Lbl3);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            Controls.Add(Chk2);
            Controls.Add(Chk1);
            Controls.Add(btnsalir);
            Controls.Add(btnejecutar);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnejecutar;
        private Button btnsalir;
        private CheckBox Chk1;
        private CheckBox Chk2;
        private Label Lbl1;
        private Label Lbl2;
        private Label Lbl3;
    }
}