using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using QLKARAOKE.HuongDoiTuong;

namespace QLKARAOKE
{
    public class ADO
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLKARAOKE"].ConnectionString;

        public bool Command(string sql)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return count >= 1;
            }
        }
        //Nhan Vien
        public bool Them_NV(HuongDoiTuong.NhanVien nv)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = "insert into NHANVIEN values(@HOTEN, @GIOITINH, @DIACHI, @CMND, @SDT)";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@HOTEN", nv.HOTEN);
                cmd.Parameters.AddWithValue("@GIOITINH", nv.GIOITINH);
                cmd.Parameters.AddWithValue("@DIACHI", nv.DIACHI);
                cmd.Parameters.AddWithValue("@CMND", nv.CMND);
                cmd.Parameters.AddWithValue("@SDT", nv.SDT);
                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return count >= 1;
            }
        }

      

        public bool Sua_NV(HuongDoiTuong.NhanVien nv)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = "update NHANVIEN set HOTEN = @HOTEN, GIOITINH= @GIOITINH, DIACHI=@DIACHI, CMND=@CMND, SDT=@SDT where MANV = @MNV";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@MNV", nv.MANV);
                cmd.Parameters.AddWithValue("@HOTEN", nv.HOTEN);
                cmd.Parameters.AddWithValue("@GIOITINH", nv.GIOITINH);
                cmd.Parameters.AddWithValue("@DIACHI", nv.DIACHI);
                cmd.Parameters.AddWithValue("@CMND", nv.CMND);
                cmd.Parameters.AddWithValue("@SDT", nv.SDT);
                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return count >= 1;
            }
        }

        internal bool Xoa_TaiKhoan(TaiKhoan tk)
        {
            throw new NotImplementedException();
        }

        public bool Xoa_NV(HuongDoiTuong.NhanVien nv)
        {
            string sql = "delete from NHANVIEN where MANV='" + nv.MANV + "'";
            return Command(sql);
        }

        //Dich vu
        public bool Them_DV(HuongDoiTuong.DichVu dv)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = "insert into DICHVU values(@TENDV, @DONGIA)";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@TENDV", dv.TENDICHVU);
                cmd.Parameters.AddWithValue("@DONGIA", dv.DONGIA);
                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return count >= 1;
            }
        }
        public bool Sua_DV(HuongDoiTuong.DichVu dv)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = "update DICHVU set TENDV = @tdv, DONGIA= @gia where MADV = @madv";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@madv", dv.MADICHVU);
                cmd.Parameters.AddWithValue("@tdv", dv.TENDICHVU);
                cmd.Parameters.AddWithValue("@gia", dv.DONGIA);

                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return count >= 1;
            }
        }
        public bool Xoa_DV(HuongDoiTuong.DichVu dv)
        {
            string sql = "delete from DICHVU where MADV='" + dv.MADICHVU + "'";
            return Command(sql);
        }
        //Chi tiet dich vu
        public bool Them_CTDV(HuongDoiTuong.ChiTietDichVu dv)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = "insert into ChiTietDichVu values(@MADON, @STT, @MADV,@SOLUONG)";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@MADON", dv.MADON);
                cmd.Parameters.AddWithValue("@STT", dv.STT);
                cmd.Parameters.AddWithValue("@MADV", dv.MADICHVU);
                cmd.Parameters.AddWithValue("@SOLUONG", dv.SOLUONG);
                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return count >= 1;
            }
        }
        public bool Sua_CTDV(HuongDoiTuong.ChiTietDichVu dv)
        {
            string sql = "update CHITIETDICHVU set MADV=N'" + dv.MADICHVU + "',SOLUONG='" + dv.SOLUONG + "')";
            return Command(sql);
        }
        public bool Xoa_CTDV(HuongDoiTuong.ChiTietDichVu dv)
        {
            string sql = "delete from CHITIETDICHVU where MADON='" + dv.MADON + "' and '" + dv.STT + "')";
            return Command(sql);
        }
        //Phong
        public bool Them_P(HuongDoiTuong.Phong p)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = "insert into PHONG(TENPHONG, GIAPHONG, TINHTRANG) values(@TENPHONG, @GIAPHONG, @TINHTRANG)";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@TENPHONG", p.TENPHONG);
                cmd.Parameters.AddWithValue("@GIAPHONG", p.GIAPHONG);
                cmd.Parameters.AddWithValue("@TINHTRANG", p.TINHTRANG);

                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return count >= 1;
            }
        }
        public bool Sua_Phong(HuongDoiTuong.Phong p)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = "update PHONG set TENPHONG = @tp, GIAPHONG= @gia, TINHTRANG=@tt where MAPHONG = @map";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@map", p.MAPHONG);
                cmd.Parameters.AddWithValue("@tp", p.TENPHONG);
                cmd.Parameters.AddWithValue("@tt", p.TINHTRANG);
                cmd.Parameters.AddWithValue("@gia", p.GIAPHONG);

                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return count >= 1;
            }
        }
        public bool Xoa_Phong(HuongDoiTuong.Phong p)
        {
            string sql = "delete from PHONG where MAPHONG='" + p.MAPHONG + "'";
            return Command(sql);
        }
        public bool Dung_p(string mp)

        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = "update PHONG set TINHTRANG = @tt where MAPHONG = @mp";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@tt", "Đang sử dụng");
                cmd.Parameters.AddWithValue("@mp", mp);
                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return (count >= 1);
            }

        }

        //chuyen phong ve trang thai khong 
        public bool Mo_p(string mp)

        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = "update PHONG set TINHTRANG = @tt where MAPHONG = @mp";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@tt", "Còn trống");
                cmd.Parameters.AddWithValue("@mp", mp);
                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return (count >= 1);
            }

        }
        //Khach hang
        public bool Them_KH(HuongDoiTuong.KhachHang kh)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = "insert into KHACHHANG(HOTEN, CMND, SDT) values(@HOTEN, @CMND, @SDT)";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@HOTEN", kh.HOTEN);
                cmd.Parameters.AddWithValue("@CMND", kh.CMND);
                cmd.Parameters.AddWithValue("@SDT", kh.SDT);
                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return (count >= 1);
            }
        }
        public bool Sua_KH(HuongDoiTuong.KhachHang kh)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = "update KHACHHANG set HOTEN = @HOTEN, CMND=@CMND, SDT=@SDT where MAKH = @mkh";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@mkh", kh.MAKH);
                cmd.Parameters.AddWithValue("@HOTEN", kh.HOTEN);
                cmd.Parameters.AddWithValue("@CMND", kh.CMND);
                cmd.Parameters.AddWithValue("@SDT", kh.SDT);
                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return count >= 1;
            }
        }
        public bool Xoa_KH(HuongDoiTuong.KhachHang kh)
        {
            string sql = "delete from KHACHHANG where MAKH='" + kh.MAKH + "'";
            return Command(sql);
        }
        //Hoa don
        public bool Them_HD(HuongDoiTuong.HoaDon hd)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = "insert into HOADON(MAKH, MAPHONG, GIAPHONG, THOIGIANDUNG) values(@MAKH,@MAPHONG, @GIAPHONG, @THOIGIANDUNG)";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@MAKH", hd.MAKH);
                cmd.Parameters.AddWithValue("@MAPHONG", hd.MAPHONG);
                cmd.Parameters.AddWithValue("@GIAPHONG", hd.GIAPHONG);
                cmd.Parameters.AddWithValue("@THOIGIANDUNG", hd.THOIGIANDUNG);
                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return (count >= 1);
            }
        }
        public bool Sua_HD(HuongDoiTuong.HoaDon hd)
        {
            string sql = "update HOADON set MAKH='" + hd.MAKH  + "',MAPHONG='" + hd.MAPHONG + "',GIAPHONG='" + hd.GIAPHONG + "',THOIGIANDUNG'" + hd.THOIGIANDUNG + "')";
            return Command(sql);
        }
        public bool Xoa_HD(HuongDoiTuong.HoaDon hd)
        {
            string sql = "delete from HOADON where MADON='" + hd.MAHD + "'";
            return Command(sql);
        }




        //Dat Phong
        public bool Them_Phong(HuongDoiTuong.DatPhong dp)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = "insert into DATPHONG values(@MAKH, @MAPHONG, @THOIGIANDEN)";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@MAKH", dp.MAKH);
                cmd.Parameters.AddWithValue("@MAPHONG", dp.MAPHONG);
                cmd.Parameters.AddWithValue("@THOIGIANDEN", dp.THOIGIANDEN);
                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return count >= 1;
            }
        }
        public bool Sua_DP(HuongDoiTuong.DatPhong dp)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = "update NHANVIEN set MAKH = @MAKH, MAPHONG= @MAPHONG, THOIGIANDEN=@THOIGIANDEN where MADP = @MADP";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@MADP", dp.MADP);
                cmd.Parameters.AddWithValue("@MAKH", dp.MAKH);
                cmd.Parameters.AddWithValue("@MAPHONG", dp.MAPHONG);
                cmd.Parameters.AddWithValue("@THOIGIANDEN", dp.THOIGIANDEN);
                connect.Open();
                int count = cmd.ExecuteNonQuery();
                connect.Close();
                return count >= 1;
            }
        }
        public bool Xoa_DP(HuongDoiTuong.DatPhong dp)
        {
            string sql = "delete from NHANVIEN where MADP='" + dp.MADP + "'";
            return Command(sql);
        }





        //Tai_khoan

        public bool Them_TK(HuongDoiTuong.TaiKhoan tk)
        {
            string sql = "insert into TAIKHOAN values('" + tk.TENTK + "','" + tk.MK + "')";
            return Command(sql);
        }
        public bool Sua_TK(HuongDoiTuong.TaiKhoan tk)
        {
            string sql = "update TAIKHOAN set TENTK=N'" + tk.TENTK + "',MATKHAU='" + tk.MK + "')";
            return Command(sql);
        }
        public bool Xoa_TK(HuongDoiTuong.TaiKhoan tk)
        {
            string sql = "delete from TAIKHOAN where TenTK='" + tk.TENTK + "'";
            return Command(sql);
        }

        public DataTable GetData(string sql)
        {
            DataTable table = new DataTable();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                connect.Open();
                SqlDataAdapter dA = new SqlDataAdapter(cmd);
                dA.Fill(table);
                connect.Close();
                return table;
            }
        }
        //lay data nhan vien
        public DataTable GetData_NV()
        {
            string sql = "select * from NHANVIEN";
            return GetData(sql);
        }
        public DataTable GetData_NV(string Manv)
        {
            string sql = @"select * from NHANVIEN where MANV='" + Manv + "'";
            return GetData(sql);
        }


        //lay data dich vu
        public DataTable GetData_DV()
        {
            string sql = "select * from DICHVU";
            return GetData(sql);
        }
        public DataTable GetData_DV(string Madv)
        {
            string sql = @"select * from DICHVU where MADV='" + Madv + "'";
            return GetData(sql);
        }

        //lay data hoa don
        public DataTable GetData_HD()
        {
            string sql = "select * from HOADON";
            return GetData(sql);
        }
        public DataTable GetData_HD(string Mahd)
        {
            string sql = @"select * from HOADON where MADON='" + Mahd + "'";
            return GetData(sql);
        }


        //lay data Khach hang
        public DataTable GetData_KH()
        {
            string sql = "select * from KHACHHANG";
            return GetData(sql);
        }
        public DataTable GetData_KH(string Makh)
        {
            string sql = @"select * from KHACHHANG where MAKH='" + Makh + "'";
            return GetData(sql);
        }

        //lay data phong
        public DataTable GetData_P()
        {
            string sql = "select * from PHONG";
            return GetData(sql);
        }
        public DataTable GetData_P(string Ma)
        {
            string sql = @"select * from PHONG where MAPHONG='" + Ma + "'";
            return GetData(sql);
        }



 

        //lay data tai khoan
        public DataTable GetData_TK()
        {
            string sql = "select * from TAIKHOAN";
            return GetData(sql);
        }
        public DataTable GetData_TK(string TenTK)
        {
            string sql = @"select * from TAIKHOAN where TENTK='" + TenTK + "'";
            return GetData(sql);
        }



        public bool KiemTra(string sql)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                connect.Open();
                int count = (int)cmd.ExecuteScalar();
                connect.Close();
                return count >= 1;
            }
        }

        public bool KiemTraTaiKhoan(HuongDoiTuong.TaiKhoan taikhoan)
        {
            string sqlchecklogin = "select count(*) from TAIKHOAN where TENTK=N'" + taikhoan.TENTK + "' and MATKHAU=N'" + taikhoan.MK + "'";
            return KiemTra(sqlchecklogin);
        }
    }
}