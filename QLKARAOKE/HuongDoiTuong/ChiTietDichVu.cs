using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKARAOKE.HuongDoiTuong
{
    public class ChiTietDichVu
    {
        private int MaDon;
        private int stt;
        private int MaDichVu;
        private int SoLuong;

        public ChiTietDichVu(int MaDon, int stt, int MaDichVu, int SoLuong)
        {
            this.MaDon = MaDon;
            this.stt = stt;
            this.MaDichVu = MaDichVu;
            this.SoLuong = SoLuong;

        }

        public int MADON
        {
            get
            {
                return MaDon;
            }
            set
            {
                MaDon = value;
            }
        }
        public int STT
        {
            get
            {
                return STT;
            }
            set
            {
                STT = value;
            }
        }
        public int MADICHVU
        {
            get
            {
                return MaDichVu;
            }
            set
            {
                MaDichVu = value;
            }
        }
        public int SOLUONG
        {
            get
            {
                return SoLuong;
            }
            set
            {
                SoLuong = value;
            }
        }
    }
}