using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Model实体类：OutWorkPower
    /// </summary>
    [DataContract]
    public partial class OutWorkPowerModel
    {
        #region Model

        /// <summary>
        /// 主键：外出权限ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        [DataMember]
        public Guid? FilialeID { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [DataMember]
        public Guid? BranchID { get; set; }

        /// <summary>
        /// 职位ID
        /// </summary>
        [DataMember]
        public Guid? PositionID { get; set; }

        /// <summary>
        /// 可以审核公司ID
        /// </summary>
        [DataMember]
        public Guid? AuditFilialeID { get; set; }

        /// <summary>
        /// 可以审核部门ID
        /// </summary>
        [DataMember]
        public Guid? AuditBranchID { get; set; }

        /// <summary>
        /// 可以审核职位ID
        /// </summary>
        [DataMember]
        public Guid? AuditPositionID { get; set; }

        /// <summary>
        /// 外出类型(请假、因公外出、调休)
        /// </summary>
        [DataMember]
        public byte? OutType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [DataMember]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [DataMember]
        public Guid CreateUserID { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [DataMember]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [DataMember]
        public Guid? UpdateUserID { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        [DataMember]
        public string IPAddress { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [DataMember]
        public bool IsDelete { get; set; }

        #endregion Model
    }
}
