using DAL;
using Entidades;
using System;
using System.Collections.Generic;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public List<Entidad> BuscarInfo(Parametros Parametros)
        {
            try
            {
                DepartamentoDAL DepartamentoDAL = new DepartamentoDAL();
                return DepartamentoDAL.BuscarInfo(Parametros);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GuardarInfo(List<Parametros> Parametros)
        {
            try
            {
                DepartamentoDAL DepartamentoDAL = new DepartamentoDAL();
                return DepartamentoDAL.GuardarInfo(Parametros);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
