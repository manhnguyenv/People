using MvvmCross.iOS.Views;
using System;
using System.Collections.Generic;
using MvvmCross.Binding.iOS.Views;
using People.Core.ViewModels;
using UIKit;
using MvvmCross.Binding.BindingContext;

namespace People.Touch.Views
{
    public partial class PeopleListView : MvxViewController
    {
        public PeopleListView() : base("PeopleListView", null)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "People#";

            var source = new MvxSimpleTableViewSource(this.PeopleTableView, PeopleRow.Key, PeopleRow.Key);
            this.AddBindings(new Dictionary<object, string>
            {
                {source, "ItemsSource Contacts"}
            });
            PeopleTableView.RowHeight = 80;
            PeopleTableView.Source = source;
            PeopleTableView.ReloadData();
            
        }
    }

   
}