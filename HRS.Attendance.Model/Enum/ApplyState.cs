using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 申请状态枚举
    /// </summary>
    [Serializable]
    public enum ApplyState
    {
        /// <summary>
        /// 待审核
        /// </summary>
        [EnumArrtibute("未审核")]
        No=0,

        /// <summary>
        /// 已审核
        /// </summary>
        [EnumArrtibute("已审核")]
        Yes=1,

        /// <summary>
        /// 拒绝
        /// </summary>
        [EnumArrtibute("拒绝")]
        Refusing=2,

        /// <summary>
        /// 作废
        /// </summary>
        [EnumArrtibute("作废")]
        Defeasance=3
    }
}
