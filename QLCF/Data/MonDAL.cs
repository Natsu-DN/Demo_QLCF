using QuanLyQuanCF.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCF.Data
{
    internal class MonDAL
    {
        private readonly QuanLyCFModel quanLyCFModel; 
        public MonDAL()
        {
            quanLyCFModel = new QuanLyCFModel();
        }
        public List<Mon> GetMon(int madanhmuc)
        {
            return quanLyCFModel.Mons.Where(mon => mon.MaDanhMuc == madanhmuc).ToList();
        }
    }
}
