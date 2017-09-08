using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Model实体类：WorkFlowDetail
    /// </summary>
    [DataContract]
    public partial class WorkFlowDetailModel
    {
        #region Model

        /// <summary>
        /// 主键：审批流详情ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// 审批流ID
        /// </summary>
        [DataMember]
        public Guid WorkflowID { get; set; }

        /// <summary>
        /// 审批类型（0：角色，1：账号）
        /// </summary>
        [DataMember]
        public byte CurrentOwnerType { get; set; }

        /// <summary>
        /// 审批角色或账号ID
        /// </summary>
        [DataMember]
        public Guid CurrentOwner { get; set; }

        /// <summary>
        /// 审批编号（审批顺序从小到大）
        /// </summary>
        [DataMember]
        public short ApproverIndex { get; set; }

        /// <summary>
        /// 请假离开大于多少天需要审批
        /// </summary>
        [DataMember]
        public short LeaveDays { get; set; }

        /// <summary>
        /// 是否需提供相关材料至人事部
        /// </summary>
        [DataMember]
        public bool IsNeedDocument { get; set; }

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
