using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKARAOKE.HuongDoiTuong
{
    public class Phong
    {
        private int MaPhong;
        private string TenPhong;
        private float GiaPhong;
        private string TinhTrang;

        public Phong()
        {
        }

        public Phong(int MaPhong, string TenPhong, float GiaPhong, string TinhTrang)
        {
            this.MaPhong = MaPhong;
            this.TenPhong = TenPhong;
            this.GiaPhong = GiaPhong;
            this.TinhTrang = TinhTrang;

        }

        public int MAPHONG
        {
            get
            {
                return MaPhong;
            }
            set
            {
                MaPhong = value;
            }
        }
        public string TENPHONG
        {
            get
            {
                return TenPhong;
            }
            set
            {
                TenPhong = value;
            }
        }
        public float GIAPHONG
        {
            get
            {
                return GiaPhong;
            }
            set
            {
                GiaPhong = value;
            }
        }
        public string TINHTRANG
        {
            get
            {
                return TinhTrang;
            }
            set
            {
                TinhTrang = value;
            }
        }
    }
}