using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 等级枚举
    /// </summary>
    [Serializable]
    public enum LevelState
    {
        /// <summary>
        /// 高
        /// </summary>
        [EnumArrtibute("高")]
        Advanced = 1,

        /// <summary>
        /// 中
        /// </summary>
        [EnumArrtibute("中")]
        Medium = 2,

        /// <summary>
        /// 初
        /// </summary>
        [EnumArrtibute("初")]
        Lower = 3,
        
        /// <summary>
        /// 处理空值
        /// </summary>
        IsNull=0
    }
}
