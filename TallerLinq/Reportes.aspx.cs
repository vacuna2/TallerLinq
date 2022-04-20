using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TallerLinq
{
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlLambda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlLambda.Text == "Consulta Precio Promedio,minimo,maximo de productos agrupado por categoria")
            {
                using (NothWindLDataContext northwind = new NothWindLDataContext())
                {
                    var consulta = from P in northwind.Products
                                   group P by P.Categories into C
                                   select new
                                   {
                                       COdCategoria = C.Key.CategoryID,
                                       NombreCategoria = C.Key.CategoryName,
                                       Descripcion = C.Key.Description,
                                       PrecioPromedio = C.Average(P => P.UnitPrice),
                                       PrecioMaximo = C.Max(P => P.UnitPrice),
                                       PrecioMinimo = C.Min(P => P.UnitPrice)
                                   };
                    gvReporte.DataSource = consulta;
                    gvReporte.DataBind();
                }
            }
            else if(ddlLambda.Text == "Selecciona Productos cuyo stock es mayor a ")
            {
                using (NothWindLDataContext northwind = new NothWindLDataContext())
                {
                    int nro = int.Parse(txtLambda.Text);
                    var consulta = northwind.Products.Where(P => P.UnitsInStock > nro);
                    gvReporte.DataSource = consulta;
                    gvReporte.DataBind();
                }
            }
            else if(ddlLambda.Text == "Selecciona ordenes realizadas despues de 1997")
            {
                using (NothWindLDataContext northwind = new NothWindLDataContext())
                {
                    var consulta = northwind.Orders.Where(O => O.OrderDate.Year >= 1997);
                    gvReporte.DataSource = consulta;
                    gvReporte.DataBind();
                }
            }
        }

        protected void ddlClaseParcial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlClaseParcial.Text == "consultar Nombre del empeleado y Ubicacion")
            {
                using (NothWindLDataContext context = new NothWindLDataContext())
                {
                    gvReporte.DataSource = from E in context.Employees
                                             select new
                                             {
                                                 Id = E.EmployeeID,
                                                 Empleado = E.NombreEmpleado(),
                                                 Ubicacion = E.UbicacionEmpleado()
                                             };
                    gvReporte.DataBind();
                }
            }
            else if(ddlClaseParcial.Text == "consultar Datos del envio")
            {
                using (NothWindLDataContext context = new NothWindLDataContext())
                {
                    gvReporte.DataSource = from O in context.Orders
                                             select new
                                             {
                                                 Id = O.OrderID,
                                                 Embarcacion = O.DatoTransporte(),
                                                 LugarEnvio = O.LugarEnvio()
                                             };
                    gvReporte.DataBind();
                }
            }
            else if(ddlClaseParcial.Text == "consultar Datos de contacto y direccion de cliente")
            {
                using (NothWindLDataContext context = new NothWindLDataContext())
                {
                    gvReporte.DataSource = from C in context.Customers
                                             select new
                                             {
                                                 Id = C.CustomerID,
                                                 Direccion = C.direccionCustomers(),
                                                 Contacto = C.contactoCustomers()
                                             };
                    gvReporte.DataBind();
                }
            }
        }

        protected void ddlProyeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlProyeccion.Text == "consultar productos para saber el stock menor al numero ingresado")
            {
                using (NothWindLDataContext northwind = new NothWindLDataContext())
                {

                    int nro = int.Parse(txtProyeccion.Text);
                    var consulta = from U in northwind.Products
                                   where U.UnitsInStock <= nro
                                   select new
                                   {
                                       U.ProductID,
                                       U.ProductName,
                                       U.UnitsInStock
                                   };
                    gvReporte.DataSource = consulta;
                    gvReporte.DataBind();

                }
            }
            else if(ddlProyeccion.Text == "consultar pedidos respecto al pais para donde se hizo")
            {
                using (NothWindLDataContext northwind = new NothWindLDataContext())
                {

                    string palabra = txtProyeccion.Text;
                    var consulta = from C in northwind.Orders
                                   where C.ShipCountry == palabra
                                   select new
                                   {
                                       C.OrderID,
                                       C.ShipCountry,
                                       C.ShipCity
                                   };
                    gvReporte.DataSource = consulta;
                    gvReporte.DataBind();

                }
            }
            else if(ddlProyeccion.Text == "consultar empleados segun el apellido del empleado")
            {
                using (NothWindLDataContext northwind = new NothWindLDataContext())
                {

                    string palabra = txtProyeccion.Text;
                    var consulta = from L in northwind.Employees
                                   where L.LastName.Contains(palabra)
                                   select new
                                   {
                                       L.EmployeeID,
                                       L.LastName,
                                       L.FirstName
                                   };
                    gvReporte.DataSource = consulta;
                    gvReporte.DataBind();

                }
            }
        }
    }
}