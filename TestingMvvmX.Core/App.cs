using Cirrious.CrossCore.IoC;

namespace TestingMvvmX.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
			RegisterAppStart<FirstViewModel>();
			//RegisterAppStart<SecondViewModel> ();
        }
    }
}