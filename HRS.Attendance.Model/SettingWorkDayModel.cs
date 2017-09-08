using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺSettingWorkDay
    /// </summary>
    [DataContract]
    public partial class SettingWorkDayModel
    {
        #region Model

        /// <summary>
        /// ����������������ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [DataMember]
        public short WorkYear { get; set; }

        /// <summary>
        /// �����·�
        /// </summary>
        [DataMember]
        public byte WorkMonth { get; set; }

        /// <summary>
        /// ������ƴ���ַ������ö��ŷָ
        /// </summary>
        [DataMember]
        public string WorkDay_Array { get; set; }

        /// <summary>
        /// Ա��ID
        /// </summary>
        [DataMember]
        public Guid PersonnelID { get; set; }

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
        /// �Ƿ��Թ�����
        /// </summary>
        [DataMember]
        public bool IsFlexibleWorking { get; set; }

        #endregion Model
    }
}
