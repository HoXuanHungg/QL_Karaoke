using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace QLKARAOKE
{
    public partial class WebForm2 : System.Web.UI.Page
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
                GridDV.DataSource = ado.GetData_DV();
                GridDV.DataBind();
            }
            protected void GridDV_SelectedIndexChanged(object sender, EventArgs e)
            {
            txtMaDV.Text = HttpUtility.HtmlDecode(GridDV.SelectedRow.Cells[0].Text);
            txtTenDichVu.Text = HttpUtility.HtmlDecode(GridDV.SelectedRow.Cells[1].Text);
            txtDonGia.Text = HttpUtility.HtmlDecode(GridDV.SelectedRow.Cells[2].Text);

        }

        protected void btnThem_Click(object sender, EventArgs e)
            {
                HuongDoiTuong.DichVu dv = new HuongDoiTuong.DichVu();
                dv.TENDICHVU = txtTenDichVu.Text;
                dv.DONGIA = int.Parse(txtDonGia.Text);
                if (ado.Them_DV(dv))
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
                HuongDoiTuong.DichVu dv = new HuongDoiTuong.DichVu();
                dv.MADICHVU = int.Parse(txtMaDV.Text);
                dv.TENDICHVU = txtTenDichVu.Text;
                dv.DONGIA = float.Parse(txtDonGia.Text);
                if (ado.Sua_DV(dv))
                {
                    Load_Grid();
                }
                else
                {
                    Response.Write("<script>alert('Insert failed.');</script>");
                }
            }


            protected void GridDV_RowDeleting(object sender, GridViewDeleteEventArgs e)
            {
                HuongDoiTuong.DichVu dv = new HuongDoiTuong.DichVu();
                dv.MADICHVU = int.Parse(GridDV.Rows[e.RowIndex].Cells[0].Text);               
                if (ado.Xoa_DV(dv))
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