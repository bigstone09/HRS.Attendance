using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺOverWorkApply
    /// </summary>
    [DataContract]
    public partial class OverWorkApplyModel
    {
        #region Model

        /// <summary>
        /// �������Ӱ�����ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// �Ӱ������˱��
        /// </summary>
        [DataMember]
        public Guid PersonnelID { get; set; }

        /// <summary>
        /// �Ӱ�����������
        /// </summary>
        [DataMember]
        public Guid ApplyBranchID { get; set; }

        /// <summary>
        /// ����Ե��
        /// </summary>
        [DataMember]
        public string ApplyReason { get; set; }

        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        [DataMember]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DataMember]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// �Ӱ�����
        /// </summary>
        [DataMember]
        public byte OverTimeType { get; set; }

        /// <summary>
        /// ����״̬
        /// </summary>
        [DataMember]
        public byte ApplyState { get; set; }

        /// <summary>
        /// ���ʱ��
        /// </summary>
        [DataMember]
        public DateTime? AuditTime { get; set; }

        /// <summary>
        /// ����˱��
        /// </summary>
        [DataMember]
        public Guid? AuditorID { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        [DataMember]
        public string Remarks { get; set; }

        /// <summary>
        /// ʵ����Ҫ�Ӱ���Ա�������ַ�������(���ŷָ�)
        /// </summary>
        [DataMember]
        public string PersonnelID_Array { get; set; }

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
