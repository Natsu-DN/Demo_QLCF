using QuanLyQuanCF.Data;
using QuanLyQuanCF.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCF.Business
{
    internal class BanCafeBUS
    {
        private readonly BanCafeDAL banCafeDAL;
        public BanCafeBUS()
        {
            banCafeDAL = new BanCafeDAL();
        }
        public List<BanCafe> GetBanCafe()
        {
            return banCafeDAL.GetBanCafe();
        }
    }
}
