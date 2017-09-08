using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺRestOverTime
    /// </summary>
    [DataContract]
    public partial class RestOverTimeModel
    {
        #region Model

        /// <summary>
        /// �������ڼ�����Ϣʱ��ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// ��Ϣʱ�䣨��һ�죩
        /// </summary>
        [DataMember]
        public DateTime? RestDateTime { get; set; }

        /// <summary>
        /// ��Ϣ����(˫���ջ��ǽڼ���)
        /// </summary>
        [DataMember]
        public byte? OverTimeType { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [DataMember]
        public string Description { get; set; }

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
