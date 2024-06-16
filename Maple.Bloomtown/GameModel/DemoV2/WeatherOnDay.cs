
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
    /// class ["Assembly-CSharp".""."WeatherOnDay"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x02000415U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [87, 101, 97, 116, 104, 101, 114, 79, 110, 68, 97, 121])]
    public partial class WeatherOnDay
    { 
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "WeatherOnDay";
        //public static byte[] Static_ClassName { get; } = [87, 101, 97, 116, 104, 101, 114, 79, 110, 68, 97, 121];

        //public const uint Const_TypeToken = 0x02000415U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_WeatherOnDay
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
            
            
                        
            /// const string Name_Field_date = "date";
            /// <summary>
            /// struct 0x10 CustomDateTime date
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly CustomDateTime date;

                        
            /// const string Name_Field_weatherType = "weatherType";
            /// <summary>
            /// enum 0x20 WeatherOnDay.WeatherType weatherType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly WeatherType weatherType;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_WeatherOnDay(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_WeatherOnDay(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_WeatherOnDay obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_WeatherOnDay AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_WeatherOnDay>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp".""."WeatherOnDay"]
        /// </summary>
        public partial class WeatherOnDay
        { 

            
            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor(System.DateTime day)
            /// </summary>
            /// <param name="day">struct System.DateTime</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR (System.DateTime day);

            
            /// const string Name_Func_ADD_WEATHER = "AddWeather";
            /// <summary>
            /// static  WeatherOnDay.WeatherFlag AddWeather(WeatherOnDay.WeatherFlag flag,WeatherOnDay.WeatherType val)
            /// </summary>
            /// <param name="flag">enum WeatherOnDay.WeatherFlag</param>
            /// <param name="val">enum WeatherOnDay.WeatherType</param>
            /// <returns>enum WeatherOnDay.WeatherFlag</returns>
            /// public static extern WeatherOnDay.WeatherFlag ADD_WEATHER (WeatherOnDay.WeatherFlag flag,WeatherOnDay.WeatherType val);

            
            /// const string Name_Func_IS_WEATHER_PERSIST = "IsWeatherPersist";
            /// <summary>
            /// static  System.Boolean IsWeatherPersist(WeatherOnDay.WeatherFlag flag,WeatherOnDay.WeatherType val)
            /// </summary>
            /// <param name="flag">enum WeatherOnDay.WeatherFlag</param>
            /// <param name="val">enum WeatherOnDay.WeatherType</param>
            /// <returns>struct System.Boolean</returns>
            /// public static extern System.Boolean IS_WEATHER_PERSIST (WeatherOnDay.WeatherFlag flag,WeatherOnDay.WeatherType val);

            
            /// const string Name_Func_TRY_PARSE_WEATHER_TYPE = "TryParseWeatherType";
            /// <summary>
            /// static  System.Boolean TryParseWeatherType(System.String str,WeatherOnDay.WeatherType& result)
            /// </summary>
            /// <param name="str">class System.String</param>
            /// <param name="result">enum WeatherOnDay.WeatherType&</param>
            /// <returns>struct System.Boolean</returns>
            /// public static extern System.Boolean TRY_PARSE_WEATHER_TYPE (nint str,WeatherOnDay.WeatherType& result);
            
            

            
            /// public static partial class Search_WeatherOnDay
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}