using Entidades;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/BuscarInfo", ResponseFormat = WebMessageFormat.Json,
                  BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<Entidad> BuscarInfo(Parametros Parametros);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/GuardarInfo", ResponseFormat = WebMessageFormat.Json,
                  BodyStyle = WebMessageBodyStyle.Wrapped)]
        Boolean GuardarInfo(List<Parametros> Parametros);
        
    }


}
