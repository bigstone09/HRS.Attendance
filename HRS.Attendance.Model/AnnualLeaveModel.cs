using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺAnnualLeave
    /// </summary>
    [DataContract]
    public partial class AnnualLeaveModel
    {
        #region Model

        /// <summary>
        /// ��������ټ�¼ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// Ա��ID
        /// </summary>
        [DataMember]
        public Guid PersonnelID { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [DataMember]
        public byte AnnualLeaveDays { get; set; }

        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        [DataMember]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DataMember]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// ���ʹ��״̬��0��δ�ã�1�����ã�2���ѹ��ڣ�
        /// </summary>
        [DataMember]
        public byte Status { get; set; }

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
