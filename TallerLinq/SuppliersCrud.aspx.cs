using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TallerLinq
{
    public partial class SuppliersCrud : System.Web.UI.Page
    {
        NothWindLDataContext northwindL = new NothWindLDataContext();
        private IList<Suppliers> Listar()
        {
            var consulta = from C in northwindL.Suppliers select C;
            gvSuppliers.DataSource = consulta.ToList();
            gvSuppliers.DataBind();
            return consulta.ToList();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                Listar();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Suppliers supp = new Suppliers();
            supp.SupplierID = Convert.ToInt32(txtSupplierID.Text);
            supp.CompanyName = txtCompanyName.Text;
            supp.ContactName = txtContactName.Text;
            supp.ContactTitle = txtContactTitle.Text;
            supp.Address = txtAddress.Text;
            supp.City = txtCity.Text;
            supp.Region = txtRegion.Text;
            supp.PostalCode = txtPostalCode.Text;
            supp.Country = txtCountry.Text;
            supp.Phone = txtPhone.Text;
            supp.Fax = txtFax.Text;
            supp.HomePage = txtHomePage.Text;

            northwindL.Suppliers.InsertOnSubmit(supp);
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Suppliers supp = northwindL.Suppliers.Single(C => C.SupplierID == Convert.ToInt32(txtSupplierID.Text));

            supp.CompanyName = txtCompanyName.Text;
            supp.ContactName = txtContactName.Text;
            supp.ContactTitle = txtContactTitle.Text;
            supp.Address = txtAddress.Text;
            supp.City = txtCity.Text;
            supp.Region = txtRegion.Text;
            supp.PostalCode = txtPostalCode.Text;
            supp.Country = txtCountry.Text;
            supp.Phone = txtPhone.Text;
            supp.Fax = txtFax.Text;
            supp.HomePage = txtHomePage.Text;

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

        protected void Button2_Click(object sender, EventArgs e)
        {
            var consulta = (from S in northwindL.Suppliers where S.SupplierID.Equals(Convert.ToInt32(txtSupplierID.Text)) select S).First();
            northwindL.Suppliers.DeleteOnSubmit(consulta);
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