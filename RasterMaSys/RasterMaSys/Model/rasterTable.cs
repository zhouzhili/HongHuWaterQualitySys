//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RasterMaSys.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class rasterTable
    {
        public int id { get; set; }
        public string sensor { get; set; }
        public string path { get; set; }
        public System.DateTime rstime { get; set; }
        public Nullable<int> rowID { get; set; }
        public Nullable<int> colID { get; set; }
        public Nullable<double> cloudage { get; set; }
    }
}
