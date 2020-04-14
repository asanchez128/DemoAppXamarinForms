using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using DemoApp.Core.Helpers;

namespace DemoApp.Droid.Helpers
{
    [Activity]
    public class DroidIdActivity : AppCompatActivity
    {
        public static event EventHandler<AndroidIdEventArgs> OnAndroidId;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            string droidId = Android.Provider.Settings.Secure.GetString(Android.App.Application.Context.ContentResolver, Android.Provider.Settings.Secure.AndroidId);

            OnAndroidId?.Invoke(this, new AndroidIdEventArgs
            {
                AndroidId = droidId
            });

            Finish();
        }

        
    }
}
