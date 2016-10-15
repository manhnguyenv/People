// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace People.Touch.Views
{
    [Register ("PeopleRow")]
    partial class PeopleRow
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelComany { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelJobTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView Photo { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelComany != null) {
                LabelComany.Dispose ();
                LabelComany = null;
            }

            if (LabelJobTitle != null) {
                LabelJobTitle.Dispose ();
                LabelJobTitle = null;
            }

            if (LabelTitle != null) {
                LabelTitle.Dispose ();
                LabelTitle = null;
            }

            if (Photo != null) {
                Photo.Dispose ();
                Photo = null;
            }
        }
    }
}