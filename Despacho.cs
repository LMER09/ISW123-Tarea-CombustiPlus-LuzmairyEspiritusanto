using System;

namespace CombustiPlus
{
    public class Despacho
    {
        public int Numero {  get; set; }
        public string Placa { get; set; }
        public string Combustible {  get; set; }
        public decimal Galones { get; set; }
        public string Pago { get; set; }
        public decimal Total { get; set; }

        public Despacho (int numero, string placa, string combustible, 
            decimal galones, string pago, decimal total)
        {
            this.Numero = numero;
            this.Placa = placa;
            this.Combustible = combustible;
            this.Galones = galones;
            this.Pago = pago;
            this.Total = total;
        }
        public override string ToString()
        {
            return $"#{Numero:00} - {Placa} - {Combustible} - " +
                 $"{Galones:N2} gal - {Pago} -  RD${Total:N2}";
        }

    }
}
