//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRS.Attendance.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class RestOverTime
    {
        public System.Guid ID { get; set; }
        public Nullable<System.DateTime> RestDateTime { get; set; }
        public Nullable<byte> OverTimeType { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.Guid CreateUserID { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<System.Guid> UpdateUserID { get; set; }
        public string IPAddress { get; set; }
        public bool IsDelete { get; set; }
    }
}
