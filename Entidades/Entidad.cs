using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entidad
    {
        public int IdDepartamento { get; set; }
        public string DescripcionDep { get; set; }

        public int IdCiudad { get; set; }
        public string DescripcionCiu { get; set; }

        public int IdRelacion { get; set; }
        public int ESTADO { get; set; }

        public string DESCRIESTADO { get; set; }

    }
}
