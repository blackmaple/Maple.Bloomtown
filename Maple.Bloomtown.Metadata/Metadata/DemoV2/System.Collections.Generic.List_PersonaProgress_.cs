
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
    /// class ["mscorlib"."System.Collections.Generic"."List`1"]
    /// [System.Object]
    /// [System.Collections.Generic.IList<PersonaProgress>]=>[System.Collections.Generic.ICollection<PersonaProgress>]=>[System.Collections.Generic.IEnumerable<PersonaProgress>]=>[System.Collections.IEnumerable]=>[System.Collections.IList]=>[System.Collections.ICollection]=>[System.Collections.Generic.IReadOnlyList<PersonaProgress>]=>[System.Collections.Generic.IReadOnlyCollection<PersonaProgress>]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([109, 115, 99, 111, 114, 108, 105, 98], 0x0200071BU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([109, 115, 99, 111, 114, 108, 105, 98], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99], [76, 105, 115, 116, 96, 49])]

    //  class static PersonaProgress[] s_emptyArray
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"s_emptyArray", "S_EMPTY_ARRAY", true)]

    // class 0x10 PersonaProgress[] _items
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_items", "_ITEMS")]

    // struct 0x18 System.Int32 _size
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_size", "_SIZE")]

    // struct 0x1C System.Int32 _version
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_version", "_VERSION")]

    // class 0x20 System.Object _syncRoot
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_syncRoot", "_SYNC_ROOT")]
    public partial class ListGeneric
    {
        //public const string Const_ImageName = "mscorlib";
        //public static byte[] Static_ImageName { get; } = [109, 115, 99, 111, 114, 108, 105, 98];

        //public const string Const_Namespace = "System.Collections.Generic";
        //public static byte[] Static_Namespace { get; } = [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99];

        //public const string Const_ClassName = "List`1";
        //public static byte[] Static_ClassName { get; } = [76, 105, 115, 116, 96, 49];

        //public const uint Const_TypeToken = 0x0200071BU;




        /// <summary>
        /// struct System.Int32 DefaultCapacity "4"
        /// </summary>
        /// public const System.Int32 DEFAULT_CAPACITY=>"4";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ListGeneric(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ListGeneric(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ListGeneric obj) => obj._ptr;
            public static implicit operator bool(Ptr_ListGeneric obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["mscorlib"."System.Collections.Generic"."List`1"]
    /// </summary>
    public partial class ListGeneric
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        ///   System.Void Add(PersonaProgress item)
        /// </summary>
        /// <param name="item">class PersonaProgress</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Add")]
        extern void ADD(nint item);


        /// <summary>
        ///   System.Void AddEnumerable(System.Collections.Generic.IEnumerable<PersonaProgress> enumerable)
        /// </summary>
        /// <param name="enumerable">interface System.Collections.Generic.IEnumerable<PersonaProgress></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEnumerable")]
        ///  extern void ADD_ENUMERABLE (nint enumerable);


        /// <summary>
        ///   System.Void AddRange(System.Collections.Generic.IEnumerable<PersonaProgress> collection)
        /// </summary>
        /// <param name="collection">interface System.Collections.Generic.IEnumerable<PersonaProgress></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRange")]
        ///  extern void ADD_RANGE (nint collection);


        /// <summary>
        ///   System.Void AddWithResize(PersonaProgress item)
        /// </summary>
        /// <param name="item">class PersonaProgress</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWithResize")]
        ///  extern void ADD_WITH_RESIZE (nint item);


        /// <summary>
        ///   System.Collections.ObjectModel.ReadOnlyCollection<PersonaProgress> AsReadOnly()
        /// </summary>
        /// <returns>class System.Collections.ObjectModel.ReadOnlyCollection<PersonaProgress></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AsReadOnly")]
        ///  extern nint AS_READ_ONLY ();


        /// <summary>
        ///   System.Void Clear()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clear")]
        ///  extern void CLEAR ();


        /// <summary>
        ///   System.Boolean Contains(PersonaProgress item)
        /// </summary>
        /// <param name="item">class PersonaProgress</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Contains")]
        ///  extern System.Boolean CONTAINS (nint item);


        /// <summary>
        ///   System.Void EnsureCapacity(System.Int32 min)
        /// </summary>
        /// <param name="min">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnsureCapacity")]
        ///  extern void ENSURE_CAPACITY (System.Int32 min);


        /// <summary>
        ///   System.Boolean Exists(System.Predicate<PersonaProgress> match)
        /// </summary>
        /// <param name="match">class System.Predicate<PersonaProgress></param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Exists")]
        ///  extern System.Boolean EXISTS (nint match);


        /// <summary>
        ///   PersonaProgress Find(System.Predicate<PersonaProgress> match)
        /// </summary>
        /// <param name="match">class System.Predicate<PersonaProgress></param>
        /// <returns>class PersonaProgress</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Find")]
        ///  extern nint FIND (nint match);


        /// <summary>
        ///   System.Collections.Generic.List<PersonaProgress> FindAll(System.Predicate<PersonaProgress> match)
        /// </summary>
        /// <param name="match">class System.Predicate<PersonaProgress></param>
        /// <returns>class System.Collections.Generic.List<PersonaProgress></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAll")]
        ///  extern nint FIND_ALL (nint match);


        /// <summary>
        ///   PersonaProgress FindLast(System.Predicate<PersonaProgress> match)
        /// </summary>
        /// <param name="match">class System.Predicate<PersonaProgress></param>
        /// <returns>class PersonaProgress</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindLast")]
        ///  extern nint FIND_LAST (nint match);


        /// <summary>
        ///   System.Void ForEach(System.Action<PersonaProgress> action)
        /// </summary>
        /// <param name="action">class System.Action<PersonaProgress></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ForEach")]
        ///  extern void FOR_EACH (nint action);


        /// <summary>
        ///   System.Int32 get_Capacity()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Capacity")]
        ///  extern System.Int32 GET_CAPACITY ();


        /// <summary>
        ///   System.Int32 get_Count()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Count")]
        ///  extern System.Int32 GET_COUNT ();


        /// <summary>
        ///   PersonaProgress get_Item(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class PersonaProgress</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item")]
        ///  extern nint GET_ITEM (System.Int32 index);


        /// <summary>
        ///   System.Collections.Generic.List.Enumerator<PersonaProgress> GetEnumerator()
        /// </summary>
        /// <returns>struct System.Collections.Generic.List.Enumerator<PersonaProgress></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEnumerator")]
        ///  extern System.Collections.Generic.List.Enumerator<PersonaProgress> GET_ENUMERATOR ();


        /// <summary>
        ///   System.Collections.Generic.List<PersonaProgress> GetRange(System.Int32 index, System.Int32 count)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>class System.Collections.Generic.List<PersonaProgress></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRange")]
        ///  extern nint GET_RANGE (System.Int32 index, System.Int32 count);


        /// <summary>
        ///   System.Int32 IndexOf(PersonaProgress item)
        /// </summary>
        /// <param name="item">class PersonaProgress</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IndexOf")]
        ///  extern System.Int32 INDEX_OF (nint item);


        /// <summary>
        ///   System.Void Insert(System.Int32 index, PersonaProgress item)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="item">class PersonaProgress</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Insert")]
        ///  extern void INSERT (System.Int32 index, nint item);


        /// <summary>
        ///   System.Void InsertRange(System.Int32 index, System.Collections.Generic.IEnumerable<PersonaProgress> collection)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="collection">interface System.Collections.Generic.IEnumerable<PersonaProgress></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InsertRange")]
        ///  extern void INSERT_RANGE (System.Int32 index, nint collection);


        /// <summary>
        /// static  System.Boolean IsCompatibleObject(System.Object value)
        /// </summary>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCompatibleObject")]
        /// static extern System.Boolean IS_COMPATIBLE_OBJECT (nint value);


        /// <summary>
        ///   System.Boolean Remove(PersonaProgress item)
        /// </summary>
        /// <param name="item">class PersonaProgress</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove")]
        ///  extern System.Boolean REMOVE (nint item);


        /// <summary>
        ///   System.Int32 RemoveAll(System.Predicate<PersonaProgress> match)
        /// </summary>
        /// <param name="match">class System.Predicate<PersonaProgress></param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAll")]
        ///  extern System.Int32 REMOVE_ALL (nint match);


        /// <summary>
        ///   System.Void RemoveAt(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAt")]
        ///  extern void REMOVE_AT (System.Int32 index);


        /// <summary>
        ///   System.Void RemoveRange(System.Int32 index, System.Int32 count)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRange")]
        ///  extern void REMOVE_RANGE (System.Int32 index, System.Int32 count);


        /// <summary>
        ///   System.Void set_Capacity(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Capacity")]
        ///  extern void SET_CAPACITY (System.Int32 value);


        /// <summary>
        ///   System.Void set_Item(System.Int32 index, PersonaProgress value)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="value">class PersonaProgress</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Item")]
        ///  extern void SET_ITEM (System.Int32 index, nint value);


        /// <summary>
        ///   System.Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.ICollection<T>.get_IsReadOnly")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.GENERIC.I_COLLECTION<T>.GET_IS_READ_ONLY ();


        /// <summary>
        ///   System.Collections.Generic.IEnumerator<PersonaProgress> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        /// </summary>
        /// <returns>interface System.Collections.Generic.IEnumerator<PersonaProgress></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.IEnumerable<T>.GetEnumerator")]
        ///  extern nint SYSTEM.COLLECTIONS.GENERIC.I_ENUMERABLE<T>.GET_ENUMERATOR ();


        /// <summary>
        ///   System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 arrayIndex)
        /// </summary>
        /// <param name="array">abstract class System.Array</param>
        /// <param name="arrayIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.ICollection.CopyTo")]
        ///  extern void SYSTEM.COLLECTIONS.I_COLLECTION.COPY_TO (nint array, System.Int32 arrayIndex);


        /// <summary>
        ///   System.Boolean System.Collections.ICollection.get_IsSynchronized()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.ICollection.get_IsSynchronized")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.I_COLLECTION.GET_IS_SYNCHRONIZED ();


        /// <summary>
        ///   System.Object System.Collections.ICollection.get_SyncRoot()
        /// </summary>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.ICollection.get_SyncRoot")]
        ///  extern nint SYSTEM.COLLECTIONS.I_COLLECTION.GET_SYNC_ROOT ();


        /// <summary>
        ///   System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        /// </summary>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IEnumerable.GetEnumerator")]
        ///  extern nint SYSTEM.COLLECTIONS.I_ENUMERABLE.GET_ENUMERATOR ();


        /// <summary>
        ///   System.Int32 System.Collections.IList.Add(System.Object item)
        /// </summary>
        /// <param name="item">class System.Object</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.Add")]
        ///  extern System.Int32 SYSTEM.COLLECTIONS.I_LIST.ADD (nint item);


        /// <summary>
        ///   System.Boolean System.Collections.IList.Contains(System.Object item)
        /// </summary>
        /// <param name="item">class System.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.Contains")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.I_LIST.CONTAINS (nint item);


        /// <summary>
        ///   System.Boolean System.Collections.IList.get_IsFixedSize()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.get_IsFixedSize")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.I_LIST.GET_IS_FIXED_SIZE ();


        /// <summary>
        ///   System.Boolean System.Collections.IList.get_IsReadOnly()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.get_IsReadOnly")]
        ///  extern System.Boolean SYSTEM.COLLECTIONS.I_LIST.GET_IS_READ_ONLY ();


        /// <summary>
        ///   System.Object System.Collections.IList.get_Item(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.get_Item")]
        ///  extern nint SYSTEM.COLLECTIONS.I_LIST.GET_ITEM (System.Int32 index);


        /// <summary>
        ///   System.Int32 System.Collections.IList.IndexOf(System.Object item)
        /// </summary>
        /// <param name="item">class System.Object</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.IndexOf")]
        ///  extern System.Int32 SYSTEM.COLLECTIONS.I_LIST.INDEX_OF (nint item);


        /// <summary>
        ///   System.Void System.Collections.IList.Insert(System.Int32 index, System.Object item)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="item">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.Insert")]
        ///  extern void SYSTEM.COLLECTIONS.I_LIST.INSERT (System.Int32 index, nint item);


        /// <summary>
        ///   System.Void System.Collections.IList.Remove(System.Object item)
        /// </summary>
        /// <param name="item">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.Remove")]
        ///  extern void SYSTEM.COLLECTIONS.I_LIST.REMOVE (nint item);


        /// <summary>
        ///   System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.set_Item")]
        ///  extern void SYSTEM.COLLECTIONS.I_LIST.SET_ITEM (System.Int32 index, nint value);


        /// <summary>
        ///   PersonaProgress[] ToArray()
        /// </summary>
        /// <returns>class PersonaProgress[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToArray")]
        ///  extern nint TO_ARRAY ();


        /// <summary>
        ///   System.Void TrimExcess()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TrimExcess")]
        ///  extern void TRIM_EXCESS ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ListGeneric))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor(System.Int32 capacity)
        /// </summary>
        /// <param name="capacity">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ListGeneric))]
        ///  extern void .CTOR_01 (System.Int32 capacity);


        /// <summary>
        ///   System.Void .ctor(System.Collections.Generic.IEnumerable<PersonaProgress> collection)
        /// </summary>
        /// <param name="collection">interface System.Collections.Generic.IEnumerable<PersonaProgress></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ListGeneric))]
        ///  extern void .CTOR_02 (nint collection);


        /// <summary>
        ///   System.Int32 BinarySearch(System.Int32 index, System.Int32 count, PersonaProgress item, System.Collections.Generic.IComparer<PersonaProgress> comparer)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="count">struct System.Int32</param>
        /// <param name="item">class PersonaProgress</param>
        /// <param name="comparer">interface System.Collections.Generic.IComparer<PersonaProgress></param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BinarySearch", Search = typeof(Search_ListGeneric))]
        ///  extern System.Int32 BINARY_SEARCH_00 (System.Int32 index, System.Int32 count, nint item, nint comparer);


        /// <summary>
        ///   System.Int32 BinarySearch(PersonaProgress item)
        /// </summary>
        /// <param name="item">class PersonaProgress</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BinarySearch", Search = typeof(Search_ListGeneric))]
        ///  extern System.Int32 BINARY_SEARCH_01 (nint item);


        /// <summary>
        ///   System.Int32 BinarySearch(PersonaProgress item, System.Collections.Generic.IComparer<PersonaProgress> comparer)
        /// </summary>
        /// <param name="item">class PersonaProgress</param>
        /// <param name="comparer">interface System.Collections.Generic.IComparer<PersonaProgress></param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BinarySearch", Search = typeof(Search_ListGeneric))]
        ///  extern System.Int32 BINARY_SEARCH_02 (nint item, nint comparer);


        /// <summary>
        ///   System.Void CopyTo(PersonaProgress[] array)
        /// </summary>
        /// <param name="array">class PersonaProgress[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CopyTo", Search = typeof(Search_ListGeneric))]
        ///  extern void COPY_TO_00 (nint array);


        /// <summary>
        ///   System.Void CopyTo(PersonaProgress[] array, System.Int32 arrayIndex)
        /// </summary>
        /// <param name="array">class PersonaProgress[]</param>
        /// <param name="arrayIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CopyTo", Search = typeof(Search_ListGeneric))]
        ///  extern void COPY_TO_01 (nint array, System.Int32 arrayIndex);


        /// <summary>
        ///   System.Int32 FindIndex(System.Predicate<PersonaProgress> match)
        /// </summary>
        /// <param name="match">class System.Predicate<PersonaProgress></param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindIndex", Search = typeof(Search_ListGeneric))]
        ///  extern System.Int32 FIND_INDEX_00 (nint match);


        /// <summary>
        ///   System.Int32 FindIndex(System.Int32 startIndex, System.Int32 count, System.Predicate<PersonaProgress> match)
        /// </summary>
        /// <param name="startIndex">struct System.Int32</param>
        /// <param name="count">struct System.Int32</param>
        /// <param name="match">class System.Predicate<PersonaProgress></param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindIndex", Search = typeof(Search_ListGeneric))]
        ///  extern System.Int32 FIND_INDEX_01 (System.Int32 startIndex, System.Int32 count, nint match);


        /// <summary>
        ///   System.Void Reverse()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Reverse", Search = typeof(Search_ListGeneric))]
        ///  extern void REVERSE_00 ();


        /// <summary>
        ///   System.Void Reverse(System.Int32 index, System.Int32 count)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Reverse", Search = typeof(Search_ListGeneric))]
        ///  extern void REVERSE_01 (System.Int32 index, System.Int32 count);


        /// <summary>
        ///   System.Void Sort()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Sort", Search = typeof(Search_ListGeneric))]
        ///  extern void SORT_00 ();


        /// <summary>
        ///   System.Void Sort(System.Collections.Generic.IComparer<PersonaProgress> comparer)
        /// </summary>
        /// <param name="comparer">interface System.Collections.Generic.IComparer<PersonaProgress></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Sort", Search = typeof(Search_ListGeneric))]
        ///  extern void SORT_01 (nint comparer);


        /// <summary>
        ///   System.Void Sort(System.Int32 index, System.Int32 count, System.Collections.Generic.IComparer<PersonaProgress> comparer)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="count">struct System.Int32</param>
        /// <param name="comparer">interface System.Collections.Generic.IComparer<PersonaProgress></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Sort", Search = typeof(Search_ListGeneric))]
        ///  extern void SORT_02 (System.Int32 index, System.Int32 count, nint comparer);


        /// <summary>
        ///   System.Void Sort(System.Comparison<PersonaProgress> comparison)
        /// </summary>
        /// <param name="comparison">class System.Comparison<PersonaProgress></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Sort", Search = typeof(Search_ListGeneric))]
        ///  extern void SORT_03 (nint comparison);


        /// public static partial class Search_ListGeneric
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
        ///   System.Void .ctor(System.Int32 capacity)
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(System.Collections.Generic.IEnumerable<PersonaProgress> collection)
        /// </summary>
        /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Collections.Generic.IEnumerable<PersonaProgress>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 BinarySearch(System.Int32 index, System.Int32 count, PersonaProgress item, System.Collections.Generic.IComparer<PersonaProgress> comparer)
        /// </summary>
        /// public static bool BINARY_SEARCH_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BinarySearch", "System.Int32", "System.Int32", "PersonaProgress", "System.Collections.Generic.IComparer<PersonaProgress>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 BinarySearch(PersonaProgress item)
        /// </summary>
        /// public static bool BINARY_SEARCH_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BinarySearch", "PersonaProgress");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 BinarySearch(PersonaProgress item, System.Collections.Generic.IComparer<PersonaProgress> comparer)
        /// </summary>
        /// public static bool BINARY_SEARCH_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BinarySearch", "PersonaProgress", "System.Collections.Generic.IComparer<PersonaProgress>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CopyTo(PersonaProgress[] array)
        /// </summary>
        /// public static bool COPY_TO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CopyTo", "PersonaProgress[]");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CopyTo(PersonaProgress[] array, System.Int32 arrayIndex)
        /// </summary>
        /// public static bool COPY_TO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CopyTo", "PersonaProgress[]", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 FindIndex(System.Predicate<PersonaProgress> match)
        /// </summary>
        /// public static bool FIND_INDEX_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindIndex", "System.Predicate<PersonaProgress>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 FindIndex(System.Int32 startIndex, System.Int32 count, System.Predicate<PersonaProgress> match)
        /// </summary>
        /// public static bool FIND_INDEX_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindIndex", "System.Int32", "System.Int32", "System.Predicate<PersonaProgress>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Reverse()
        /// </summary>
        /// public static bool REVERSE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Reverse");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Reverse(System.Int32 index, System.Int32 count)
        /// </summary>
        /// public static bool REVERSE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Reverse", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Sort()
        /// </summary>
        /// public static bool SORT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Sort");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Sort(System.Collections.Generic.IComparer<PersonaProgress> comparer)
        /// </summary>
        /// public static bool SORT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Sort", "System.Collections.Generic.IComparer<PersonaProgress>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Sort(System.Int32 index, System.Int32 count, System.Collections.Generic.IComparer<PersonaProgress> comparer)
        /// </summary>
        /// public static bool SORT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Sort", "System.Int32", "System.Int32", "System.Collections.Generic.IComparer<PersonaProgress>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Sort(System.Comparison<PersonaProgress> comparison)
        /// </summary>
        /// public static bool SORT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Sort", "System.Comparison<PersonaProgress>");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}