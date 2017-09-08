using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺOperationLog
    /// </summary>
    [DataContract]
    public partial class OperationLogModel
    {
        #region Model

        /// <summary>
        /// ������������־ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// ������ID
        /// </summary>
        [DataMember]
        public Guid PersonnelID { get; set; }

        /// <summary>
        /// ��������ʵ����
        /// </summary>
        [DataMember]
        public string RealName { get; set; }

        /// <summary>
        /// ��������ľ�ֵ
        /// </summary>
        [DataMember]
        public string OldValue { get; set; }

        /// <summary>
        /// �����������ֵ
        /// </summary>
        [DataMember]
        public string NewValue { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        [DataMember]
        public string Type { get; set; }

        /// <summary>
        /// �������ݵ�����
        /// </summary>
        [DataMember]
        public string Content { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [DataMember]
        public string ColumnName { get; set; }

        /// <summary>
        /// ��������ԱID
        /// </summary>
        [DataMember]
        public Guid? OpertionObject { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        [DataMember]
        public Guid PrimaryKeyID { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [DataMember]
        public byte OperationType { get; set; }

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
        /// IP��ַ
        /// </summary>
        [DataMember]
        public string IPAddress { get; set; }

        #endregion Model
    }
}
