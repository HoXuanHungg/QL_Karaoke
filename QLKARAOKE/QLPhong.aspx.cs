using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace QLKARAOKE
{
    public partial class WebForm5 : System.Web.UI.Page
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
            
                txtMaPhong.Text = HttpUtility.HtmlDecode(GridP.SelectedRow.Cells[0].Text);
            txtTenPhong.Text = HttpUtility.HtmlDecode(GridP.SelectedRow.Cells[1].Text);
            txtGiaPhong.Text = HttpUtility.HtmlDecode(GridP.SelectedRow.Cells[2].Text);
            rbnTrangThai.SelectedValue = HttpUtility.HtmlDecode(GridP.SelectedRow.Cells[3].Text);


        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            HuongDoiTuong.Phong p = new HuongDoiTuong.Phong();
            p.TENPHONG = txtTenPhong.Text;
            p.TINHTRANG = rbnTrangThai.SelectedValue;
            p.GIAPHONG = float.Parse(txtGiaPhong.Text);
            if (ado.Them_P(p))
            {
                Load_Grid();
            }
            else
            {
                Response.Write("<script>alert('Insert failed.');</script>");
            }
        }

        protected void GridP_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            HuongDoiTuong.Phong p = new HuongDoiTuong.Phong();
            p.MAPHONG = int.Parse(GridP.Rows[e.RowIndex].Cells[0].Text);

            if (ado.Xoa_Phong(p))
            {
                Load_Grid();
            }
            else
            {
                Response.Write("<script>alert('Insert failed.');</script>");
            }

        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            HuongDoiTuong.Phong p = new HuongDoiTuong.Phong();
            p.MAPHONG = int.Parse(txtMaPhong.Text);
            p.TENPHONG = txtTenPhong.Text;
            p.TINHTRANG = rbnTrangThai.SelectedValue;
            p.GIAPHONG = float.Parse(txtGiaPhong.Text);
            if (ado.Sua_Phong(p))
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