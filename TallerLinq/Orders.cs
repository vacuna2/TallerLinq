using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerLinq
{
    public partial class Orders
    {
        //Datos de transporte
        public string DatoTransporte()
        {
            return ShipVia + ", " + Freight + ", " + ShipName;
        }

        //Datos de Lugar de envio
        public string LugarEnvio()
        {
            return ShipCountry + ", " + ShipCity + ", " + ShipAddress;
        }
    }
}