using Entidades;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ServicioDepartamentos
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/BuscarInfo", ResponseFormat = WebMessageFormat.Json,
               BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<Entidad> BuscarInfo(ParametrosDep Parametros);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/GuardarInfo", ResponseFormat = WebMessageFormat.Json,
                  BodyStyle = WebMessageBodyStyle.Wrapped)]
        Boolean GuardarInfo(List<ParametrosDep> Parametros);

    }
}
