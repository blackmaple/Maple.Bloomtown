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
    /// ["Assembly-CSharp".""."TableVersion"]
    /// </summary>
    public enum TableVersion : int
    {


        None = 0x00000000,

        Consumer = 0x00000001,

        Locales = 0x00000002,

        LocalesBatch1 = 0x00000003,

        LocalesBatch2 = 0x00000004,

    }


}