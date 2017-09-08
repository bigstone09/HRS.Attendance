using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺWorkFlowDetail
    /// </summary>
    [DataContract]
    public partial class WorkFlowDetailModel
    {
        #region Model

        /// <summary>
        /// ����������������ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// ������ID
        /// </summary>
        [DataMember]
        public Guid WorkflowID { get; set; }

        /// <summary>
        /// �������ͣ�0����ɫ��1���˺ţ�
        /// </summary>
        [DataMember]
        public byte CurrentOwnerType { get; set; }

        /// <summary>
        /// ������ɫ���˺�ID
        /// </summary>
        [DataMember]
        public Guid CurrentOwner { get; set; }

        /// <summary>
        /// ������ţ�����˳���С����
        /// </summary>
        [DataMember]
        public short ApproverIndex { get; set; }

        /// <summary>
        /// ����뿪���ڶ�������Ҫ����
        /// </summary>
        [DataMember]
        public short LeaveDays { get; set; }

        /// <summary>
        /// �Ƿ����ṩ��ز��������²�
        /// </summary>
        [DataMember]
        public bool IsNeedDocument { get; set; }

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
