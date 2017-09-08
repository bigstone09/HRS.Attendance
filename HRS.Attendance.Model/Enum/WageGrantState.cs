using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 工资发放状态枚举
    /// </summary>
    [Serializable]
    public enum WageGrantState
    {
        /// <summary>
        /// 本单位发放
        /// </summary>
        [EnumArrtibute("本单位发放")] 
        TheUnit = 1,

        /// <summary>
        /// 外单位发放
        /// </summary>
        [EnumArrtibute("外单位发放")] 
        OutsideUnit = 2,

        /// <summary>
        /// 本单位发外单位划转
        /// </summary>
        [EnumArrtibute("本单位发外单位划转")] 
        UnitToOutside = 3
    }
}
