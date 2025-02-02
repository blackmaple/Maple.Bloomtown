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
    /// ["Assembly-CSharp".""."Effect"]
    /// </summary>
    public enum Effect : int
    {


        None = 0x00000000,

        CritRate = 0x00000001,

        IncomingCritRate = 0x00000002,

        Susceptibility = 0x00000003,

        Evasion = 0x00000004,

        Inflict = 0x00000005,

        Immunity = 0x00000006,

        Attack = 0x00000007,

        CritRateWhenAmbushed = 0x00000008,

        MeleeAilment = 0x00000009,

        RangeAilment = 0x0000000A,

        Stat = 0x0000000B,

    }


}