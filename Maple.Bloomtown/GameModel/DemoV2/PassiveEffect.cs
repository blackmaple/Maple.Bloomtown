
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
    public partial class PassiveEffect
    {
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "PassiveEffect";
        //public static byte[] Static_ClassName { get; } = [80, 97, 115, 115, 105, 118, 101, 69, 102, 102, 101, 99, 116];

        //public const uint Const_TypeToken = 0x020000E7U;






        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Static_PassiveEffect
        {



            /// const string Name_Field_needStatusTypeEffects = "needStatusTypeEffects";
            /// <summary>
            /// class 0x0 PassiveEffect.Effect[] needStatusTypeEffects
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly nint needStatusTypeEffects;


            /// const string Name_Field_needAttackTypeEffects = "needAttackTypeEffects";
            /// <summary>
            /// class 0x8 PassiveEffect.Effect[] needAttackTypeEffects
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            public readonly nint needAttackTypeEffects;

        }


        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_PassiveEffect
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



            /// const string Name_Field_UID = "UID";
            /// <summary>
            /// class 0x10 System.String UID
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly nint UID;


            /// const string Name_Field_name = "name";
            /// <summary>
            /// class 0x18 LocalizationManager.LocalizedField name
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            public readonly nint name;


            /// const string Name_Field_description = "description";
            /// <summary>
            /// class 0x20 LocalizationManager.LocalizedField description
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly nint description;


            /// const string Name_Field_nameUid = "nameUid";
            /// <summary>
            /// class 0x28 System.String nameUid
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public readonly nint nameUid;


            /// const string Name_Field_descriptionUid = "descriptionUid";
            /// <summary>
            /// class 0x30 System.String descriptionUid
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public readonly nint descriptionUid;


            /// const string Name_Field_argStr = "argStr";
            /// <summary>
            /// class 0x38 System.String argStr
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            [MonoCollectorProperty(PropertyName = "ArgStr")]
            public readonly PMonoString argStr;


            /// const string Name_Field_effect = "effect";
            /// <summary>
            /// enum 0x40 PassiveEffect.Effect effect
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly  Effect effect;


            /// const string Name_Field_arg = "arg";
            /// <summary>
            /// struct 0x44 System.Int32 arg
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x44)]
            public readonly System.Int32 arg;


            /// const string Name_Field_statusType = "statusType";
            /// <summary>
            /// enum 0x48 StatusEffect.Type statusType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public readonly  Type statusType;


            /// const string Name_Field_damageType = "damageType";
            /// <summary>
            /// enum 0x4C DamageType damageType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x4C)]
            public readonly DamageType damageType;


            /// const string Name_Field_powerInfliction = "powerInfliction";
            /// <summary>
            /// enum 0x50 PassiveEffect.PowerInfliction powerInfliction
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x50)]
            public readonly  PowerInfliction powerInfliction;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_PassiveEffect(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_PassiveEffect(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_PassiveEffect obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_PassiveEffect AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_PassiveEffect>(_ptr.ToPointer());
            }
        }

    }

    /// <summary>
    /// ["Assembly-CSharp".""."PassiveEffect"]
    /// </summary>
    public partial class PassiveEffect
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


        /// const string Name_Func_FROM_STRING = "FromString";
        /// <summary>
        ///   System.Void FromString(System.String effectInfo,System.Int32 inpArg)
        /// </summary>
        /// <param name="effectInfo">class System.String</param>
        /// <param name="inpArg">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void FROM_STRING (nint effectInfo,System.Int32 inpArg);


        /// const string Name_Func_GET_IS_EMPTY = "get_isEmpty";
        /// <summary>
        ///   System.Boolean get_isEmpty()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_IS_EMPTY ();


        /// const string Name_Func_GET_IS_IMPLEMENTED = "get_isImplemented";
        /// <summary>
        ///   System.Boolean get_isImplemented()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_IS_IMPLEMENTED ();


        /// const string Name_Func_GET_DAMAGE_TYPE = "GetDamageType";
        /// <summary>
        /// static  DamageType GetDamageType(System.String str)
        /// </summary>
        /// <param name="str">class System.String</param>
        /// <returns>enum DamageType</returns>
        /// public static extern DamageType GET_DAMAGE_TYPE (nint str);


        /// const string Name_Func_GET_EFFECT_TYPE = "GetEffectType";
        /// <summary>
        /// static  PassiveEffect.Effect GetEffectType(System.String str)
        /// </summary>
        /// <param name="str">class System.String</param>
        /// <returns>enum PassiveEffect.Effect</returns>
        /// public static extern PassiveEffect.Effect GET_EFFECT_TYPE (nint str);


        /// const string Name_Func_GET_STATUS_TYPE = "GetStatusType";
        /// <summary>
        /// static  StatusEffect.Type GetStatusType(System.String str)
        /// </summary>
        /// <param name="str">class System.String</param>
        /// <returns>enum StatusEffect.Type</returns>
        /// public static extern StatusEffect.Type GET_STATUS_TYPE (nint str);



        /// const string Name_Func_PARSE = "Parse";
        /// <summary>
        /// static  PassiveEffect Parse(System.String data)
        /// </summary>
        /// <param name="data">class System.String</param>
        /// <returns>class PassiveEffect</returns>
        /// public static extern nint PARSE_00 (nint data);


        /// const string Name_Func_PARSE = "Parse";
        /// <summary>
        /// static  System.Void Parse(System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>> table)
        /// </summary>
        /// <param name="table">class System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>></param>
        /// <returns>struct System.Void</returns>
        /// public static extern void PARSE_01 (nint table);


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