namespace student_learning_outcomes_management
{
    partial class frmMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEditSoTietThucHanh = new DevExpress.XtraEditors.TextEdit();
            this.textEditSoTietLyThuyet = new DevExpress.XtraEditors.TextEdit();
            this.textEditTenMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.tMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaMonHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenMonHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTietLyThuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTietThucHanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditMaMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemMaMonHoc = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoTietThucHanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoTietLyThuyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMaMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAdd,
            this.barButtonItemUpdate,
            this.barButtonItemDelete,
            this.barButtonItemCancel});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 4;
            this.barManager.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.Caption = "Thêm";
            this.barButtonItemAdd.Id = 0;
            this.barButtonItemAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemAdd.ImageOptions.Image")));
            this.barButtonItemAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemAdd.ImageOptions.LargeImage")));
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItemUpdate
            // 
            this.barButtonItemUpdate.Caption = "Cập nhật";
            this.barButtonItemUpdate.Id = 1;
            this.barButtonItemUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemUpdate.ImageOptions.Image")));
            this.barButtonItemUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemUpdate.ImageOptions.LargeImage")));
            this.barButtonItemUpdate.Name = "barButtonItemUpdate";
            this.barButtonItemUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUpdate_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Xóa";
            this.barButtonItemDelete.Id = 2;
            this.barButtonItemDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDelete.ImageOptions.Image")));
            this.barButtonItemDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemDelete.ImageOptions.LargeImage")));
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            // 
            // barButtonItemCancel
            // 
            this.barButtonItemCancel.Caption = "Hủy";
            this.barButtonItemCancel.Id = 3;
            this.barButtonItemCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemCancel.ImageOptions.Image")));
            this.barButtonItemCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemCancel.ImageOptions.LargeImage")));
            this.barButtonItemCancel.Name = "barButtonItemCancel";
            this.barButtonItemCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCancel_ItemClick);
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
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1194, 56);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 623);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1194, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 56);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 567);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1194, 56);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 567);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEditSoTietThucHanh);
            this.layoutControl1.Controls.Add(this.textEditSoTietLyThuyet);
            this.layoutControl1.Controls.Add(this.textEditTenMonHoc);
            this.layoutControl1.Controls.Add(this.gridControl);
            this.layoutControl1.Controls.Add(this.textEditMaMonHoc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 56);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1194, 567);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEditSoTietThucHanh
            // 
            this.textEditSoTietThucHanh.Location = new System.Drawing.Point(839, 170);
            this.textEditSoTietThucHanh.MenuManager = this.barManager;
            this.textEditSoTietThucHanh.Name = "textEditSoTietThucHanh";
            this.textEditSoTietThucHanh.Size = new System.Drawing.Size(309, 22);
            this.textEditSoTietThucHanh.StyleController = this.layoutControl1;
            this.textEditSoTietThucHanh.TabIndex = 8;
            // 
            // textEditSoTietLyThuyet
            // 
            this.textEditSoTietLyThuyet.Location = new System.Drawing.Point(839, 132);
            this.textEditSoTietLyThuyet.MenuManager = this.barManager;
            this.textEditSoTietLyThuyet.Name = "textEditSoTietLyThuyet";
            this.textEditSoTietLyThuyet.Size = new System.Drawing.Size(309, 22);
            this.textEditSoTietLyThuyet.StyleController = this.layoutControl1;
            this.textEditSoTietLyThuyet.TabIndex = 7;
            // 
            // textEditTenMonHoc
            // 
            this.textEditTenMonHoc.Location = new System.Drawing.Point(839, 94);
            this.textEditTenMonHoc.MenuManager = this.barManager;
            this.textEditTenMonHoc.Name = "textEditTenMonHoc";
            this.textEditTenMonHoc.Size = new System.Drawing.Size(309, 22);
            this.textEditTenMonHoc.StyleController = this.layoutControl1;
            this.textEditTenMonHoc.TabIndex = 6;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.tMonHocBindingSource;
            this.gridControl.Location = new System.Drawing.Point(12, 31);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.barManager;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(665, 524);
            this.gridControl.TabIndex = 5;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // tMonHocBindingSource
            // 
            this.tMonHocBindingSource.DataSource = typeof(student_learning_outcomes_management.tMonHoc);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaMonHoc,
            this.colTenMonHoc,
            this.colSoTietLyThuyet,
            this.colSoTietThucHanh});
            this.gridView.CustomizationFormBounds = new System.Drawing.Rectangle(1153, 560, 326, 271);
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            // 
            // colMaMonHoc
            // 
            this.colMaMonHoc.Caption = "Mã môn học";
            this.colMaMonHoc.FieldName = "MaMonHoc";
            this.colMaMonHoc.MinWidth = 25;
            this.colMaMonHoc.Name = "colMaMonHoc";
            this.colMaMonHoc.Visible = true;
            this.colMaMonHoc.VisibleIndex = 0;
            this.colMaMonHoc.Width = 130;
            // 
            // colTenMonHoc
            // 
            this.colTenMonHoc.Caption = "Tên môn học";
            this.colTenMonHoc.FieldName = "TenMonHoc";
            this.colTenMonHoc.MinWidth = 25;
            this.colTenMonHoc.Name = "colTenMonHoc";
            this.colTenMonHoc.Visible = true;
            this.colTenMonHoc.VisibleIndex = 1;
            this.colTenMonHoc.Width = 200;
            // 
            // colSoTietLyThuyet
            // 
            this.colSoTietLyThuyet.Caption = "Số tiết lý thuyết";
            this.colSoTietLyThuyet.FieldName = "SoTietLyThuyet";
            this.colSoTietLyThuyet.MinWidth = 25;
            this.colSoTietLyThuyet.Name = "colSoTietLyThuyet";
            this.colSoTietLyThuyet.Visible = true;
            this.colSoTietLyThuyet.VisibleIndex = 2;
            this.colSoTietLyThuyet.Width = 100;
            // 
            // colSoTietThucHanh
            // 
            this.colSoTietThucHanh.Caption = "Số tiết thực hành";
            this.colSoTietThucHanh.FieldName = "SoTietThucHanh";
            this.colSoTietThucHanh.MinWidth = 25;
            this.colSoTietThucHanh.Name = "colSoTietThucHanh";
            this.colSoTietThucHanh.Visible = true;
            this.colSoTietThucHanh.VisibleIndex = 3;
            this.colSoTietThucHanh.Width = 100;
            // 
            // textEditMaMonHoc
            // 
            this.textEditMaMonHoc.Location = new System.Drawing.Point(839, 56);
            this.textEditMaMonHoc.MenuManager = this.barManager;
            this.textEditMaMonHoc.Name = "textEditMaMonHoc";
            this.textEditMaMonHoc.Size = new System.Drawing.Size(309, 22);
            this.textEditMaMonHoc.StyleController = this.layoutControl1;
            this.textEditMaMonHoc.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1194, 567);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(669, 202);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(505, 345);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(669, 547);
            this.layoutControlItem2.Text = "Danh sách môn học";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(112, 16);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItemMaMonHoc});
            this.layoutControlGroup1.Location = new System.Drawing.Point(669, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(505, 202);
            this.layoutControlGroup1.Text = "Thông tin môn học";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEditSoTietThucHanh;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 114);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(24, 24, 8, 8);
            this.layoutControlItem4.Size = new System.Drawing.Size(481, 38);
            this.layoutControlItem4.Text = "Số tiết thực hành";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(112, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEditSoTietLyThuyet;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(24, 24, 8, 8);
            this.layoutControlItem3.Size = new System.Drawing.Size(481, 38);
            this.layoutControlItem3.Text = "Số tiết lý thuyết";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(112, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEditTenMonHoc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 38);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(24, 24, 8, 8);
            this.layoutControlItem1.Size = new System.Drawing.Size(481, 38);
            this.layoutControlItem1.Text = "Tên môn học";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(112, 16);
            // 
            // layoutControlItemMaMonHoc
            // 
            this.layoutControlItemMaMonHoc.Control = this.textEditMaMonHoc;
            this.layoutControlItemMaMonHoc.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemMaMonHoc.Name = "layoutControlItemMaMonHoc";
            this.layoutControlItemMaMonHoc.Padding = new DevExpress.XtraLayout.Utils.Padding(24, 24, 8, 8);
            this.layoutControlItemMaMonHoc.Size = new System.Drawing.Size(481, 38);
            this.layoutControlItemMaMonHoc.Text = "Mã môn học";
            this.layoutControlItemMaMonHoc.TextSize = new System.Drawing.Size(112, 16);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 644);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "frmMonHoc";
            this.Text = "frmMonHoc";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoTietThucHanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoTietLyThuyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMaMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.TextEdit textEditMaMonHoc;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemMaMonHoc;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource tMonHocBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTietLyThuyet;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTietThucHanh;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUpdate;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCancel;
        private DevExpress.XtraEditors.TextEdit textEditSoTietThucHanh;
        private DevExpress.XtraEditors.TextEdit textEditSoTietLyThuyet;
        private DevExpress.XtraEditors.TextEdit textEditTenMonHoc;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}