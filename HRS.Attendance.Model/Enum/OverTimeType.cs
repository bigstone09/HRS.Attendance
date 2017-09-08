using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 加班类型枚举
    /// </summary>
    [Serializable]
    public enum OverTimeType
    {
        /// <summary>
        /// 所有类型
        /// </summary>
        All = -1,

        /// <summary>
        /// 工作日加班
        /// </summary>
        [EnumArrtibute("工作日加班")]
        Normal = 0,

        /// <summary>
        /// 双休日加班
        /// </summary>
        [EnumArrtibute("双休日加班")]
        Rest = 1,

        /// <summary>
        /// 节假日加班
        /// </summary>
        [EnumArrtibute("节假日加班")]
        Holiday = 2
    }
}
