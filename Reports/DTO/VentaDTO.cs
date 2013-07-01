using System;
using System.Collections.Generic;
using System.Text;

namespace Exportador_Ventas_ServP.Reports.DTO
{
    public class VentaDTO
    {
        private long consecutivo;

        public long Consecutivo
        {
            get { return consecutivo; }
            set { consecutivo = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string placa;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        private string producto;

        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }
        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        private string modoPago;

        public string ModoPago
        {
            get { return modoPago; }
            set { modoPago = value; }
        }
        private double kilometraje;

        public double Kilometraje
        {
            get { return kilometraje; }
            set { kilometraje = value; }
        }
    }
}
