//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class S_dicttype
    {
        public int Id { get; set; }
        public string Typecode { get; set; }
        public string Typename_cn { get; set; }
        public string Typename_en { get; set; }
        public Nullable<int> Sort { get; set; }
        public string Isvalid { get; set; }
        public Nullable<System.DateTime> Createtime { get; set; }
        public Nullable<int> Createuserid { get; set; }
        public Nullable<System.DateTime> Updatetime { get; set; }
        public Nullable<int> Updateuserid { get; set; }
    }
}