using System;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 合同标记枚举
    /// </summary>
    [Serializable]
    public enum AgreementStampState
    {
        /// <summary>
        /// 新签
        /// </summary>
        New=1,

        /// <summary>
        /// 续签
        /// </summary>
        Continued=2
    }
}
