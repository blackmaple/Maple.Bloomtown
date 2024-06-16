
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
    public partial class Skill
    { 
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "Skill";
        //public static byte[] Static_ClassName { get; } = [83, 107, 105, 108, 108];

        //public const uint Const_TypeToken = 0x020001E7U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_Skill
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
            
            
                        
            /// const string Name_Field_skillInfo = "skillInfo";
            /// <summary>
            /// class 0x10 SkillInfo skillInfo
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly nint skillInfo;

                        
            /// const string Name_Field_level = "level";
            /// <summary>
            /// struct 0x18 System.Int32 level
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            public readonly System.Int32 level;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Skill(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Skill(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Skill obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_Skill AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_Skill>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp".""."Skill"]
        /// </summary>
        public partial class Skill
        { 

            
            
            /// const string Name_Func_DESERIALIZE = "Deserialize";
            /// <summary>
            ///   System.Void Deserialize(System.String data)
            /// </summary>
            /// <param name="data">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void DESERIALIZE (nint data);

            
            /// const string Name_Func_DESERIALIZE_STATIC = "DeserializeStatic";
            /// <summary>
            /// static  Skill DeserializeStatic(System.String dataStr)
            /// </summary>
            /// <param name="dataStr">class System.String</param>
            /// <returns>class Skill</returns>
            /// public static extern nint DESERIALIZE_STATIC (nint dataStr);

            
            /// const string Name_Func_GET_GET_UID = "get_getUID";
            /// <summary>
            ///   System.String get_getUID()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_GET_UID ();

            
            /// const string Name_Func_GET_DESCRIPTION = "GetDescription";
            /// <summary>
            ///   System.String GetDescription()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_DESCRIPTION ();

            
            /// const string Name_Func_GET_DESCRIPTION_FIELD = "GetDescriptionField";
            /// <summary>
            ///   LocalizationManager.LocalizedField GetDescriptionField()
            /// </summary>
            /// <returns>class LocalizationManager.LocalizedField</returns>
            /// public  extern nint GET_DESCRIPTION_FIELD ();

            
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

            
            /// const string Name_Func_GET_NAME_FIELD = "GetNameField";
            /// <summary>
            ///   LocalizationManager.LocalizedField GetNameField()
            /// </summary>
            /// <returns>class LocalizationManager.LocalizedField</returns>
            /// public  extern nint GET_NAME_FIELD ();

            
            /// const string Name_Func_GET_RESTRICTION = "GetRestriction";
            /// <summary>
            ///   System.Int32 GetRestriction(BattleParticipantController caster)
            /// </summary>
            /// <param name="caster">abstract class BattleParticipantController</param>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_RESTRICTION (nint caster);

            
            /// const string Name_Func_GET_RESTRICTION_TEXT = "GetRestrictionText";
            /// <summary>
            ///   System.String GetRestrictionText(BattleParticipantController caster)
            /// </summary>
            /// <param name="caster">abstract class BattleParticipantController</param>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_RESTRICTION_TEXT (nint caster);

            
            /// const string Name_Func_SERIALIZE = "Serialize";
            /// <summary>
            ///   System.String Serialize()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint SERIALIZE ();
            
            
            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor(System.String data)
            /// </summary>
            /// <param name="data">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR_00 (nint data);

            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor(SkillInfo skillInfo)
            /// </summary>
            /// <param name="skillInfo">class SkillInfo</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR_01 (nint skillInfo);

            
            /// public static partial class Search_Skill
            /// {
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
                    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "SkillInfo");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}