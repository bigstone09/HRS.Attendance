using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Model实体类：OutWorkRecord
    /// </summary>
    [DataContract]
    public partial class OutWorkRecordModel
    {
        #region Model

        /// <summary>
        /// 主键：请假记录ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// 申请外出人ID
        /// </summary>
        [DataMember]
        public Guid PersonnelID { get; set; }

        /// <summary>
        /// 外出理由
        /// </summary>
        [DataMember]
        public string OutReason { get; set; }

        /// <summary>
        /// 外出开始时间
        /// </summary>
        [DataMember]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 外出结束时间
        /// </summary>
        [DataMember]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [DataMember]
        public byte AuditState { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [DataMember]
        public DateTime? ApplyTime { get; set; }

        /// <summary>
        /// 审核人ID
        /// </summary>
        [DataMember]
        public Guid? AuditorID { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        [DataMember]
        public DateTime? AuditTime { get; set; }

        /// <summary>
        /// 外出类型
        /// </summary>
        [DataMember]
        public byte OutType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [DataMember]
        public string Remarks { get; set; }

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
