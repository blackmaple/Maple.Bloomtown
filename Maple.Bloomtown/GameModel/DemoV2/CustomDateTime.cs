
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
    /// struct ["Assembly-CSharp".""."CustomDateTime"]
    /// 
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x020008F8U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [67, 117, 115, 116, 111, 109, 68, 97, 116, 101, 84, 105, 109, 101])]
    public partial class CustomDateTime
    { 
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "CustomDateTime";
        //public static byte[] Static_ClassName { get; } = [67, 117, 115, 116, 111, 109, 68, 97, 116, 101, 84, 105, 109, 101];

        //public const uint Const_TypeToken = 0x020008F8U;



        
        public readonly unsafe partial struct Const_CustomDateTime
        {

            
                        
            /// <summary>
            /// struct System.Int32 defaultYear "0"
            /// </summary>
            /// public System.Int32 DEFAULT_YEAR=>"0";

                        
            /// <summary>
            /// enum CustomDateTime.Month defaultMonth "0x00000006"
            /// </summary>
            /// public CustomDateTime.Month DEFAULT_MONTH=>"0x00000006";

                        
            /// <summary>
            /// struct System.Int32 defaultDay "0"
            /// </summary>
            /// public System.Int32 DEFAULT_DAY=>"0";

                        
            /// <summary>
            /// struct System.Int32 defaultHour "0"
            /// </summary>
            /// public System.Int32 DEFAULT_HOUR=>"0";

        }
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_CustomDateTime
        {

            
            
            
                        
            /// const string Name_Field_dateTimeStr = "dateTimeStr";
            /// <summary>
            /// class 0x10 System.String dateTimeStr
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly nint dateTimeStr;

                        
            /// const string Name_Field_m_dateTime = "m_dateTime";
            /// <summary>
            /// struct 0x18 System.DateTime m_dateTime
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            public readonly System.DateTime m_dateTime;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_CustomDateTime(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_CustomDateTime(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_CustomDateTime obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_CustomDateTime AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_CustomDateTime>(_ptr.ToPointer());
            }
        }

    }


}