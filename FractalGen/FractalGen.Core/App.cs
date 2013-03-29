using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using FractalGen.Core.ViewModels;

namespace FractalGen.Core
{
    public class App : MvxApplication 
    {
        public override void Initialize()
        {
            this.CreatableTypes()
                .EndingWith("Generator")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            this.CreatableTypes()
                .EndingWith("Converter")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            this.CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsSingleton();

            this.RegisterAppStart<GenerateViewModel>();
        }
    }
}
