using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺBranchDefaultWorkTime
    /// </summary>
    [DataContract]
    public partial class BranchDefaultWorkTimeModel
    {
        #region Model

        /// <summary>
        /// ������ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        [DataMember]
        public Guid BranchID { get; set; }

        /// <summary>
        /// ����ʱ��ID
        /// </summary>
        [DataMember]
        public Guid? WorkTimeID { get; set; }

        /// <summary>
        /// ����ʱ������
        /// </summary>
        [DataMember]
        public string WorkTimeDescription { get; set; }

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
