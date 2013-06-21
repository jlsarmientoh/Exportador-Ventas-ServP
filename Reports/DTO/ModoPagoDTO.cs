using System;
using System.Collections.Generic;
using System.Text;

namespace Exportador_Ventas_ServP.Reports.DTO
{
    public class ModoPagoDTO
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public ModoPagoDTO(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
