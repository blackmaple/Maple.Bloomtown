
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
    /// class ["Assembly-CSharp".""."StatusEffect"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x020000ECU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [83, 116, 97, 116, 117, 115, 69, 102, 102, 101, 99, 116])]
                
    //  class static StatusEffect.Type[] SkipTurnTypes
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"SkipTurnTypes", "SKIP_TURN_TYPES"), true]
            
    //  class static StatusEffect.Type[] RepelsWithDamage
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"RepelsWithDamage", "REPELS_WITH_DAMAGE"), true]
            
    //  class static StatusEffect.Type[] RepelsWithHoldUp
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"RepelsWithHoldUp", "REPELS_WITH_HOLD_UP"), true]
            
    //  class static StatusEffect.Type[] ContainedInRandomStatus
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"ContainedInRandomStatus", "CONTAINED_IN_RANDOM_STATUS"), true]
                
    // enum 0x10 StatusEffect.Type type
    // [MonoCollectorSearchFieldAttribute(typeof(StatusEffect.Type),"type", "TYPE")]
            
    // struct 0x14 System.Int32 duration
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"duration", "DURATION")]
    public partial class StatusEffect
    { 
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "StatusEffect";
        //public static byte[] Static_ClassName { get; } = [83, 116, 97, 116, 117, 115, 69, 102, 102, 101, 99, 116];

        //public const uint Const_TypeToken = 0x020000ECU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_StatusEffect(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_StatusEffect(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_StatusEffect obj) => obj._ptr;
            public static implicit operator bool(Ptr_StatusEffect obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp".""."StatusEffect"]
        /// </summary>
        public partial class StatusEffect
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
            ///   System.Boolean get_isDowned()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isDowned")]
            ///  extern System.Boolean GET_IS_DOWNED ();

            
            /// <summary>
            ///   System.String GetEffectOnCharacterDescription()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEffectOnCharacterDescription")]
            ///  extern nint GET_EFFECT_ON_CHARACTER_DESCRIPTION ();
            
            
            
            /// <summary>
            /// static  System.Boolean IsTechnical(StatusEffect.Type effectType, DamageType damageType)
            /// </summary>
            /// <param name="effectType">enum StatusEffect.Type</param>
            /// <param name="damageType">enum DamageType</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsTechnical", Search = typeof(Search_StatusEffect))]
            /// static extern System.Boolean IS_TECHNICAL_00 (StatusEffect.Type effectType, DamageType damageType);

            
            /// <summary>
            ///   System.Boolean IsTechnical(DamageType damageType)
            /// </summary>
            /// <param name="damageType">enum DamageType</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsTechnical", Search = typeof(Search_StatusEffect))]
            ///  extern System.Boolean IS_TECHNICAL_01 (DamageType damageType);

            
            /// public static partial class Search_StatusEffect
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    /// static  System.Boolean IsTechnical(StatusEffect.Type effectType, DamageType damageType)
                    /// </summary>
                    /// public static bool IS_TECHNICAL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsTechnical", "StatusEffect.Type", "DamageType");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean IsTechnical(DamageType damageType)
                    /// </summary>
                    /// public static bool IS_TECHNICAL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsTechnical", "DamageType");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}