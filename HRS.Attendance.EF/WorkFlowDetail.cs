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
    
    public partial class WorkFlowDetail
    {
        public System.Guid ID { get; set; }
        public System.Guid WorkflowID { get; set; }
        public byte CurrentOwnerType { get; set; }
        public System.Guid CurrentOwner { get; set; }
        public short ApproverIndex { get; set; }
        public short LeaveDays { get; set; }
        public bool IsNeedDocument { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.Guid CreateUserID { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<System.Guid> UpdateUserID { get; set; }
        public string IPAddress { get; set; }
        public bool IsDelete { get; set; }
    }
}
