using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 学位枚举
    /// </summary>
    [Serializable]
    public enum DegreeState
    {
        /// <summary>
        ///  博士
        /// </summary>
        [EnumArrtibute("博士")]
        Doctorate = 1,

        /// <summary>
        /// 硕士
        /// </summary>
        [EnumArrtibute("硕士")]
        Master = 2,

        /// <summary>
        /// 学士
        /// </summary>
        [EnumArrtibute("学士")]
        Bachelor = 3,

        /// <summary>
        /// 无
        /// </summary>
        No = 4
    }
}
