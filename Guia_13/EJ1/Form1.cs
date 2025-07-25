using System.Security.AccessControl;

namespace EJ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        FormExpediente formExpediente = new FormExpediente();
        FormVerExpediente FVerExpedientes = new FormVerExpediente();
        
        #region Varibles
        int[] expediente = new int[100];
        int[] DNI = new int[100];
        double[] monto = new double[100];
        int contador = 0;
        int contRegistros = 0;
        #endregion
        #region Metodos
        void RegistrarExpediente(int exp, int dni, double mon)
        {
            expediente[contador] = exp;
            DNI[contador] = dni;
            monto[contador] = mon;
            contador++;
        }
        void OrdenarExpedientes()
        {
            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    if (monto[i] < monto[j])
                    {
                        double auxM = monto[i];
                        int auxE = expediente[i];
                        int auxDni = DNI[i];

                        monto[i] = monto[j];
                        expediente[i] = expediente[j];
                        DNI[i] = DNI[j];

                        monto[j] = auxM;
                        expediente[j] = auxE;
                        DNI[j] = auxDni;
                    }

                }
            }
        }
        void VerExpedientes(int idx, out int numero, out int dni, out double montos)
        {
            numero = expediente[idx];
            dni = DNI[idx];
            montos = monto[idx];
        }
        double CalcularMontoPromedio()
        {
            double prom = 0, acum = 0;
            for (int i = 0; i < contador; i++)
            {
                acum += monto[i];
            }
            prom = acum / contador;
            return prom;
        }
        int VerExpedientePorDNI(int dni, int[] lista)
        {
            for (int i = 0; i < contador; i++)
            {
                if (lista[i] == dni)
                {
                    return i;
                }
            }
            return -1;
        }
        int VerExpedientePorNumero(int numero)
        {
            int inx = -1;
            for (int i = 0; i < contador; i++)
            {
                if (expediente[i] == numero)
                {
                    inx = i;
                }
            }
            return inx;
        }
        #endregion
        private void btnRegistrarN_Click(object sender, EventArgs e)
        {
            while (formExpediente.ShowDialog() == DialogResult.OK)
            {
                int exp = Convert.ToInt32(formExpediente.tbNumerocausa.Text);
                int dni = Convert.ToInt32(formExpediente.tbDNI.Text);
                double mon = Convert.ToDouble(formExpediente.tbImporte.Text);
                RegistrarExpediente(exp, dni, mon);
                MessageBox.Show("Expediente registrado correctamente.");
                contRegistros++;
                GroupBox1.Text = $"Expedientes Registrados: {contRegistros}";
                formExpediente.tbDNI.Clear();
                formExpediente.tbImporte.Clear();
                formExpediente.tbNumerocausa.Clear();
            }
        }

        private void btnVerT_Click(object sender, EventArgs e)
        {
            OrdenarExpedientes();
            int dnis;
            int exp;
            double montos;
            for (int i = 0; i < contador; i++)
            {
                VerExpedientes(i, out exp, out dnis, out montos);
                FVerExpedientes.lsbExpedientes.Items.Add($"{exp} - {dnis} - {montos}");
                //FVerExpedientes.lsbExpedientes.Items.Add
            }
            FVerExpedientes.ShowDialog();
            FVerExpedientes.lsbExpedientes.Items.Clear();
        }

        private void btnMonto_Click(object sender, EventArgs e)
        {
            double promedio = CalcularMontoPromedio();
            int dnis;
            int exp;
            double montos;
            for (int i = 0; i < contador; i++)
            {
                VerExpedientes(i, out exp, out dnis, out montos);
                if (montos > promedio)
                {
                    FVerExpedientes.lsbExpedientes.Items.Add($"{exp} - {dnis} - {montos}");
                }
            }
            FVerExpedientes.ShowDialog();
            FVerExpedientes.lsbExpedientes.Items.Clear();
        }

        private void btnVerDNI_Click(object sender, EventArgs e)
        {
            int exp;
            int dni = Convert.ToInt32(tbDNI.Text);
            double monto;
            int[] aux = new int[contador];
            for (int i = 0; i < contador; i++)
            {
                aux[i] = DNI[i];
            }
            int inx = VerExpedientePorDNI(dni, aux);
            if (inx != -1)
            {
                VerExpedientes(inx, out exp, out dni, out monto);
                FVerExpedientes.lsbExpedientes.Items.Add($"{exp} - {dni} - {monto}");
            }
            else FVerExpedientes.lsbExpedientes.Items.Add("No se encontraron resultados");
            FVerExpedientes.ShowDialog();
            FVerExpedientes.lsbExpedientes.Items.Clear();
            tbDNI.Clear();
        }

        private void btnCausa_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(tbCausa.Text);
            int dni;
            double monto;
            int inx = VerExpedientePorNumero(numero);
            if (inx != -1)
            {
                VerExpedientes(inx, out numero, out dni, out monto);
                FVerExpedientes.lsbExpedientes.Items.Add($"{numero} - {dni} - {monto}");
                FVerExpedientes.ShowDialog();
            }
            else MessageBox.Show("No se encontraron resultados");
            FVerExpedientes.lsbExpedientes.Items.Clear();
            tbDNI.Clear();
        }
    }
}
