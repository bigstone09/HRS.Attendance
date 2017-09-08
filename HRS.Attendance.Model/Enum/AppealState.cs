using System;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 申诉状态枚举
    /// </summary>
    [Serializable]
    public enum AppealState
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal=1,

        /// <summary>
        /// 申诉中
        /// </summary>
        Appealing=2,

        /// <summary>
        /// 申诉失败
        /// </summary>
        Failure=3
    }
}
