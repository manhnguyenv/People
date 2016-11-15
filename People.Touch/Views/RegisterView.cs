using System;
using System.Collections.Generic;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace People.Touch.Views
{
    public partial class RegisterView : MvxViewController
    {
        public RegisterView() : base("RegisterView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationController.NavigationBar.Translucent = false;
            Title = "Register";

            this.AddBindings(new Dictionary<object, string>()
            {
                {RegisterButton, "TouchUpInside RegisterCommand"},
                {UsernameText, "Text Username"},
                {PasswordText, "Text Password"},
                {EmailText, "Text Email"}
            });
        }
    }
}