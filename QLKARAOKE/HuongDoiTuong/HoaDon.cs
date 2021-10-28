using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKARAOKE.HuongDoiTuong
{
    public class HoaDon
    {
        private int MaHD;
        private int MaKH;
        private int MaDP;
        private int MaPhong;
        private float GiaPhong;
        private int ThoiGianDung;

        public HoaDon()
        {
        }

        public HoaDon(int MaHD, int MaKH, int MaPhong,int MaDP, float GiaPhong,int ThoiGianDung)
        {
            this.MaHD = MaHD;
            this.MaKH = MaKH;
            this.MaDP = MaDP;
            this.MaPhong = MaPhong;
            this.GiaPhong = GiaPhong;
            this.ThoiGianDung = ThoiGianDung;
        }

        public int MAHD
        {
            get
            {
                return MaHD;
            }
            set
            {
                MaHD = value;
            }
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

        public int MADP
        {
            get
            {
                return MaDP;
            }
            set
            {
                MaDP = value;
            }
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
        public int THOIGIANDUNG
        {
            get
            {
                return ThoiGianDung;
            }
            set
            {
                ThoiGianDung = value;
            }
        }

    }
}