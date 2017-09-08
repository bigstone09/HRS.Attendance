using System;
using System.Configuration;

namespace HRS.Attendance.Tool
{
    /// <summary>全局配置信息
    /// </summary>
    public class GlobalConfig
    {
        /// <summary>
        ///
        /// </summary>
        public static readonly string DBConnectString = ConfigurationManager.ConnectionStrings[DB_CONNECT_NAME].ConnectionString;
        

        /// <summary>
        ///
        /// </summary>
        public const string DB_CONNECT_NAME = "DBConnectString";

    }
}