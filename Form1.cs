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

            decimal precio = 0;

            switch (cmbCombustible.Text)
            {
                case "Regular":
                    precio = 272;
                    break;
                case "Premium":
                    precio = 290;
                    break;
                case "Gasoil":
                    precio = 225;
                    break;
            }
            decimal galones = nudGalones.Value;
            decimal total = galones * precio;

            lstDetalle.Items.Clear();
            lstDetalle.Items.Add($"{galones} gal × RD$ {precio:N2} = RD$ {total:N2}");

            if (galones >= 20)
            {
                total = total - total * 0.02m;
                lstDetalle.Items.Add($"Descuento 20+ galones ?2 %: RD$ {total:N2}");
            }
            if (cmbPago.Text == "Tarjeta")
            {
                total = total + total * 0.03m;
                lstDetalle.Items.Add($"Tarjeta +3 %: RD$ {total:N2}");
            }

            lstDetalle.Items.Add($"TOTAL: RD$ {total:N2}");
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
