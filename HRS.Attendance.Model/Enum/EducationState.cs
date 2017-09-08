using System;
using HRS.User.Model.Enum.Attributes;
namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 学历枚举
    /// </summary>
    [Serializable]
    public enum EducationState
    {
        /// <summary>
        ///  博士
        /// </summary>
        [EnumArrtibute("博士")]
        Doctorate = 1,

        /// <summary>
        /// 硕士
        /// </summary>
        [EnumArrtibute("硕士")]
        Master = 2,

        /// <summary>
        /// 本科
        /// </summary>
        [EnumArrtibute("本科")]
        Undergraduate = 3,

        /// <summary>
        /// 大专
        /// </summary>
        [EnumArrtibute("大专")]
        College = 4,

        /// <summary>
        /// 中专
        /// </summary>
        [EnumArrtibute("中专")]
        Specialized = 5,

        /// <summary>
        /// 高中以下
        /// </summary>
        [EnumArrtibute("高中以下")]
        BelowHighSchool = 6,

        /// <summary>
        /// 空值处理
        /// </summary>
        Null=0
    }
}
