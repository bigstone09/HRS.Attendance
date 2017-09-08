using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Model实体类：OperationLog
    /// </summary>
    [DataContract]
    public partial class OperationLogModel
    {
        #region Model

        /// <summary>
        /// 主键：操作日志ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// 操作者ID
        /// </summary>
        [DataMember]
        public Guid PersonnelID { get; set; }

        /// <summary>
        /// 操作者真实姓名
        /// </summary>
        [DataMember]
        public string RealName { get; set; }

        /// <summary>
        /// 操作对象的旧值
        /// </summary>
        [DataMember]
        public string OldValue { get; set; }

        /// <summary>
        /// 操作对象的新值
        /// </summary>
        [DataMember]
        public string NewValue { get; set; }

        /// <summary>
        /// 操作的类型
        /// </summary>
        [DataMember]
        public string Type { get; set; }

        /// <summary>
        /// 操作内容的描述
        /// </summary>
        [DataMember]
        public string Content { get; set; }

        /// <summary>
        /// 操作的列
        /// </summary>
        [DataMember]
        public string ColumnName { get; set; }

        /// <summary>
        /// 被操作人员ID
        /// </summary>
        [DataMember]
        public Guid? OpertionObject { get; set; }

        /// <summary>
        /// 主键ID
        /// </summary>
        [DataMember]
        public Guid PrimaryKeyID { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [DataMember]
        public byte OperationType { get; set; }

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
        /// IP地址
        /// </summary>
        [DataMember]
        public string IPAddress { get; set; }

        #endregion Model
    }
}
