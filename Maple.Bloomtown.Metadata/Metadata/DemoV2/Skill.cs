
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
    /// class ["Assembly-CSharp".""."Skill"]
    /// [System.Object]
    /// [ISaveable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x020001E7U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [83, 107, 105, 108, 108])]


    // class 0x10 SkillInfo skillInfo
    [MonoCollectorSearchFieldAttribute(typeof(SkillInfo.Ptr_SkillInfo), "skillInfo", "SKILL_INFO")]

    // struct 0x18 System.Int32 level
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"level", "LEVEL")]
    public partial class Skill
    {
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "Skill";
        //public static byte[] Static_ClassName { get; } = [83, 107, 105, 108, 108];

        //public const uint Const_TypeToken = 0x020001E7U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Skill(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Skill(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Skill obj) => obj._ptr;
            public static implicit operator bool(Ptr_Skill obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp".""."Skill"]
    /// </summary>
    public partial class Skill
    {



        /// <summary>
        ///   System.Void Deserialize(System.String data)
        /// </summary>
        /// <param name="data">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Deserialize")]
        ///  extern void DESERIALIZE (nint data);


        /// <summary>
        /// static  Skill DeserializeStatic(System.String dataStr)
        /// </summary>
        /// <param name="dataStr">class System.String</param>
        /// <returns>class Skill</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DeserializeStatic")]
        /// static extern nint DESERIALIZE_STATIC (nint dataStr);


        /// <summary>
        ///   System.String get_getUID()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_getUID")]
        ///  extern nint GET_GET_UID ();


        /// <summary>
        ///   System.String GetDescription()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDescription")]
        ///  extern nint GET_DESCRIPTION ();


        /// <summary>
        ///   LocalizationManager.LocalizedField GetDescriptionField()
        /// </summary>
        /// <returns>class LocalizationManager.LocalizedField</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDescriptionField")]
        ///  extern nint GET_DESCRIPTION_FIELD ();


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
        ///   LocalizationManager.LocalizedField GetNameField()
        /// </summary>
        /// <returns>class LocalizationManager.LocalizedField</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNameField")]
        ///  extern nint GET_NAME_FIELD ();


        /// <summary>
        ///   System.Int32 GetRestriction(BattleParticipantController caster)
        /// </summary>
        /// <param name="caster">abstract class BattleParticipantController</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRestriction")]
        ///  extern System.Int32 GET_RESTRICTION (nint caster);


        /// <summary>
        ///   System.String GetRestrictionText(BattleParticipantController caster)
        /// </summary>
        /// <param name="caster">abstract class BattleParticipantController</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRestrictionText")]
        ///  extern nint GET_RESTRICTION_TEXT (nint caster);


        /// <summary>
        ///   System.String Serialize()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Serialize")]
        ///  extern nint SERIALIZE ();



        /// <summary>
        ///   System.Void .ctor(System.String data)
        /// </summary>
        /// <param name="data">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Skill))]
        ///  extern void .CTOR_00 (nint data);


        /// <summary>
        ///   System.Void .ctor(SkillInfo skillInfo)
        /// </summary>
        /// <param name="skillInfo">class SkillInfo</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Skill))]
        extern void CTOR_01(nint skillInfo);


        public static partial class Search_Skill
        {
            /// 
            ///     

            /// <summary>
            ///   System.Void .ctor(System.String data)
            /// </summary>
            /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor(SkillInfo skillInfo)
            /// </summary>
            public static bool CTOR_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "SkillInfo");
            ///     
            ///  
            /// 
            /// 
        }

    }


}