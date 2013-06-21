using System;
using System.Collections.Generic;
using System.Text;

namespace Exportador_Ventas_ServP.Reports.DTO
{
    public class EstadoCuentaDTO
    {
        private string producto;

        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }
        private double cantidad;

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private double valorBruto;

        public double ValorBruto
        {
            get { return valorBruto; }
            set { valorBruto = value; }
        }
        private double valorTotal;

        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }
    }
}
