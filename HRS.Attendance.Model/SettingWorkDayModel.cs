using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Model实体类：SettingWorkDay
    /// </summary>
    [DataContract]
    public partial class SettingWorkDayModel
    {
        #region Model

        /// <summary>
        /// 主键：工作日设置ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// 设置年份
        /// </summary>
        [DataMember]
        public short WorkYear { get; set; }

        /// <summary>
        /// 设置月份
        /// </summary>
        [DataMember]
        public byte WorkMonth { get; set; }

        /// <summary>
        /// 工作日拼接字符串（用逗号分割）
        /// </summary>
        [DataMember]
        public string WorkDay_Array { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        [DataMember]
        public Guid PersonnelID { get; set; }

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
        /// 是否弹性工作制
        /// </summary>
        [DataMember]
        public bool IsFlexibleWorking { get; set; }

        #endregion Model
    }
}
