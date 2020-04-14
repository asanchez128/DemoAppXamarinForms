using Android.App;
using DemoApp.Core.Helpers;
using DemoApp.Droid.Helpers;
using MvvmCross.Forms.Platforms.Android.Core;
using Xamarin.Forms;

#if DEBUG
[assembly: Application(Debuggable = true)]
#else
[assembly: Application(Debuggable = false)]
#endif

namespace DemoApp.Droid
{
    public class Setup : MvxFormsAndroidSetup<Core.App, UI.App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
            DependencyService.Register<IAndroidId, AndroidId>();
        }
    }
}
