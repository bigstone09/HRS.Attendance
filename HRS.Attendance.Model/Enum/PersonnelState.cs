using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 员工状态
    /// </summary>
    [Serializable]
    public enum PersonnelState
    {
        /// <summary>
        /// 离职
        /// </summary>
        [EnumArrtibute("离职")] 
        Departure = 1,

        /// <summary>
        /// 在职
        /// </summary>
        [EnumArrtibute("在职")] 
        Working = 2,

        /// <summary>
        /// 退休
        /// </summary>
        [EnumArrtibute("退休")] 
        Retirement = 3,

        /// <summary>
        /// 协保
        /// </summary>
        [EnumArrtibute("协保")]
        Assurance = 4,

        /// <summary>
        /// 全部
        /// </summary>
        [EnumArrtibute("全部")]
        All=0
    }
}
