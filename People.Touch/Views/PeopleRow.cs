using System;
using System.Collections.Generic;
using Foundation;
using MvvmCross.Binding.BindingContext;
using UIKit;
using MvvmCross.Binding.iOS.Views;

namespace People.Touch.Views
{
    public partial class PeopleRow : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("PeopleRow");
        public static readonly UINib Nib;

        private readonly MvxImageViewLoader _photoloader;
        static PeopleRow()
        {
            Nib = UINib.FromName("PeopleRow", NSBundle.MainBundle);
        }
        public static PeopleRow Create()
        {
            return (PeopleRow)Nib.Instantiate(null, null)[0];
        }
        protected PeopleRow(IntPtr handle) : base(handle)
        {
            _photoloader = new MvxImageViewLoader(() => Photo);
            this.DelayBind(() =>
            {
                this.AddBindings(new Dictionary<object, string>() {
                    {LabelTitle, "Text DisplayName"},
                    {LabelComany, "Text Company"},
                    {LabelJobTitle, "Text JobTitle"},
                    {_photoloader, "ImageUrl PhotoUrl"},
                });
            });
        }
    }
}
