using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace QLKARAOKE
{
    public partial class WebForm7 : System.Web.UI.Page
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
            GridTK.DataSource = ado.GetData_TK();
            GridTK.DataBind();
        }


       


        protected void GridTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtTenTK.Text = HttpUtility.HtmlDecode(GridTK.SelectedRow.Cells[0].Text);
            txtPass.Text = HttpUtility.HtmlDecode(GridTK.SelectedRow.Cells[1].Text);

        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            HuongDoiTuong.TaiKhoan tk = new HuongDoiTuong.TaiKhoan();
            tk.TENTK = txtTenTK.Text;
            tk.MK = txtPass.Text;
            if (ado.Sua_TK(tk))
            {
                Load_Grid();
            }
            else
            {
                Response.Write("<script>alert('Insert failed.');</script>");
            }
        }

        protected void GridTK_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            HuongDoiTuong.TaiKhoan tk = new HuongDoiTuong.TaiKhoan();
            tk.TENTK = GridTK.Rows[e.RowIndex].Cells[0].Text;
            if (ado.Xoa_TK(tk))
            {
                Load_Grid();
            }
            else
            {
                Response.Write("<script>alert('Insert failed.');</script>");
            }
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            HuongDoiTuong.TaiKhoan tk = new HuongDoiTuong.TaiKhoan();
            tk.TENTK = txtTenTK.Text;
            tk.MK = txtPass.Text;
            if (ado.Them_TK(tk))
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