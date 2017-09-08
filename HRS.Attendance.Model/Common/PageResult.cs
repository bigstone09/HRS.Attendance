using System;
using System.Collections.Generic;

namespace HRS.Attendance.Model.Common
{
    /// <summary>服务分页返回模型
    /// </summary>
    public class PageResult<T> : ResultInfo
    {
        /// <summary>每页显示记录数
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>总记录数
        /// </summary>
        public int Total { get; set; }

        /// <summary>总页数
        /// </summary>
        public int TotalPage { get; set; }

        public List<T> Data { get; set; }

        private PageResult() { }

        /// <summary>失败
        /// </summary>
        /// <param name="msg">定义失败信息</param>
        /// <returns></returns>
        public new static PageResult<T> Fail(string msg)
        {
            return new PageResult<T>
            {
                IsSuccess = false,
                Msg = msg
            };
        }

        /// <summary>成功 
        /// </summary>
        /// <param name="data">要返回的数据泛型</param>
        /// <param name="msg">可定义成功信息</param>
        /// <param name="pageSize"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static PageResult<T> Success(List<T> data, string msg, int pageSize, int total)
        {
            if (total == 0)
                return new PageResult<T>
               {
                   IsSuccess = true,
                   Msg = msg,
                   Data = data,
                   PageSize = pageSize,
                   Total = total,
                   TotalPage = 1
               };

            return new PageResult<T>
            {
                IsSuccess = true,
                Msg = msg,
                Data = data,
                PageSize = pageSize,
                Total = total,
                TotalPage = Convert.ToInt32(Math.Floor(total / (decimal)pageSize)) + (total % pageSize > 0 ? 1 : 0)
            };
        }

        /// <summary>成功 
        /// </summary>
        /// <param name="data">要返回的数据泛型</param>
        /// <param name="pageSize"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static PageResult<T> Success(List<T> data, int pageSize, int total)
        {
            return Success(data, string.Empty, pageSize, total);
        }

        /// <summary>成功 
        /// </summary>
        /// <param name="data">要返回的数据泛型</param>
        /// <param name="pageSize"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static PageResult<T> Success(List<T> data, long pageSize, long total)
        {
            return Success(data, string.Empty, Convert.ToInt32(pageSize), Convert.ToInt32(total));
        }

        /// <summary>
        /// 成功
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static PageResult<T> Success(List<T> data)
        {
            return Success(data, string.Empty, data.Count, data.Count);
        }
    }
}
