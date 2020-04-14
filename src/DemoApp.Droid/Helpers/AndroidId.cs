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
using DemoApp.Core.Helpers;
using Xamarin.Forms;

namespace DemoApp.Droid.Helpers
{
    public class AndroidId : IAndroidId
    {
        private TaskCompletionSource<string> tcs;
        //public event EventHandler<AndroidIdEventArgs> OnAndroidId;
        public Task<string> GetAndroidId()
        {
            DroidIdActivity.OnAndroidId += DroidIdActivity_OnAndroidId;
            tcs = new TaskCompletionSource<string>();
            var intent = new Intent(Forms.Context, typeof(DroidIdActivity));

            intent.AddFlags(ActivityFlags.NewTask);

            Forms.Context.StartActivity(intent);
            return tcs.Task;
        }

        private void DroidIdActivity_OnAndroidId(object sender, AndroidIdEventArgs e)
        {
            tcs.SetResult(e.AndroidId);
            DroidIdActivity.OnAndroidId -= DroidIdActivity_OnAndroidId;
        }
    }
}
