﻿// WARNING
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
    [Register ("PeopleListView")]
    partial class PeopleListView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView PeopleTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (PeopleTableView != null) {
                PeopleTableView.Dispose ();
                PeopleTableView = null;
            }
        }
    }
}