using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TallerLinq
{
    public partial class ReportesJoin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsulta1_Click(object sender, EventArgs e)
        {
            //Consulta que muestra la informacion de una orden con el id, nombre del cliente y el empleado
            using (NothWindLDataContext northwind = new NothWindLDataContext())
            {
                var consulta = from O in northwind.Orders
                               join C in northwind.Customers on O.CustomerID equals C.CustomerID
                               join E in northwind.Employees on O.EmployeeID equals E.EmployeeID
                               select new
                               {
                                   O.OrderID,
                                   C.CustomerID,
                                   C.CompanyName,
                                   Empleado = E.LastName + " " + E.FirstName
                               };
                GridView1.DataSource = consulta;
                GridView1.DataBind();
            }
        }

        protected void btnConsulta2_Click(object sender, EventArgs e)
        {
            //Consulta que muestra la informacion de un producto(nombre,id) categoria (nombre, descripcion) y proveedor(nombre,ciudad)
            using (NothWindLDataContext northwind = new NothWindLDataContext())
            {
                var consulta = from P in northwind.Products
                               join C in northwind.Categories on P.CategoryID equals C.CategoryID
                               join S in northwind.Suppliers on P.SupplierID equals S.SupplierID
                               select new
                               {
                                   P.ProductID,
                                   P.ProductName,
                                   C.CategoryName,
                                   C.Description,
                                   S.CompanyName,
                                   S.City
                               };
                GridView1.DataSource = consulta;
                GridView1.DataBind();
            }
        }

        protected void btnConsulta3_Click(object sender, EventArgs e)
        {
            //Consulta que muestra la informacion de un producto(nombre,id,precio de forma ascendente) categoria (nombre, descripcion) y proveedor(nombre,ciudad)
            using (NothWindLDataContext northwind = new NothWindLDataContext())
            {
                var consulta = from P in northwind.Products
                               join C in northwind.Categories on P.CategoryID equals C.CategoryID
                               join S in northwind.Suppliers on P.SupplierID equals S.SupplierID
                               orderby P.UnitPrice ascending
                               select new
                               {
                                   P.UnitPrice,
                                   P.ProductName,
                                   P.UnitsInStock,
                                   C.CategoryName,
                                   C.Description,
                                   S.CompanyName,
                                   S.City
                               };
                GridView1.DataSource = consulta;
                GridView1.DataBind();
            }
        }

        protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (NothWindLDataContext northwind = new NothWindLDataContext())
            {
                if (ddlbuscar.SelectedValue == "Precio")
                {
                    var consulta = from P in northwind.Products
                                   join C in northwind.Categories on P.CategoryID equals C.CategoryID
                                   join S in northwind.Suppliers on P.SupplierID equals S.SupplierID
                                   orderby P.UnitPrice ascending
                                   select new
                                   {
                                       P.UnitPrice,
                                       P.ProductName,
                                       P.UnitsInStock,
                                       C.CategoryName,
                                       C.Description,
                                       S.CompanyName,
                                       S.City
                                   };
                    GridView1.DataSource = consulta;
                    GridView1.DataBind();
                }
                else if (ddlbuscar.SelectedValue == "Stock")
                {
                    var consulta = from P in northwind.Products
                                   join C in northwind.Categories on P.CategoryID equals C.CategoryID
                                   join S in northwind.Suppliers on P.SupplierID equals S.SupplierID
                                   orderby P.UnitsInStock ascending
                                   select new
                                   {
                                       P.UnitsInStock,
                                       P.UnitPrice,
                                       P.ProductName,
                                       C.CategoryName,
                                       C.Description,
                                       S.CompanyName,
                                       S.City
                                   };
                    GridView1.DataSource = consulta;
                    GridView1.DataBind();
                }
            }
        }

        protected void btnConsulta4_Click(object sender, EventArgs e)
        {
            //Consulta que muestra la informacion de una orden con el id, nombre del cliente y el empleado
            using (NothWindLDataContext northwind = new NothWindLDataContext())
            {
                int fecha = int.Parse(txtfecha.Text);
                var consulta = from O in northwind.Orders
                               join C in northwind.Customers on O.CustomerID equals C.CustomerID
                               join E in northwind.Employees on O.EmployeeID equals E.EmployeeID
                               where O.OrderDate.Year == fecha
                               select new
                               {
                                   O.OrderID,
                                   O.OrderDate,
                                   C.CustomerID,
                                   C.CompanyName,
                                   Empleado = E.LastName + " " + E.FirstName
                               };
                GridView1.DataSource = consulta;
                GridView1.DataBind();
            }
        }
    }
}