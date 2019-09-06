using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParametrosDep
    {
        public int Operacion { get; set; }
        public string NombreCiudad { get; set; }
        public string nombreDepartamento { get; set; }

        public int IdCiudad { get; set; }

        public int IdDepartamento { get; set; }
        public int IdRelacion { get; set; }

        public string login { get; set; }
    }
}
