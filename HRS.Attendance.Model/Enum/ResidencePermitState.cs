using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 居住证类型
    /// </summary>
    [Serializable]
    public enum ResidencePermitState
    {
        /// <summary>
        /// 人才居住证
        /// </summary>
        [EnumArrtibute("人才居住证")]
        Talent = 1,

        /// <summary>
        /// 一般居住证
        /// </summary>
        [EnumArrtibute("一般居住证")]
        General = 2
    }
}
