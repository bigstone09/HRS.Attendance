using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺOverTimeData
    /// </summary>
    [DataContract]
    public partial class OverTimeDataModel
    {
        #region Model

        /// <summary>
        /// �������Ӱ�򿨼�¼ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        [DataMember]
        public Guid? PersonnelID { get; set; }

        /// <summary>
        /// ʵ���ϰ��ʱ��
        /// </summary>
        [DataMember]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// ʵ���°��ʱ��
        /// </summary>
        [DataMember]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// �Ӱ�����
        /// </summary>
        [DataMember]
        public byte? OverTimeType { get; set; }

        /// <summary>
        /// �ϰ��ͷ��
        /// </summary>
        [DataMember]
        public string StartImage { get; set; }

        /// <summary>
        /// �°��ͷ��
        /// </summary>
        [DataMember]
        public string EndImage { get; set; }

        /// <summary>
        /// ״̬(����)
        /// </summary>
        [DataMember]
        public byte RecordState { get; set; }

        /// <summary>
        /// ����ԭ��
        /// </summary>
        [DataMember]
        public string AppealReason { get; set; }

        /// <summary>
        /// ����ԭ��
        /// </summary>
        [DataMember]
        public string RejectReason { get; set; }

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
