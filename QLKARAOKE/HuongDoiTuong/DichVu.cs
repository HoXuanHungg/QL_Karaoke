using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKARAOKE.HuongDoiTuong
{
    public class DichVu
    {
        private int MaDichVu;
        private string TenDichVu;
        private float DonGia;

        public DichVu(int MaDichVu, string TenDichVu, float DonGia)
        {
            this.MaDichVu = MaDichVu;
            this.TenDichVu = TenDichVu;
            this.DonGia = DonGia;

        }
        public DichVu(string TenDichVu, int DonGia)
        {
            this.TenDichVu = TenDichVu;
            this.DonGia = DonGia;


        }

        public DichVu()
        {
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

        public string TENDICHVU
        {
            get
            {
                return TenDichVu;
            }
            set
            {
                TenDichVu = value;
            }
        }
        public float DONGIA
        {
            get
            {
                return DonGia;
            }
            set
            {
                DonGia = value;
            }
        }
    }
}