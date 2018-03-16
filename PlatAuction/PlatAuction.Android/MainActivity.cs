using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;

namespace PlatAuction.Droid
{
    [Activity(Label = "PlatAuction", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            CurrentPlatform.Init();
            Forms.Init(this, bundle);

            LoadApplication(new PlatAuction.App());
        }
    }
}

