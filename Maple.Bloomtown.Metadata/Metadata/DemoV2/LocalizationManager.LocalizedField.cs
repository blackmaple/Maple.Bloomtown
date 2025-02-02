
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
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x02000476U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [76, 111, 99, 97, 108, 105, 122, 101, 100, 70, 105, 101, 108, 100])]


    // class 0x10 System.Collections.Generic.List<LocalizationManager.TextPair> values
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"values", "VALUES")]
    public partial class LocalizedField
    {
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "LocalizedField";
        //public static byte[] Static_ClassName { get; } = [76, 111, 99, 97, 108, 105, 122, 101, 100, 70, 105, 101, 108, 100];

        //public const uint Const_TypeToken = 0x02000476U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_LocalizedField(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_LocalizedField(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_LocalizedField obj) => obj._ptr;
            public static implicit operator bool(Ptr_LocalizedField obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp".""."LocalizedField"]
    /// </summary>
    public partial class LocalizedField
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   System.Void AddValue(System.String lngKey, System.String value)
        /// </summary>
        /// <param name="lngKey">class System.String</param>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddValue")]
        ///  extern void ADD_VALUE (nint lngKey, nint value);


        /// <summary>
        ///   System.Void Clear()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clear")]
        ///  extern void CLEAR ();


        /// <summary>
        ///   System.String get_getValue()
        /// </summary>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_getValue")]
        extern PMonoString GET_VALUE();


        /// <summary>
        ///   System.String GetValueForLng(System.String lngID)
        /// </summary>
        /// <param name="lngID">class System.String</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetValueForLng")]
        ///  extern nint GET_VALUE_FOR_LNG (nint lngID);


        /// <summary>
        ///   System.Boolean IsEmpty()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsEmpty")]
        ///  extern System.Boolean IS_EMPTY ();


        /// <summary>
        ///   System.Void UpdateLocalesFromDatabases(System.String textUid)
        /// </summary>
        /// <param name="textUid">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateLocalesFromDatabases")]
        ///  extern void UPDATE_LOCALES_FROM_DATABASES (nint textUid);



        /// <summary>
        ///   System.Void UpdateLocales(System.Collections.Generic.Dictionary<System.String,System.Object> row)
        /// </summary>
        /// <param name="row">class System.Collections.Generic.Dictionary<System.String,System.Object></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateLocales", Search = typeof(Search_LocalizedField))]
        ///  extern void UPDATE_LOCALES_00 (nint row);


        /// <summary>
        ///   System.Void UpdateLocales(System.String dictKeyBase, System.Collections.Generic.Dictionary<System.String,System.Object> row)
        /// </summary>
        /// <param name="dictKeyBase">class System.String</param>
        /// <param name="row">class System.Collections.Generic.Dictionary<System.String,System.Object></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateLocales", Search = typeof(Search_LocalizedField))]
        ///  extern void UPDATE_LOCALES_01 (nint dictKeyBase, nint row);


        /// public static partial class Search_LocalizedField
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void UpdateLocales(System.Collections.Generic.Dictionary<System.String,System.Object> row)
        /// </summary>
        /// public static bool UPDATE_LOCALES_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "UpdateLocales", "System.Collections.Generic.Dictionary<System.String,System.Object>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void UpdateLocales(System.String dictKeyBase, System.Collections.Generic.Dictionary<System.String,System.Object> row)
        /// </summary>
        /// public static bool UPDATE_LOCALES_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "UpdateLocales", "System.String", "System.Collections.Generic.Dictionary<System.String,System.Object>");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}