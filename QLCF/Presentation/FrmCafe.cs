using QuanLyQuanCF.Business;
using QuanLyQuanCF.Data.Models;
using QuanLyQuanCF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCF.Presentation
{
    public partial class FrmCafe : Form
    {
        //bố trí 5 bàn cho 1 dãy
        private const int COT = 5;
        private readonly BanCafeBUS banCafeBUS;
        private readonly DanhMucBUS dmBUS;
        private readonly MonBUS monBUS;
        Button banChon = null;
        double total = 0;
        CultureInfo formatVN = CultureInfo.CreateSpecificCulture("vi-VN");
        List<GoiMonTT> gmtts = new List<GoiMonTT>();
        public FrmCafe()
        {
      
            InitializeComponent();
            nbDiscount.Minimum = 0;
            nbDiscount.Maximum = 100;
            nbDiscount.TextChanged += NbDiscount_TextChanged;
            this.Load += FrmBanHang_Load;
            banCafeBUS = new BanCafeBUS();
            dmBUS = new DanhMucBUS();
            monBUS = new MonBUS();
        }

        private void NbDiscount_TextChanged(object sender, EventArgs e)
        {
            double discount = total * (double)(nbDiscount.Value) / 100;
            txtTotal.Text = String.Format(formatVN, "{0:C0}", total - discount);
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            cdban(COT);
            loadDM();
            loadDB();
        }

        private void loadDB()
        {
            cbboxDoiBan.DisplayMember = "TenBan";
            cbboxDoiBan.ValueMember = "MaSoBan";
            cbboxDoiBan.DataSource = banCafeBUS.GetBanCafe();
        }

        public void loadDM()
        {
            cbDM.ValueMember = "MaDanhMuc";
            cbDM.DisplayMember = "Ten";
            cbDM.DataSource = dmBUS.GetDanhMuc();
        }
        public void taoban(int x, int y, BanCafe ban)
        {
            Button btn = new Button();
            this.Controls.Add(btn);

            btn.Text = ban.TenBan;
            btn.Tag = ban.MaSoBan;
            pnlBan.Controls.Add(btn);
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Red;
            btn.Size = new Size(92, 83);
            btn.Width = 92;
            btn.Location = new Point(x, y);
            btn.Click += Btn_Click1;
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            if (banChon == null)
            {
                banChon = sender as Button;
                banChon.BackColor = Color.Cyan;
            }
            else if (banChon == sender as Button)
            {
                banChon.BackColor = Color.White;
                banChon = null;
                dgv1.Rows.Clear();
                total = 0;
                txtTotal.Clear();
                return;
            }
            else
            {
                banChon.BackColor = Color.White;
                banChon = sender as Button;
                banChon.BackColor = Color.Cyan;
            }
            int masobanChon = Convert.ToInt32(banChon.Tag);
            GoiMonTT tt = gmtts.Where(Z => Z.MsBan == masobanChon).FirstOrDefault();
            if (tt == null)
            {
                dgv1.Rows.Clear();
                total = 0;
                txtTotal.Clear();
            }
            else
            {
                hienthiDSMon (tt.GetDSMonDat());
                total = tt.GetDSMonDat().Sum(t => t.thanhtien);
                txtTotal.Text = String.Format(formatVN, "{0:C0}", total);
            }
        }

        public void cdban(int SoCot)
        {
            int count = 0, x = 22, y = 59;
            foreach(BanCafe ban in banCafeBUS.GetBanCafe())
            {
                taoban(x,y,ban);
                count++;
                x += 119;
                if(count%5==0)
                {
                    y += 102;
                    x = 22;
                }
            }
        }

        private void cbboxDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = (ComboBox)sender;
            int maDanhMuc = int.Parse(cbx.SelectedValue.ToString());
            cbMon.DisplayMember = "Ten";
            cbMon.ValueMember = "MaMon";
            cbMon.DataSource = monBUS.GetMon(maDanhMuc);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (banChon == null)
            {
                MessageBox.Show("Vui long chon ban.");
                return;
            }

            if (int.Parse (nbSL.Value.ToString()) <= 0)
            {
                MessageBox.Show("Vui long them so luong.");
                return;
            }

            MonDat monDat = new MonDat();
            monDat.maMon = int.Parse(cbMon.SelectedValue.ToString());
            monDat.tenMon = cbMon.Text;
            monDat.donGia = (double) (cbMon.SelectedItem as Mon).GiaTien;
            monDat.sLuong = int.Parse(nbSL.Value.ToString());
            int msbanChon = int.Parse(banChon.Tag.ToString());
            GoiMonTT gmtt = gmtts.Where(x => x.MsBan == msbanChon).FirstOrDefault();

            if (gmtt == null)
            {
                gmtt = new GoiMonTT();
                gmtt.MsBan = msbanChon;
                gmtts.Add(gmtt);
                banChon.Image = Properties.Resources.cafe;
                banChon.ImageAlign = ContentAlignment.MiddleCenter;
            }
            gmtt.addMon(monDat);
            hienthiDSMon(gmtt.GetDSMonDat());
            total = gmtt.GetDSMonDat().Sum(t => t.thanhtien);
            txtTotal.Text = String.Format(formatVN, "{0:C0}", total);
        }

        private void hienthiDSMon (List<MonDat> monDats)
        {
            dgv1.Rows.Clear();
            foreach (MonDat item in monDats)
            {
                int rowIndex = dgv1.Rows.Add();
                dgv1.Rows[rowIndex].Cells[0].Value = item.tenMon;
                dgv1.Rows[rowIndex].Cells[1].Value = item.sLuong;
                dgv1.Rows[rowIndex].Cells[2].Value = item.donGia;
                dgv1.Rows[rowIndex].Cells[3].Value = item.thanhtien;
            }
        }

        private void nbDiscount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            if (banChon == null)
            {
                MessageBox.Show("Vui long chon ban.");
                return;
            }
            
            int msBanChon = Convert.ToInt32(banChon.Tag);
            GoiMonTT ttbchuyen = gmtts.Where(d => d.MsBan == msBanChon).FirstOrDefault();
            
            if (ttbchuyen == null)
            {
                MessageBox.Show("Khong the doi ban trong.");
                return;
            }
            int msBanDich = Convert.ToInt32(cbboxDoiBan.SelectedValue);
            if (msBanChon == msBanDich)
            {
                MessageBox.Show("Loi cung ban.");
                return;
            }

            GoiMonTT ttbdich = gmtts.Where(d => d.MsBan == msBanDich).FirstOrDefault();
            Button btnBDich = pnlBan.Controls.OfType<Button>().Where(x => x.Tag.ToString() == msBanDich.ToString()).FirstOrDefault();
            
            if (ttbdich == null)
            {
                ttbchuyen.MsBan = msBanDich;
                btnBDich.Image = Properties.Resources.cafe;
                btnBDich.ImageAlign = ContentAlignment.MiddleCenter;
                btnBDich.BackColor = Color.Green;
                banChon.BackColor = Color.White;
                banChon = btnBDich;
            }
            else
            {
                foreach (var item in ttbchuyen.GetDSMonDat())
                {
                    ttbdich.addMon(item);
                }
                gmtts.Remove(ttbchuyen);
                hienthiDSMon(ttbdich.GetDSMonDat());
            }
            btnBDich.BackColor = Color.Green;
            banChon.BackColor = Color.White;
            banChon = btnBDich;
            banChon.Image = null;
        }

        private void FrmCafe_Load(object sender, EventArgs e)
        {

        }
    }
}
