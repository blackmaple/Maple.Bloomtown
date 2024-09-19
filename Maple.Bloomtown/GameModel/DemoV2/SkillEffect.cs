
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Bloomtown
{
    
    
    /// <summary>
    /// class ["Assembly-CSharp".""."SkillEffect"]
    /// [EffectHolder]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x020001E8U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [83, 107, 105, 108, 108, 69, 102, 102, 101, 99, 116])]
    
                
    // class 0x10 EffectTemplate effectTemplate
     [MonoCollectorSearchFieldAttribute(typeof(EffectTemplate.Ptr_EffectTemplate),"effectTemplate", "EFFECT_TEMPLATE")]
            
    // abstract class 0x18 Descriptable descriptable
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"descriptable", "DESCRIPTABLE")]
            
    // class 0x20 LocalizationManager.LocalizedField additionalDescription
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"additionalDescription", "ADDITIONAL_DESCRIPTION")]
            
    // class 0x28 System.String additionalDescriptionUid
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"additionalDescriptionUid", "ADDITIONAL_DESCRIPTION_UID")]
    public partial class SkillEffect
    { 
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "SkillEffect";
        //public static byte[] Static_ClassName { get; } = [83, 107, 105, 108, 108, 69, 102, 102, 101, 99, 116];

        //public const uint Const_TypeToken = 0x020001E8U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_SkillEffect(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_SkillEffect(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_SkillEffect obj) => obj._ptr;
            public static implicit operator bool(Ptr_SkillEffect obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp".""."SkillEffect"]
        /// </summary>
        public partial class SkillEffect
        { 

            
            
            /// <summary>
            ///   System.Boolean CanBeTargeted(BattleParticipantController caster, BattleParticipantController target)
            /// </summary>
            /// <param name="caster">abstract class BattleParticipantController</param>
            /// <param name="target">abstract class BattleParticipantController</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanBeTargeted")]
            ///  extern System.Boolean CAN_BE_TARGETED (nint caster, nint target);

            
            /// <summary>
            ///   System.Boolean CanUseEffectOutsideBattle()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanUseEffectOutsideBattle")]
            ///  extern System.Boolean CAN_USE_EFFECT_OUTSIDE_BATTLE ();

            
            /// <summary>
            ///   DamageType get_getDamageType()
            /// </summary>
            /// <returns>enum DamageType</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_getDamageType")]
            ///  extern DamageType GET_GET_DAMAGE_TYPE ();

            
            /// <summary>
            ///   System.Boolean get_isAoE()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isAoE")]
            ///  extern System.Boolean GET_IS_AO_E ();

            
            /// <summary>
            ///   System.Boolean get_isCastedOnAllies()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isCastedOnAllies")]
            ///  extern System.Boolean GET_IS_CASTED_ON_ALLIES ();

            
            /// <summary>
            ///   System.Boolean get_isEmpty()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isEmpty")]
            ///  extern System.Boolean GET_IS_EMPTY ();

            
            /// <summary>
            ///   EffectTemplate.CastTarget get_targetType()
            /// </summary>
            /// <returns>enum EffectTemplate.CastTarget</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_targetType")]
            ///  extern EffectTemplate.CastTarget GET_TARGET_TYPE ();

            
            /// <summary>
            ///   System.String GetDescription()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDescription")]
            ///  extern nint GET_DESCRIPTION ();

            
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
            ///   System.String GetUid()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetUid")]
            ///  extern nint GET_UID ();

            
            /// <summary>
            ///   System.Boolean HaveDispelEffect()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HaveDispelEffect")]
            ///  extern System.Boolean HAVE_DISPEL_EFFECT ();

            
            /// <summary>
            ///   System.Boolean HaveKillEffect()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HaveKillEffect")]
            ///  extern System.Boolean HAVE_KILL_EFFECT ();

            
            /// <summary>
            ///   System.Boolean HaveOffensiveEffects()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HaveOffensiveEffects")]
            ///  extern System.Boolean HAVE_OFFENSIVE_EFFECTS ();

            
            /// <summary>
            ///   System.Boolean HaveStatusEffect()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HaveStatusEffect")]
            ///  extern System.Boolean HAVE_STATUS_EFFECT ();

            
            /// <summary>
            ///   System.Boolean IsCathing()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCathing")]
            ///  extern System.Boolean IS_CATHING ();

            
            /// <summary>
            ///   System.Boolean IsCharging()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCharging")]
            ///  extern System.Boolean IS_CHARGING ();

            
            /// <summary>
            ///   System.Boolean IsCuring()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCuring")]
            ///  extern System.Boolean IS_CURING ();

            
            /// <summary>
            ///   System.Boolean IsDealingElementalDamage()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsDealingElementalDamage")]
            ///  extern System.Boolean IS_DEALING_ELEMENTAL_DAMAGE ();

            
            /// <summary>
            ///   System.Boolean IsLastingBuff()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsLastingBuff")]
            ///  extern System.Boolean IS_LASTING_BUFF ();

            
            /// <summary>
            ///   System.Boolean IsLastingDebuff()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsLastingDebuff")]
            ///  extern System.Boolean IS_LASTING_DEBUFF ();

            
            /// <summary>
            ///   System.Boolean IsRestoringHP()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsRestoringHP")]
            ///  extern System.Boolean IS_RESTORING_HP ();

            
            /// <summary>
            ///   System.Boolean IsRestoringSP()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsRestoringSP")]
            ///  extern System.Boolean IS_RESTORING_SP ();

            
            /// <summary>
            ///   System.Boolean IsReviving()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsReviving")]
            ///  extern System.Boolean IS_REVIVING ();

            
            /// <summary>
            ///   System.Void UseInWorld(Character caster, Character target, System.Boolean free)
            /// </summary>
            /// <param name="caster">class Character</param>
            /// <param name="target">class Character</param>
            /// <param name="free">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UseInWorld")]
            ///  extern void USE_IN_WORLD (nint caster, nint target, System.Boolean free);
            
            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_SkillEffect))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_SkillEffect))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Boolean CanConsumeResources(BattleParticipantController caster)
            /// </summary>
            /// <param name="caster">abstract class BattleParticipantController</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanConsumeResources", Search = typeof(Search_SkillEffect))]
            ///  extern System.Boolean CAN_CONSUME_RESOURCES_00 (nint caster);

            
            /// <summary>
            ///   System.Boolean CanConsumeResources(Character caster)
            /// </summary>
            /// <param name="caster">class Character</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanConsumeResources", Search = typeof(Search_SkillEffect))]
            ///  extern System.Boolean CAN_CONSUME_RESOURCES_01 (nint caster);

            
            /// <summary>
            ///  abstract System.Boolean CanConsumeResources(BattleParticipantController caster)
            /// </summary>
            /// <param name="caster">abstract class BattleParticipantController</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanConsumeResources", Search = typeof(Search_SkillEffect))]
            ///  extern System.Boolean CAN_CONSUME_RESOURCES_02 (nint caster);

            
            /// <summary>
            ///  abstract System.Boolean CanConsumeResources(Character caster)
            /// </summary>
            /// <param name="caster">class Character</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanConsumeResources", Search = typeof(Search_SkillEffect))]
            ///  extern System.Boolean CAN_CONSUME_RESOURCES_03 (nint caster);

            
            /// <summary>
            /// static  System.String CanUseEffect(BattleParticipantController caster, EffectHolder skill)
            /// </summary>
            /// <param name="caster">abstract class BattleParticipantController</param>
            /// <param name="skill">abstract class EffectHolder</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanUseEffect", Search = typeof(Search_SkillEffect))]
            /// static extern nint CAN_USE_EFFECT_00 (nint caster, nint skill);

            
            /// <summary>
            /// static  System.String CanUseEffect(Character caster, EffectHolder skill)
            /// </summary>
            /// <param name="caster">class Character</param>
            /// <param name="skill">abstract class EffectHolder</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanUseEffect", Search = typeof(Search_SkillEffect))]
            /// static extern nint CAN_USE_EFFECT_01 (nint caster, nint skill);

            
            /// <summary>
            /// static  System.String CanUseEffect(BattleParticipantController caster, EffectHolder skill, System.Collections.Generic.List<BattleParticipantController> skillTargets)
            /// </summary>
            /// <param name="caster">abstract class BattleParticipantController</param>
            /// <param name="skill">abstract class EffectHolder</param>
            /// <param name="skillTargets">class System.Collections.Generic.List<BattleParticipantController></param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanUseEffect", Search = typeof(Search_SkillEffect))]
            /// static extern nint CAN_USE_EFFECT_02 (nint caster, nint skill, nint skillTargets);

            
            /// <summary>
            /// static  System.String CanUseEffect(Character caster, EffectHolder skill, System.Collections.Generic.List<Character> skillTargets)
            /// </summary>
            /// <param name="caster">class Character</param>
            /// <param name="skill">abstract class EffectHolder</param>
            /// <param name="skillTargets">class System.Collections.Generic.List<Character></param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanUseEffect", Search = typeof(Search_SkillEffect))]
            /// static extern nint CAN_USE_EFFECT_03 (nint caster, nint skill, nint skillTargets);

            
            /// <summary>
            ///   System.Void ConsumeResources(BattleParticipantController caster)
            /// </summary>
            /// <param name="caster">abstract class BattleParticipantController</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ConsumeResources", Search = typeof(Search_SkillEffect))]
            ///  extern void CONSUME_RESOURCES_00 (nint caster);

            
            /// <summary>
            ///   System.Void ConsumeResources(Character caster)
            /// </summary>
            /// <param name="caster">class Character</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ConsumeResources", Search = typeof(Search_SkillEffect))]
            ///  extern void CONSUME_RESOURCES_01 (nint caster);

            
            /// <summary>
            ///  abstract System.Void ConsumeResources(BattleParticipantController caster)
            /// </summary>
            /// <param name="caster">abstract class BattleParticipantController</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ConsumeResources", Search = typeof(Search_SkillEffect))]
            ///  extern void CONSUME_RESOURCES_02 (nint caster);

            
            /// <summary>
            ///  abstract System.Void ConsumeResources(Character caster)
            /// </summary>
            /// <param name="caster">class Character</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ConsumeResources", Search = typeof(Search_SkillEffect))]
            ///  extern void CONSUME_RESOURCES_03 (nint caster);

            
            /// <summary>
            ///   System.String GetAdditionalDescription()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAdditionalDescription", Search = typeof(Search_SkillEffect))]
            ///  extern nint GET_ADDITIONAL_DESCRIPTION_00 ();

            
            /// <summary>
            ///   System.String GetAdditionalDescription()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAdditionalDescription", Search = typeof(Search_SkillEffect))]
            ///  extern nint GET_ADDITIONAL_DESCRIPTION_01 ();

            
            /// <summary>
            ///   System.Int32 GetRestriction(BattleParticipantController caster)
            /// </summary>
            /// <param name="caster">abstract class BattleParticipantController</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRestriction", Search = typeof(Search_SkillEffect))]
            ///  extern System.Int32 GET_RESTRICTION_00 (nint caster);

            
            /// <summary>
            ///   System.Int32 GetRestriction(Character caster)
            /// </summary>
            /// <param name="caster">class Character</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRestriction", Search = typeof(Search_SkillEffect))]
            ///  extern System.Int32 GET_RESTRICTION_01 (nint caster);

            
            /// <summary>
            ///  abstract System.Int32 GetRestriction(BattleParticipantController caster)
            /// </summary>
            /// <param name="caster">abstract class BattleParticipantController</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRestriction", Search = typeof(Search_SkillEffect))]
            ///  extern System.Int32 GET_RESTRICTION_02 (nint caster);

            
            /// <summary>
            ///  abstract System.Int32 GetRestriction(Character caster)
            /// </summary>
            /// <param name="caster">class Character</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRestriction", Search = typeof(Search_SkillEffect))]
            ///  extern System.Int32 GET_RESTRICTION_03 (nint caster);

            
            /// <summary>
            ///   System.String GetRestrictionText(BattleParticipantController caster)
            /// </summary>
            /// <param name="caster">abstract class BattleParticipantController</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRestrictionText", Search = typeof(Search_SkillEffect))]
            ///  extern nint GET_RESTRICTION_TEXT_00 (nint caster);

            
            /// <summary>
            ///  abstract System.String GetRestrictionText(BattleParticipantController caster)
            /// </summary>
            /// <param name="caster">abstract class BattleParticipantController</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRestrictionText", Search = typeof(Search_SkillEffect))]
            ///  extern nint GET_RESTRICTION_TEXT_01 (nint caster);

            
            /// <summary>
            ///   System.Boolean IsConsumable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsConsumable", Search = typeof(Search_SkillEffect))]
            ///  extern System.Boolean IS_CONSUMABLE_00 ();

            
            /// <summary>
            ///  abstract System.Boolean IsConsumable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsConsumable", Search = typeof(Search_SkillEffect))]
            ///  extern System.Boolean IS_CONSUMABLE_01 ();

            
            /// <summary>
            ///   System.Void Use(UsageInfo castInfo, System.Boolean free)
            /// </summary>
            /// <param name="castInfo">class UsageInfo</param>
            /// <param name="free">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Use", Search = typeof(Search_SkillEffect))]
            ///  extern void USE_00 (nint castInfo, System.Boolean free);

            
            /// <summary>
            ///   System.Void Use(System.Collections.Generic.List<UsageInfo> castInfos, System.Boolean free)
            /// </summary>
            /// <param name="castInfos">class System.Collections.Generic.List<UsageInfo></param>
            /// <param name="free">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Use", Search = typeof(Search_SkillEffect))]
            ///  extern void USE_01 (nint castInfos, System.Boolean free);

            
            /// <summary>
            ///  abstract System.Void Use(UsageInfo castInfo, System.Boolean free)
            /// </summary>
            /// <param name="castInfo">class UsageInfo</param>
            /// <param name="free">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Use", Search = typeof(Search_SkillEffect))]
            ///  extern void USE_02 (nint castInfo, System.Boolean free);

            
            /// public static partial class Search_SkillEffect
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean CanConsumeResources(BattleParticipantController caster)
                    /// </summary>
                    /// public static bool CAN_CONSUME_RESOURCES_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CanConsumeResources", "BattleParticipantController");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean CanConsumeResources(Character caster)
                    /// </summary>
                    /// public static bool CAN_CONSUME_RESOURCES_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CanConsumeResources", "Character");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Boolean CanConsumeResources(BattleParticipantController caster)
                    /// </summary>
                    /// public static bool CAN_CONSUME_RESOURCES_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CanConsumeResources", "BattleParticipantController");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Boolean CanConsumeResources(Character caster)
                    /// </summary>
                    /// public static bool CAN_CONSUME_RESOURCES_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CanConsumeResources", "Character");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.String CanUseEffect(BattleParticipantController caster, EffectHolder skill)
                    /// </summary>
                    /// public static bool CAN_USE_EFFECT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CanUseEffect", "BattleParticipantController", "EffectHolder");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.String CanUseEffect(Character caster, EffectHolder skill)
                    /// </summary>
                    /// public static bool CAN_USE_EFFECT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CanUseEffect", "Character", "EffectHolder");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.String CanUseEffect(BattleParticipantController caster, EffectHolder skill, System.Collections.Generic.List<BattleParticipantController> skillTargets)
                    /// </summary>
                    /// public static bool CAN_USE_EFFECT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CanUseEffect", "BattleParticipantController", "EffectHolder", "System.Collections.Generic.List<BattleParticipantController>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.String CanUseEffect(Character caster, EffectHolder skill, System.Collections.Generic.List<Character> skillTargets)
                    /// </summary>
                    /// public static bool CAN_USE_EFFECT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CanUseEffect", "Character", "EffectHolder", "System.Collections.Generic.List<Character>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void ConsumeResources(BattleParticipantController caster)
                    /// </summary>
                    /// public static bool CONSUME_RESOURCES_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ConsumeResources", "BattleParticipantController");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void ConsumeResources(Character caster)
                    /// </summary>
                    /// public static bool CONSUME_RESOURCES_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ConsumeResources", "Character");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void ConsumeResources(BattleParticipantController caster)
                    /// </summary>
                    /// public static bool CONSUME_RESOURCES_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ConsumeResources", "BattleParticipantController");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void ConsumeResources(Character caster)
                    /// </summary>
                    /// public static bool CONSUME_RESOURCES_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ConsumeResources", "Character");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.String GetAdditionalDescription()
                    /// </summary>
                    /// public static bool GET_ADDITIONAL_DESCRIPTION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetAdditionalDescription");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.String GetAdditionalDescription()
                    /// </summary>
                    /// public static bool GET_ADDITIONAL_DESCRIPTION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetAdditionalDescription");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Int32 GetRestriction(BattleParticipantController caster)
                    /// </summary>
                    /// public static bool GET_RESTRICTION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetRestriction", "BattleParticipantController");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Int32 GetRestriction(Character caster)
                    /// </summary>
                    /// public static bool GET_RESTRICTION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetRestriction", "Character");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Int32 GetRestriction(BattleParticipantController caster)
                    /// </summary>
                    /// public static bool GET_RESTRICTION_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetRestriction", "BattleParticipantController");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Int32 GetRestriction(Character caster)
                    /// </summary>
                    /// public static bool GET_RESTRICTION_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetRestriction", "Character");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.String GetRestrictionText(BattleParticipantController caster)
                    /// </summary>
                    /// public static bool GET_RESTRICTION_TEXT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetRestrictionText", "BattleParticipantController");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.String GetRestrictionText(BattleParticipantController caster)
                    /// </summary>
                    /// public static bool GET_RESTRICTION_TEXT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetRestrictionText", "BattleParticipantController");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean IsConsumable()
                    /// </summary>
                    /// public static bool IS_CONSUMABLE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsConsumable");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Boolean IsConsumable()
                    /// </summary>
                    /// public static bool IS_CONSUMABLE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsConsumable");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Use(UsageInfo castInfo, System.Boolean free)
                    /// </summary>
                    /// public static bool USE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Use", "UsageInfo", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Use(System.Collections.Generic.List<UsageInfo> castInfos, System.Boolean free)
                    /// </summary>
                    /// public static bool USE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Use", "System.Collections.Generic.List<UsageInfo>", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void Use(UsageInfo castInfo, System.Boolean free)
                    /// </summary>
                    /// public static bool USE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Use", "UsageInfo", "System.Boolean");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}