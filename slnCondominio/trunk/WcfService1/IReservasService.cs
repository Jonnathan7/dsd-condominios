﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architects.Dominio;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReservasService" in both code and config file together.
    [ServiceContract]
    public interface IReservasService
    {
        [OperationContract]
        IList<EspacioComun> ListarEspacioComun();
    }
}
