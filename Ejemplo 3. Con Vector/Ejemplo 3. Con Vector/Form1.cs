namespace Ejemplo_3._Con_Vector
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double[] vector = new double[100];
        int contador = 0;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vector[contador] = Convert.ToDouble(tbValor.Text);
            contador++;

        }

        private void btnCalcularResultado_Click(object sender, EventArgs e)
        {
            double promedio, acum=0;

            for (int i = 0; i < contador; i++)
            {
                acum += vector[i];
            }

            promedio = (acum / contador);

            lbResultado.Text = promedio.ToString();
            tbResultado.Text = Convert.ToString($"Promedio: {promedio}");
        }
    }
}
