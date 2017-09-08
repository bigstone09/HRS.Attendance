using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺOutWorkPower
    /// </summary>
    [DataContract]
    public partial class OutWorkPowerModel
    {
        #region Model

        /// <summary>
        /// ���������Ȩ��ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// ��˾ID
        /// </summary>
        [DataMember]
        public Guid? FilialeID { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        [DataMember]
        public Guid? BranchID { get; set; }

        /// <summary>
        /// ְλID
        /// </summary>
        [DataMember]
        public Guid? PositionID { get; set; }

        /// <summary>
        /// ������˹�˾ID
        /// </summary>
        [DataMember]
        public Guid? AuditFilialeID { get; set; }

        /// <summary>
        /// ������˲���ID
        /// </summary>
        [DataMember]
        public Guid? AuditBranchID { get; set; }

        /// <summary>
        /// �������ְλID
        /// </summary>
        [DataMember]
        public Guid? AuditPositionID { get; set; }

        /// <summary>
        /// �������(��١������������)
        /// </summary>
        [DataMember]
        public byte? OutType { get; set; }

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
