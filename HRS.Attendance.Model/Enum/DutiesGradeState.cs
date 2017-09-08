using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 职等枚举
    /// </summary>
    [Serializable]
    public enum DutiesGradeState
    {
        /// <summary>
        /// 总裁
        /// </summary>
        [EnumArrtibute("总裁")]
        President=1,

        /// <summary>
        /// 副总裁
        /// </summary>
        [EnumArrtibute("副总裁")]
        AssistantPresident=2,

        /// <summary>
        /// 总经理
        /// </summary>
        [EnumArrtibute("总经理")]
        TopManager=3,

        /// <summary>
        /// 总监
        /// </summary>
        [EnumArrtibute("总监")]
        ChiefInspector=4,

        /// <summary>
        /// 高级经理
        /// </summary>
        [EnumArrtibute("高级经理")]
        SeniorManager=5,

        /// <summary>
        /// 经理
        /// </summary>
        [EnumArrtibute("经理")]
        Manager=6,

        /// <summary>
        /// 副经理
        /// </summary>
        [EnumArrtibute("副经理")]
        AssistantManager=7,

        /// <summary>
        /// 高级主管
        /// </summary>
        [EnumArrtibute("高级主管")]
        SeniorSupervisor=8,

        /// <summary>
        /// 主管
        /// </summary>
        [EnumArrtibute("主管")]
        Supervisor=9,

        /// <summary>
        /// 副主管
        /// </summary>
        [EnumArrtibute("副主管")]
        AssistantSupervisor=10,

        /// <summary>
        /// 专员
        /// </summary>
        [EnumArrtibute("专员")]
        Commissioner=11,

        /// <summary>
        /// 助理
        /// </summary>
        [EnumArrtibute("助理")]
        Assistant=12,

        /// <summary>
        /// 无（处理空值）
        /// </summary>
        Null=0
    }
}
