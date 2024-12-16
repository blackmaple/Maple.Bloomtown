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
    /// class ["Assembly-CSharp".""."LocalizedField"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x020003EBU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [76, 111, 99, 97, 108, 105, 122, 101, 100, 70, 105, 101, 108, 100])]
    public partial class LocalizedField
    {
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "LocalizedField";
        //public static byte[] Static_ClassName { get; } = [76, 111, 99, 97, 108, 105, 122, 101, 100, 70, 105, 101, 108, 100];

        //public const uint Const_TypeToken = 0x020003EBU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_LocalizedField
        {


            /// <summary>
            /// REF_MONO_OBJECT._vtable
            /// </summary>
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public readonly nint _vtable;

            /// <summary>
            /// REF_MONO_OBJECT._synchronisation
            /// </summary>
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
            public readonly nint _synchronisation;



            /// const string Name_Field_values = "values";
            /// <summary>
            /// class 0x10 System.Collections.Generic.List<LocalizationManager.TextPair> values
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly nint values;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_LocalizedField(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_LocalizedField(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_LocalizedField obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_LocalizedField AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_LocalizedField>(_ptr.ToPointer());
            }
        }

    }

    /// <summary>
    /// ["Assembly-CSharp".""."LocalizedField"]
    /// </summary>
    public partial class LocalizedField
    {



        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR ();


        /// const string Name_Func_ADD_VALUE = "AddValue";
        /// <summary>
        ///   System.Void AddValue(System.String lngKey,System.String value)
        /// </summary>
        /// <param name="lngKey">class System.String</param>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_VALUE (nint lngKey,nint value);


        /// const string Name_Func_CLEAR = "Clear";
        /// <summary>
        ///   System.Void Clear()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void CLEAR ();


        const string Name_Func_GET_GET_VALUE = "get_getValue";
        /// <summary>
        ///   System.String get_getValue()
        /// </summary>
        /// <returns>class System.String</returns>
        [MonoCollectorMethod(Name_Func_GET_GET_VALUE)]
        extern PMonoString GET_VALUE();


        /// const string Name_Func_GET_VALUE_FOR_LNG = "GetValueForLng";
        /// <summary>
        ///   System.String GetValueForLng(System.String lngID)
        /// </summary>
        /// <param name="lngID">class System.String</param>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_VALUE_FOR_LNG (nint lngID);


        /// const string Name_Func_IS_EMPTY = "IsEmpty";
        /// <summary>
        ///   System.Boolean IsEmpty()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean IS_EMPTY ();


        /// const string Name_Func_UPDATE_LOCALES = "UpdateLocales";
        /// <summary>
        ///   System.Void UpdateLocales(System.String dictKeyBase,System.Collections.Generic.Dictionary<System.String,System.Object> row)
        /// </summary>
        /// <param name="dictKeyBase">class System.String</param>
        /// <param name="row">class System.Collections.Generic.Dictionary<System.String,System.Object></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void UPDATE_LOCALES (nint dictKeyBase,nint row);




        /// public static partial class Search_LocalizedField
        /// {
        /// 
        ///     
        /// 
        /// }

    }

}
