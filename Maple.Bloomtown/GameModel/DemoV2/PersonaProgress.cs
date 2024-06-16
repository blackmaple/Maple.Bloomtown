
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
    /// class ["Assembly-CSharp".""."PersonaProgress"]
    /// [System.Object]
    /// [ISaveable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x0200041FU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [80, 101, 114, 115, 111, 110, 97, 80, 114, 111, 103, 114, 101, 115, 115])]
    public partial class PersonaProgress
    { 
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "PersonaProgress";
        //public static byte[] Static_ClassName { get; } = [80, 101, 114, 115, 111, 110, 97, 80, 114, 111, 103, 114, 101, 115, 115];

        //public const uint Const_TypeToken = 0x0200041FU;



        
        public readonly unsafe partial struct Const_PersonaProgress
        {

            
                        
            /// <summary>
            /// struct System.Int32 SkillCountMax "0"
            /// </summary>
            /// public System.Int32 SKILL_COUNT_MAX=>"0";

        }
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_PersonaProgress
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
            
            
                        
            /// const string Name_Field_monsterModel = "monsterModel";
            /// <summary>
            /// class 0x10 BattleMonsterModel monsterModel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly nint monsterModel;

                        
            /// const string Name_Field_monsterPreviewMini = "monsterPreviewMini";
            /// <summary>
            /// class 0x18 UnityEngine.Sprite monsterPreviewMini
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            public readonly nint monsterPreviewMini;

                        
            /// const string Name_Field_monsterPreview = "monsterPreview";
            /// <summary>
            /// class 0x20 UnityEngine.Sprite monsterPreview
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly nint monsterPreview;

                        
            /// const string Name_Field_monsterPreviewMicro = "monsterPreviewMicro";
            /// <summary>
            /// class 0x28 UnityEngine.Sprite monsterPreviewMicro
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public readonly nint monsterPreviewMicro;

                        
            /// const string Name_Field_holder = "holder";
            /// <summary>
            /// class 0x30 BattlePlayerModel holder
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public readonly nint holder;

                        
            /// const string Name_Field_m_saveResists = "m_saveResists";
            /// <summary>
            /// class 0x38 System.Collections.Generic.List<Resist> m_saveResists
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            public readonly nint m_saveResists;

                        
            /// const string Name_Field_m_skill = "m_skill";
            /// <summary>
            /// class 0x40 System.Collections.Generic.List<Skill> m_skill
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly nint m_skill;

                        
            /// const string Name_Field_level = "level";
            /// <summary>
            /// struct 0x48 System.Int32 level
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public readonly System.Int32 level;

                        
            /// const string Name_Field_exp = "exp";
            /// <summary>
            /// struct 0x4C System.Int32 exp
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x4C)]
            public readonly System.Int32 exp;

                        
            /// const string Name_Field_levelOfGetLastSkill = "levelOfGetLastSkill";
            /// <summary>
            /// struct 0x50 System.Int32 levelOfGetLastSkill
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x50)]
            public readonly System.Int32 levelOfGetLastSkill;

                        
            /// const string Name_Field_m_strength = "m_strength";
            /// <summary>
            /// struct 0x54 System.Int32 m_strength
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x54)]
            public readonly System.Int32 m_strength;

                        
            /// const string Name_Field_m_magic = "m_magic";
            /// <summary>
            /// struct 0x58 System.Int32 m_magic
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x58)]
            public readonly System.Int32 m_magic;

                        
            /// const string Name_Field_m_endurance = "m_endurance";
            /// <summary>
            /// struct 0x5C System.Int32 m_endurance
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x5C)]
            public readonly System.Int32 m_endurance;

                        
            /// const string Name_Field_m_agility = "m_agility";
            /// <summary>
            /// struct 0x60 System.Int32 m_agility
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x60)]
            public readonly System.Int32 m_agility;

                        
            /// const string Name_Field_m_luck = "m_luck";
            /// <summary>
            /// struct 0x64 System.Int32 m_luck
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x64)]
            public readonly System.Int32 m_luck;

                        
            /// const string Name_Field_prevStrength = "prevStrength";
            /// <summary>
            /// struct 0x68 System.Int32 prevStrength
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x68)]
            public readonly System.Int32 prevStrength;

                        
            /// const string Name_Field_prevMagic = "prevMagic";
            /// <summary>
            /// struct 0x6C System.Int32 prevMagic
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x6C)]
            public readonly System.Int32 prevMagic;

                        
            /// const string Name_Field_prevEndurance = "prevEndurance";
            /// <summary>
            /// struct 0x70 System.Int32 prevEndurance
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x70)]
            public readonly System.Int32 prevEndurance;

                        
            /// const string Name_Field_prevAgility = "prevAgility";
            /// <summary>
            /// struct 0x74 System.Int32 prevAgility
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x74)]
            public readonly System.Int32 prevAgility;

                        
            /// const string Name_Field_prevLuck = "prevLuck";
            /// <summary>
            /// struct 0x78 System.Int32 prevLuck
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x78)]
            public readonly System.Int32 prevLuck;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_PersonaProgress(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_PersonaProgress(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_PersonaProgress obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_PersonaProgress AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_PersonaProgress>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp".""."PersonaProgress"]
        /// </summary>
        public partial class PersonaProgress
        { 

            
            
            /// const string Name_Func_<GET_SKILLS>B__50_0 = "<GetSkills>b__50_0";
            /// <summary>
            ///   System.Boolean <GetSkills>b__50_0(Skill x)
            /// </summary>
            /// <param name="x">class Skill</param>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean <GET_SKILLS>B__50_0 (nint x);

            
            /// const string Name_Func_<SET_LEVEL>G__ADD_LEVEL|57_0 = "<SetLevel>g__AddLevel|57_0";
            /// <summary>
            ///   System.Void <SetLevel>g__AddLevel|57_0()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void <SET_LEVEL>G__ADD_LEVEL|57_0 ();

            
            /// const string Name_Func_ADD_SKILL = "AddSkill";
            /// <summary>
            ///   System.Void AddSkill(Skill skill)
            /// </summary>
            /// <param name="skill">class Skill</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void ADD_SKILL (nint skill);

            
            /// const string Name_Func_CAN_GET_NEW_SKILL = "CanGetNewSkill";
            /// <summary>
            ///   System.Boolean CanGetNewSkill()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean CAN_GET_NEW_SKILL ();

            
            /// const string Name_Func_DESERIALIZE = "Deserialize";
            /// <summary>
            ///   System.Void Deserialize(System.String dataStr)
            /// </summary>
            /// <param name="dataStr">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void DESERIALIZE (nint dataStr);

            
            /// const string Name_Func_GET_AGILITY = "get_agility";
            /// <summary>
            ///   System.Int32 get_agility()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_AGILITY ();

            
            /// const string Name_Func_GET_ENDURANCE = "get_endurance";
            /// <summary>
            ///   System.Int32 get_endurance()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_ENDURANCE ();

            
            /// const string Name_Func_GET_GET_UID = "get_getUID";
            /// <summary>
            ///   System.String get_getUID()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_GET_UID ();

            
            /// const string Name_Func_GET_HOLDER_CHAR = "get_holderChar";
            /// <summary>
            ///   Character get_holderChar()
            /// </summary>
            /// <returns>class Character</returns>
            /// public  extern nint GET_HOLDER_CHAR ();

            
            /// const string Name_Func_GET_LUCK = "get_luck";
            /// <summary>
            ///   System.Int32 get_luck()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_LUCK ();

            
            /// const string Name_Func_GET_MAGIC = "get_magic";
            /// <summary>
            ///   System.Int32 get_magic()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_MAGIC ();

            
            /// const string Name_Func_GET_SKILLS = "get_skills";
            /// <summary>
            ///   System.Collections.Generic.List<Skill> get_skills()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Skill></returns>
            /// public  extern nint GET_SKILLS ();

            
            /// const string Name_Func_GET_STRENGTH = "get_strength";
            /// <summary>
            ///   System.Int32 get_strength()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_STRENGTH ();

            
            /// const string Name_Func_GET_UNLOCKED_SKILLS_EFFECTS = "get_unlockedSkillsEffects";
            /// <summary>
            ///   System.Collections.Generic.List<EffectHolder> get_unlockedSkillsEffects()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<EffectHolder></returns>
            /// public  extern nint GET_UNLOCKED_SKILLS_EFFECTS ();

            
            /// const string Name_Func_GET_ALL_RESISTS = "GetAllResists";
            /// <summary>
            ///   System.Collections.Generic.List<Resist> GetAllResists()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Resist></returns>
            /// public  extern nint GET_ALL_RESISTS ();

            
            /// const string Name_Func_GET_BASE_RESIST = "GetBaseResist";
            /// <summary>
            ///   Resist GetBaseResist(DamageType damageType)
            /// </summary>
            /// <param name="damageType">enum DamageType</param>
            /// <returns>class Resist</returns>
            /// public  extern nint GET_BASE_RESIST (DamageType damageType);

            
            /// const string Name_Func_GET_EXP_TO_PERSONA_LEVEL = "GetExpToPersonaLevel";
            /// <summary>
            /// static  System.Int32 GetExpToPersonaLevel(System.Int32 lvl)
            /// </summary>
            /// <param name="lvl">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /// public static extern System.Int32 GET_EXP_TO_PERSONA_LEVEL (System.Int32 lvl);

            
            /// const string Name_Func_GET_NEAREST_SKILL_LEVEL = "GetNearestSkillLevel";
            /// <summary>
            ///   System.Int32 GetNearestSkillLevel()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_NEAREST_SKILL_LEVEL ();

            
            /// const string Name_Func_GET_SKILLS = "GetSkills";
            /// <summary>
            ///   System.Collections.Generic.List<Skill> GetSkills()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Skill></returns>
            /// public  extern nint GET_SKILLS ();

            
            /// const string Name_Func_GET_STAT = "GetStat";
            /// <summary>
            ///   System.Int32 GetStat(PersonaProgress.StateType stateType)
            /// </summary>
            /// <param name="stateType">enum PersonaProgress.StateType</param>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_STAT (PersonaProgress.StateType stateType);

            
            /// const string Name_Func_INITIALIZE_PREV_STATS = "InitializePrevStats";
            /// <summary>
            ///   System.Void InitializePrevStats()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void INITIALIZE_PREV_STATS ();

            
            /// const string Name_Func_REMOVE_SKILL = "RemoveSkill";
            /// <summary>
            ///   System.Void RemoveSkill(Skill skill)
            /// </summary>
            /// <param name="skill">class Skill</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void REMOVE_SKILL (nint skill);

            
            /// const string Name_Func_SERIALIZE = "Serialize";
            /// <summary>
            ///   System.String Serialize()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint SERIALIZE ();

            
            /// const string Name_Func_SET_SKILLS = "set_skills";
            /// <summary>
            ///   System.Void set_skills(System.Collections.Generic.List<Skill> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<Skill></param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_SKILLS (nint value);

            
            /// const string Name_Func_SET_LEVEL = "SetLevel";
            /// <summary>
            ///   System.Void SetLevel(System.Int32 lvl)
            /// </summary>
            /// <param name="lvl">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_LEVEL (System.Int32 lvl);

            
            /// const string Name_Func_SET_PREVIEW = "SetPreview";
            /// <summary>
            ///   System.Void SetPreview(BattleMonsterView monsterView)
            /// </summary>
            /// <param name="monsterView">class BattleMonsterView</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_PREVIEW (nint monsterView);

            
            /// const string Name_Func_SET_RESIST = "SetResist";
            /// <summary>
            ///   System.Void SetResist(Resist resist)
            /// </summary>
            /// <param name="resist">class Resist</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_RESIST (nint resist);
            
            
            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR_00 ();

            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor(BattleMonsterModel monsterModel)
            /// </summary>
            /// <param name="monsterModel">class BattleMonsterModel</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR_01 (nint monsterModel);

            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor(System.String dataStr)
            /// </summary>
            /// <param name="dataStr">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR_02 (nint dataStr);

            
            /// const string Name_Func_ADD_EXP = "AddExp";
            /// <summary>
            ///   System.Void AddExp(System.Collections.Generic.List<BattleMonsterController> defeatedEnemies,System.Int32 personasOnCharacter)
            /// </summary>
            /// <param name="defeatedEnemies">class System.Collections.Generic.List<BattleMonsterController></param>
            /// <param name="personasOnCharacter">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void ADD_EXP_00 (nint defeatedEnemies,System.Int32 personasOnCharacter);

            
            /// const string Name_Func_ADD_EXP = "AddExp";
            /// <summary>
            ///   System.Void AddExp(System.Int32 count)
            /// </summary>
            /// <param name="count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void ADD_EXP_01 (System.Int32 count);

            
            /// public static partial class Search_PersonaProgress
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
                    ///   System.Void .ctor(BattleMonsterModel monsterModel)
                    /// </summary>
                    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "BattleMonsterModel");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor(System.String dataStr)
                    /// </summary>
                    /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void AddExp(System.Collections.Generic.List<BattleMonsterController> defeatedEnemies, System.Int32 personasOnCharacter)
                    /// </summary>
                    /// public static bool ADD_EXP_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddExp", "System.Collections.Generic.List<BattleMonsterController>", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void AddExp(System.Int32 count)
                    /// </summary>
                    /// public static bool ADD_EXP_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddExp", "System.Int32");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}