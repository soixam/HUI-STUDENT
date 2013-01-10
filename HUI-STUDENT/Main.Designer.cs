namespace HUI_STUDENT
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Tồng môn tính");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Tổng tín chỉ tính");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Tỷ lệ Giỏi");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Tỷ lệ Khá");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Tỷ lệ TB");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Tỷ lệ TBY");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Tích lũy hệ 10");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Tích lũy hệ 4");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Xếp loại");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.wb = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTinhLai = new System.Windows.Forms.Button();
            this.lvThongTin = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbSinhVien = new System.Windows.Forms.PictureBox();
            this.txtMaXN = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btnTichLuy = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvMonHoc = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmMonHoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bỏQuaMônNàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvMonBo = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmMonBo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.wbinfo = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ctmMonHoc.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ctmMonBo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wb
            // 
            this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb.IsWebBrowserContextMenuEnabled = false;
            this.wb.Location = new System.Drawing.Point(3, 3);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(577, 441);
            this.wb.TabIndex = 0;
            this.wb.Url = new System.Uri("http://www.iuh.edu.vn/ketquahoctap/Default.aspx", System.UriKind.Absolute);
            this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wb_DocumentCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTinhLai);
            this.groupBox1.Controls.Add(this.lvThongTin);
            this.groupBox1.Controls.Add(this.pbSinhVien);
            this.groupBox1.Controls.Add(this.txtMaXN);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblMSSV);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.btnTichLuy);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(580, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 441);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnTinhLai
            // 
            this.btnTinhLai.Location = new System.Drawing.Point(103, 81);
            this.btnTinhLai.Name = "btnTinhLai";
            this.btnTinhLai.Size = new System.Drawing.Size(75, 23);
            this.btnTinhLai.TabIndex = 7;
            this.btnTinhLai.Text = "Tính lại";
            this.btnTinhLai.UseVisualStyleBackColor = true;
            this.btnTinhLai.Visible = false;
            this.btnTinhLai.Click += new System.EventHandler(this.btnTinhLai_Click);
            // 
            // lvThongTin
            // 
            this.lvThongTin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.lvThongTin.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.lvThongTin.Location = new System.Drawing.Point(3, 252);
            this.lvThongTin.Name = "lvThongTin";
            this.lvThongTin.Size = new System.Drawing.Size(192, 183);
            this.lvThongTin.TabIndex = 6;
            this.lvThongTin.UseCompatibleStateImageBehavior = false;
            this.lvThongTin.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Thông tin";
            this.columnHeader8.Width = 94;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "KQ";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 84;
            // 
            // pbSinhVien
            // 
            this.pbSinhVien.Image = global::HUI_STUDENT.Properties.Resources.graduated;
            this.pbSinhVien.Location = new System.Drawing.Point(55, 110);
            this.pbSinhVien.Name = "pbSinhVien";
            this.pbSinhVien.Size = new System.Drawing.Size(97, 136);
            this.pbSinhVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSinhVien.TabIndex = 5;
            this.pbSinhVien.TabStop = false;
            // 
            // txtMaXN
            // 
            this.txtMaXN.Location = new System.Drawing.Point(94, 46);
            this.txtMaXN.Name = "txtMaXN";
            this.txtMaXN.Size = new System.Drawing.Size(70, 20);
            this.txtMaXN.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 20);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(19, 22);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(39, 13);
            this.lblMSSV.TabIndex = 2;
            this.lblMSSV.Text = "Mã số:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(94, 19);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(70, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // btnTichLuy
            // 
            this.btnTichLuy.Enabled = false;
            this.btnTichLuy.Location = new System.Drawing.Point(22, 81);
            this.btnTichLuy.Name = "btnTichLuy";
            this.btnTichLuy.Size = new System.Drawing.Size(75, 23);
            this.btnTichLuy.TabIndex = 0;
            this.btnTichLuy.Text = "Đợi chút...";
            this.btnTichLuy.UseVisualStyleBackColor = true;
            this.btnTichLuy.Click += new System.EventHandler(this.btnTichLuy_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Red;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(577, 441);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvMonHoc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 441);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách môn học";
            // 
            // lvMonHoc
            // 
            this.lvMonHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMonHoc.ContextMenuStrip = this.ctmMonHoc;
            this.lvMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMonHoc.FullRowSelect = true;
            this.lvMonHoc.Location = new System.Drawing.Point(3, 16);
            this.lvMonHoc.MultiSelect = false;
            this.lvMonHoc.Name = "lvMonHoc";
            this.lvMonHoc.Size = new System.Drawing.Size(279, 422);
            this.lvMonHoc.TabIndex = 0;
            this.lvMonHoc.UseCompatibleStateImageBehavior = false;
            this.lvMonHoc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Mã môn";
            this.columnHeader0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Môn học";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tín chỉ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "KQ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 40;
            // 
            // ctmMonHoc
            // 
            this.ctmMonHoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bỏQuaMônNàyToolStripMenuItem});
            this.ctmMonHoc.Name = "ctmMonHoc";
            this.ctmMonHoc.Size = new System.Drawing.Size(163, 26);
            // 
            // bỏQuaMônNàyToolStripMenuItem
            // 
            this.bỏQuaMônNàyToolStripMenuItem.Name = "bỏQuaMônNàyToolStripMenuItem";
            this.bỏQuaMônNàyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.bỏQuaMônNàyToolStripMenuItem.Text = "Bỏ qua môn này";
            this.bỏQuaMônNàyToolStripMenuItem.Click += new System.EventHandler(this.bỏQuaMônNàyToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.lvMonBo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 441);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách môn bỏ qua";
            // 
            // lvMonBo
            // 
            this.lvMonBo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvMonBo.ContextMenuStrip = this.ctmMonBo;
            this.lvMonBo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMonBo.FullRowSelect = true;
            this.lvMonBo.Location = new System.Drawing.Point(3, 16);
            this.lvMonBo.MultiSelect = false;
            this.lvMonBo.Name = "lvMonBo";
            this.lvMonBo.Size = new System.Drawing.Size(282, 422);
            this.lvMonBo.TabIndex = 0;
            this.lvMonBo.UseCompatibleStateImageBehavior = false;
            this.lvMonBo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã môn";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Môn học";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tín chỉ";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "KQ";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 40;
            // 
            // ctmMonBo
            // 
            this.ctmMonBo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.ctmMonBo.Name = "ctmMonBo";
            this.ctmMonBo.Size = new System.Drawing.Size(120, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem1.Text = "Loại bỏ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 473);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.wb);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Xem điểm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.wbinfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // wbinfo
            // 
            this.wbinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbinfo.IsWebBrowserContextMenuEnabled = false;
            this.wbinfo.Location = new System.Drawing.Point(3, 3);
            this.wbinfo.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbinfo.Name = "wbinfo";
            this.wbinfo.Size = new System.Drawing.Size(778, 441);
            this.wbinfo.TabIndex = 0;
            this.wbinfo.Url = new System.Uri("http://tichluy.net/hui-student.html", System.UriKind.Absolute);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 473);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "HUI-STUDENT";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ctmMonHoc.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ctmMonBo.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTichLuy;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.TextBox txtMaXN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvMonHoc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvMonBo;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ContextMenuStrip ctmMonHoc;
        private System.Windows.Forms.ToolStripMenuItem bỏQuaMônNàyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctmMonBo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbSinhVien;
        private System.Windows.Forms.ListView lvThongTin;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser wbinfo;
        private System.Windows.Forms.Button btnTinhLai;
    }
}

