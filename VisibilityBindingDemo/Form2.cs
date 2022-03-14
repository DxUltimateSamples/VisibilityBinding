using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisibilityBindingDemo
{
    using VisibilityBindingDemo.Data;

    public partial class Form2 : VisibilityBindingDemo.FormBase
    {
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.</summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data. </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.testRecordListBindingSource.DataSource = TestRecordList.CreateTestRecordList(20);
        }
    }
}
