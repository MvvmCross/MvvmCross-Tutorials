using Babel.Core.Services;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using MvvmCross.Localization;
using MvvmCross.Plugins.JsonLocalization;

namespace Babel.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
            InitializeText();
            RegisterAppStart<ViewModels.FirstViewModel>();
        }

        private void InitializeText()
        {
            var builder = new TextProviderBuilder();
            Mvx.RegisterSingleton<IMvxTextProviderBuilder>(builder);
            Mvx.RegisterSingleton<IMvxTextProvider>(builder.TextProvider);
        }
    }
}