using System;
using System.Runtime.Serialization;

namespace HRS.User.Attendance
{
    /// <summary>
    /// Modelʵ���ࣺOverWorkDetail
    /// </summary>
    [DataContract]
    public partial class OverWorkDetailModel
    {
        #region Model

        /// <summary>
        /// ������ID
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// �Ӱ�򿨼�¼��ʶ
        /// </summary>
        [DataMember]
        public Guid OverTimeID { get; set; }

        /// <summary>
        /// �Ӱ�������Ϣ��ʶ
        /// </summary>
        [DataMember]
        public Guid ApplyID { get; set; }

        /// <summary>
        /// �Ӱ��Ա����ʶ
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

        #endregion Model
    }
}
