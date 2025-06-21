namespace Ejemplo_3._Con_Vector
{
    partial class FormPrincipal
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
            label1 = new Label();
            label2 = new Label();
            lbResultado = new Label();
            tbValor = new TextBox();
            tbResultado = new TextBox();
            btnCalcularResultado = new Button();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 69);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Promedio";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(102, 69);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 15);
            lbResultado.TabIndex = 2;
            lbResultado.Text = "lbResultado";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(68, 28);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 3;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(24, 102);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(168, 91);
            tbResultado.TabIndex = 4;
            // 
            // btnCalcularResultado
            // 
            btnCalcularResultado.Location = new Point(174, 65);
            btnCalcularResultado.Name = "btnCalcularResultado";
            btnCalcularResultado.Size = new Size(126, 23);
            btnCalcularResultado.TabIndex = 5;
            btnCalcularResultado.Text = "Calcular Promedio";
            btnCalcularResultado.UseVisualStyleBackColor = true;
            btnCalcularResultado.Click += btnCalcularResultado_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(174, 27);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 226);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCalcularResultado);
            Controls.Add(tbResultado);
            Controls.Add(tbValor);
            Controls.Add(lbResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPrincipal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbResultado;
        private TextBox tbValor;
        private TextBox tbResultado;
        private Button btnCalcularResultado;
        private Button btnRegistrar;
    }
}
