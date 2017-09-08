using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺLeaveRelation
    /// </summary>
    [DataContract]
    public partial class LeaveRelationModel
    {
        #region Model

        /// <summary>
        /// ������ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// ���ݼ�¼ID
        /// </summary>
        [DataMember]
        public Guid LeaveRelationID { get; set; }

        /// <summary>
        /// ��ټ�¼ID
        /// </summary>
        [DataMember]
        public Guid? OutWorkRecordID { get; set; }

        /// <summary>
        /// �Ӱ����ϢID
        /// </summary>
        [DataMember]
        public Guid? OverTimeDataID { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DataMember]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [DataMember]
        public Guid CreateUserID { get; set; }

        /// <summary>
        /// �޸�ʱ��
        /// </summary>
        [DataMember]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// �޸���
        /// </summary>
        [DataMember]
        public Guid? UpdateUserID { get; set; }

        /// <summary>
        /// IP��ַ
        /// </summary>
        [DataMember]
        public string IPAddress { get; set; }

        /// <summary>
        /// �Ƿ�ɾ��
        /// </summary>
        [DataMember]
        public bool IsDelete { get; set; }

        #endregion Model
    }
}
