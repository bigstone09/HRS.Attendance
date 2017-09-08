using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺOutWorkRecord
    /// </summary>
    [DataContract]
    public partial class OutWorkRecordModel
    {
        #region Model

        /// <summary>
        /// ��������ټ�¼ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// ���������ID
        /// </summary>
        [DataMember]
        public Guid PersonnelID { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [DataMember]
        public string OutReason { get; set; }

        /// <summary>
        /// �����ʼʱ��
        /// </summary>
        [DataMember]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// �������ʱ��
        /// </summary>
        [DataMember]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// ���״̬
        /// </summary>
        [DataMember]
        public byte AuditState { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DataMember]
        public DateTime? ApplyTime { get; set; }

        /// <summary>
        /// �����ID
        /// </summary>
        [DataMember]
        public Guid? AuditorID { get; set; }

        /// <summary>
        /// ���ʱ��
        /// </summary>
        [DataMember]
        public DateTime? AuditTime { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [DataMember]
        public byte OutType { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        [DataMember]
        public string Remarks { get; set; }

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

        /// <summary>
        /// �������
        /// </summary>
        [DataMember]
        public short? ApproverIndex { get; set; }

        #endregion Model
    }
}
