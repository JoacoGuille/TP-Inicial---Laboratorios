namespace Parte_C
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
            btnLimpiar = new Button();
            Btnsalir = new Button();
            btnswitch = new Button();
            Btnif = new Button();
            Lbl1 = new Label();
            Lbl2 = new Label();
            Txt1 = new TextBox();
            Txt2 = new TextBox();
            TxtRta = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            Lbl3 = new Label();
            fileSystemWatcher2 = new FileSystemWatcher();
            Optsuma = new RadioButton();
            Optresta = new RadioButton();
            Optprod = new RadioButton();
            OptCoc = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(269, 198);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(125, 29);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Btnsalir
            // 
            Btnsalir.Location = new Point(377, 378);
            Btnsalir.Name = "Btnsalir";
            Btnsalir.Size = new Size(125, 29);
            Btnsalir.TabIndex = 1;
            Btnsalir.Text = "Salir";
            Btnsalir.UseVisualStyleBackColor = true;
            Btnsalir.Click += Btnsalir_Click_1;
            // 
            // btnswitch
            // 
            btnswitch.Location = new Point(377, 320);
            btnswitch.Name = "btnswitch";
            btnswitch.Size = new Size(125, 29);
            btnswitch.TabIndex = 2;
            btnswitch.Text = "Con Switch";
            btnswitch.UseVisualStyleBackColor = true;
            btnswitch.Click += btnswitch_Click;
            // 
            // Btnif
            // 
            Btnif.Location = new Point(179, 320);
            Btnif.Name = "Btnif";
            Btnif.Size = new Size(125, 29);
            Btnif.TabIndex = 3;
            Btnif.Text = "Con IF";
            Btnif.UseVisualStyleBackColor = true;
            Btnif.Click += Btnif_Click;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(179, 33);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(96, 20);
            Lbl1.TabIndex = 4;
            Lbl1.Text = "1er operador";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Location = new Point(179, 101);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(101, 20);
            Lbl2.TabIndex = 5;
            Lbl2.Text = "2do operador";
            // 
            // Txt1
            // 
            Txt1.Location = new Point(377, 33);
            Txt1.Name = "Txt1";
            Txt1.Size = new Size(125, 27);
            Txt1.TabIndex = 6;
            Txt1.TextChanged += Txt1_TextChanged;
            // 
            // Txt2
            // 
            Txt2.Location = new Point(377, 101);
            Txt2.Name = "Txt2";
            Txt2.Size = new Size(125, 27);
            Txt2.TabIndex = 7;
            // 
            // TxtRta
            // 
            TxtRta.Location = new Point(377, 153);
            TxtRta.Name = "TxtRta";
            TxtRta.Size = new Size(125, 27);
            TxtRta.TabIndex = 8;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Location = new Point(179, 160);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(75, 20);
            Lbl3.TabIndex = 9;
            Lbl3.Text = "Resultado";
            // 
            // fileSystemWatcher2
            // 
            fileSystemWatcher2.EnableRaisingEvents = true;
            fileSystemWatcher2.SynchronizingObject = this;
            // 
            // Optsuma
            // 
            Optsuma.AutoSize = true;
            Optsuma.Location = new Point(179, 242);
            Optsuma.Name = "Optsuma";
            Optsuma.Size = new Size(67, 24);
            Optsuma.TabIndex = 10;
            Optsuma.TabStop = true;
            Optsuma.Text = "Suma";
            Optsuma.UseVisualStyleBackColor = true;
            // 
            // Optresta
            // 
            Optresta.AutoSize = true;
            Optresta.Location = new Point(377, 242);
            Optresta.Name = "Optresta";
            Optresta.Size = new Size(62, 24);
            Optresta.TabIndex = 11;
            Optresta.TabStop = true;
            Optresta.Text = "resta";
            Optresta.UseVisualStyleBackColor = true;
            Optresta.CheckedChanged += Optresta_CheckedChanged;
            // 
            // Optprod
            // 
            Optprod.AutoSize = true;
            Optprod.Location = new Point(377, 279);
            Optprod.Name = "Optprod";
            Optprod.Size = new Size(90, 24);
            Optprod.TabIndex = 12;
            Optprod.TabStop = true;
            Optprod.Text = "Producto";
            Optprod.UseVisualStyleBackColor = true;
            Optprod.CheckedChanged += Optprod_CheckedChanged;
            // 
            // OptCoc
            // 
            OptCoc.AutoSize = true;
            OptCoc.Location = new Point(179, 290);
            OptCoc.Name = "OptCoc";
            OptCoc.Size = new Size(86, 24);
            OptCoc.TabIndex = 13;
            OptCoc.TabStop = true;
            OptCoc.Text = "cociente";
            OptCoc.UseVisualStyleBackColor = true;
            OptCoc.CheckedChanged += OptCoc_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OptCoc);
            Controls.Add(Optprod);
            Controls.Add(Optresta);
            Controls.Add(Optsuma);
            Controls.Add(Lbl3);
            Controls.Add(TxtRta);
            Controls.Add(Txt2);
            Controls.Add(Txt1);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            Controls.Add(Btnif);
            Controls.Add(btnswitch);
            Controls.Add(Btnsalir);
            Controls.Add(btnLimpiar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button Btnsalir;
        private Button btnswitch;
        private Button Btnif;
        private Label Lbl1;
        private Label Lbl2;
        private TextBox Txt1;
        private TextBox Txt2;
        private TextBox TxtRta;
        private FileSystemWatcher fileSystemWatcher1;
        private Label Lbl3;
        private FileSystemWatcher fileSystemWatcher2;
        private RadioButton OptCoc;
        private RadioButton Optprod;
        private RadioButton Optresta;
        private RadioButton Optsuma;
    }
}
