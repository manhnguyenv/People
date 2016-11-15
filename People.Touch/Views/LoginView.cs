using System;
using System.Collections.Generic;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace People.Touch.Views
{
    public partial class LoginView : MvxViewController
    {
        public LoginView() : base("LoginView", null)
        {
        }

public override void ViewDidLoad()
{
    base.ViewDidLoad();

    NavigationController.NavigationBar.Translucent = false;
    Title = "Login";

    this.AddBindings(new Dictionary<object, string>()
    {
        {RegisterButton, "TouchUpInside RegisterCommand"},
        {LoginButton, "TouchUpInside LoginCommand"},
        {UsernameText, "Text Username"},
        {PasswordText, "Text Password"}
    });
}
    }
}