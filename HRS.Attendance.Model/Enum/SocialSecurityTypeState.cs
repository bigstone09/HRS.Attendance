using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 社保缴纳类型枚举
    /// </summary>
    [Serializable]
    public enum SocialSecurityTypeState
    {
        /// <summary>
        /// 城保
        /// </summary>
        [EnumArrtibute("城保")] 
        TownInsurance = 1,

        /// <summary>
        /// 新三险
        /// </summary>
        [EnumArrtibute("新三险")] 
        NewThreeInsurance = 2,

        /// <summary>
        /// 其他
        /// </summary>
        [EnumArrtibute("其他")] 
        Other = 3
    }
}
