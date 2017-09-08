using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Model实体类：OverWorkApply
    /// </summary>
    [DataContract]
    public partial class OverWorkApplyModel
    {
        #region Model

        /// <summary>
        /// 主键：加班申请ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// 加班申请人编号
        /// </summary>
        [DataMember]
        public Guid PersonnelID { get; set; }

        /// <summary>
        /// 加班申请人名称
        /// </summary>
        [DataMember]
        public Guid ApplyBranchID { get; set; }

        /// <summary>
        /// 申请缘由
        /// </summary>
        [DataMember]
        public string ApplyReason { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [DataMember]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [DataMember]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 加班类型
        /// </summary>
        [DataMember]
        public byte OverTimeType { get; set; }

        /// <summary>
        /// 申请状态
        /// </summary>
        [DataMember]
        public byte ApplyState { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        [DataMember]
        public DateTime? AuditTime { get; set; }

        /// <summary>
        /// 审核人编号
        /// </summary>
        [DataMember]
        public Guid? AuditorID { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [DataMember]
        public string Remarks { get; set; }

        /// <summary>
        /// 实际需要加班人员姓名的字符串集合(逗号分割)
        /// </summary>
        [DataMember]
        public string PersonnelID_Array { get; set; }

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

        /// <summary>
        /// 审批编号
        /// </summary>
        [DataMember]
        public short? ApproverIndex { get; set; }

        #endregion Model
    }
}
