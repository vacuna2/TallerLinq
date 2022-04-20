using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerLinq
{
    public partial class Employees
    {
        //Metodo de nombre completo de los empleados
        public string NombreEmpleado()
        {
            return FirstName + " " + LastName;
        }

        //Metodo de ubicacion de los empleados
        public string UbicacionEmpleado()
        {
            return Country + ", " + City + ", " + Region + ", " + Address;
        }
    }
}