
namespace VisibilityBinding
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows.Forms;
    using DevExpress.Data.Access;

    public abstract class VisibilityBinderBase<TControl, TEnum> : Component
    where TControl : Component, IBindableComponent
    where TEnum : Enum
    {
        private readonly Dictionary<TControl, RegisteredControl> registeredControls = new Dictionary<TControl, RegisteredControl>();

        /// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Component" /> class. </summary>
        protected VisibilityBinderBase(string propertyName)
        {
            this.PropertyName = propertyName;
        }

        protected string PropertyName { get; }

        public virtual bool CanExtend(object extendee)
        {
            if (extendee is TControl)
            {
                return true;

                ////var propInfos = TypeDescriptor.GetProperties(extendee);
                ////var propInfo = propInfos.Find(this.PropertyName, true);

                ////if (propInfo != null && propInfo.PropertyType == typeof(TEnum))
                ////{
                ////    var browsableAttr = propInfo.GetAttribute<BrowsableAttribute>();
                ////    if (browsableAttr == null || browsableAttr.Browsable)
                ////    {
                ////        return true;
                ////    }
                ////}
            }

            return false;
        }

        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.ComponentModel.Component" /> and optionally releases the managed resources.</summary>
        /// <param name="disposing">
        /// <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                var obsoleteControls = this.registeredControls.ToList();

                foreach (var registeredControl in obsoleteControls)
                {
                    this.registeredControls.Remove(registeredControl.Key);
                    registeredControl.Value.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        protected bool GetBindingEnabled(TControl control)
        {
            return this.registeredControls.ContainsKey(control);
        }

        protected void SetBindingEnabled(TControl control, bool enabled)
        {
            if (enabled)
            {
                this.CheckRegisterControl(control);
            }
            else
            {
                this.CheckUnregisterControl(control);
            }
        }

        protected abstract TEnum ConvertBoolToEnum(bool value);

        protected abstract bool ConvertEnumToBool(TEnum value);

        private void CheckUnregisterControl(TControl control)
        {
            if (!this.registeredControls.ContainsKey(control))
            {
                return;
            }

            var registeredControl = this.registeredControls[control];
            this.registeredControls.Remove(control);
            registeredControl.Dispose();
        }

        private void CheckRegisterControl(TControl control)
        {
            if (this.registeredControls.ContainsKey(control))
            {
                return;
            }

            var registeredControl = new RegisteredControl(this, control);
            this.registeredControls.Add(control, registeredControl);
        }

        private class RegisteredControl : IDisposable
        {
            private readonly Dictionary<Binding, RegisteredBinding> registeredBindings = new Dictionary<Binding, RegisteredBinding>();

            public RegisteredControl(VisibilityBinderBase<TControl, TEnum> binder, TControl control)
            {
                this.Binder = binder;
                this.Control = control;
                this.RegisterControl();
            }

            private VisibilityBinderBase<TControl, TEnum> Binder { get; }

            private TControl Control { get; }

            /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
            public void Dispose()
            {
                this.Control.DataBindings.CollectionChanged -= this.DataBindings_CollectionChanged;

                foreach (var registeredBinding in this.registeredBindings.Values)
                {
                    registeredBinding.Dispose();
                }

                this.registeredBindings.Clear();
            }

            private void RegisterControl()
            {
                this.Control.DataBindings.CollectionChanged += this.DataBindings_CollectionChanged;
                this.UpdateBindingRegistrations();
            }

            private void DataBindings_CollectionChanged(object sender, CollectionChangeEventArgs e)
            {
                this.UpdateBindingRegistrations();
            }

            private void UpdateBindingRegistrations()
            {
                // Remove obsolete registrations
                var obsoleteBindings = this.registeredBindings
                    .Where(
                        e => Control.DataBindings.OfType<Binding>().Contains(e.Key)
                             || e.Key.PropertyName != Binder.PropertyName)
                    .ToList();

                foreach (var registeredBinding in obsoleteBindings)
                {
                    this.registeredBindings.Remove(registeredBinding.Key);
                    registeredBinding.Value.Dispose();
                }

                // Add new bindings
                var newBindings = this.Control.DataBindings
                    .OfType<Binding>()
                    .Where(
                        e => e.PropertyName == Binder.PropertyName
                             && !this.registeredBindings.ContainsKey(e))
                    .ToList();

                foreach (var newBinding in newBindings)
                {
                    var registeredBinding = new RegisteredBinding(this.Binder, newBinding);
                    this.registeredBindings.Add(newBinding, registeredBinding);
                }
            }

            private class RegisteredBinding : IDisposable
            {
                private readonly Binding binding;

                public RegisteredBinding(VisibilityBinderBase<TControl, TEnum> binder, Binding binding)
                {
                    this.binding = binding;
                    this.Binder = binder;
                    this.RegisterBinding();
                }

                private VisibilityBinderBase<TControl, TEnum> Binder { get; }

                /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
                public void Dispose()
                {
                    this.binding.Format -= this.Binding_Format;
                    this.binding.Parse -= this.Binding_Parse;
                }

                private void RegisterBinding()
                {
                    this.binding.Format += this.Binding_Format;
                    this.binding.Parse += this.Binding_Parse;
                }

                private void Binding_Parse(object sender, ConvertEventArgs e)
                {
                    if (e.Value == null)
                    {
                        throw new FormatException("VisibilityBinder.Parse: Source value is expected to be " + typeof(TEnum) + " but is null!");
                    }

                    if (!(e.Value is TEnum))
                    {
                        throw new FormatException("VisibilityBinder.Parse: Source value is expected to be " + typeof(TEnum) + " but is of type " + e.Value.GetType());
                    }

                    if ((e.DesiredType != typeof(bool)))
                    {
                        throw new FormatException("VisibilityBinder.Parse: The desired type is expected to be boolean but is of type " + e.DesiredType);
                    }

                    e.Value = Binder.ConvertEnumToBool((TEnum)e.Value);
                }

                private void Binding_Format(object sender, ConvertEventArgs e)
                {
                    if (e.Value == null)
                    {
                        throw new FormatException("VisibilityBinder.Format: Source value is expected to be boolean but is null!");
                    }

                    if (!(e.Value is bool))
                    {
                        throw new FormatException("VisibilityBinder.Format: Source value is expected to be boolean but is of type " + e.Value.GetType());
                    }

                    if ((e.DesiredType != typeof(TEnum)))
                    {
                        throw new FormatException("VisibilityBinder.Format: The desired type is expected to be " + typeof(TEnum) + " but is of type " + e.DesiredType);
                    }

                    e.Value = Binder.ConvertBoolToEnum((bool)e.Value);
                }
            }
        }
    }
}
