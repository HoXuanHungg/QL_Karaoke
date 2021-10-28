using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKARAOKE.HuongDoiTuong
{
    public class DatPhong { 
    private int MaDP;
    private int MaKH;
    private int MaPhong;
    private string ThoiGianDen;

        public DatPhong(int MaDP, int MaKH, int MaPhong, string ThoiGianDen)
        {
            this.MaDP = MaDP;
            this.MaKH = MaKH;
            this.MaPhong = MaPhong;
            this.ThoiGianDen = ThoiGianDen;
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
        public string THOIGIANDEN
        {
            get
            {
                return ThoiGianDen;
            }
            set
            {
                ThoiGianDen = value;
            }
        }
    }
}