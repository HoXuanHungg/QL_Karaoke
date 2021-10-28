using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKARAOKE.HuongDoiTuong
{
    public class KhachHang
    {
        private int MaKH;
        private string HoTen;
        private string cmnd;
        private string sdt;

        public KhachHang()
        {
        }

        public KhachHang(int maKH, string HoTen,string cmnd, string sdt)
        {
            this.MaKH = maKH;
            this.HoTen = HoTen;
            this.cmnd = cmnd;
            this.sdt = sdt;
        }

        public int MAKH
        {
            get
            {
                return MaKH;
            }
            set
            {
                MaKH = value;
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