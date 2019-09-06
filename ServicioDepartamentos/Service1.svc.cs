using Entidades;
using DAL;
using System;
using System.Collections.Generic;

namespace ServicioDepartamentos
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Entidad> BuscarInfo(ParametrosDep Parametros)
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

        public bool GuardarInfo(List<ParametrosDep> Parametros)
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
