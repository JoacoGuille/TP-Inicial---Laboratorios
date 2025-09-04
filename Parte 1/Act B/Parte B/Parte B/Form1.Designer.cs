namespace Parte_B
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Avalor = new TextBox();
            txt_Cvalor = new TextBox();
            txt_Bvalor = new TextBox();
            lbl_Atexto = new Label();
            lbl_Btexto = new Label();
            lbl_Ctexto = new Label();
            btn_suma = new Button();
            btn_resta = new Button();
            btn_salir = new Button();
            brn_cociente = new Button();
            btn_producto = new Button();
            SuspendLayout();
            // 
            // txt_Avalor
            // 
            txt_Avalor.Location = new Point(115, 47);
            txt_Avalor.Name = "txt_Avalor";
            txt_Avalor.Size = new Size(108, 27);
            txt_Avalor.TabIndex = 0;
            txt_Avalor.TextChanged += textBox1_TextChanged;
            // 
            // txt_Cvalor
            // 
            txt_Cvalor.Location = new Point(115, 162);
            txt_Cvalor.Name = "txt_Cvalor";
            txt_Cvalor.Size = new Size(108, 27);
            txt_Cvalor.TabIndex = 1;
            // 
            // txt_Bvalor
            // 
            txt_Bvalor.Location = new Point(115, 108);
            txt_Bvalor.Name = "txt_Bvalor";
            txt_Bvalor.Size = new Size(108, 27);
            txt_Bvalor.TabIndex = 2;
            // 
            // lbl_Atexto
            // 
            lbl_Atexto.AutoSize = true;
            lbl_Atexto.Location = new Point(289, 54);
            lbl_Atexto.Name = "lbl_Atexto";
            lbl_Atexto.Size = new Size(27, 20);
            lbl_Atexto.TabIndex = 3;
            lbl_Atexto.Text = "---";
            lbl_Atexto.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Atexto.Click += label1_Click;
            // 
            // lbl_Btexto
            // 
            lbl_Btexto.AutoSize = true;
            lbl_Btexto.Location = new Point(289, 115);
            lbl_Btexto.Name = "lbl_Btexto";
            lbl_Btexto.Size = new Size(27, 20);
            lbl_Btexto.TabIndex = 4;
            lbl_Btexto.Text = "---";
            // 
            // lbl_Ctexto
            // 
            lbl_Ctexto.AutoSize = true;
            lbl_Ctexto.Location = new Point(289, 169);
            lbl_Ctexto.Name = "lbl_Ctexto";
            lbl_Ctexto.Size = new Size(27, 20);
            lbl_Ctexto.TabIndex = 5;
            lbl_Ctexto.Text = "---";
            // 
            // btn_suma
            // 
            btn_suma.Location = new Point(392, 79);
            btn_suma.Name = "btn_suma";
            btn_suma.Size = new Size(94, 29);
            btn_suma.TabIndex = 6;
            btn_suma.Text = "Suma";
            btn_suma.UseVisualStyleBackColor = true;
            btn_suma.Click += button1_Click;
            // 
            // btn_resta
            // 
            btn_resta.Location = new Point(535, 79);
            btn_resta.Name = "btn_resta";
            btn_resta.Size = new Size(94, 29);
            btn_resta.TabIndex = 8;
            btn_resta.Text = "Resta";
            btn_resta.UseVisualStyleBackColor = true;
            btn_resta.Click += btn_resta_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(460, 173);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(94, 29);
            btn_salir.TabIndex = 9;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += button4_Click;
            // 
            // brn_cociente
            // 
            brn_cociente.Location = new Point(535, 138);
            brn_cociente.Name = "brn_cociente";
            brn_cociente.Size = new Size(94, 29);
            brn_cociente.TabIndex = 10;
            brn_cociente.Text = "Cociente";
            brn_cociente.UseVisualStyleBackColor = true;
            brn_cociente.Click += button5_Click;
            // 
            // btn_producto
            // 
            btn_producto.Location = new Point(392, 138);
            btn_producto.Name = "btn_producto";
            btn_producto.Size = new Size(94, 29);
            btn_producto.TabIndex = 11;
            btn_producto.Text = "Producto";
            btn_producto.UseVisualStyleBackColor = true;
            btn_producto.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_producto);
            Controls.Add(brn_cociente);
            Controls.Add(btn_salir);
            Controls.Add(btn_resta);
            Controls.Add(btn_suma);
            Controls.Add(lbl_Ctexto);
            Controls.Add(lbl_Btexto);
            Controls.Add(lbl_Atexto);
            Controls.Add(txt_Bvalor);
            Controls.Add(txt_Cvalor);
            Controls.Add(txt_Avalor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Avalor;
        private TextBox txt_Cvalor;
        private TextBox txt_Bvalor;
        private Label lbl_Atexto;
        private Label lbl_Btexto;
        private Label lbl_Ctexto;
        private Button btn_suma;
        private Button btn_resta;
        private Button btn_salir;
        private Button brn_cociente;
        private Button btn_producto;
    }
}
