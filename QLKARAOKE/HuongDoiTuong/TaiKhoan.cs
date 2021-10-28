using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKARAOKE.HuongDoiTuong
{
    public class TaiKhoan
    {
        private string TenTK;
        private string Mk;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string TenTK, string Mk)
        {
            this.TenTK = TenTK;
            this.Mk = Mk;
        }
        public string TENTK
        {
            get
            {
                return TenTK;
            }
            set
            {
                TenTK = value;
            }
        }
        public string MK
        {
            get
            {
                return Mk;
            }
            set
            {
                Mk = value;
            }
        }
    }
}