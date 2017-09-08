using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺExchangeWorkData
    /// </summary>
    [DataContract]
    public partial class ExchangeWorkDataModel
    {
        #region Model

        /// <summary>
        /// ���������ݼ�¼ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// �˵��ݶ�Ӧ�������ϢID
        /// </summary>
        [DataMember]
        public Guid? OutWorkID { get; set; }

        /// <summary>
        /// �Ƿ������ϰ�
        /// </summary>
        [DataMember]
        public bool? IsCramWork { get; set; }

        /// <summary>
        /// ���࿪ʼʱ��
        /// </summary>
        [DataMember]
        public DateTime? ExchangeWorkStartTime { get; set; }

        /// <summary>
        /// �������ʱ��
        /// </summary>
        [DataMember]
        public DateTime? ExchangeWorkEndTime { get; set; }

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
