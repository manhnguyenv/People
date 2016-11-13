
using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace People.Droid.Views
{
    [Activity]
    public class LoginView: MvxAppCompatActivity
    {
        public Toolbar Toolbar { get; set; }

        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.LoginView);

            Toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            if (Toolbar != null)
            {
                Toolbar.Title = "Login";
                SetSupportActionBar(Toolbar);
                SupportActionBar.SetDisplayHomeAsUpEnabled(false);
                Toolbar.NavigationClick += (s, e) =>
                    Finish();
            }

        }
    }
}