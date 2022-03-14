namespace VisibilityBinding
{
    using System;

    using System.ComponentModel;

    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;

    [ProvideProperty(ExtenderPropertyName, typeof(BarItem))]
    public sealed class VisibilityBinderBars : VisibilityBinderBase<BarItem, BarItemVisibility>, IExtenderProvider
    {
        public const string ExtenderPropertyName = "VisibilityBindToBool";

        /// <summary>Initializes a new instance of the <see cref="VisibilityBinderBars" /> class.</summary>
        public VisibilityBinderBars()
            : base(nameof(BarItem.Visibility))
        {
        }

        /// <summary>Initializes a new instance of the <see cref="VisibilityBinderBars"/> class.</summary>
        /// <param name="container">The container.</param>
        public VisibilityBinderBars(IContainer container)
            : this()
        {
            container.Add(this);
        }

        public void SetVisibilityBindToBool(BarItem control, bool enabled)
        {
            this.SetBindingEnabled(control, enabled);
        }

        [DXCategory("Behavior")]
        [DefaultValue(false)]
        [Bindable(false)]
        [DisplayName(ExtenderPropertyName)]
        public bool GetVisibilityBindToBool(BarItem control)
        {
            return this.GetBindingEnabled(control);
        }

        protected override BarItemVisibility ConvertBoolToEnum(bool value)
        {
            if (value)
            {
                return BarItemVisibility.Always;
            }

            return BarItemVisibility.Never;
        }

        protected override bool ConvertEnumToBool(BarItemVisibility value)
        {
            switch (value)
            {
                case BarItemVisibility.Always:
                    return true;
                case BarItemVisibility.Never:
                    return false;
                case BarItemVisibility.OnlyInCustomizing:
                    return false;
                case BarItemVisibility.OnlyInRuntime:
                    return true;
                default:
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }
    }
}
