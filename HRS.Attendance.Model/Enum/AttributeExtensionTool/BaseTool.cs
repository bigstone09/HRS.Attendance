using System;
using System.Text.RegularExpressions;

namespace HRS.User.Model.Enum.AttributeExtensionTool
{
    /// <summary>
    /// 特性扩展工具 —— 基本工具
    /// </summary>
    internal static class BaseTool
    {
        private const string GUID = "^[0-9a-fA-F]{8}(-[0-9a-fA-F]{4}){3}-[0-9a-fA-F]{12}$|^[0-9a-fA-F]{32}$";

        #region> 公用扩展方法 > 判断是否为空
        /// <summary>
        /// 判断对象是否为空，为空返回true
        /// </summary>
        internal static bool IsNullOrEmpty<T>(T data)
        {
            if (data == null)
            {
                return true;
            }
            if (data is string && data.ToString().Trim().Length <= 0)
            {
                return true;
            }
            if (data is DBNull)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断对象是否为空，为空返回true
        /// </summary>
        internal static bool IsNullOrEmpty(this object data)
        {
            if (data == null)
            {
                return true;
            }
            if (data is string && data.ToString().Trim().Length <= 0)
            {
                return true;
            }
            if (data is DBNull)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region> 公用扩展方法 > 判断是否是某一类型
        /// <summary>
        /// 是否是Byte
        /// </summary>
        internal static bool IsByte(this object data)
        {
            if (IsNullOrEmpty(data))
            {
                return false;
            }
            byte outParam;
            return byte.TryParse(data.ToString(), out outParam);
        }

        /// <summary>
        /// 是否是整数
        /// </summary>
        internal static bool IsInt(this object data)
        {
            if (IsNullOrEmpty(data))
            {
                return false;
            }
            int outParam;
            return int.TryParse(data.ToString(), out outParam);
        }

        /// <summary>
        /// 是否是日期
        /// </summary>
        internal static bool IsDateTime(this object data)
        {
            if (IsNullOrEmpty(data))
            {
                return false;
            }
            DateTime outParam;
            return DateTime.TryParse(data.ToString(), out outParam);
        }

        /// <summary>
        /// 是否是GUID
        /// </summary>
        internal static bool IsGuid(this object data)
        {
            return !IsNullOrEmpty(data) && Regex.IsMatch(data.ToString(), GUID);
        }
        #endregion

        #region> 公用扩展方法 > 转换为某一类型
        /// <summary>
        /// 转换成Byte
        /// </summary>
        internal static int ToByte(this object data)
        {
            return IsByte(data) ? Convert.ToByte(data) : 0;
        }

        /// <summary>
        /// 转换成Int32
        /// </summary>
        internal static int ToInt(this object data)
        {
            return IsInt(data) ? Convert.ToInt32(data) : 0;
        }

        /// <summary>
        /// 转换成DateTime
        /// </summary>
        internal static DateTime ToDateTime(this object data)
        {
            return IsDateTime(data) ? DateTime.Parse(data.ToString()) : DateTime.MinValue;
        }

        /// <summary>
        /// 转换成GUID
        /// </summary>
        internal static Guid ToGuid(this object data)
        {
            return IsGuid(data) ? new Guid(data.ToString()) : Guid.Empty;
        }
        #endregion
    }
}
