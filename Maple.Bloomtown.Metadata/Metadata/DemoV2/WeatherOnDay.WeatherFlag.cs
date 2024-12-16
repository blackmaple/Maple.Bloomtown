using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Bloomtown.Metadata.Metadata.DemoV2
{


    /// <summary>
    /// ["Assembly-CSharp".""."WeatherFlag"]
    /// </summary>
    public enum WeatherFlag : int
    {


        None = 0x00000000,

        All = 0x0000000F,

        Sunny = 0x00000001,

        Rainy = 0x00000002,

        Heatwave = 0x00000004,

        Foggy = 0x00000008,

    }


}