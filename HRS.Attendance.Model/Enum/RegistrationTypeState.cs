using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 户籍类型枚举
    /// </summary>
    [Serializable]
    public enum RegistrationTypeState
    {
        /// <summary>
        /// 上海城镇
        /// </summary>
        [EnumArrtibute("上海城镇")]
        LocalTown = 1,

        /// <summary>
        /// 上海非城镇
        /// </summary>
        [EnumArrtibute("上海非城镇")] 
        LocalNonTown = 2,

        /// <summary>
        /// 外地城镇
        /// </summary>
        [EnumArrtibute("外地城镇")]
        OtherTown = 3,

        /// <summary>
        /// 外地非城镇
        /// </summary>
        [EnumArrtibute("外地非城镇")] 
        OtherNonTown = 4,
    }
}
