namespace Ejercicio_5
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
        double promedio;
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            vector[contador] = Convert.ToDouble(tbValor.Text);
            contador++;
            tbValor.Clear();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double acum = 0;

            for (int i = 0; i < contador; i++)
            {
                acum += vector[i];
            }

            promedio = (acum / contador);

            lbResultado.Text = promedio.ToString();
            tbResultado.Text = Convert.ToString($"Promedio: {promedio}");

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            double busqueda = Convert.ToDouble(tbBuscar.Text);
            int indice = -1;

            for (int n = 0; n < vector.Length && indice == -1; n++)
            {
                if (busqueda == vector[n])
                {
                    indice = n;
                }
            }

            if (indice != -1)
            {
                tbBuscar.Text = ($"Encontrado Pos: {indice}");
            }
            else
            {
                tbBuscar.Text = ("No encontrado");
            }

        }

        private void btnListarOrdenado_Click(object sender, EventArgs e)
        {
            tbResultado.Clear();

            for (int n = 0; n < contador - 1; n++)
            {
                for (int m = n + 1; m < contador; m++)
                {
                    if (vector[n] > vector[m])
                    {
                        double aux = vector[m];
                        vector[m] = vector[n];
                        vector[n] = aux;
                    }
                }
            }

            for (int i = 0; i < contador; i++)
            {
                tbResultado.Text += ($"{vector[i]}\r\r");
            }
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            double mayor = 0;
            for (int i = 0; i < contador; i++)
            {
                if (vector[i] > mayor)
                {
                    mayor = vector[i];
                }

            }
            lbMaximo.Text = Convert.ToString(mayor);
        }

        private void btnMinimo_Click(object sender, EventArgs e)
        {
            double menor = 999;

            for (int i = 0; i < contador; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }

            }
            lbMinimo.Text = Convert.ToString(menor);
        }

        private void btnMayoresAlPromedio_Click(object sender, EventArgs e)
        {
            double acum = 0;

            for (int n=0;n<contador;n++)
            {
                acum += vector[n];
            }

            tbResultado.Clear();
            for (int i = 0; i < contador; i++)
            {
                if (vector[i] > promedio)
                {
                    tbResultado.Text += $"{vector[i]}\r\r";                                     
                }

            }

            
                                
        }
    }
}
