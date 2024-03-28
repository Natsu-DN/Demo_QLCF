using QuanLyQuanCF.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCF.Data
{
    internal class DanhMucDAL
    {
        private readonly QuanLyCFModel quanLyCFModel; 
        public DanhMucDAL()
        {
            quanLyCFModel = new QuanLyCFModel();
        }
        public List<DanhMuc> GetDanhMuc()
        {
            return quanLyCFModel.DanhMucs.ToList();
        }
    }
}
