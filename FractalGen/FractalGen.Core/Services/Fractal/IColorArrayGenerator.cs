using System.Collections.Generic;
using Cirrious.CrossCore.UI;

namespace FractalGen.Core.Services
{
    public interface IColorArrayGenerator
    {
        List<MvxColor> NextColorArray();
    }
}