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
    
    public partial class T_ServicePersonnel
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public int PersonnelType { get; set; }
        public string RealName { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public string IdCard { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int Area { get; set; }
        public string AreaName { get; set; }
        public string HeadImgUrl { get; set; }
        public string ServiceSkills { get; set; }
        public string ServiceTime { get; set; }
        public string ServiceEvaluation { get; set; }
        public Nullable<int> AgencyId { get; set; }
        public int TotalIntegral { get; set; }
        public int UsedIntegral { get; set; }
        public int ResidualIntegral { get; set; }
        public int IsVolunteerExperience { get; set; }
        public int IsWorkExperience { get; set; }
        public string Profile { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserid { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> UpdateUserid { get; set; }
        public string SkillCertificate { get; set; }
    }
}
