using System;
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
    }
}
}