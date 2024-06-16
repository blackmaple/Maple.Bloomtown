
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
    public partial class StatusEffect
    { 
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "StatusEffect";
        //public static byte[] Static_ClassName { get; } = [83, 116, 97, 116, 117, 115, 69, 102, 102, 101, 99, 116];

        //public const uint Const_TypeToken = 0x020000ECU;



        
            
        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Static_StatusEffect
        {

            
                        
            /// const string Name_Field_SkipTurnTypes = "SkipTurnTypes";
            /// <summary>
            /// class 0x0 StatusEffect.Type[] SkipTurnTypes
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly nint SkipTurnTypes;

                        
            /// const string Name_Field_RepelsWithDamage = "RepelsWithDamage";
            /// <summary>
            /// class 0x8 StatusEffect.Type[] RepelsWithDamage
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            public readonly nint RepelsWithDamage;

                        
            /// const string Name_Field_RepelsWithHoldUp = "RepelsWithHoldUp";
            /// <summary>
            /// class 0x10 StatusEffect.Type[] RepelsWithHoldUp
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly nint RepelsWithHoldUp;

                        
            /// const string Name_Field_ContainedInRandomStatus = "ContainedInRandomStatus";
            /// <summary>
            /// class 0x18 StatusEffect.Type[] ContainedInRandomStatus
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            public readonly nint ContainedInRandomStatus;

        }

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_StatusEffect
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
            
            
                        
            /// const string Name_Field_type = "type";
            /// <summary>
            /// enum 0x10 StatusEffect.Type type
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly  Type type;

                        
            /// const string Name_Field_duration = "duration";
            /// <summary>
            /// struct 0x14 System.Int32 duration
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x14)]
            public readonly System.Int32 duration;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_StatusEffect(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_StatusEffect(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_StatusEffect obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_StatusEffect AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_StatusEffect>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp".""."StatusEffect"]
        /// </summary>
        public partial class StatusEffect
        { 

            
            
            /// const string Name_Func_.CCTOR = ".cctor";
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public static extern void .CCTOR ();

            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR ();

            
            /// const string Name_Func_GET_IS_DOWNED = "get_isDowned";
            /// <summary>
            ///   System.Boolean get_isDowned()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean GET_IS_DOWNED ();

            
            /// const string Name_Func_GET_EFFECT_ON_CHARACTER_DESCRIPTION = "GetEffectOnCharacterDescription";
            /// <summary>
            ///   System.String GetEffectOnCharacterDescription()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_EFFECT_ON_CHARACTER_DESCRIPTION ();
            
            
            
            /// const string Name_Func_IS_TECHNICAL = "IsTechnical";
            /// <summary>
            /// static  System.Boolean IsTechnical(StatusEffect.Type effectType,DamageType damageType)
            /// </summary>
            /// <param name="effectType">enum StatusEffect.Type</param>
            /// <param name="damageType">enum DamageType</param>
            /// <returns>struct System.Boolean</returns>
            /// public static extern System.Boolean IS_TECHNICAL_00 (StatusEffect.Type effectType,DamageType damageType);

            
            /// const string Name_Func_IS_TECHNICAL = "IsTechnical";
            /// <summary>
            ///   System.Boolean IsTechnical(DamageType damageType)
            /// </summary>
            /// <param name="damageType">enum DamageType</param>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean IS_TECHNICAL_01 (DamageType damageType);

            
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