using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 外出类型枚举
    /// </summary>
    [Serializable]
    public enum OutType
    {
        /// <summary>
        /// 所有
        /// </summary>
        All = 0,

        /// <summary>
        /// 因公外出
        /// </summary>
        [EnumArrtibute("因公外出")]
        WorkOut = 10,

        /// <summary>
        /// 事假
        /// </summary>
        [EnumArrtibute("事假")]
        ThingHoliday = 20,

        /// <summary>
        /// 病假
        /// </summary>
        [EnumArrtibute("病假")]
        IllHoliday = 21,

        /// <summary>
        /// 丧假
        /// </summary>
        [EnumArrtibute("丧假")]
        DeadHoliday = 22,

        /// <summary>
        /// 产假
        /// </summary>
        [EnumArrtibute("产假")]
        BornHoliday = 23,

        /// <summary>
        /// 年假
        /// </summary>
        [EnumArrtibute("年假")]
        YearHoliday = 24,

        /// <summary>
        /// 婚假
        /// </summary>
        [EnumArrtibute("婚假")]
        MarryHoliday = 25,

        /// <summary>
        /// 调休
        /// </summary>
        [EnumArrtibute("调休")]
        Exchanging = 30,

        /// <summary>
        /// 总裁特批
        /// </summary>
        [EnumArrtibute("总裁特批")]
        Special = 40
    }
}
