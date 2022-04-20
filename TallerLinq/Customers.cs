using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerLinq
{
    public partial class Customers
    {
        //Metodo Direccion 
        public string direccionCustomers()
        {
            return Country + ", " + City + ", " + Region + ", (" + PostalCode + ")";
        }

        //Metodo Nombre empresa y contacto 
        public string contactoCustomers()
        {
            return ContactName + ", " + ContactTitle + ", " + Phone;
        }
    }
}