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
    
    public partial class OperationLog
    {
        public System.Guid ID { get; set; }
        public System.Guid PersonnelID { get; set; }
        public string RealName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public string ColumnName { get; set; }
        public Nullable<System.Guid> OpertionObject { get; set; }
        public System.Guid PrimaryKeyID { get; set; }
        public byte OperationType { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.Guid CreateUserID { get; set; }
        public string IPAddress { get; set; }
    }
}
