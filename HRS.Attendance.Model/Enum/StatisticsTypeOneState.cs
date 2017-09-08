using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 统计分类[1]枚举
    /// </summary>
    [Serializable]
    public enum StatisticalTypeOneState
    {
        /// <summary>
        /// 列入本单位成本
        /// </summary>
        [EnumArrtibute("列入本单位成本")] 
        TheUnit=1,

        /// <summary>
        /// 不列入本单位成本
        /// </summary>
        [EnumArrtibute("不列入本单位成本")]
        OutsideUnit = 2,

        /// <summary>
        /// 本单位发放外单位划转
        /// </summary>
        [EnumArrtibute("本单位发放外单位划转")]
        UnitToOutside = 3,

        /// <summary>
        /// 外单位发放本单位划转
        /// </summary>
        [EnumArrtibute("外单位发放本单位划转")]
        OutsideToUnit = 4
    }
}
