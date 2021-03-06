using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Model实体类：AttendanceData
    /// </summary>
    [DataContract]
    public partial class AttendanceDataModel
    {
        #region Model

        /// <summary>
        /// 主键：正常班打卡记录ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// 进行打卡的员工号
        /// </summary>
        [DataMember]
        public Guid PersonnelID { get; set; }

        /// <summary>
        /// 是否弹性工作制
        /// </summary>
        [DataMember]
        public bool IsFlexibleWorking { get; set; }

        /// <summary>
        /// 实际上班打卡时间
        /// </summary>
        [DataMember]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 实际下班打卡时间
        /// </summary>
        [DataMember]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 应上班打卡时间
        /// </summary>
        [DataMember]
        public DateTime? CurrentWorkTime { get; set; }

        /// <summary>
        /// 应下班打卡时间
        /// </summary>
        [DataMember]
        public DateTime? CurrentEndTime { get; set; }

        /// <summary>
        /// 上班打卡头像
        /// </summary>
        [DataMember]
        public string StartImage { get; set; }

        /// <summary>
        /// 下班打卡头像
        /// </summary>
        [DataMember]
        public string EndImage { get; set; }

        /// <summary>
        /// 状态(申诉)
        /// </summary>
        [DataMember]
        public byte RecordState { get; set; }

        /// <summary>
        /// 申诉原因
        /// </summary>
        [DataMember]
        public string AppealReason { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [DataMember]
        public string RejectReason { get; set; }

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
