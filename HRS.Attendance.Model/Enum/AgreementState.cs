using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 合同状态枚举
    /// </summary>
    [Serializable]
    public enum AgreementState
    {
        /// <summary>
        /// 有效
        /// </summary>
        [EnumArrtibute("有效")]
        Effective = 1,

        /// <summary>
        /// 中止
        /// </summary>
        [EnumArrtibute("中止")]
        Suspension = 2,

        /// <summary>
        /// 终止
        /// </summary>
        [EnumArrtibute("终止")]
        Termination = 3,

        /// <summary>
        /// 解除
        /// </summary>
        [EnumArrtibute("解除")]
        Relieve = 4,

        /// <summary>
        /// 待签
        /// </summary>
        Watting = 0,
    }
}
