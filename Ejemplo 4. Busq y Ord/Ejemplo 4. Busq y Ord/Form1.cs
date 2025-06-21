using System.ComponentModel;

namespace Ejemplo_4._Busq_y_Ord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] vector = new double[100];
        int contador = 0;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vector[contador] = Convert.ToDouble(tbValor.Text);
            contador++;
            tbValor.Clear();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {         

            double promedio, acum = 0;

            for (int i = 0; i < contador; i++)
            {
                acum += vector[i];
            }

            promedio = (acum / contador);

            lbResultado.Text = promedio.ToString();
            tbResultado.Text = Convert.ToString($"Promedio: {promedio}");

            tbResultado.Clear();
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


            for (int i=0; i<contador;i++)
            {
                tbResultado.Text += ($"{vector[i]}\r");

            }    

        }
    }

}
