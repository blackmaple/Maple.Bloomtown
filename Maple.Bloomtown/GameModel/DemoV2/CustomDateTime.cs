
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
    /// struct ["Assembly-CSharp".""."CustomDateTime"]
    /// 
    /// </summary>
    public partial class CustomDateTime
    { 

                    
        /// <summary>
        /// struct System.Int32 defaultYear "0"
        /// </summary>
        /// public const System.Int32 DEFAULT_YEAR=>"0";
            
        /// <summary>
        /// enum CustomDateTime.Month defaultMonth "0x00000006"
        /// </summary>
        /// public const CustomDateTime.Month DEFAULT_MONTH=>"0x00000006";
            
        /// <summary>
        /// struct System.Int32 defaultDay "0"
        /// </summary>
        /// public const System.Int32 DEFAULT_DAY=>"0";
            
        /// <summary>
        /// struct System.Int32 defaultHour "0"
        /// </summary>
        /// public const System.Int32 DEFAULT_HOUR=>"0";
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_CustomDateTime
        {
    
            
                        
            /// const string Name_Field_dateTimeStr = "dateTimeStr";
            /// <summary>
            /// class 0x10 System.String dateTimeStr
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly nint dateTimeStr;

                        
            /// const string Name_Field_m_dateTime = "m_dateTime";
            /// <summary>
            /// struct 0x18 System.DateTime m_dateTime
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            public readonly System.DateTime m_dateTime;

        }

    }


}