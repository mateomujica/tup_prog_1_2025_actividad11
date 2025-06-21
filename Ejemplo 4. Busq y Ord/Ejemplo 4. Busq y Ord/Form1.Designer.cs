namespace Ejemplo_4._Busq_y_Ord
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
            label1 = new Label();
            label2 = new Label();
            btnRegistrar = new Button();
            btnCalcularPromedio = new Button();
            tbValor = new TextBox();
            lbResultado = new Label();
            tbBuscar = new TextBox();
            btnBuscar = new Button();
            tbResultado = new TextBox();
            btnListarOrdenado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 28);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 72);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Promedio";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(200, 25);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(200, 68);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(118, 23);
            btnCalcularPromedio.TabIndex = 3;
            btnCalcularPromedio.Text = "Calcular Promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(84, 25);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 4;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(115, 72);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 15);
            lbResultado.TabIndex = 5;
            lbResultado.Text = "lbResultado";
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(40, 113);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(144, 23);
            tbBuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(200, 113);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(30, 154);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(164, 83);
            tbResultado.TabIndex = 8;
            // 
            // btnListarOrdenado
            // 
            btnListarOrdenado.Location = new Point(212, 173);
            btnListarOrdenado.Name = "btnListarOrdenado";
            btnListarOrdenado.Size = new Size(75, 48);
            btnListarOrdenado.TabIndex = 9;
            btnListarOrdenado.Text = "Listar Ordenado";
            btnListarOrdenado.UseVisualStyleBackColor = true;
            btnListarOrdenado.Click += btnListarOrdenado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 311);
            Controls.Add(btnListarOrdenado);
            Controls.Add(tbResultado);
            Controls.Add(btnBuscar);
            Controls.Add(tbBuscar);
            Controls.Add(lbResultado);
            Controls.Add(tbValor);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(btnRegistrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnRegistrar;
        private Button btnCalcularPromedio;
        private TextBox tbValor;
        private Label lbResultado;
        private TextBox tbBuscar;
        private Button btnBuscar;
        private TextBox tbResultado;
        private Button btnListarOrdenado;
    }
}
