using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Model实体类：ExchangeWorkData
    /// </summary>
    [DataContract]
    public partial class ExchangeWorkDataModel
    {
        #region Model

        /// <summary>
        /// 主键：调休记录ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// 此调休对应的请假信息ID
        /// </summary>
        [DataMember]
        public Guid? OutWorkID { get; set; }

        /// <summary>
        /// 是否有来上班
        /// </summary>
        [DataMember]
        public bool? IsCramWork { get; set; }

        /// <summary>
        /// 补班开始时间
        /// </summary>
        [DataMember]
        public DateTime? ExchangeWorkStartTime { get; set; }

        /// <summary>
        /// 补班结束时间
        /// </summary>
        [DataMember]
        public DateTime? ExchangeWorkEndTime { get; set; }

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
