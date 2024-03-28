using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCF.ViewModels
{
    class MonDat
    {
        public int maMon { get; set; }
        public int sLuong { get; set; }
        public string tenMon { get; set; }
        public double donGia { get; set; }
        public double thanhtien
        {
            get
            {
                return donGia * sLuong;
            }
        }
    }
}
