using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKARAOKE
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ADO ado = new ADO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Load_Grid();
            }
        }
        protected void Load_Grid()
        {
            GridP.DataSource = ado.GetData_P();
            GridP.DataBind();
        }
        protected void GridP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string map = GridP.SelectedRow.Cells[0].Text;

            if (ado.Dung_p(map))
            {
                
                Load_Grid();
            }
            else
            {
                Response.Write("<script>alert('Insert failed.');</script>");

            }
        }

    }
}