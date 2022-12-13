namespace student_learning_outcomes_management
{
    partial class frmKhoaHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoaHoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.S = new DevExpress.XtraBars.BarCheckItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbx_MH = new DevExpress.XtraEditors.LookUpEdit();
            this.cbx_GV = new DevExpress.XtraEditors.LookUpEdit();
            this.lView_Course = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKhoaHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaGiaoVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenGiaoVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaMonHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenMonHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtm_end = new DevExpress.XtraEditors.DateEdit();
            this.dtm_start = new DevExpress.XtraEditors.DateEdit();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_MH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_GV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lView_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtm_end.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtm_end.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtm_start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtm_start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.S,
            this.btnUpdate,
            this.btnDelete,
            this.btnCancel});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancel)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnUpdate.Caption = "Cập nhật";
            this.btnUpdate.Id = 2;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 3;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnCancel.Caption = "Hủy";
            this.btnCancel.Id = 4;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.LargeImage")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1121, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 529);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1121, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 499);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1121, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 499);
            // 
            // S
            // 
            this.S.Caption = "barCheckItem1";
            this.S.Id = 1;
            this.S.Name = "S";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbx_MH);
            this.layoutControl1.Controls.Add(this.cbx_GV);
            this.layoutControl1.Controls.Add(this.lView_Course);
            this.layoutControl1.Controls.Add(this.dtm_end);
            this.layoutControl1.Controls.Add(this.dtm_start);
            this.layoutControl1.Controls.Add(this.txtMaKH);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1121, 499);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbx_MH
            // 
            this.cbx_MH.Location = new System.Drawing.Point(824, 102);
            this.cbx_MH.MenuManager = this.barManager1;
            this.cbx_MH.Name = "cbx_MH";
            this.cbx_MH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_MH.Size = new System.Drawing.Size(273, 22);
            this.cbx_MH.StyleController = this.layoutControl1;
            this.cbx_MH.TabIndex = 11;
            // 
            // cbx_GV
            // 
            this.cbx_GV.Location = new System.Drawing.Point(824, 76);
            this.cbx_GV.MenuManager = this.barManager1;
            this.cbx_GV.Name = "cbx_GV";
            this.cbx_GV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_GV.Size = new System.Drawing.Size(273, 22);
            this.cbx_GV.StyleController = this.layoutControl1;
            this.cbx_GV.TabIndex = 10;
            // 
            // lView_Course
            // 
            this.lView_Course.Location = new System.Drawing.Point(12, 33);
            this.lView_Course.MainView = this.gridView1;
            this.lView_Course.MenuManager = this.barManager1;
            this.lView_Course.Name = "lView_Course";
            this.lView_Course.Size = new System.Drawing.Size(714, 454);
            this.lView_Course.TabIndex = 9;
            this.lView_Course.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.lView_Course.Click += new System.EventHandler(this.lView_Course_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.No,
            this.MaKhoaHoc,
            this.MaGiaoVien,
            this.TenGiaoVien,
            this.MaMonHoc,
            this.TenMonHoc,
            this.NgayBatDau,
            this.NgayKetThuc});
            this.gridView1.GridControl = this.lView_Course;
            this.gridView1.Name = "gridView1";
            // 
            // No
            // 
            this.No.Caption = "STT";
            this.No.FieldName = "No";
            this.No.MinWidth = 25;
            this.No.Name = "No";
            this.No.Visible = true;
            this.No.VisibleIndex = 0;
            this.No.Width = 47;
            // 
            // MaKhoaHoc
            // 
            this.MaKhoaHoc.Caption = "Mã KH";
            this.MaKhoaHoc.FieldName = "MaKhoaHoc";
            this.MaKhoaHoc.MinWidth = 25;
            this.MaKhoaHoc.Name = "MaKhoaHoc";
            this.MaKhoaHoc.Visible = true;
            this.MaKhoaHoc.VisibleIndex = 1;
            this.MaKhoaHoc.Width = 55;
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.Caption = "Mã GV";
            this.MaGiaoVien.FieldName = "MaGiaoVien";
            this.MaGiaoVien.MinWidth = 25;
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.Visible = true;
            this.MaGiaoVien.VisibleIndex = 2;
            this.MaGiaoVien.Width = 56;
            // 
            // TenGiaoVien
            // 
            this.TenGiaoVien.Caption = "Tên Giáo Viên";
            this.TenGiaoVien.FieldName = "TenGiaoVien";
            this.TenGiaoVien.MinWidth = 25;
            this.TenGiaoVien.Name = "TenGiaoVien";
            this.TenGiaoVien.Visible = true;
            this.TenGiaoVien.VisibleIndex = 3;
            this.TenGiaoVien.Width = 127;
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.Caption = "Mã MH";
            this.MaMonHoc.FieldName = "MaMonHoc";
            this.MaMonHoc.MinWidth = 25;
            this.MaMonHoc.Name = "MaMonHoc";
            this.MaMonHoc.Visible = true;
            this.MaMonHoc.VisibleIndex = 4;
            this.MaMonHoc.Width = 55;
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.Caption = "Tên Môn";
            this.TenMonHoc.FieldName = "TenMonHoc";
            this.TenMonHoc.MinWidth = 25;
            this.TenMonHoc.Name = "TenMonHoc";
            this.TenMonHoc.Visible = true;
            this.TenMonHoc.VisibleIndex = 5;
            this.TenMonHoc.Width = 120;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.Caption = "Ngày bắt đầu";
            this.NgayBatDau.FieldName = "NgayBatDau";
            this.NgayBatDau.MinWidth = 25;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Visible = true;
            this.NgayBatDau.VisibleIndex = 6;
            this.NgayBatDau.Width = 112;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.Caption = "Ngày Kết Thúc";
            this.NgayKetThuc.FieldName = "NgayKetThuc";
            this.NgayKetThuc.MinWidth = 25;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Visible = true;
            this.NgayKetThuc.VisibleIndex = 7;
            this.NgayKetThuc.Width = 112;
            // 
            // dtm_end
            // 
            this.dtm_end.EditValue = null;
            this.dtm_end.Location = new System.Drawing.Point(824, 154);
            this.dtm_end.MenuManager = this.barManager1;
            this.dtm_end.Name = "dtm_end";
            this.dtm_end.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtm_end.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtm_end.Size = new System.Drawing.Size(273, 22);
            this.dtm_end.StyleController = this.layoutControl1;
            this.dtm_end.TabIndex = 8;
            // 
            // dtm_start
            // 
            this.dtm_start.EditValue = null;
            this.dtm_start.Location = new System.Drawing.Point(824, 128);
            this.dtm_start.MenuManager = this.barManager1;
            this.dtm_start.Name = "dtm_start";
            this.dtm_start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtm_start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtm_start.Size = new System.Drawing.Size(273, 22);
            this.dtm_start.StyleController = this.layoutControl1;
            this.dtm_start.TabIndex = 7;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(824, 50);
            this.txtMaKH.MenuManager = this.barManager1;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(273, 22);
            this.txtMaKH.StyleController = this.layoutControl1;
            this.txtMaKH.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1121, 499);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.lView_Course;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(718, 479);
            this.layoutControlItem6.Text = "Danh sách khóa học";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(146, 18);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(718, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(383, 479);
            this.layoutControlGroup1.Text = "Thông tin khóa học";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMaKH;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(359, 26);
            this.layoutControlItem1.Text = "Mã khóa học";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(77, 16);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbx_GV;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(359, 26);
            this.layoutControlItem2.Text = "Giáo Viên";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 16);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbx_MH;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(359, 26);
            this.layoutControlItem3.Text = "Môn học";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 16);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dtm_start;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(359, 26);
            this.layoutControlItem4.Text = "Ngày bắt đầu";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(77, 16);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dtm_end;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(359, 325);
            this.layoutControlItem5.Text = "Ngày kết thúc";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(77, 16);
            this.layoutControlItem5.TextToControlDistance = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 549);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKhoaHoc";
            this.Text = "Quản lý khóa học";
            this.Load += new System.EventHandler(this.frmKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbx_MH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_GV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lView_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtm_end.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtm_end.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtm_start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtm_start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl lView_Course;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dtm_end;
        private DevExpress.XtraEditors.DateEdit dtm_start;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraBars.BarCheckItem S;
        private DevExpress.XtraEditors.LookUpEdit cbx_MH;
        private DevExpress.XtraEditors.LookUpEdit cbx_GV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn No;
        private DevExpress.XtraGrid.Columns.GridColumn MaKhoaHoc;
        private DevExpress.XtraGrid.Columns.GridColumn MaGiaoVien;
        private DevExpress.XtraGrid.Columns.GridColumn TenGiaoVien;
        private DevExpress.XtraGrid.Columns.GridColumn MaMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn TenMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn NgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKetThuc;
    }
}