using QuanLyQuanCF.Data;
using QuanLyQuanCF.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCF.Business
{
    internal class MonBUS
    {
        private readonly MonDAL MonDAL;
        public MonBUS()
        {
            MonDAL = new MonDAL();
        }
        public List<Mon> GetMon(int maDanhMuc)
        {
            return MonDAL.GetMon(maDanhMuc);
        }
    }
}
