using System;

namespace HRS.Attendance.Model.Common
{
    /// <summary>分页请求模型
    /// </summary>
    public class PageRequest 
    {
        /// <summary>每页记录数
        /// </summary>
        public Int32 Size { get; set; }

        /// <summary>当前页码
        /// </summary>
        public Int32 Page { get; set; }
    }
}
