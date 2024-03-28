namespace QuanLyQuanCF.Presentation
{
    partial class FrmCafe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCafe));
            this.mnuQuanLy = new System.Windows.Forms.MenuStrip();
            this.smnuQuanly = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clomSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDM = new System.Windows.Forms.ComboBox();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nbDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nbSL = new System.Windows.Forms.NumericUpDown();
            this.cbboxDoiBan = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.pnlBan = new System.Windows.Forms.Panel();
            this.mnuQuanLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSL)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuQuanLy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnuQuanly,
            this.tàiKhoảnToolStripMenuItem});
            this.mnuQuanLy.Location = new System.Drawing.Point(0, 0);
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(1924, 31);
            this.mnuQuanLy.TabIndex = 0;
            this.mnuQuanLy.Text = "menuStrip1";
            // 
            // smnuQuanly
            // 
            this.smnuQuanly.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.smnuQuanly.Name = "smnuQuanly";
            this.smnuQuanly.Size = new System.Drawing.Size(85, 27);
            this.smnuQuanly.Text = "Quản lý";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(101, 27);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv1.ColumnHeadersHeight = 29;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenMon,
            this.clomSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.dgv1.Location = new System.Drawing.Point(1259, 197);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.Size = new System.Drawing.Size(824, 377);
            this.dgv1.TabIndex = 31;
            // 
            // colTenMon
            // 
            this.colTenMon.HeaderText = "Tên món";
            this.colTenMon.MinimumWidth = 6;
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            this.colTenMon.Width = 165;
            // 
            // clomSoLuong
            // 
            this.clomSoLuong.HeaderText = "Số Lượng";
            this.clomSoLuong.MinimumWidth = 6;
            this.clomSoLuong.Name = "clomSoLuong";
            this.clomSoLuong.ReadOnly = true;
            this.clomSoLuong.Width = 140;
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            this.colDonGia.Width = 140;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 140;
            // 
            // cbDM
            // 
            this.cbDM.FormattingEnabled = true;
            this.cbDM.Location = new System.Drawing.Point(1346, 97);
            this.cbDM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDM.Name = "cbDM";
            this.cbDM.Size = new System.Drawing.Size(217, 24);
            this.cbDM.TabIndex = 32;
            this.cbDM.SelectedIndexChanged += new System.EventHandler(this.cbboxDanhMuc_SelectedIndexChanged);
            // 
            // cbMon
            // 
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(1346, 142);
            this.cbMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(217, 24);
            this.cbMon.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1247, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Danh mục:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1255, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Món:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1739, 595);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(159, 22);
            this.txtTotal.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1639, 597);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1315, 615);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Giảm giá:";
            // 
            // nbDiscount
            // 
            this.nbDiscount.Location = new System.Drawing.Point(1416, 615);
            this.nbDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nbDiscount.Name = "nbDiscount";
            this.nbDiscount.Size = new System.Drawing.Size(160, 22);
            this.nbDiscount.TabIndex = 40;
            this.nbDiscount.ValueChanged += new System.EventHandler(this.nbDiscount_ValueChanged);
            // 
            // btnDB
            // 
            this.btnDB.BackColor = System.Drawing.Color.Lime;
            this.btnDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDB.Location = new System.Drawing.Point(1319, 655);
            this.btnDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(69, 39);
            this.btnDB.TabIndex = 41;
            this.btnDB.Text = "Đổi bàn";
            this.btnDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDB.UseVisualStyleBackColor = false;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1605, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Số lượng:";
            // 
            // nbSL
            // 
            this.nbSL.Location = new System.Drawing.Point(1692, 98);
            this.nbSL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nbSL.Name = "nbSL";
            this.nbSL.Size = new System.Drawing.Size(80, 22);
            this.nbSL.TabIndex = 46;
            // 
            // cbboxDoiBan
            // 
            this.cbboxDoiBan.FormattingEnabled = true;
            this.cbboxDoiBan.Location = new System.Drawing.Point(1416, 664);
            this.cbboxDoiBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbboxDoiBan.Name = "cbboxDoiBan";
            this.cbboxDoiBan.Size = new System.Drawing.Size(160, 24);
            this.cbboxDoiBan.TabIndex = 47;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Lime;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(1728, 641);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(167, 95);
            this.btnPay.TabIndex = 43;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Lime;
            this.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Image = global::QuanLyQuanCF.Properties.Resources.sign_add_icon;
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdd.Location = new System.Drawing.Point(1822, 61);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btAdd.Size = new System.Drawing.Size(167, 105);
            this.btAdd.TabIndex = 36;
            this.btAdd.Text = "Thêm món";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // pnlBan
            // 
            this.pnlBan.Location = new System.Drawing.Point(16, 49);
            this.pnlBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBan.Name = "pnlBan";
            this.pnlBan.Size = new System.Drawing.Size(1223, 785);
            this.pnlBan.TabIndex = 48;
            // 
            // FrmCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1924, 804);
            this.Controls.Add(this.pnlBan);
            this.Controls.Add(this.cbboxDoiBan);
            this.Controls.Add(this.nbSL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnDB);
            this.Controls.Add(this.nbDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMon);
            this.Controls.Add(this.cbDM);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.mnuQuanLy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuQuanLy;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCafe";
            this.Text = "Màn Hình Bán Hàng";
            this.Load += new System.EventHandler(this.FrmCafe_Load);
            this.mnuQuanLy.ResumeLayout(false);
            this.mnuQuanLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem smnuQuanly;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ComboBox cbDM;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nbDiscount;
        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nbSL;
        private System.Windows.Forms.ComboBox cbboxDoiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clomSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Panel pnlBan;
    }
}