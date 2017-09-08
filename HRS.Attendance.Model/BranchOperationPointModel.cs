using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Model实体类：BranchOperationPoint
    /// </summary>
    [DataContract]
    public partial class BranchOperationPointModel
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
        /// 操作点ID
        /// </summary>
        [DataMember]
        public Guid PointID { get; set; }

        /// <summary>
        /// 操作类型ID
        /// </summary>
        [DataMember]
        public Guid TypeID { get; set; }

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
