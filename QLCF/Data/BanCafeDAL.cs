using QuanLyQuanCF.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCF.Data
{
    internal class BanCafeDAL
    {
        private readonly QuanLyCFModel quanLyCFModel; 
        public BanCafeDAL()
        {
            quanLyCFModel = new QuanLyCFModel();
        }
        public List<BanCafe> GetBanCafe()
        {
            return quanLyCFModel.BanCafes.ToList();
        }
    }
}
