
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
    /// class ["Assembly-CSharp".""."EffectTemplate"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x020001E2U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [69, 102, 102, 101, 99, 116, 84, 101, 109, 112, 108, 97, 116, 101])]
    
                
    // class 0x10 System.String costStr
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"costStr", "COST_STR")]
            
    // class 0x18 System.Collections.Generic.List<EffectTemplate.EffectPrimitive> effects
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"effects", "EFFECTS")]
            
    // class 0x20 System.Collections.Generic.List<BattleEffect> special
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"special", "SPECIAL")]
            
    // enum 0x28 EffectTemplate.CastTarget target
    // [MonoCollectorSearchFieldAttribute(typeof(EffectTemplate.CastTarget),"target", "TARGET")]
            
    // struct 0x2C System.Boolean isAoE
     [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isAoE", "IS_AOE")]
            
    // enum 0x30 EffectTemplate.CostType costType
    // [MonoCollectorSearchFieldAttribute(typeof(EffectTemplate.CostType),"costType", "COST_TYPE")]
            
    // struct 0x34 System.Int32 cost
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"cost", "COST")]
            
    // enum 0x38 DamageType damageType
    // [MonoCollectorSearchFieldAttribute(typeof(DamageType),"damageType", "DAMAGE_TYPE")]
            
    // struct 0x3C System.Int32 accuracy
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"accuracy", "ACCURACY")]
            
    // struct 0x40 System.Int32 critChance
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"critChance", "CRIT_CHANCE")]
            
    // struct 0x44 System.Int32 critDamage
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"critDamage", "CRIT_DAMAGE")]
            
    // struct 0x48 System.Int32 hitsMin
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"hitsMin", "HITS_MIN")]
            
    // struct 0x4C System.Int32 hitsMax
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"hitsMax", "HITS_MAX")]
            
    // enum 0x50 StatusEffect.Type statusType
    // [MonoCollectorSearchFieldAttribute(typeof(StatusEffect.Type),"statusType", "STATUS_TYPE")]
            
    // struct 0x54 System.Int32 statusChance
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"statusChance", "STATUS_CHANCE")]
            
    // struct 0x58 System.Int32 duration
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"duration", "DURATION")]
            
    // enum 0x5C EffectTemplate.Power powerType
    // [MonoCollectorSearchFieldAttribute(typeof(EffectTemplate.Power),"powerType", "POWER_TYPE")]
    public partial class EffectTemplate
    { 
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "EffectTemplate";
        //public static byte[] Static_ClassName { get; } = [69, 102, 102, 101, 99, 116, 84, 101, 109, 112, 108, 97, 116, 101];

        //public const uint Const_TypeToken = 0x020001E2U;



                    
        /// <summary>
        /// struct System.Int32 BlankValue "0"
        /// </summary>
        /// public const System.Int32 BLANK_VALUE=>"0";
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_EffectTemplate(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_EffectTemplate(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_EffectTemplate obj) => obj._ptr;
            public static implicit operator bool(Ptr_EffectTemplate obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp".""."EffectTemplate"]
        /// </summary>
        public partial class EffectTemplate
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();

            
            /// <summary>
            ///   System.Boolean get_isCastedOnAllies()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isCastedOnAllies")]
            ///  extern System.Boolean GET_IS_CASTED_ON_ALLIES ();

            
            /// <summary>
            ///   System.Boolean get_isStrengthAttack()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isStrengthAttack")]
            ///  extern System.Boolean GET_IS_STRENGTH_ATTACK ();

            
            /// <summary>
            ///   System.Void Parse(System.Collections.Generic.Dictionary<System.String,System.Object> row, System.String uid)
            /// </summary>
            /// <param name="row">class System.Collections.Generic.Dictionary<System.String,System.Object></param>
            /// <param name="uid">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Parse")]
            ///  extern void PARSE (nint row, nint uid);

            
            /// <summary>
            /// static  System.Collections.Generic.List<EffectTemplate.EffectPrimitive> ParseEffectPrimitives(System.String data)
            /// </summary>
            /// <param name="data">class System.String</param>
            /// <returns>class System.Collections.Generic.List<EffectTemplate.EffectPrimitive></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ParseEffectPrimitives")]
            /// static extern nint PARSE_EFFECT_PRIMITIVES (nint data);

            
            /// <summary>
            /// static  System.Collections.Generic.List<BattleEffect> ParseSpecials(System.String data)
            /// </summary>
            /// <param name="data">class System.String</param>
            /// <returns>class System.Collections.Generic.List<BattleEffect></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ParseSpecials")]
            /// static extern nint PARSE_SPECIALS (nint data);
            
            

            
            /// public static partial class Search_EffectTemplate
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}