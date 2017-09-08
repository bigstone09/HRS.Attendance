using System;
using System.Collections.Generic;
using System.Linq;
using Framework.Common;

namespace HRS.User.Model.Enum.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class EnumArrtibute : Attribute
    {
        #region -- field

        /// <summary>
        /// Enum项的文字描述信息
        /// </summary>
        /// <param name="name">关键字名称</param>
        public EnumArrtibute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Enum项的文字描述信息
        /// </summary>
        /// <param name="index"></param>
        /// <param name="name">关键字名称</param>
        public EnumArrtibute(int index, string name)
        {
            Index = index;
            Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region -- Utility

        /// <summary>
        /// 得到枚举的所有值/描述对列表
        /// </summary>
        /// <returns></returns>
        public static IDictionary<int, string> GetDict<TEnum>()
        {
            var d = new Dictionary<int, string>();
            var dict = EnumUtility.GetEnumDictWithKeyInt<TEnum, EnumArrtibute>();
            foreach (var t in dict)
            {
                d.Add(t.Key, t.Value.Name);
            }
            return d;
        }

        /// <summary>
        /// 得到枚举的所有值/描述对列表
        /// </summary>
        /// <returns></returns>
        public static IDictionary<int, string> GetDict<TEnum>(params int[] removeIndex)
        {
            var removeKeys = removeIndex.ToList();
            var d = new Dictionary<int, string>();
            var dict = EnumUtility.GetEnumDictWithKeyInt<TEnum, EnumArrtibute>();
            foreach (var t in dict)
            {
                if (!removeKeys.Contains(t.Key))
                {
                    d.Add(t.Key, t.Value.Name);
                }
            }
            return d;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumKey"></param>
        /// <returns></returns>
        public static string GetKeyName<TEnum>(TEnum enumKey)
        {
            var attr = EnumUtility.GetAttribute<TEnum, EnumArrtibute>(enumKey);
            if (attr != null)
            {
                return attr.Name;
            }
            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumKey"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string GetKeyName<TEnum>(TEnum enumKey, string defaultValue)
        {
            var attr = EnumUtility.GetAttribute<TEnum, EnumArrtibute>(enumKey);
            if (attr != null)
            {
                return attr.Name;
            }
            return defaultValue;
        }
        #endregion
    }
}
