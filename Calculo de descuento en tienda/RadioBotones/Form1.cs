using System.Reflection.Metadata;

namespace RadioBotones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
 
            if (txtNombre.Text == "" || txtMonto.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos");
                return;
            }

            double monto;

            
            if (!double.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show("Ingrese un monto válido");
                return;
            }

            double descuento = 0;
            string tipoCliente = "";

            if (rbSinDescuento.Checked)
            {
                descuento = 0;
                tipoCliente = "Sin descuento";
            }
            else if (rb10.Checked)
            {
                descuento = monto * 0.10;
                tipoCliente = "10% descuento";
            }
            else if (rb20.Checked)
            {
                descuento = monto * 0.20;
                tipoCliente = "20% descuento";
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de cliente");
                return;
            }

            double total = monto - descuento;

           
            MessageBox.Show(
                "Nombre: " + txtNombre.Text +
                "\nTipo de cliente: " + tipoCliente +
                "\nMonto original: " + monto +
                "\nDescuento: " + descuento +
                "\nTotal a pagar: " + total
            );
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtMonto.Clear();
            rbSinDescuento.Checked = false;
            rb10.Checked = false;
            rb20.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
