using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKARAOKE.HuongDoiTuong
{
    public class NhanVien
    {
        private int MaNV;
        private string HoTen;
        private string GioiTinh;
        private string DiaChi;
        private string cmnd;
        private string sdt;

        public NhanVien()
        {
        }

        public NhanVien(int MaNV, string HoTen,string GioiTinh, string DiaChi, string cmnd, string sdt)
        {
            this.MaNV = MaNV;
            this.HoTen = HoTen;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.cmnd = cmnd;
            this.sdt = sdt;
        }

        public int MANV
        {
            get
            {
                return MaNV;
            }
            set
            {
                MaNV = value;
            }
        }
        public string HOTEN
        {
            get
            {
                return HoTen;
            }
            set
            {
                HoTen = value;
            }
        }
        public string GIOITINH
        {
            get
            {
                return GioiTinh;
            }
            set
            {
                GioiTinh = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return DiaChi;
            }
            set
            {
                DiaChi = value;
            }
        }
        public string CMND
        {
            get
            {
                return cmnd;
            }
            set
            {
                cmnd = value;
            }
        }
        public string SDT
        {
            get
            {
                return sdt;
            }
            set
            {
                sdt = value;
            }
        }
    }
}