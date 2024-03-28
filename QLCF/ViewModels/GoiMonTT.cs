using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCF.ViewModels
{
    class GoiMonTT
    {
        public int MsBan { get; set; }
        private List<MonDat> dsMon;
        public GoiMonTT()
        {
            dsMon = new List<MonDat>();
        }

        public void addMon (MonDat mon)
        {
            MonDat m = dsMon.Where(v => v.maMon == mon.maMon).FirstOrDefault();
            if (m == null)
                dsMon.Add(mon);
            else
                m.sLuong += mon.sLuong;
           
        }

        public void delMon (MonDat mon)
        {
            dsMon.Remove(mon);
        }

        public List<MonDat> GetDSMonDat()
        {
            return dsMon;
        }
    }
}
