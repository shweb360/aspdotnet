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
    
    public partial class S_user_log
    {
        public int Id { get; set; }
        public Nullable<int> User_id { get; set; }
        public Nullable<int> Oprttype { get; set; }
        public Nullable<System.DateTime> Oprttime { get; set; }
        public string Ip { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> Createtime { get; set; }
        public Nullable<int> Createuserid { get; set; }
        public Nullable<System.DateTime> Updatetime { get; set; }
        public Nullable<int> Updateuserid { get; set; }
        public string Macaddr { get; set; }
        public string Username { get; set; }
        public string Ip_2 { get; set; }
        public string Clientversion { get; set; }
    }
}
