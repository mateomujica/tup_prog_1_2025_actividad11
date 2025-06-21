namespace Ejercicio_5
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
            label3 = new Label();
            label4 = new Label();
            tbValor = new TextBox();
            lbResultado = new Label();
            btnRegistar = new Button();
            btnCalcularPromedio = new Button();
            btnMaximo = new Button();
            btnMinimo = new Button();
            lbMaximo = new Label();
            lbMinimo = new Label();
            tbResultado = new TextBox();
            btnListarOrdenado = new Button();
            btnMayoresAlPromedio = new Button();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 33);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 78);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Promedio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 134);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Maximo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 185);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Minimo";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(87, 33);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 4;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(111, 78);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 15);
            lbResultado.TabIndex = 5;
            lbResultado.Text = "lbResultado";
            // 
            // btnRegistar
            // 
            btnRegistar.Location = new Point(231, 32);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(75, 23);
            btnRegistar.TabIndex = 6;
            btnRegistar.Text = "Registrar";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(231, 74);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(114, 23);
            btnCalcularPromedio.TabIndex = 7;
            btnCalcularPromedio.Text = "Calcular promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // btnMaximo
            // 
            btnMaximo.Location = new Point(223, 134);
            btnMaximo.Name = "btnMaximo";
            btnMaximo.Size = new Size(122, 23);
            btnMaximo.TabIndex = 8;
            btnMaximo.Text = "Calcular Maximo";
            btnMaximo.UseVisualStyleBackColor = true;
            btnMaximo.Click += btnMaximo_Click;
            // 
            // btnMinimo
            // 
            btnMinimo.Location = new Point(223, 185);
            btnMinimo.Name = "btnMinimo";
            btnMinimo.Size = new Size(122, 23);
            btnMinimo.TabIndex = 9;
            btnMinimo.Text = "Calcular Minimo";
            btnMinimo.UseVisualStyleBackColor = true;
            btnMinimo.Click += btnMinimo_Click;
            // 
            // lbMaximo
            // 
            lbMaximo.AutoSize = true;
            lbMaximo.Location = new Point(128, 134);
            lbMaximo.Name = "lbMaximo";
            lbMaximo.Size = new Size(61, 15);
            lbMaximo.TabIndex = 10;
            lbMaximo.Text = "lbMaximo";
            // 
            // lbMinimo
            // 
            lbMinimo.AutoSize = true;
            lbMinimo.Location = new Point(128, 185);
            lbMinimo.Name = "lbMinimo";
            lbMinimo.Size = new Size(59, 15);
            lbMinimo.TabIndex = 11;
            lbMinimo.Text = "lbMinimo";
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(35, 292);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(162, 96);
            tbResultado.TabIndex = 12;
            // 
            // btnListarOrdenado
            // 
            btnListarOrdenado.Location = new Point(223, 292);
            btnListarOrdenado.Name = "btnListarOrdenado";
            btnListarOrdenado.Size = new Size(122, 23);
            btnListarOrdenado.TabIndex = 13;
            btnListarOrdenado.Text = "Listar Ordenado";
            btnListarOrdenado.UseVisualStyleBackColor = true;
            btnListarOrdenado.Click += btnListarOrdenado_Click;
            // 
            // btnMayoresAlPromedio
            // 
            btnMayoresAlPromedio.Location = new Point(223, 329);
            btnMayoresAlPromedio.Name = "btnMayoresAlPromedio";
            btnMayoresAlPromedio.Size = new Size(122, 59);
            btnMayoresAlPromedio.TabIndex = 14;
            btnMayoresAlPromedio.Text = "Listado Superior al Promedio";
            btnMayoresAlPromedio.UseVisualStyleBackColor = true;
            btnMayoresAlPromedio.Click += btnMayoresAlPromedio_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(185, 244);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(33, 245);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(134, 23);
            tbBuscar.TabIndex = 17;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 438);
            Controls.Add(tbBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnMayoresAlPromedio);
            Controls.Add(btnListarOrdenado);
            Controls.Add(tbResultado);
            Controls.Add(lbMinimo);
            Controls.Add(lbMaximo);
            Controls.Add(btnMinimo);
            Controls.Add(btnMaximo);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(btnRegistar);
            Controls.Add(lbResultado);
            Controls.Add(tbValor);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private TextBox tbValor;
        private Label lbResultado;
        private Button btnRegistar;
        private Button btnCalcularPromedio;
        private Button btnMaximo;
        private Button btnMinimo;
        private Label lbMaximo;
        private Label lbMinimo;
        private TextBox tbResultado;
        private Button btnListarOrdenado;
        private Button btnMayoresAlPromedio;
        private Button btnBuscar;
        private TextBox textBox1;
        private TextBox tbBuscar;
    }
}
