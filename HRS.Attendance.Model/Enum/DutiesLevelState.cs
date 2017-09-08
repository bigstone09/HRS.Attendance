using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 职级枚举
    /// </summary>
    [Serializable]
    public enum DutiesLevelState
    {
        /// <summary>
        /// 一级
        /// </summary>
        [EnumArrtibute("一级")]
        LevelOne = 1,

        /// <summary>
        /// 二级
        /// </summary>
        [EnumArrtibute("二级")]
        LevelTwo = 2,

        /// <summary>
        /// 三级
        /// </summary>
        [EnumArrtibute("三级")]
        LevelThree = 3,

        /// <summary>
        /// 四级
        /// </summary>
        [EnumArrtibute("四级")]
        LevelFour = 4,

        /// <summary>
        /// 五级
        /// </summary>
        [EnumArrtibute("五级")]
        LevelFive = 5,

        /// <summary>
        /// 无（处理空值）
        /// </summary>
        LevelNull=0
    }
}
