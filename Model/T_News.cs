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
    
    public partial class T_News
    {
        public int Id { get; set; }
        public int NewsType { get; set; }
        public string Title { get; set; }
        public string PicUrl { get; set; }
        public string ShortContent { get; set; }
        public string Content { get; set; }
        public int PublishUser { get; set; }
        public Nullable<System.DateTime> PublishTime { get; set; }
        public int Hits { get; set; }
        public int Status { get; set; }
    }
}