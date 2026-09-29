namespace Practica_Rapida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void sumar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textNum1.Text);
            int num2 = Convert.ToInt32(textNum2.Text);
            int suma = num1 + num2;
            textResultado.Text = suma.ToString();
            lstLista.Items.Add($"Suma: {num1} + {num2} = {suma}");
        }

        private void Restar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textNum1.Text);
            int num2 = Convert.ToInt32(textNum2.Text);
            int restar = num1 - num2;
            textResultado.Text = restar.ToString();
            lstLista.Items.Add($"Resta: {num1} - {num2} = {restar}");
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textNum1.Text);
            int num2 = Convert.ToInt32(textNum2.Text);
            int multiplicar = num1 * num2;
            textResultado.Text = multiplicar.ToString();
            lstLista.Items.Add($"Multiplicación: {num1} * {num2} = {multiplicar}");
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textNum1.Text);
            int num2 = Convert.ToInt32(textNum2.Text);
            int dividir = num1 / num2;
            textResultado.Text = dividir.ToString();
            lstLista.Items.Add($"División: {num1} / {num2} = {dividir}");
        }
    }
}
