using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace QLKARAOKE
{
    public partial class WebForm4 : System.Web.UI.Page
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
            GridNV.DataSource = ado.GetData_NV();
            GridNV.DataBind();
        }


        protected void btnThem_Click(object sender, EventArgs e)
        {
            HuongDoiTuong.NhanVien nv = new HuongDoiTuong.NhanVien();
            nv.HOTEN = txtHoTen.Text;
            nv.GIOITINH = rbnGioiTinh.SelectedValue;
            nv.DIACHI = txtDiaChi.Text;
            nv.CMND = txtCMND.Text;
            nv.SDT = txtSDT.Text;
            if (ado.Them_NV(nv))
            {
                Load_Grid();
            }
            else
            {
                Response.Write("<script>alert('Insert failed.');</script>");
            }
        }


        protected void GridNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                txtMaNV.Text = HttpUtility.HtmlDecode(GridNV.SelectedRow.Cells[0].Text);
            txtHoTen.Text = HttpUtility.HtmlDecode(GridNV.SelectedRow.Cells[1].Text);
            rbnGioiTinh.SelectedValue = HttpUtility.HtmlDecode(GridNV.SelectedRow.Cells[2].Text);
            txtDiaChi.Text = HttpUtility.HtmlDecode(GridNV.SelectedRow.Cells[3].Text);
            txtCMND.Text = HttpUtility.HtmlDecode(GridNV.SelectedRow.Cells[4].Text);
            txtSDT.Text = HttpUtility.HtmlDecode(GridNV.SelectedRow.Cells[5].Text);


        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            HuongDoiTuong.NhanVien nv = new HuongDoiTuong.NhanVien();
            nv.MANV = int.Parse(txtMaNV.Text);
            nv.HOTEN = txtHoTen.Text;
            nv.GIOITINH = rbnGioiTinh.SelectedValue;
            nv.DIACHI = txtDiaChi.Text;
            nv.CMND = txtCMND.Text;
            nv.SDT = txtSDT.Text;
            if (ado.Sua_NV(nv))
            {
                Load_Grid();
            }
            else
            {
                Response.Write("<script>alert('Insert failed.');</script>");
            }
        }

        protected void GridNV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            HuongDoiTuong.NhanVien nv = new HuongDoiTuong.NhanVien();
            nv.MANV = int.Parse(GridNV.Rows[e.RowIndex].Cells[0].Text);
            if (ado.Xoa_NV(nv))
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