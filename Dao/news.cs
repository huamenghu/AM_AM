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
    
    public partial class news
    {
        public string newsid { get; set; }
        public string newstitle { get; set; }
        public bool newsistj { get; set; }
        public bool newsislogo { get; set; }
        public string newslogo { get; set; }
        public System.DateTime newsdate { get; set; }
        public string newssummary { get; set; }
        public string newscontent { get; set; }
        public Nullable<int> newsclicks { get; set; }
        public string newstype { get; set; }
    }
}
