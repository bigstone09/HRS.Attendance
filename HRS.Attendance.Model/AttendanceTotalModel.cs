using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Model实体类：AttendanceTotal
    /// </summary>
    [DataContract]
    public partial class AttendanceTotalModel
    {
        #region Model

        /// <summary>
        /// 主键：考勤ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        [DataMember]
        public Guid BranchID { get; set; }

        /// <summary>
        /// 职务
        /// </summary>
        [DataMember]
        public Guid PositionID { get; set; }

        /// <summary>
        /// 员工号
        /// </summary>
        [DataMember]
        public Guid PersonelID { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [DataMember]
        public string PersonelName { get; set; }

        /// <summary>
        /// 迟到10分钟以内
        /// </summary>
        [DataMember]
        public byte? LateTypeOne { get; set; }

        /// <summary>
        /// 迟到10到40分钟
        /// </summary>
        [DataMember]
        public byte? LateTypeTwo { get; set; }

        /// <summary>
        /// 迟到40分钟以上
        /// </summary>
        [DataMember]
        public byte? LateTypeThree { get; set; }

        /// <summary>
        /// 早退次数
        /// </summary>
        [DataMember]
        public byte? AdvanceCount { get; set; }

        /// <summary>
        /// 实际上班天数
        /// </summary>
        [DataMember]
        public string RealWork { get; set; }

        /// <summary>
        /// 年
        /// </summary>
        [DataMember]
        public short Year { get; set; }

        /// <summary>
        /// 月
        /// </summary>
        [DataMember]
        public byte Month { get; set; }

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
