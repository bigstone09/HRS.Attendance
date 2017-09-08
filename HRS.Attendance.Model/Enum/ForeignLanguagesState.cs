using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 外语语种枚举
    /// </summary>
    [Serializable]
    public enum ForeignLanguagesState
    {
        /// <summary>
        /// 英语
        /// </summary>
        [EnumArrtibute("英语")]
        English = 1,

        /// <summary>
        /// 法语
        /// </summary>
        [EnumArrtibute("法语")]
        French = 2,

        /// <summary>
        /// 日语
        /// </summary>
        [EnumArrtibute("日语")]
        Japanese = 3,

        /// <summary>
        /// 俄语
        /// </summary>
        [EnumArrtibute("俄语")]
        Russian = 4,

        /// <summary>
        /// 空值处理
        /// </summary>
        IsNull=0
    }
}
