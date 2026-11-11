namespace CombustiPlus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbNuevoDespacho = new GroupBox();
            btnDespachar = new Button();
            btnCotizar = new Button();
            cmbPago = new ComboBox();
            lblPago = new Label();
            nudGalones = new NumericUpDown();
            lblGalones = new Label();
            cmbCombustible = new ComboBox();
            lblCombustible = new Label();
            txtPlaca = new TextBox();
            lblPlaca = new Label();
            gbDetalle = new GroupBox();
            lstDetalle = new ListBox();
            gbDespachos = new GroupBox();
            btnPorCombustible = new Button();
            lstDespachos = new ListBox();
            lblResumen = new Label();
            gbNuevoDespacho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).BeginInit();
            gbDetalle.SuspendLayout();
            gbDespachos.SuspendLayout();
            SuspendLayout();
            // 
            // gbNuevoDespacho
            // 
            gbNuevoDespacho.Controls.Add(btnDespachar);
            gbNuevoDespacho.Controls.Add(btnCotizar);
            gbNuevoDespacho.Controls.Add(cmbPago);
            gbNuevoDespacho.Controls.Add(lblPago);
            gbNuevoDespacho.Controls.Add(nudGalones);
            gbNuevoDespacho.Controls.Add(lblGalones);
            gbNuevoDespacho.Controls.Add(cmbCombustible);
            gbNuevoDespacho.Controls.Add(lblCombustible);
            gbNuevoDespacho.Controls.Add(txtPlaca);
            gbNuevoDespacho.Controls.Add(lblPlaca);
            gbNuevoDespacho.Location = new Point(15, 28);
            gbNuevoDespacho.Margin = new Padding(4, 3, 4, 3);
            gbNuevoDespacho.Name = "gbNuevoDespacho";
            gbNuevoDespacho.Padding = new Padding(4, 3, 4, 3);
            gbNuevoDespacho.Size = new Size(544, 319);
            gbNuevoDespacho.TabIndex = 0;
            gbNuevoDespacho.TabStop = false;
            gbNuevoDespacho.Text = "Nuevo despacho";
            // 
            // btnDespachar
            // 
            btnDespachar.FlatStyle = FlatStyle.Flat;
            btnDespachar.Location = new Point(281, 252);
            btnDespachar.Margin = new Padding(4, 3, 4, 3);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(232, 48);
            btnDespachar.TabIndex = 9;
            btnDespachar.Text = "Despachar";
            btnDespachar.UseVisualStyleBackColor = true;
            btnDespachar.Click += btnDespachar_Click;
            // 
            // btnCotizar
            // 
            btnCotizar.FlatStyle = FlatStyle.Flat;
            btnCotizar.Location = new Point(9, 252);
            btnCotizar.Margin = new Padding(4, 3, 4, 3);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(232, 48);
            btnCotizar.TabIndex = 8;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCotizar_Click;
            // 
            // cmbPago
            // 
            cmbPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPago.FormattingEnabled = true;
            cmbPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cmbPago.Location = new Point(158, 207);
            cmbPago.Margin = new Padding(4, 3, 4, 3);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(354, 31);
            cmbPago.TabIndex = 7;
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(8, 214);
            lblPago.Margin = new Padding(4, 0, 4, 0);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(53, 23);
            lblPago.TabIndex = 6;
            lblPago.Text = "Pago:";
            // 
            // nudGalones
            // 
            nudGalones.BorderStyle = BorderStyle.FixedSingle;
            nudGalones.DecimalPlaces = 2;
            nudGalones.Location = new Point(158, 153);
            nudGalones.Margin = new Padding(4, 3, 4, 3);
            nudGalones.Name = "nudGalones";
            nudGalones.Size = new Size(188, 30);
            nudGalones.TabIndex = 5;
            // 
            // lblGalones
            // 
            lblGalones.AutoSize = true;
            lblGalones.Location = new Point(8, 160);
            lblGalones.Margin = new Padding(4, 0, 4, 0);
            lblGalones.Name = "lblGalones";
            lblGalones.Size = new Size(75, 23);
            lblGalones.TabIndex = 4;
            lblGalones.Text = "Galones:";
            // 
            // cmbCombustible
            // 
            cmbCombustible.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCombustible.FormattingEnabled = true;
            cmbCombustible.Items.AddRange(new object[] { "Premium", "Regular", "Gasoil" });
            cmbCombustible.Location = new Point(158, 98);
            cmbCombustible.Margin = new Padding(4, 3, 4, 3);
            cmbCombustible.Name = "cmbCombustible";
            cmbCombustible.Size = new Size(354, 31);
            cmbCombustible.TabIndex = 3;
            // 
            // lblCombustible
            // 
            lblCombustible.AutoSize = true;
            lblCombustible.Location = new Point(8, 106);
            lblCombustible.Margin = new Padding(4, 0, 4, 0);
            lblCombustible.Name = "lblCombustible";
            lblCombustible.Size = new Size(110, 23);
            lblCombustible.TabIndex = 2;
            lblCombustible.Text = "Combustible:";
            // 
            // txtPlaca
            // 
            txtPlaca.BorderStyle = BorderStyle.FixedSingle;
            txtPlaca.Location = new Point(158, 44);
            txtPlaca.Margin = new Padding(4, 3, 4, 3);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(354, 30);
            txtPlaca.TabIndex = 1;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(8, 52);
            lblPlaca.Margin = new Padding(4, 0, 4, 0);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(54, 23);
            lblPlaca.TabIndex = 0;
            lblPlaca.Text = "Placa:";
            // 
            // gbDetalle
            // 
            gbDetalle.Controls.Add(lstDetalle);
            gbDetalle.Location = new Point(15, 363);
            gbDetalle.Margin = new Padding(4, 3, 4, 3);
            gbDetalle.Name = "gbDetalle";
            gbDetalle.Padding = new Padding(4, 3, 4, 3);
            gbDetalle.Size = new Size(544, 187);
            gbDetalle.TabIndex = 1;
            gbDetalle.TabStop = false;
            gbDetalle.Text = "Detalle";
            // 
            // lstDetalle
            // 
            lstDetalle.BorderStyle = BorderStyle.FixedSingle;
            lstDetalle.FormattingEnabled = true;
            lstDetalle.ItemHeight = 23;
            lstDetalle.Location = new Point(8, 29);
            lstDetalle.Margin = new Padding(4, 3, 4, 3);
            lstDetalle.Name = "lstDetalle";
            lstDetalle.Size = new Size(528, 140);
            lstDetalle.TabIndex = 0;
            // 
            // gbDespachos
            // 
            gbDespachos.Controls.Add(btnPorCombustible);
            gbDespachos.Controls.Add(lstDespachos);
            gbDespachos.Location = new Point(581, 28);
            gbDespachos.Margin = new Padding(4, 3, 4, 3);
            gbDespachos.Name = "gbDespachos";
            gbDespachos.Padding = new Padding(4, 3, 4, 3);
            gbDespachos.Size = new Size(719, 423);
            gbDespachos.TabIndex = 2;
            gbDespachos.TabStop = false;
            gbDespachos.Text = "Despachos del dia";
            // 
            // btnPorCombustible
            // 
            btnPorCombustible.FlatStyle = FlatStyle.Flat;
            btnPorCombustible.Location = new Point(20, 362);
            btnPorCombustible.Margin = new Padding(4, 3, 4, 3);
            btnPorCombustible.Name = "btnPorCombustible";
            btnPorCombustible.Size = new Size(232, 48);
            btnPorCombustible.TabIndex = 10;
            btnPorCombustible.Text = "Galones por combustible";
            btnPorCombustible.UseVisualStyleBackColor = true;
            btnPorCombustible.Click += btnPorCombustible_Click;
            // 
            // lstDespachos
            // 
            lstDespachos.BorderStyle = BorderStyle.FixedSingle;
            lstDespachos.FormattingEnabled = true;
            lstDespachos.ItemHeight = 23;
            lstDespachos.Location = new Point(19, 30);
            lstDespachos.Margin = new Padding(4, 3, 4, 3);
            lstDespachos.Name = "lstDespachos";
            lstDespachos.Size = new Size(683, 324);
            lstDespachos.TabIndex = 1;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(581, 463);
            lblResumen.Margin = new Padding(4, 0, 4, 0);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(81, 23);
            lblResumen.TabIndex = 3;
            lblResumen.Text = "Resumen";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 591);
            Controls.Add(lblResumen);
            Controls.Add(gbDespachos);
            Controls.Add(gbDetalle);
            Controls.Add(gbNuevoDespacho);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "CombustiPlus - Estacion Bavaro";
            gbNuevoDespacho.ResumeLayout(false);
            gbNuevoDespacho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).EndInit();
            gbDetalle.ResumeLayout(false);
            gbDespachos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbNuevoDespacho;
        private TextBox txtPlaca;
        private Label lblPlaca;
        private ComboBox cmbCombustible;
        private Label lblCombustible;
        private Label lblPago;
        private NumericUpDown nudGalones;
        private Label lblGalones;
        private Button btnDespachar;
        private Button btnCotizar;
        private ComboBox cmbPago;
        private GroupBox gbDetalle;
        private ListBox lstDetalle;
        private GroupBox gbDespachos;
        private Button btnPorCombustible;
        private ListBox lstDespachos;
        private Label lblResumen;
    }
}
