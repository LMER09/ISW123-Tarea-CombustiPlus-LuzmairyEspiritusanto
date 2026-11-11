namespace CombustiPlus
{
    public partial class Form1 : Form
    {
        private List<Despacho> despachos = new List<Despacho>();
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
                total -= total * 0.02m;
                lstDetalle.Items.Add($"Descuento 20+ galones −2 %: RD$ {total:N2}");
            }
            if (cmbPago.Text == "Tarjeta")
            {
                total += total * 0.03m;
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

            if (galones >= 20)
            {
                total -= total * 0.02m;

            }
            if (cmbPago.Text == "Tarjeta")
            {
                total += total * 0.03m;

            }

            int numero = despachos.Count + 1;
            Despacho d = new Despacho(numero, txtPlaca.Text, cmbCombustible.Text,
                galones, cmbPago.Text, total);
            despachos.Add(d);

            lstDespachos.Items.Clear();

            decimal totalVendido = 0;
            decimal galonesTotales = 0;

            Despacho mayor = d;

            foreach (Despacho x in despachos)
            {
                lstDespachos.Items.Add(x.ToString());
                totalVendido = totalVendido + x.Total;
                galonesTotales = galonesTotales + x.Galones;

                if (x.Total > mayor.Total)
                {
                    mayor = x;
                }
            }

            lblResumen.Text = $"{despachos.Count} despachos - Vendido RD$ {totalVendido:N2} - " +
                $"Galones: {galonesTotales} - Mayor: #{mayor.Numero:00} {mayor.Placa} (RD$ {mayor.Total:N2})";

        }

        private void btnPorCombustible_Click(object sender, EventArgs e)
        {
            Dictionary<string, decimal> galonesPorCombustible = new Dictionary<string, decimal>();

            foreach (Despacho x in despachos)
            {
                if (galonesPorCombustible.ContainsKey(x.Combustible))
                {
                    galonesPorCombustible[x.Combustible] += x.Galones;
                }
                else
                {
                    galonesPorCombustible[x.Combustible] = x.Galones;
                }
            }

            lstDetalle.Items.Clear();

            foreach (string combustible in galonesPorCombustible.Keys)
            {
                lstDetalle.Items.Add($"{combustible}: {galonesPorCombustible[combustible]} gal");
            }

        }
    }
}
