using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Model实体类：WorkTime
    /// </summary>
    [DataContract]
    public partial class WorkTimeModel
    {
        #region Model

        /// <summary>
        /// 主键：该工作时间段的ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// 上班时间
        /// </summary>
        [DataMember]
        public DateTime WorkStartTime { get; set; }

        /// <summary>
        /// 下班时间
        /// </summary>
        [DataMember]
        public DateTime WorkEndTime { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// 枚举标识
        /// </summary>
        [DataMember]
        public int Identification { get; set; }

        /// <summary>
        /// 是否正启用
        /// </summary>
        [DataMember]
        public bool IsUse { get; set; }

        /// <summary>
        /// 是否为默认
        /// </summary>
        [DataMember]
        public bool IsDefault { get; set; }

        /// <summary>
        /// 就餐开始时间
        /// </summary>
        [DataMember]
        public DateTime? LunchStartTime { get; set; }

        /// <summary>
        /// 就餐结束时间
        /// </summary>
        [DataMember]
        public DateTime? LunchEndTime { get; set; }

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
