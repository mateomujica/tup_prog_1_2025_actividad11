namespace Ejemplo_2._Sin_vector
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        double acum = 0;
        int contador = 0;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(tbValor.Text);
            acum += valor;
            contador++;
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double promedio = 0; 
            promedio = (acum/contador);

            lbResultado.Text = promedio.ToString();
            tbResultado.Text = promedio.ToString();
        }
    }
}
