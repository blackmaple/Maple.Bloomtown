
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
    /// class ["Assembly-CSharp".""."PassiveEffect"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x020000E7U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [80, 97, 115, 115, 105, 118, 101, 69, 102, 102, 101, 99, 116])]
                
    //  class static PassiveEffect.Effect[] needStatusTypeEffects
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"needStatusTypeEffects", "NEED_STATUS_TYPE_EFFECTS"), true]
            
    //  class static PassiveEffect.Effect[] needAttackTypeEffects
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"needAttackTypeEffects", "NEED_ATTACK_TYPE_EFFECTS"), true]
                
    // class 0x10 System.String UID
    [MonoCollectorSearchFieldAttribute(typeof(nint),"UID", "UID")]
            
    // class 0x18 LocalizationManager.LocalizedField name
    [MonoCollectorSearchFieldAttribute(typeof(nint),"name", "NAME")]
            
    // class 0x20 LocalizationManager.LocalizedField description
    [MonoCollectorSearchFieldAttribute(typeof(nint),"description", "DESCRIPTION")]
            
    // class 0x28 System.String nameUid
    [MonoCollectorSearchFieldAttribute(typeof(nint),"nameUid", "NAME_UID")]
            
    // class 0x30 System.String descriptionUid
    [MonoCollectorSearchFieldAttribute(typeof(nint),"descriptionUid", "DESCRIPTION_UID")]
            
    // class 0x38 System.String argStr
    [MonoCollectorSearchFieldAttribute(typeof(nint),"argStr", "ARG_STR")]
            
    // enum 0x40 PassiveEffect.Effect effect
    [MonoCollectorSearchFieldAttribute(typeof(PassiveEffect.Effect),"effect", "EFFECT")]
            
    // struct 0x44 System.Int32 arg
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"arg", "ARG")]
            
    // enum 0x48 StatusEffect.Type statusType
    [MonoCollectorSearchFieldAttribute(typeof(StatusEffect.Type),"statusType", "STATUS_TYPE")]
            
    // enum 0x4C DamageType damageType
    [MonoCollectorSearchFieldAttribute(typeof(DamageType),"damageType", "DAMAGE_TYPE")]
            
    // enum 0x50 PassiveEffect.PowerInfliction powerInfliction
    [MonoCollectorSearchFieldAttribute(typeof(PassiveEffect.PowerInfliction),"powerInfliction", "POWER_INFLICTION")]
    public partial class PassiveEffect
    { 
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "PassiveEffect";
        //public static byte[] Static_ClassName { get; } = [80, 97, 115, 115, 105, 118, 101, 69, 102, 102, 101, 99, 116];

        //public const uint Const_TypeToken = 0x020000E7U;



        
            
        

        

    }

        /// <summary>
        /// ["Assembly-CSharp".""."PassiveEffect"]
        /// </summary>
        public partial class PassiveEffect
        { 

            
            
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
            /// static extern void .CCTOR ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();

            
            /// <summary>
            ///   System.Void FromString(System.String effectInfo, System.Int32 inpArg)
            /// </summary>
            /// <param name="effectInfo">class System.String</param>
            /// <param name="inpArg">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromString")]
            ///  extern void FROM_STRING (nint effectInfo, System.Int32 inpArg);

            
            /// <summary>
            ///   System.Boolean get_isEmpty()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isEmpty")]
            ///  extern System.Boolean GET_IS_EMPTY ();

            
            /// <summary>
            ///   System.Boolean get_isImplemented()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isImplemented")]
            ///  extern System.Boolean GET_IS_IMPLEMENTED ();

            
            /// <summary>
            /// static  DamageType GetDamageType(System.String str)
            /// </summary>
            /// <param name="str">class System.String</param>
            /// <returns>enum DamageType</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDamageType")]
            /// static extern DamageType GET_DAMAGE_TYPE (nint str);

            
            /// <summary>
            /// static  PassiveEffect.Effect GetEffectType(System.String str)
            /// </summary>
            /// <param name="str">class System.String</param>
            /// <returns>enum PassiveEffect.Effect</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEffectType")]
            /// static extern PassiveEffect.Effect GET_EFFECT_TYPE (nint str);

            
            /// <summary>
            /// static  StatusEffect.Type GetStatusType(System.String str)
            /// </summary>
            /// <param name="str">class System.String</param>
            /// <returns>enum StatusEffect.Type</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetStatusType")]
            /// static extern StatusEffect.Type GET_STATUS_TYPE (nint str);
            
            
            
            /// <summary>
            /// static  PassiveEffect Parse(System.String data)
            /// </summary>
            /// <param name="data">class System.String</param>
            /// <returns>class PassiveEffect</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Parse", Search = typeof(Search_PassiveEffect))]
            /// static extern nint PARSE_00 (nint data);

            
            /// <summary>
            /// static  System.Void Parse(System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>> table)
            /// </summary>
            /// <param name="table">class System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Parse", Search = typeof(Search_PassiveEffect))]
            /// static extern void PARSE_01 (nint table);

            
            /// public static partial class Search_PassiveEffect
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    /// static  PassiveEffect Parse(System.String data)
                    /// </summary>
                    /// public static bool PARSE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Parse", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void Parse(System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>> table)
                    /// </summary>
                    /// public static bool PARSE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Parse", "System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>>");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}