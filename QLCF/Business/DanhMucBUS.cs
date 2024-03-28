using QuanLyQuanCF.Data;
using QuanLyQuanCF.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCF.Business
{
    internal class DanhMucBUS
    {
        private readonly DanhMucDAL danhMucDAL;
        public DanhMucBUS()
        {
            danhMucDAL = new DanhMucDAL();
        }
        public List<DanhMuc> GetDanhMuc()
        {
            return danhMucDAL.GetDanhMuc();
        }
    }
}
