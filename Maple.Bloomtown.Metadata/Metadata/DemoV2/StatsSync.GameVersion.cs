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
    /// ["Assembly-CSharp".""."GameVersion"]
    /// </summary>
    public enum GameVersion : int
    {


        Production = 0x00000000,

        Normal = 0x00000001,

        PublicDemo = 0x00000002,

        Playtest = 0x00000003,

        TestBattles = 0x00000004,

    }


}