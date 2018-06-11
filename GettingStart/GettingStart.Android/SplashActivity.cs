using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GettingStart.Droid
{
    [Activity(Label = "Getting Start", Icon = "@drawable/icon", Theme = "@style/SplashScreen", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            StartActivity(typeof(MainActivity));
        }

        protected override void OnResume()
        {
            base.OnResume();
            Task.Delay(4000);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}