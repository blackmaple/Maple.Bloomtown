
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
    public partial class SocialStat
    { 
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "SocialStat";
        //public static byte[] Static_ClassName { get; } = [83, 111, 99, 105, 97, 108, 83, 116, 97, 116];

        //public const uint Const_TypeToken = 0x02000447U;



        
        public readonly unsafe partial struct Const_SocialStat
        {

            
                        
            /// <summary>
            /// struct System.Int32 MaxRang "0"
            /// </summary>
            /// public System.Int32 MAX_RANG=>"0";

        }
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_SocialStat
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
            
            
                        
            /// const string Name_Field_m_rangCaps = "m_rangCaps";
            /// <summary>
            /// class 0x10 System.Collections.Generic.List<System.Int32> m_rangCaps
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly nint m_rangCaps;

                        
            /// const string Name_Field_statType = "statType";
            /// <summary>
            /// enum 0x18 SocialStat.SocialStatType statType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            public readonly  SocialStatType statType;

                        
            /// const string Name_Field_m_rang = "m_rang";
            /// <summary>
            /// struct 0x1C System.Int32 m_rang
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1C)]
            public readonly System.Int32 m_rang;

                        
            /// const string Name_Field_m_exp = "m_exp";
            /// <summary>
            /// struct 0x20 System.Int32 m_exp
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly System.Int32 m_exp;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_SocialStat(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_SocialStat(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_SocialStat obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_SocialStat AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_SocialStat>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp".""."SocialStat"]
        /// </summary>
        public partial class SocialStat
        { 

            
            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor(SocialStat.SocialStatType type,System.Int32 exp)
            /// </summary>
            /// <param name="type">enum SocialStat.SocialStatType</param>
            /// <param name="exp">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR (SocialStat.SocialStatType type,System.Int32 exp);

            
            /// const string Name_Func_<GET_RANG_CAPS>B__15_0 = "<get_RangCaps>b__15_0";
            /// <summary>
            ///   System.Boolean <get_RangCaps>b__15_0(GameSettings.SocialStatRang x)
            /// </summary>
            /// <param name="x">class GameSettings.SocialStatRang</param>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean <GET_RANG_CAPS>B__15_0 (nint x);

            
            /// const string Name_Func_ADD_EXP = "AddExp";
            /// <summary>
            ///   System.Void AddExp(System.Int32 count)
            /// </summary>
            /// <param name="count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void ADD_EXP (System.Int32 count);

            
            /// const string Name_Func_ADD_RANG = "AddRang";
            /// <summary>
            ///   System.Void AddRang(System.Int32 count)
            /// </summary>
            /// <param name="count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void ADD_RANG (System.Int32 count);

            
            /// const string Name_Func_GET_EXP = "get_Exp";
            /// <summary>
            ///   System.Int32 get_Exp()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_EXP ();

            
            /// const string Name_Func_GET_GET_DESCRIPTION_UID = "get_getDescriptionUid";
            /// <summary>
            ///   System.String get_getDescriptionUid()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_GET_DESCRIPTION_UID ();

            
            /// const string Name_Func_GET_GET_NAME_UID = "get_getNameUid";
            /// <summary>
            ///   System.String get_getNameUid()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_GET_NAME_UID ();

            
            /// const string Name_Func_GET_RANG = "get_Rang";
            /// <summary>
            ///   System.Int32 get_Rang()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_RANG ();

            
            /// const string Name_Func_GET_RANG_CAPS = "get_RangCaps";
            /// <summary>
            ///   System.Collections.Generic.List<System.Int32> get_RangCaps()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /// public  extern nint GET_RANG_CAPS ();

            
            /// const string Name_Func_GET_DESCRIPTION = "GetDescription";
            /// <summary>
            ///   System.String GetDescription()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_DESCRIPTION ();

            
            /// const string Name_Func_GET_DESCRIPTION_FOR_SOCIAL_STAT = "GetDescriptionForSocialStat";
            /// <summary>
            /// static  System.String GetDescriptionForSocialStat(SocialStat.SocialStatType statType,System.Int32 rang)
            /// </summary>
            /// <param name="statType">enum SocialStat.SocialStatType</param>
            /// <param name="rang">struct System.Int32</param>
            /// <returns>class System.String</returns>
            /// public static extern nint GET_DESCRIPTION_FOR_SOCIAL_STAT (SocialStat.SocialStatType statType,System.Int32 rang);

            
            /// const string Name_Func_GET_ICON = "GetIcon";
            /// <summary>
            ///   UnityEngine.Sprite GetIcon()
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
            /// public  extern nint GET_ICON ();

            
            /// const string Name_Func_GET_NAME = "GetName";
            /// <summary>
            ///   System.String GetName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_NAME ();

            
            /// const string Name_Func_GET_RANG_CAP = "GetRangCap";
            /// <summary>
            ///   System.Int32 GetRangCap(System.Int32 socialRang)
            /// </summary>
            /// <param name="socialRang">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_RANG_CAP (System.Int32 socialRang);

            
            /// const string Name_Func_GET_SOCIAL_STAT_NAME = "GetSocialStatName";
            /// <summary>
            /// static  System.String GetSocialStatName(SocialStat.SocialStatType type)
            /// </summary>
            /// <param name="type">enum SocialStat.SocialStatType</param>
            /// <returns>class System.String</returns>
            /// public static extern nint GET_SOCIAL_STAT_NAME (SocialStat.SocialStatType type);

            
            /// const string Name_Func_PARSE_FROM_STRING = "ParseFromString";
            /// <summary>
            ///   System.Void ParseFromString(System.String dataStr)
            /// </summary>
            /// <param name="dataStr">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void PARSE_FROM_STRING (nint dataStr);

            
            /// const string Name_Func_PARSE_TABLE = "ParseTable";
            /// <summary>
            /// static  System.Void ParseTable(System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>> table)
            /// </summary>
            /// <param name="table">class System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>></param>
            /// <returns>struct System.Void</returns>
            /// public static extern void PARSE_TABLE (nint table);

            
            /// const string Name_Func_SET_RANG = "SetRang";
            /// <summary>
            ///   System.Void SetRang(System.Int32 rang)
            /// </summary>
            /// <param name="rang">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_RANG (System.Int32 rang);

            
            /// const string Name_Func_TO_STRING = "ToString";
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint TO_STRING ();
            
            

            
            /// public static partial class Search_SocialStat
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}