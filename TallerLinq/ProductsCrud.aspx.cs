using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TallerLinq
{
    public partial class ProductsCrud : System.Web.UI.Page
    {
        private NothWindLDataContext northwindL = new NothWindLDataContext();
        private IList<Products> Listar()
        {
            var consulta = from C in northwindL.Products select C;
            gvProductos.DataSource = consulta.ToList();
            gvProductos.DataBind();
            return consulta.ToList();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ddlCategories.DataSource = from v in northwindL.Categories select v;
                ddlCategories.DataTextField = "CategoryName";
                ddlCategories.DataValueField = "CategoryID";
                ddlCategories.DataBind();

                ddlSuppliers.DataSource = from v in northwindL.Suppliers select v;
                ddlSuppliers.DataTextField = "CompanyName";
                ddlSuppliers.DataValueField = "SupplierID";
                ddlSuppliers.DataBind();

                Listar();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.ProductID = Convert.ToInt32(txtIdPorducto.Text);
            product.ProductName = txtProductName.Text;
            product.SupplierID = Convert.ToInt32(ddlSuppliers.SelectedValue);
            product.CategoryID = Convert.ToInt32(ddlCategories.SelectedValue);
            product.QuantityPerUnit = txtQuantityPerUnit.Text;
            product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            product.UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text);
            product.UnitsOnOrder = Convert.ToInt16(txtUnitsOnOver.Text);
            product.UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text);
            product.Discontinued = cbxDiscontinued.Checked ? true : false;

            northwindL.Products.InsertOnSubmit(product);
            try
            {
                northwindL.SubmitChanges();
                Listar();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)//actualizar
        {
            Products product = northwindL.Products.Single(C => C.ProductID == Convert.ToInt32(txtIdPorducto.Text));

            product.ProductName = txtProductName.Text;
            product.SupplierID = Convert.ToInt32(ddlSuppliers.SelectedValue);
            product.CategoryID = Convert.ToInt32(ddlCategories.SelectedValue);
            product.QuantityPerUnit = txtQuantityPerUnit.Text;
            product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            product.UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text);
            product.UnitsOnOrder = Convert.ToInt16(txtUnitsOnOver.Text);
            product.UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text);
            product.Discontinued = cbxDiscontinued.Checked ? true : false;

            try
            {
                northwindL.SubmitChanges();
                Listar();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)//Eliminar
        {
            var consulta = (from P in northwindL.Products where P.ProductID.Equals(Convert.ToInt32(txtIdPorducto.Text)) select P).First();
            northwindL.Products.DeleteOnSubmit(consulta);
            try
            {
                northwindL.SubmitChanges();
                Listar();
            }
            catch (Exception ex)
            {

                Response.Write(ex.Message);
            }
        }
    }
}