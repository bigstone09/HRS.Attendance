using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 工资发放状态枚举
    /// </summary>
    [Serializable]
    public enum WageGrantUnit
    {
        /// <summary>
        /// 可得光学科技(ERP)
        /// </summary>
        [EnumArrtibute("可得光学科技(ERP)")]
        Keedeerp = 1,

        /// <summary>
        /// 可得信息(keede)
        /// </summary>
        [EnumArrtibute("可得信息(keede)")]
        KeedeInfo = 2,

        /// <summary>
        /// 百秀医药(baishop)
        /// </summary>
        [EnumArrtibute("百秀医药(baishop)")]
        Baishop = 3,

        /// <summary>
        /// 可得眼镜总公司
        /// </summary>
        [EnumArrtibute("可得眼镜总公司")]
        KeedeCompany = 4
    }
}