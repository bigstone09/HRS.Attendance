using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 工资发放状态枚举
    /// </summary>
    [Serializable]
    public enum StateColor
    {
        /// <summary>
        /// 当天未打卡
        /// </summary>
        [EnumArrtibute("当天未打卡")]
        NoClock = 1,

        /// <summary>
        /// 二个礼拜过试用期
        /// </summary>
        [EnumArrtibute("两礼拜过试用期")]
        TwoWeekProbation = 2,

        /// <summary>
        /// 一个月合同到期
        /// </summary>
        [EnumArrtibute("一个月合同到期")]
        OneMonthAgreement = 3,

        /// <summary>
        /// 全部状态
        /// </summary>
        All = 0
    }
}