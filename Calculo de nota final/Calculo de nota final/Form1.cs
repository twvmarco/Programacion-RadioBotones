namespace Calculo_de_nota_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            double acumulativo, examen, notaFinal;
            string jornada = "";
            string resultado = "";


            if (!double.TryParse(txtAcumulativo.Text, out acumulativo) ||
                !double.TryParse(txtExamen.Text, out examen))
            {
                MessageBox.Show("Ingrese valores numéricos válidos");
                return;
            }

            if (rbPresencial.Checked)
                jornada = "Presenmcial";
            else if (rbDistancia.Checked)
                jornada = "Distancia";
            else
            {
                MessageBox.Show("Seleccione una jornada");
                return;
            }

            notaFinal = acumulativo + examen;


            if (notaFinal >= 60)
                resultado = "Aprobado";
            else
                resultado = "Reprobado";


            MessageBox.Show(
                "Nombre: " + nombre +
                "\nJornada: " + jornada +
                "\nNota final: " + notaFinal +
                "\nResultado: " + resultado
            );



            txtNombre.Clear();
            txtAcumulativo.Clear();
            txtExamen.Clear();

            rbPresencial.Checked = false;
            rbDistancia.Checked = false;


            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
