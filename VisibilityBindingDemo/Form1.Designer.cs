
namespace VisibilityBindingDemo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.WeekdayTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EventTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AssistantTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EventVisibleCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.AssistantVisibleCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWeekday = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEvent = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAssistant = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEventVisible = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAssistantVisible = new DevExpress.XtraLayout.LayoutControlItem();
            this.visibilityBinderLayoutItem1 = new VisibilityBinding.VisibilityBinderLayout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testRecordListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeekdayTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssistantTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventVisibleCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssistantVisibleCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWeekday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssistant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEventVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssistantVisible)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            // 
            // bar3
            // 
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            // 
            // gridControl1
            // 
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(649, 189);
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
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 29);
            this.splitContainerControl1.Panel2.Controls.Add(this.dataLayoutControl1);
            this.splitContainerControl1.Size = new System.Drawing.Size(649, 357);
            this.splitContainerControl1.SplitterPosition = 162;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.WeekdayTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EventTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AssistantTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EventVisibleCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.AssistantVisibleCheckEdit);
            this.dataLayoutControl1.DataSource = this.testRecordListBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(267, 162);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // IdTextEdit
            // 
            this.IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.testRecordListBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IdTextEdit.Location = new System.Drawing.Point(60, 12);
            this.IdTextEdit.MenuManager = this.barManager1;
            this.IdTextEdit.Name = "IdTextEdit";
            this.IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdTextEdit.Properties.Mask.EditMask = "N0";
            this.IdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdTextEdit.Size = new System.Drawing.Size(195, 20);
            this.IdTextEdit.StyleController = this.dataLayoutControl1;
            this.IdTextEdit.TabIndex = 4;
            // 
            // WeekdayTextEdit
            // 
            this.WeekdayTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.testRecordListBindingSource, "Weekday", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.WeekdayTextEdit.Location = new System.Drawing.Point(60, 36);
            this.WeekdayTextEdit.MenuManager = this.barManager1;
            this.WeekdayTextEdit.Name = "WeekdayTextEdit";
            this.WeekdayTextEdit.Size = new System.Drawing.Size(195, 20);
            this.WeekdayTextEdit.StyleController = this.dataLayoutControl1;
            this.WeekdayTextEdit.TabIndex = 5;
            // 
            // EventTextEdit
            // 
            this.EventTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.testRecordListBindingSource, "Event", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EventTextEdit.Location = new System.Drawing.Point(60, 106);
            this.EventTextEdit.MenuManager = this.barManager1;
            this.EventTextEdit.Name = "EventTextEdit";
            this.EventTextEdit.Size = new System.Drawing.Size(195, 20);
            this.EventTextEdit.StyleController = this.dataLayoutControl1;
            this.EventTextEdit.TabIndex = 6;
            // 
            // AssistantTextEdit
            // 
            this.AssistantTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.testRecordListBindingSource, "Assistant", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AssistantTextEdit.Location = new System.Drawing.Point(60, 130);
            this.AssistantTextEdit.MenuManager = this.barManager1;
            this.AssistantTextEdit.Name = "AssistantTextEdit";
            this.AssistantTextEdit.Size = new System.Drawing.Size(195, 20);
            this.AssistantTextEdit.StyleController = this.dataLayoutControl1;
            this.AssistantTextEdit.TabIndex = 7;
            // 
            // EventVisibleCheckEdit
            // 
            this.EventVisibleCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.testRecordListBindingSource, "EventVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EventVisibleCheckEdit.Location = new System.Drawing.Point(60, 60);
            this.EventVisibleCheckEdit.MenuManager = this.barManager1;
            this.EventVisibleCheckEdit.Name = "EventVisibleCheckEdit";
            this.EventVisibleCheckEdit.Properties.Caption = "Event Visible";
            this.EventVisibleCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.EventVisibleCheckEdit.Size = new System.Drawing.Size(195, 19);
            this.EventVisibleCheckEdit.StyleController = this.dataLayoutControl1;
            this.EventVisibleCheckEdit.TabIndex = 8;
            // 
            // AssistantVisibleCheckEdit
            // 
            this.AssistantVisibleCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.testRecordListBindingSource, "AssistantVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AssistantVisibleCheckEdit.Location = new System.Drawing.Point(60, 83);
            this.AssistantVisibleCheckEdit.MenuManager = this.barManager1;
            this.AssistantVisibleCheckEdit.Name = "AssistantVisibleCheckEdit";
            this.AssistantVisibleCheckEdit.Properties.Caption = "Assistant Visible";
            this.AssistantVisibleCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.AssistantVisibleCheckEdit.Size = new System.Drawing.Size(195, 19);
            this.AssistantVisibleCheckEdit.StyleController = this.dataLayoutControl1;
            this.AssistantVisibleCheckEdit.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(267, 162);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForId,
            this.ItemForWeekday,
            this.ItemForEvent,
            this.ItemForAssistant,
            this.ItemForEventVisible,
            this.ItemForAssistantVisible});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(247, 142);
            // 
            // ItemForId
            // 
            this.ItemForId.Control = this.IdTextEdit;
            this.ItemForId.Location = new System.Drawing.Point(0, 0);
            this.ItemForId.Name = "ItemForId";
            this.ItemForId.Size = new System.Drawing.Size(247, 24);
            this.ItemForId.Text = "Id";
            this.ItemForId.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForWeekday
            // 
            this.ItemForWeekday.Control = this.WeekdayTextEdit;
            this.ItemForWeekday.Location = new System.Drawing.Point(0, 24);
            this.ItemForWeekday.Name = "ItemForWeekday";
            this.ItemForWeekday.Size = new System.Drawing.Size(247, 24);
            this.ItemForWeekday.Text = "Weekday";
            this.ItemForWeekday.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForEvent
            // 
            this.ItemForEvent.Control = this.EventTextEdit;
            this.ItemForEvent.DataBindings.Add(new System.Windows.Forms.Binding("Visibility", this.testRecordListBindingSource, "EventVisible", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.ItemForEvent.Location = new System.Drawing.Point(0, 94);
            this.ItemForEvent.Name = "ItemForEvent";
            this.ItemForEvent.Size = new System.Drawing.Size(247, 24);
            this.ItemForEvent.Text = "Event";
            this.ItemForEvent.TextSize = new System.Drawing.Size(45, 13);
            this.visibilityBinderLayoutItem1.SetVisibilityBindToBool(this.ItemForEvent, true);
            // 
            // ItemForAssistant
            // 
            this.ItemForAssistant.Control = this.AssistantTextEdit;
            this.ItemForAssistant.DataBindings.Add(new System.Windows.Forms.Binding("Visibility", this.testRecordListBindingSource, "AssistantVisible", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.ItemForAssistant.Location = new System.Drawing.Point(0, 118);
            this.ItemForAssistant.Name = "ItemForAssistant";
            this.ItemForAssistant.Size = new System.Drawing.Size(247, 24);
            this.ItemForAssistant.Text = "Assistant";
            this.ItemForAssistant.TextSize = new System.Drawing.Size(45, 13);
            this.visibilityBinderLayoutItem1.SetVisibilityBindToBool(this.ItemForAssistant, true);
            // 
            // ItemForEventVisible
            // 
            this.ItemForEventVisible.Control = this.EventVisibleCheckEdit;
            this.ItemForEventVisible.Location = new System.Drawing.Point(0, 48);
            this.ItemForEventVisible.Name = "ItemForEventVisible";
            this.ItemForEventVisible.Size = new System.Drawing.Size(247, 23);
            this.ItemForEventVisible.Text = " ";
            this.ItemForEventVisible.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForAssistantVisible
            // 
            this.ItemForAssistantVisible.Control = this.AssistantVisibleCheckEdit;
            this.ItemForAssistantVisible.Location = new System.Drawing.Point(0, 71);
            this.ItemForAssistantVisible.Name = "ItemForAssistantVisible";
            this.ItemForAssistantVisible.Size = new System.Drawing.Size(247, 23);
            this.ItemForAssistantVisible.Text = " ";
            this.ItemForAssistantVisible.TextSize = new System.Drawing.Size(45, 13);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(649, 407);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Form1.IconOptions.Icon")));
            this.Name = "Form1";
            this.Text = "Form 1: Visibility Binding with the LayoutControl";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testRecordListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeekdayTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssistantTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventVisibleCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssistantVisibleCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWeekday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssistant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEventVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssistantVisible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit IdTextEdit;
        private DevExpress.XtraEditors.TextEdit WeekdayTextEdit;
        private DevExpress.XtraEditors.TextEdit EventTextEdit;
        private DevExpress.XtraEditors.TextEdit AssistantTextEdit;
        private DevExpress.XtraEditors.CheckEdit EventVisibleCheckEdit;
        private DevExpress.XtraEditors.CheckEdit AssistantVisibleCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWeekday;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEvent;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAssistant;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEventVisible;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAssistantVisible;
        private VisibilityBinding.VisibilityBinderLayout visibilityBinderLayoutItem1;
    }
}
