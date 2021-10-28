using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace QLKARAOKE
{
    public partial class WebForm6 : System.Web.UI.Page
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
            GridHD.DataSource = ado.GetData_HD();
            GridHD.DataBind();
        }

        protected void GridHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                txtMaDon.Text = HttpUtility.HtmlDecode(GridHD.SelectedRow.Cells[0].Text);
            txtMaKhachHang.Text = HttpUtility.HtmlDecode(GridHD.SelectedRow.Cells[1].Text);
            txtMaPhong.Text = HttpUtility.HtmlDecode(GridHD.SelectedRow.Cells[2].Text);
            txtGia.Text = HttpUtility.HtmlDecode(GridHD.SelectedRow.Cells[3].Text);
            txtThoiGianDung.Text = HttpUtility.HtmlDecode(GridHD.SelectedRow.Cells[4].Text);




        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            HuongDoiTuong.HoaDon hd = new HuongDoiTuong.HoaDon();
            hd.MAKH = int.Parse(txtMaKhachHang.Text);
            hd.MAPHONG = int.Parse(txtMaPhong.Text);
            hd.GIAPHONG = float.Parse(txtGia.Text);
            hd.THOIGIANDUNG =int.Parse( txtThoiGianDung.Text);
            if (ado.Them_HD(hd))
            {
                ado.Mo_p(txtMaPhong.Text);
                Load_Grid();
            }
            else
            {
                Response.Write("<script>alert('Insert failed.');</script>");
            }
        }

        protected void GridHD_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            HuongDoiTuong.HoaDon hd = new HuongDoiTuong.HoaDon();
            hd.MAHD = int.Parse(GridHD.Rows[e.RowIndex].Cells[0].Text);
            // hd.MAKH = int.Parse(txtMaKhachHang.Text);
            // hd.MAPHONG = int.Parse(txtMaPhong.Text);
            // hd.BATDAU = DateTime.Parse(txtThoiGianVao.Text);
            // hd.KETTHUC = DateTime.Parse(txtThoiGianRa.Text);
            if (ado.Xoa_HD(hd))
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