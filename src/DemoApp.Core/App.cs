using MvvmCross.IoC;
using MvvmCross.ViewModels;
using DemoApp.Core.ViewModels.Home;

namespace DemoApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
