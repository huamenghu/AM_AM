//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dao
{
    using System;
    using System.Collections.Generic;
    
    public partial class appraisalaccident
    {
        public string GUID { get; set; }
        public string userid { get; set; }
        public string accidentcompanyname { get; set; }
        public string accidentcompanyaddr { get; set; }
        public string accidentnenginename { get; set; }
        public string accidentnenginenaddr { get; set; }
        public string accidentgoodsname { get; set; }
        public string accidentgoodstype { get; set; }
        public string accidenttype { get; set; }
        public string accidentdescription { get; set; }
        public Nullable<System.DateTime> accidentoccurrencetime { get; set; }
        public string accidentlinkname { get; set; }
        public string accidentlinktel { get; set; }
        public string accidentemail { get; set; }
        public string state { get; set; }
        public Nullable<bool> ispay { get; set; }
        public Nullable<System.DateTime> operatetime { get; set; }
        public string @operator { get; set; }
        public string remark { get; set; }
    }
}
