
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
    /// class ["Assembly-CSharp".""."SocialStat"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x02000447U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [83, 111, 99, 105, 97, 108, 83, 116, 97, 116])]


    // class 0x10 System.Collections.Generic.List<System.Int32> m_rangCaps
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_rangCaps", "M_RANG_CAPS")]

    // enum 0x18 SocialStat.SocialStatType statType
    // [MonoCollectorSearchFieldAttribute(typeof(SocialStat.SocialStatType),"statType", "STAT_TYPE")]

    // struct 0x1C System.Int32 m_rang
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "m_rang", "M_RANG", IsReadOnly = false)]

    // struct 0x20 System.Int32 m_exp
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "m_exp", "M_EXP", IsReadOnly = false)]
    public partial class SocialStat
    {
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "SocialStat";
        //public static byte[] Static_ClassName { get; } = [83, 111, 99, 105, 97, 108, 83, 116, 97, 116];

        //public const uint Const_TypeToken = 0x02000447U;




        /// <summary>
        /// struct System.Int32 MaxRang "0"
        /// </summary>
        public const System.Int32 MAX_RANG = 10;




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_SocialStat(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_SocialStat(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_SocialStat obj) => obj._ptr;
            public static implicit operator bool(Ptr_SocialStat obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp".""."SocialStat"]
    /// </summary>
    public partial class SocialStat
    {



        /// <summary>
        ///   System.Void .ctor(SocialStat.SocialStatType type, System.Int32 exp)
        /// </summary>
        /// <param name="type">enum SocialStat.SocialStatType</param>
        /// <param name="exp">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR (SocialStat.SocialStatType type, System.Int32 exp);


        /// <summary>
        ///   System.Boolean <get_RangCaps>b__15_0(GameSettings.SocialStatRang x)
        /// </summary>
        /// <param name="x">class GameSettings.SocialStatRang</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<get_RangCaps>b__15_0")]
        ///  extern System.Boolean <GET_RANG_CAPS>B__15_0 (nint x);


        /// <summary>
        ///   System.Void AddExp(System.Int32 count)
        /// </summary>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddExp")]
        ///  extern void ADD_EXP (System.Int32 count);


        /// <summary>
        ///   System.Void AddRang(System.Int32 count)
        /// </summary>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRang")]
        ///  extern void ADD_RANG (System.Int32 count);


        /// <summary>
        ///   System.Int32 get_Exp()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Exp")]
        ///  extern System.Int32 GET_EXP ();


        /// <summary>
        ///   System.String get_getDescriptionUid()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_getDescriptionUid")]
        ///  extern nint GET_GET_DESCRIPTION_UID ();


        /// <summary>
        ///   System.String get_getNameUid()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_getNameUid")]
        ///  extern nint GET_GET_NAME_UID ();


        /// <summary>
        ///   System.Int32 get_Rang()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Rang")]
        extern System.Int32 GET_RANG();


        /// <summary>
        ///   System.Collections.Generic.List<System.Int32> get_RangCaps()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<System.Int32></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RangCaps")]
        ///  extern nint GET_RANG_CAPS ();


        /// <summary>
        ///   System.String GetDescription()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDescription")]
        ///  extern nint GET_DESCRIPTION ();


        /// <summary>
        /// static  System.String GetDescriptionForSocialStat(SocialStat.SocialStatType statType, System.Int32 rang)
        /// </summary>
        /// <param name="statType">enum SocialStat.SocialStatType</param>
        /// <param name="rang">struct System.Int32</param>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDescriptionForSocialStat")]
        static extern PMonoString GET_DESCRIPTION_FOR_SOCIAL_STAT(SocialStat.SocialStatType statType, System.Int32 rang);


        /// <summary>
        ///   UnityEngine.Sprite GetIcon()
        /// </summary>
        /// <returns>class UnityEngine.Sprite</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetIcon")]
        ///  extern nint GET_ICON ();


        /// <summary>
        ///   System.String GetName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetName")]
        ///  extern nint GET_NAME ();


        /// <summary>
        ///   System.Int32 GetRangCap(System.Int32 socialRang)
        /// </summary>
        /// <param name="socialRang">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRangCap")]
        extern System.Int32 GET_RANG_CAP(System.Int32 socialRang);


        /// <summary>
        /// static  System.String GetSocialStatName(SocialStat.SocialStatType type)
        /// </summary>
        /// <param name="type">enum SocialStat.SocialStatType</param>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSocialStatName")]
        static extern PMonoString GET_SOCIAL_STAT_NAME(SocialStat.SocialStatType type);


        /// <summary>
        ///   System.Void ParseFromString(System.String dataStr)
        /// </summary>
        /// <param name="dataStr">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ParseFromString")]
        ///  extern void PARSE_FROM_STRING (nint dataStr);


        /// <summary>
        /// static  System.Void ParseTable(System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>> table)
        /// </summary>
        /// <param name="table">class System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ParseTable")]
        /// static extern void PARSE_TABLE (nint table);


        /// <summary>
        ///   System.Void SetRang(System.Int32 rang)
        /// </summary>
        /// <param name="rang">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetRang")]
        ///  extern void SET_RANG (System.Int32 rang);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
        ///  extern nint TO_STRING ();




        /// public static partial class Search_SocialStat
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}