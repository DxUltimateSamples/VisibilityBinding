namespace VisibilityBinding
{
    using System;

    using System.ComponentModel;

    using DevExpress.XtraEditors;
    using DevExpress.XtraLayout;
    using DevExpress.XtraLayout.Utils;

    [ProvideProperty(ExtenderPropertyName, typeof(BaseLayoutItem))]
    public sealed class VisibilityBinderLayout : VisibilityBinderBase<BaseLayoutItem, LayoutVisibility>, IExtenderProvider
    {
        public const string ExtenderPropertyName = "VisibilityBindToBool";

        /// <summary>Initializes a new instance of the <see cref="VisibilityBinderLayout" /> class.</summary>
        public VisibilityBinderLayout()
            : base(nameof(BaseLayoutItem.Visibility))
        {
        }

        /// <summary>Initializes a new instance of the <see cref="VisibilityBinderLayout"/> class.</summary>
        /// <param name="container">The container.</param>
        public VisibilityBinderLayout(IContainer container)
            : this()
        {
            container.Add(this);
        }

        public void SetVisibilityBindToBool(BaseLayoutItem control, bool enabled)
        {
            this.SetBindingEnabled(control, enabled);
        }

        [DXCategory("Behavior")]
        [DefaultValue(false)]
        [Bindable(false)]
        [DisplayName(ExtenderPropertyName)]
        public bool GetVisibilityBindToBool(BaseLayoutItem control)
        {
            return this.GetBindingEnabled(control);
        }

        protected override LayoutVisibility ConvertBoolToEnum(bool value)
        {
            if (value)
            {
                return LayoutVisibility.Always;
            }

            return LayoutVisibility.Never;
        }

        protected override bool ConvertEnumToBool(LayoutVisibility value)
        {
            switch (value)
            {
                case LayoutVisibility.Always:
                    return true;
                case LayoutVisibility.Never:
                    return false;
                case LayoutVisibility.OnlyInCustomization:
                    return false;
                case LayoutVisibility.OnlyInRuntime:
                    return true;
                default:
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }
    }
}
