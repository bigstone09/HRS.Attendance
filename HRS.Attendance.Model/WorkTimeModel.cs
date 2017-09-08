using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺWorkTime
    /// </summary>
    [DataContract]
    public partial class WorkTimeModel
    {
        #region Model

        /// <summary>
        /// �������ù���ʱ��ε�ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// �ϰ�ʱ��
        /// </summary>
        [DataMember]
        public DateTime WorkStartTime { get; set; }

        /// <summary>
        /// �°�ʱ��
        /// </summary>
        [DataMember]
        public DateTime WorkEndTime { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// ö�ٱ�ʶ
        /// </summary>
        [DataMember]
        public int Identification { get; set; }

        /// <summary>
        /// �Ƿ�������
        /// </summary>
        [DataMember]
        public bool IsUse { get; set; }

        /// <summary>
        /// �Ƿ�ΪĬ��
        /// </summary>
        [DataMember]
        public bool IsDefault { get; set; }

        /// <summary>
        /// �ͲͿ�ʼʱ��
        /// </summary>
        [DataMember]
        public DateTime? LunchStartTime { get; set; }

        /// <summary>
        /// �Ͳͽ���ʱ��
        /// </summary>
        [DataMember]
        public DateTime? LunchEndTime { get; set; }

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
