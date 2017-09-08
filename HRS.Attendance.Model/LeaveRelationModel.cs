using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Model实体类：LeaveRelation
    /// </summary>
    [DataContract]
    public partial class LeaveRelationModel
    {
        #region Model

        /// <summary>
        /// 主键：ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// 调休记录ID
        /// </summary>
        [DataMember]
        public Guid LeaveRelationID { get; set; }

        /// <summary>
        /// 请假记录ID
        /// </summary>
        [DataMember]
        public Guid? OutWorkRecordID { get; set; }

        /// <summary>
        /// 加班打卡信息ID
        /// </summary>
        [DataMember]
        public Guid? OverTimeDataID { get; set; }

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
