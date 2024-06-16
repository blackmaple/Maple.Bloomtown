
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
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x02000515U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [76, 111, 97, 100, 105, 110, 103, 82, 101, 115, 117, 108, 116])]
    public partial class LoadingResult
    { 
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "LoadingResult";
        //public static byte[] Static_ClassName { get; } = [76, 111, 97, 100, 105, 110, 103, 82, 101, 115, 117, 108, 116];

        //public const uint Const_TypeToken = 0x02000515U;



        
            
        

        
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
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_LoadingResult(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_LoadingResult(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_LoadingResult obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_LoadingResult AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_LoadingResult>(_ptr.ToPointer());
            }
        }

    }


}