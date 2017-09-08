using System;
using HRS.User.Model.Enum.Attributes;

namespace HRS.User.Model.Enum
{
    /// <summary>
    /// 统计分类[2]枚举
    /// </summary>
    [Serializable]
    public enum StatisticalTypeTwoState
    {
        /// <summary>
        /// 管理人员
        /// </summary>
        [EnumArrtibute("管理人员")] 
        Manager = 1,

        /// <summary>
        /// 技术人员
        /// </summary>
        [EnumArrtibute("技术人员")] 
        Technology = 2,

        /// <summary>
        /// 销售人员
        /// </summary>
        [EnumArrtibute("销售人员")] 
        Sale = 3,

        /// <summary>
        /// 辅助工人
        /// </summary>
        [EnumArrtibute("辅助工人")] 
        Auxiliary = 4,

        /// <summary>
        /// 外聘人员
        /// </summary>
        [EnumArrtibute("外聘人员")] 
        External = 5,

        /// <summary>
        /// 代发人员
        /// </summary>
        [EnumArrtibute("代发人员")] 
        Behalf = 6,

        /// <summary>
        /// 普通员工
        /// </summary>
        [EnumArrtibute("普通员工")] 
        Genera = 7
    }
}
