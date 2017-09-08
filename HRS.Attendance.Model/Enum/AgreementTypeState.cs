using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 合同类型枚举
    /// </summary>
    [Serializable]
    public enum AgreementTypeState
    {
        /// <summary>
        /// 固定期限
        /// </summary>
        [EnumArrtibute("固定期限")]
        Fixed = 1,

        /// <summary>
        /// 无固定期限
        /// </summary>
        [EnumArrtibute("无固定期限")]
        NotFixed = 2,

        /// <summary>
        /// 以完成一定工作为期限
        /// </summary>
        [EnumArrtibute("以完成一定工作为期限")]
        Certain = 3,

        /// <summary>
        /// 其他
        /// </summary>
        [EnumArrtibute("其他")]
        Other = 4
    }
}
