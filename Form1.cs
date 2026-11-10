namespace CombustiPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text.Length != 7)
            {
                MessageBox.Show("La Placa debe tener 7 caracteres. \nEjemplo: A123456");
                return;
            }
            if (nudGalones.Value == 0)
            {
                MessageBox.Show("Los galones deben ser mayor que cero");
                return;
            }

        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text.Length != 7)
            {
                MessageBox.Show("La Placa debe tener 7 caracteres. \nEjemplo: A123456");
                return;
            }
            if (nudGalones.Value == 0)
            {
                MessageBox.Show("Los galones deben ser mayor que cero");
                return;
            }

        }
    }
}
