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
    /// struct ["Assembly-CSharp".""."LoadingResult"]
    /// 
    /// </summary>
    public partial class LoadingResult
    {






        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_LoadingResult
        {



            /// const string Name_Field_error = "error";
            /// <summary>
            /// struct 0x10 System.Boolean error
            /// </summary>
            [System.Runtime.InteropServices.FieldOffset(0x0)]
            public readonly bool error;


            /// const string Name_Field_resultMessage = "resultMessage";
            /// <summary>
            /// class 0x18 System.String resultMessage
            /// </summary>
            [System.Runtime.InteropServices.FieldOffset(0x8)]
            public readonly nint resultMessage;

        }

    }


}