
using Entidades;

using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.UI;

namespace PruebaDepartamentos
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [WebMethod]
        public static Boolean GuadarInfo(List<ParametrosDep> Parametros)
        {
            DepartamentosServicio.Service1Client Servicio = new DepartamentosServicio.Service1Client();
            Boolean Guarda = Servicio.GuardarInfo(Parametros);
            return Guarda;

        }

        [WebMethod]
        public static List<Entidad> BuscarInfo(ParametrosDep Parametros)
        {
            DepartamentosServicio.Service1Client Servicio = new DepartamentosServicio.Service1Client();
            List<Entidad> Lista = Servicio.BuscarInfo(Parametros);
            return Lista;

        }
    }
}