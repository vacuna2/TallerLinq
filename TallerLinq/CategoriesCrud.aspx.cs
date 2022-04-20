using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TallerLinq
{
    public partial class CategoriesCrud : System.Web.UI.Page
    {
        NothWindLDataContext northwindL = new NothWindLDataContext();
        private IList<Categories> Listar()
        {
            var consulta = from C in northwindL.Categories select C;
            gvCAtegories.DataSource = consulta.ToList();
            gvCAtegories.DataBind();
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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}