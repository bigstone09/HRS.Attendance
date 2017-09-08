using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Model实体类：BranchDefaultWorkTime
    /// </summary>
    [DataContract]
    public partial class BranchDefaultWorkTimeModel
    {
        #region Model

        /// <summary>
        /// 主键：ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [DataMember]
        public Guid BranchID { get; set; }

        /// <summary>
        /// 工作时间ID
        /// </summary>
        [DataMember]
        public Guid? WorkTimeID { get; set; }

        /// <summary>
        /// 工作时间名称
        /// </summary>
        [DataMember]
        public string WorkTimeDescription { get; set; }

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
