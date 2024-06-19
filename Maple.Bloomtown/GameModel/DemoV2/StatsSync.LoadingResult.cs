
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Bloomtown.GameModel.Demo
{
    
    
    /// <summary>
    /// struct ["Assembly-CSharp".""."LoadingResult"]
    /// 
    /// </summary>
    public partial class LoadingResult
    { 

        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_LoadingResult
        {
    
            
                        
            /// const string Name_Field_error = "error";
            /// <summary>
            /// struct 0x10 System.Boolean error
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly System.Boolean error;

                        
            /// const string Name_Field_resultMessage = "resultMessage";
            /// <summary>
            /// class 0x18 System.String resultMessage
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            public readonly nint resultMessage;

        }

    }


}