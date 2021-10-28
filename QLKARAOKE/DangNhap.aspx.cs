using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

namespace QLKARAOKE
{
    public partial class DangNhap : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLKARAOKE"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["login"];
                if (cookie != null)
                {
                    txtTentaikhoan.Text = cookie["tk"].ToString();
                    txtPassword.Text = cookie["mk"].ToString();
                }
            }
        }

        protected void btDangnhap_Click(object sender, EventArgs e)
        {
            ADO ado = new ADO();
            HuongDoiTuong.TaiKhoan tk = new HuongDoiTuong.TaiKhoan();
            {
                tk.TENTK = txtTentaikhoan.Text;
                tk.MK = txtPassword.Text;
            }

            if (ado.KiemTraTaiKhoan(tk))
            {
                HttpCookie cookie = new HttpCookie("login");
                cookie["tk"] = tk.TENTK;
                cookie["mk"] = tk.MK;
                Response.Cookies.Add(cookie);
                Server.Transfer("home.aspx");
            }
            else
            {
                Response.Write("That bai");
            }
        }
    }
}   