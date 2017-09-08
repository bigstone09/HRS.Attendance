using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 在职状况枚举
    /// </summary>
    [Serializable]
    public enum EmployState
    {
        /// <summary>
        /// 合同工
        /// </summary>
        [EnumArrtibute("合同工")]
        Agreement=1,

        /// <summary>
        /// 劳务工
        /// </summary>
        [EnumArrtibute("劳务工")]
        LabourService=2,

        /// <summary>
        /// 外单位派遣
        /// </summary>
        [EnumArrtibute("外单位派遣")]
        Expatriate=3,

        /// <summary>
        /// 本单位协保
        /// </summary>
        [EnumArrtibute("本单位协保")]
        Assurance=4,

        /// <summary>
        /// 退休返聘
        /// </summary>
        [EnumArrtibute("退休返聘")]
        EmployRetirement=5,

        /// <summary>
        /// 钟点工
        /// </summary>
        [EnumArrtibute("钟点工")]
        PartTime=6
    }
}
