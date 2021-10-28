using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace QLKARAOKE
{
    public partial class WebForm3 : System.Web.UI.Page
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
            GridKH.DataSource = ado.GetData_KH();
            GridKH.DataBind();
        }


        protected void GridKH_SelectedIndexChanged(object sender, EventArgs e)
        {

            //string makh = GridKH.SelectedRow.Cells[0].Text;

            //DataTable table = new DataTable();
            //table = ado.GetData_KH(makh);
            //if (table != null)
            //{
            //    txtMaKH.Text = table.Rows[0][0].ToString();
            //    txtHoTen.Text = table.Rows[0][1].ToString();
            //    txtCMND.Text = table.Rows[0][2].ToString();
            //    txtSDT.Text = table.Rows[0][3].ToString();
            //}

            txtMaKH.Text = HttpUtility.HtmlDecode(GridKH.SelectedRow.Cells[0].Text);
            txtHoTen.Text = HttpUtility.HtmlDecode(GridKH.SelectedRow.Cells[1].Text);

            txtCMND.Text = HttpUtility.HtmlDecode(GridKH.SelectedRow.Cells[2].Text);
            txtSDT.Text = HttpUtility.HtmlDecode(GridKH.SelectedRow.Cells[3].Text);
        }

            protected void btnThem_Click(object sender, EventArgs e)
        {
            HuongDoiTuong.KhachHang kh = new HuongDoiTuong.KhachHang();
            kh.HOTEN = txtHoTen.Text;
            kh.CMND = txtCMND.Text;
            kh.SDT = txtSDT.Text;
            if (ado.Them_KH(kh))
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

            HuongDoiTuong.KhachHang kh = new HuongDoiTuong.KhachHang();
            kh.MAKH = int.Parse(txtMaKH.Text);
            kh.HOTEN = txtHoTen.Text;
            kh.CMND = txtCMND.Text;
            kh.SDT = txtSDT.Text;
            if (ado.Sua_KH(kh))
            {
                Load_Grid();
            }
            else
            {
                Response.Write("<script>alert('Insert failed.');</script>");
            }
        }

        protected void GridKH_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            HuongDoiTuong.KhachHang kh = new HuongDoiTuong.KhachHang();
            kh.MAKH = int.Parse(GridKH.Rows[e.RowIndex].Cells[0].Text);
            if (ado.Xoa_KH(kh))
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