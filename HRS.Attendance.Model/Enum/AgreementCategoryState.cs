using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 合同类别枚举
    /// </summary>
    [Serializable]
    public enum AgreementCategoryState
    {
        /// <summary>
        /// 劳动合同
        /// </summary>
        [EnumArrtibute("劳动合同")]
        Labor = 1,

        /// <summary>
        /// 劳务合同
        /// </summary>
        [EnumArrtibute("劳务合同")]
        LabourService = 2,

        /// <summary>
        /// 外聘合同
        /// </summary>
        [EnumArrtibute("外聘合同")]
        External = 3
    }
}
