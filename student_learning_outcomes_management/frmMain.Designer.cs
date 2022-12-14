namespace student_learning_outcomes_management
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItemKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItemGiaoVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemKhoaHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemKetQua = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barButtonItemDSSinhVienKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCongTacGiangDay = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemBangDiemKhoaHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemBangDiemSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Tiện ích";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
            this.skinPaletteRibbonGalleryBarItem1.Id = 22;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Trang chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonGroup1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonGroup2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 7;
            this.barButtonGroup1.ItemLinks.Add(this.barButtonItemKhoa);
            this.barButtonGroup1.ItemLinks.Add(this.barButtonItemMonHoc);
            this.barButtonGroup1.ItemLinks.Add(this.barButtonItemSinhVien);
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItemKhoa
            // 
            this.barButtonItemKhoa.Caption = "Khoa";
            this.barButtonItemKhoa.Id = 9;
            this.barButtonItemKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemKhoa.ImageOptions.Image")));
            this.barButtonItemKhoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemKhoa.ImageOptions.LargeImage")));
            this.barButtonItemKhoa.Name = "barButtonItemKhoa";
            this.barButtonItemKhoa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barButtonItemKhoa.SmallWithTextWidth = 100;
            this.barButtonItemKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemKhoa_ItemClick);
            // 
            // barButtonItemMonHoc
            // 
            this.barButtonItemMonHoc.Caption = "Môn học";
            this.barButtonItemMonHoc.Id = 28;
            this.barButtonItemMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemMonHoc.ImageOptions.Image")));
            this.barButtonItemMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemMonHoc.ImageOptions.LargeImage")));
            this.barButtonItemMonHoc.Name = "barButtonItemMonHoc";
            this.barButtonItemMonHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barButtonItemMonHoc.SmallWithTextWidth = 100;
            this.barButtonItemMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMonHoc_ItemClick);
            // 
            // barButtonItemSinhVien
            // 
            this.barButtonItemSinhVien.Caption = "Sinh viên";
            this.barButtonItemSinhVien.Id = 11;
            this.barButtonItemSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemSinhVien.ImageOptions.Image")));
            this.barButtonItemSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemSinhVien.ImageOptions.LargeImage")));
            this.barButtonItemSinhVien.Name = "barButtonItemSinhVien";
            this.barButtonItemSinhVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barButtonItemSinhVien.SmallWithTextWidth = 100;
            this.barButtonItemSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSinhVien_ItemClick);
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Caption = "barButtonGroup2";
            this.barButtonGroup2.Id = 8;
            this.barButtonGroup2.ItemLinks.Add(this.barButtonItemGiaoVien);
            this.barButtonGroup2.ItemLinks.Add(this.barButtonItemKhoaHoc);
            this.barButtonGroup2.ItemLinks.Add(this.barButtonItemKetQua);
            this.barButtonGroup2.Name = "barButtonGroup2";
            // 
            // barButtonItemGiaoVien
            // 
            this.barButtonItemGiaoVien.Caption = "Giáo viên";
            this.barButtonItemGiaoVien.Id = 12;
            this.barButtonItemGiaoVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemGiaoVien.ImageOptions.Image")));
            this.barButtonItemGiaoVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemGiaoVien.ImageOptions.LargeImage")));
            this.barButtonItemGiaoVien.Name = "barButtonItemGiaoVien";
            this.barButtonItemGiaoVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barButtonItemGiaoVien.SmallWithTextWidth = 100;
            this.barButtonItemGiaoVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemGiaoVien_ItemClick);
            // 
            // barButtonItemKhoaHoc
            // 
            this.barButtonItemKhoaHoc.Caption = "Khóa học";
            this.barButtonItemKhoaHoc.Id = 13;
            this.barButtonItemKhoaHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemKhoaHoc.ImageOptions.Image")));
            this.barButtonItemKhoaHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemKhoaHoc.ImageOptions.LargeImage")));
            this.barButtonItemKhoaHoc.Name = "barButtonItemKhoaHoc";
            this.barButtonItemKhoaHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barButtonItemKhoaHoc.SmallWithTextWidth = 100;
            this.barButtonItemKhoaHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemKhoaHoc_ItemClick);
            // 
            // barButtonItemKetQua
            // 
            this.barButtonItemKetQua.Caption = "Kết quả";
            this.barButtonItemKetQua.Id = 14;
            this.barButtonItemKetQua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemKetQua.ImageOptions.Image")));
            this.barButtonItemKetQua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemKetQua.ImageOptions.LargeImage")));
            this.barButtonItemKetQua.Name = "barButtonItemKetQua";
            this.barButtonItemKetQua.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barButtonItemKetQua.SmallWithTextWidth = 100;
            this.barButtonItemKetQua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemKetQua_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barLinkContainerItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "In ấn";
            // 
            // barLinkContainerItem1
            // 
            this.barLinkContainerItem1.Caption = "Tạo in ấn";
            this.barLinkContainerItem1.Id = 23;
            this.barLinkContainerItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barLinkContainerItem1.ImageOptions.Image")));
            this.barLinkContainerItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLinkContainerItem1.ImageOptions.LargeImage")));
            this.barLinkContainerItem1.LargeWidth = 100;
            this.barLinkContainerItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemDSSinhVienKhoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemCongTacGiangDay, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemBangDiemKhoaHoc, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemBangDiemSinhVien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // barButtonItemDSSinhVienKhoa
            // 
            this.barButtonItemDSSinhVienKhoa.Caption = "Danh sách sinh viên Khoa";
            this.barButtonItemDSSinhVienKhoa.Id = 24;
            this.barButtonItemDSSinhVienKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDSSinhVienKhoa.ImageOptions.Image")));
            this.barButtonItemDSSinhVienKhoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemDSSinhVienKhoa.ImageOptions.LargeImage")));
            this.barButtonItemDSSinhVienKhoa.Name = "barButtonItemDSSinhVienKhoa";
            this.barButtonItemDSSinhVienKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDSSinhVienKhoa_ItemClick);
            // 
            // barButtonItemCongTacGiangDay
            // 
            this.barButtonItemCongTacGiangDay.Caption = "Công tác giảng dạy";
            this.barButtonItemCongTacGiangDay.Id = 25;
            this.barButtonItemCongTacGiangDay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemCongTacGiangDay.ImageOptions.Image")));
            this.barButtonItemCongTacGiangDay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemCongTacGiangDay.ImageOptions.LargeImage")));
            this.barButtonItemCongTacGiangDay.Name = "barButtonItemCongTacGiangDay";
            this.barButtonItemCongTacGiangDay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCongTacGiangDay_ItemClick);
            // 
            // barButtonItemBangDiemKhoaHoc
            // 
            this.barButtonItemBangDiemKhoaHoc.Caption = "Bảng điểm khóa học";
            this.barButtonItemBangDiemKhoaHoc.Id = 26;
            this.barButtonItemBangDiemKhoaHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemBangDiemKhoaHoc.ImageOptions.Image")));
            this.barButtonItemBangDiemKhoaHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemBangDiemKhoaHoc.ImageOptions.LargeImage")));
            this.barButtonItemBangDiemKhoaHoc.Name = "barButtonItemBangDiemKhoaHoc";
            this.barButtonItemBangDiemKhoaHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemBangDiemKhoaHoc_ItemClick);
            // 
            // barButtonItemBangDiemSinhVien
            // 
            this.barButtonItemBangDiemSinhVien.Caption = "Bảng điểm sinh viên";
            this.barButtonItemBangDiemSinhVien.Id = 27;
            this.barButtonItemBangDiemSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemBangDiemSinhVien.ImageOptions.Image")));
            this.barButtonItemBangDiemSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemBangDiemSinhVien.ImageOptions.LargeImage")));
            this.barButtonItemBangDiemSinhVien.Name = "barButtonItemBangDiemSinhVien";
            this.barButtonItemBangDiemSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemBangDiemSinhVien_ItemClick);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "Môn học";
            this.barCheckItem1.Id = 10;
            this.barCheckItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barCheckItem1.ImageOptions.Image")));
            this.barCheckItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barCheckItem1.ImageOptions.LargeImage")));
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barCheckItem1.SmallWithTextWidth = 100;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Tạo bản in";
            this.barButtonItem6.Id = 15;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.LargeWidth = 100;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 18;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Id = 29;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonGroup1,
            this.barButtonGroup2,
            this.barButtonItemKhoa,
            this.barCheckItem1,
            this.barButtonItemSinhVien,
            this.barButtonItemGiaoVien,
            this.barButtonItemKhoaHoc,
            this.barButtonItemKetQua,
            this.barButtonItem6,
            this.skinRibbonGalleryBarItem1,
            this.skinPaletteRibbonGalleryBarItem1,
            this.barLinkContainerItem1,
            this.barButtonItemDSSinhVienKhoa,
            this.barButtonItemCongTacGiangDay,
            this.barButtonItemBangDiemKhoaHoc,
            this.barButtonItemBangDiemSinhVien,
            this.barButtonItemMonHoc,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 31;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barButtonItem2);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1498, 183);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thoát";
            this.barButtonItem2.Id = 30;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 613);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Quản lý hệ thống trường đại học - 52000650 Hoàng Đức Duy - 52000651 Huỳnh Kiên Du" +
    "y";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemKhoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMonHoc;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSinhVien;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGiaoVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItemKhoaHoc;
        private DevExpress.XtraBars.BarButtonItem barButtonItemKetQua;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDSSinhVienKhoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCongTacGiangDay;
        private DevExpress.XtraBars.BarButtonItem barButtonItemBangDiemKhoaHoc;
        private DevExpress.XtraBars.BarButtonItem barButtonItemBangDiemSinhVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}