using System;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 审核状态
    /// </summary>
    [Serializable]
    public enum AuditingState
    {
        /// <summary>
        /// 未审核
        /// </summary>
        No = 0,

        /// <summary>
        /// 已审核
        /// </summary>
        Yes = 1,

        /// <summary>
        /// 隐藏
        /// </summary>
        Hide = 2
    }
}
