
namespace VisibilityBindingDemo
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.visibilityBinderBars1 = new VisibilityBinding.VisibilityBinderBars(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testRecordListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barStaticItem2,
            this.barButtonItem1,
            this.barStaticItem3,
            this.barStaticItem4,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            // 
            // bar3
            // 
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem4)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            // 
            // gridControl1
            // 
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(665, 258);
            // 
            // colId
            // 
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colWeekday
            // 
            this.colWeekday.OptionsColumn.AllowEdit = false;
            // 
            // colEvent
            // 
            this.colEvent.OptionsColumn.AllowEdit = false;
            // 
            // colAssistant
            // 
            this.colAssistant.OptionsColumn.AllowEdit = false;
            // 
            // colEventVisible
            // 
            this.colEventVisible.OptionsColumn.AllowFocus = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 29);
            this.splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            this.splitContainerControl1.Size = new System.Drawing.Size(665, 258);
            this.splitContainerControl1.SplitterPosition = 181;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem1.Caption = "Event:";
            this.barStaticItem1.DataBindings.Add(new System.Windows.Forms.Binding("Visibility", this.testRecordListBindingSource, "EventVisible", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            this.visibilityBinderBars1.SetVisibilityBindToBool(this.barStaticItem1, true);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.DataBindings.Add(new System.Windows.Forms.Binding("Caption", this.testRecordListBindingSource, "Event", true));
            this.barStaticItem2.DataBindings.Add(new System.Windows.Forms.Binding("Visibility", this.testRecordListBindingSource, "EventVisible", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.barStaticItem2.Id = 4;
            this.barStaticItem2.Name = "barStaticItem2";
            this.visibilityBinderBars1.SetVisibilityBindToBool(this.barStaticItem2, true);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "Event Button";
            this.barButtonItem1.DataBindings.Add(new System.Windows.Forms.Binding("Visibility", this.testRecordListBindingSource, "EventVisible", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            this.visibilityBinderBars1.SetVisibilityBindToBool(this.barButtonItem1, true);
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem3.Caption = "Assistant:";
            this.barStaticItem3.DataBindings.Add(new System.Windows.Forms.Binding("Visibility", this.testRecordListBindingSource, "AssistantVisible", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.barStaticItem3.Id = 6;
            this.barStaticItem3.Name = "barStaticItem3";
            this.visibilityBinderBars1.SetVisibilityBindToBool(this.barStaticItem3, true);
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.DataBindings.Add(new System.Windows.Forms.Binding("Caption", this.testRecordListBindingSource, "Assistant", true));
            this.barStaticItem4.DataBindings.Add(new System.Windows.Forms.Binding("Visibility", this.testRecordListBindingSource, "AssistantVisible", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.barStaticItem4.Id = 7;
            this.barStaticItem4.Name = "barStaticItem4";
            this.visibilityBinderBars1.SetVisibilityBindToBool(this.barStaticItem4, true);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem2.Caption = "Assistant Button";
            this.barButtonItem2.DataBindings.Add(new System.Windows.Forms.Binding("Visibility", this.testRecordListBindingSource, "AssistantVisible", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.Name = "barButtonItem2";
            this.visibilityBinderBars1.SetVisibilityBindToBool(this.barButtonItem2, true);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(665, 312);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Form2.IconOptions.Icon")));
            this.Name = "Form2";
            this.Text = "Form 2: Visibility Binding with BarItems";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testRecordListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private VisibilityBinding.VisibilityBinderBars visibilityBinderBars1;
    }
}
