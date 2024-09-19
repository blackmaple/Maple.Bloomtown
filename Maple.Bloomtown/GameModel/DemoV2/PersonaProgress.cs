
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


    // class 0x10 BattleMonsterModel monsterModel
    [MonoCollectorSearchFieldAttribute(typeof(BattleMonsterModel.Ptr_BattleMonsterModel), "monsterModel", "MONSTER_MODEL")]

    // class 0x18 UnityEngine.Sprite monsterPreviewMini
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"monsterPreviewMini", "MONSTER_PREVIEW_MINI")]

    // class 0x20 UnityEngine.Sprite monsterPreview
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"monsterPreview", "MONSTER_PREVIEW")]

    // class 0x28 UnityEngine.Sprite monsterPreviewMicro
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"monsterPreviewMicro", "MONSTER_PREVIEW_MICRO")]

    // class 0x30 BattlePlayerModel holder
    [MonoCollectorSearchFieldAttribute(typeof(nint), "holder", "HOLDER", IsReadOnly = false)]

    // class 0x38 System.Collections.Generic.List<Resist> m_saveResists
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_saveResists", "M_SAVE_RESISTS")]

    // class 0x40 System.Collections.Generic.List<Skill> m_skill
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_skill", "M_SKILL")]

    // struct 0x48 System.Int32 level
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "level", "LEVEL", IsReadOnly = false)]

    // struct 0x4C System.Int32 exp
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "exp", "EXP", IsReadOnly = false)]

    // struct 0x50 System.Int32 levelOfGetLastSkill
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"levelOfGetLastSkill", "LEVEL_OF_GET_LAST_SKILL")]

    // struct 0x54 System.Int32 m_strength
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"m_strength", "M_STRENGTH")]

    // struct 0x58 System.Int32 m_magic
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"m_magic", "M_MAGIC")]

    // struct 0x5C System.Int32 m_endurance
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"m_endurance", "M_ENDURANCE")]

    // struct 0x60 System.Int32 m_agility
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"m_agility", "M_AGILITY")]

    // struct 0x64 System.Int32 m_luck
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"m_luck", "M_LUCK")]

    // struct 0x68 System.Int32 prevStrength
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"prevStrength", "PREV_STRENGTH")]

    // struct 0x6C System.Int32 prevMagic
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"prevMagic", "PREV_MAGIC")]

    // struct 0x70 System.Int32 prevEndurance
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"prevEndurance", "PREV_ENDURANCE")]

    // struct 0x74 System.Int32 prevAgility
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"prevAgility", "PREV_AGILITY")]

    // struct 0x78 System.Int32 prevLuck
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"prevLuck", "PREV_LUCK")]
    public partial class PersonaProgress
    {
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "PersonaProgress";
        //public static byte[] Static_ClassName { get; } = [80, 101, 114, 115, 111, 110, 97, 80, 114, 111, 103, 114, 101, 115, 115];

        //public const uint Const_TypeToken = 0x0200041FU;




        /// <summary>
        /// struct System.Int32 SkillCountMax "0"
        /// </summary>
        public const System.Int32 SKILL_COUNT_MAX = 8;




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_PersonaProgress(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_PersonaProgress(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_PersonaProgress obj) => obj._ptr;
            public static implicit operator bool(Ptr_PersonaProgress obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp".""."PersonaProgress"]
    /// </summary>
    public partial class PersonaProgress
    {



        /// <summary>
        ///   System.Boolean <GetSkills>b__50_0(Skill x)
        /// </summary>
        /// <param name="x">class Skill</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<GetSkills>b__50_0")]
        ///  extern System.Boolean <GET_SKILLS>B__50_0 (nint x);


        /// <summary>
        ///   System.Void <SetLevel>g__AddLevel|57_0()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<SetLevel>g__AddLevel|57_0")]
        ///  extern void <SET_LEVEL>G__ADD_LEVEL|57_0 ();


        /// <summary>
        ///   System.Void AddSkill(Skill skill)
        /// </summary>
        /// <param name="skill">class Skill</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSkill")]
        extern void ADD_SKILL(nint skill);


        /// <summary>
        ///   System.Boolean CanGetNewSkill()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanGetNewSkill")]
        ///  extern System.Boolean CAN_GET_NEW_SKILL ();


        /// <summary>
        ///   System.Void Deserialize(System.String dataStr)
        /// </summary>
        /// <param name="dataStr">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Deserialize")]
        ///  extern void DESERIALIZE (nint dataStr);


        /// <summary>
        ///   System.Int32 get_agility()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_agility")]
        extern System.Int32 GET_AGILITY();


        /// <summary>
        ///   System.Int32 get_endurance()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_endurance")]
        extern System.Int32 GET_ENDURANCE();


        /// <summary>
        ///   System.String get_getUID()
        /// </summary>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_getUID")]
        extern PMonoString GET_GET_UID();


        /// <summary>
        ///   Character get_holderChar()
        /// </summary>
        /// <returns>class Character</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_holderChar")]
        ///  extern nint GET_HOLDER_CHAR ();


        /// <summary>
        ///   System.Int32 get_luck()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_luck")]
        extern System.Int32 GET_LUCK();


        /// <summary>
        ///   System.Int32 get_magic()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_magic")]
        extern System.Int32 GET_MAGIC();


        /// <summary>
        ///   System.Collections.Generic.List<Skill> get_skills()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Skill></returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_skills")]
        extern PMonoList_S<Skill.Ptr_Skill> GET_SKILLS();


        /// <summary>
        ///   System.Int32 get_strength()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_strength")]
        extern System.Int32 GET_STRENGTH();


        /// <summary>
        ///   System.Collections.Generic.List<EffectHolder> get_unlockedSkillsEffects()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<EffectHolder></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unlockedSkillsEffects")]
        ///  extern nint GET_UNLOCKED_SKILLS_EFFECTS ();


        /// <summary>
        ///   System.Collections.Generic.List<Resist> GetAllResists()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Resist></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllResists")]
        ///  extern nint GET_ALL_RESISTS ();


        /// <summary>
        ///   Resist GetBaseResist(DamageType damageType)
        /// </summary>
        /// <param name="damageType">enum DamageType</param>
        /// <returns>class Resist</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBaseResist")]
        ///  extern nint GET_BASE_RESIST (DamageType damageType);


        /// <summary>
        /// static  System.Int32 GetExpToPersonaLevel(System.Int32 lvl)
        /// </summary>
        /// <param name="lvl">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetExpToPersonaLevel")]
        /// static extern System.Int32 GET_EXP_TO_PERSONA_LEVEL (System.Int32 lvl);


        /// <summary>
        ///   System.Int32 GetNearestSkillLevel()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNearestSkillLevel")]
        extern System.Int32 GET_NEAREST_SKILL_LEVEL();


        /// <summary>
        ///   System.Collections.Generic.List<Skill> GetSkills()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Skill></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSkills")]
        ///  extern nint GET_SKILLS ();


        /// <summary>
        ///   System.Int32 GetStat(PersonaProgress.StateType stateType)
        /// </summary>
        /// <param name="stateType">enum PersonaProgress.StateType</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetStat")]
        ///  extern System.Int32 GET_STAT (PersonaProgress.StateType stateType);


        /// <summary>
        ///   System.Void InitializePrevStats()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitializePrevStats")]
        ///  extern void INITIALIZE_PREV_STATS ();


        /// <summary>
        ///   System.Void RemoveSkill(Skill skill)
        /// </summary>
        /// <param name="skill">class Skill</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSkill")]
        extern void REMOVE_SKILL(nint skill);


        /// <summary>
        ///   System.String Serialize()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Serialize")]
        ///  extern nint SERIALIZE ();


        /// <summary>
        ///   System.Void set_skills(System.Collections.Generic.List<Skill> value)
        /// </summary>
        /// <param name="value">class System.Collections.Generic.List<Skill></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_skills")]
        ///  extern void SET_SKILLS (nint value);


        /// <summary>
        ///   System.Void SetLevel(System.Int32 lvl)
        /// </summary>
        /// <param name="lvl">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLevel")]
        extern void SET_LEVEL(System.Int32 lvl);


        /// <summary>
        ///   System.Void SetPreview(BattleMonsterView monsterView)
        /// </summary>
        /// <param name="monsterView">class BattleMonsterView</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetPreview")]
        ///  extern void SET_PREVIEW (nint monsterView);


        /// <summary>
        ///   System.Void SetResist(Resist resist)
        /// </summary>
        /// <param name="resist">class Resist</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetResist")]
        ///  extern void SET_RESIST (nint resist);



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_PersonaProgress))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor(BattleMonsterModel monsterModel)
        /// </summary>
        /// <param name="monsterModel">class BattleMonsterModel</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_PersonaProgress))]
        extern void CTOR_01(nint monsterModel);


        /// <summary>
        ///   System.Void .ctor(System.String dataStr)
        /// </summary>
        /// <param name="dataStr">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_PersonaProgress))]
        ///  extern void .CTOR_02 (nint dataStr);


        /// <summary>
        ///   System.Void AddExp(System.Collections.Generic.List<BattleMonsterController> defeatedEnemies, System.Int32 personasOnCharacter)
        /// </summary>
        /// <param name="defeatedEnemies">class System.Collections.Generic.List<BattleMonsterController></param>
        /// <param name="personasOnCharacter">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddExp", Search = typeof(Search_PersonaProgress))]
        ///  extern void ADD_EXP_00 (nint defeatedEnemies, System.Int32 personasOnCharacter);


        /// <summary>
        ///   System.Void AddExp(System.Int32 count)
        /// </summary>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddExp", Search = typeof(Search_PersonaProgress))]
        extern void ADD_EXP_01(System.Int32 count);


        public static partial class Search_PersonaProgress
        {
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
            public static bool CTOR_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "BattleMonsterModel");
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
            public static bool ADD_EXP_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddExp", "System.Int32");
            ///     
            ///  
            /// 
            /// 
        }

    }


}