using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺAttendanceTotal
    /// </summary>
    [DataContract]
    public partial class AttendanceTotalModel
    {
        #region Model

        /// <summary>
        /// ����������ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [DataMember]
        public Guid BranchID { get; set; }

        /// <summary>
        /// ְ��
        /// </summary>
        [DataMember]
        public Guid PositionID { get; set; }

        /// <summary>
        /// Ա����
        /// </summary>
        [DataMember]
        public Guid PersonelID { get; set; }

        /// <summary>
        /// Ա������
        /// </summary>
        [DataMember]
        public string PersonelName { get; set; }

        /// <summary>
        /// �ٵ�10��������
        /// </summary>
        [DataMember]
        public byte? LateTypeOne { get; set; }

        /// <summary>
        /// �ٵ�10��40����
        /// </summary>
        [DataMember]
        public byte? LateTypeTwo { get; set; }

        /// <summary>
        /// �ٵ�40��������
        /// </summary>
        [DataMember]
        public byte? LateTypeThree { get; set; }

        /// <summary>
        /// ���˴���
        /// </summary>
        [DataMember]
        public byte? AdvanceCount { get; set; }

        /// <summary>
        /// ʵ���ϰ�����
        /// </summary>
        [DataMember]
        public string RealWork { get; set; }

        /// <summary>
        /// ��
        /// </summary>
        [DataMember]
        public short Year { get; set; }

        /// <summary>
        /// ��
        /// </summary>
        [DataMember]
        public byte Month { get; set; }

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
