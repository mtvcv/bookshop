using System;
using System.Web;

namespace YF
{
    #region Session操作助手类-SessionHelper

    /// <summary>
    /// Session操作助手类
    /// </summary>
    public class SessionHelper
    {
        static SessionHelper() { HttpContext.Current.Session.Timeout = 30; }

        /// <summary>
        /// 设置一个Session
        /// </summary>
        /// <param name="key">Session的Key值</param>
        /// <param name="value">Session的Value值</param>
        public static void SetSession(string key, object value)
        {
            HttpContext.Current.Session.Remove(key);
            HttpContext.Current.Session.Add(key, value);
        }

        /// <summary>
        /// 移除Session
        /// </summary>
        /// <param name="key">Session的Key值</param>
        public static void RemoveSession(string key)
        {
            HttpContext.Current.Session.Remove(key);
        }

        /// <summary>
        /// 移除所有Session
        /// </summary>
        public static void RemoveAllSession()
        {
            HttpContext.Current.Session.RemoveAll();
        }

        /// <summary>
        /// 获取Session值
        /// </summary>
        /// <param name="key">Session的Key值</param>
        /// <returns>Session的Value值</returns>
        public static object GetSesstion(string key)
        {
            return HttpContext.Current.Session[key];
        }

        /// <summary>
        /// 获取Session（泛型）
        /// </summary>
        /// <typeparam name="T">希望获得的类型</typeparam>
        /// <param name="key">Session的Key值</param>
        /// <returns>Session的Value值</returns>
        public static T GetSesstion<T>(string key)
        {
            return ((T)(HttpContext.Current.Session[key]));
        }

        /// <summary>
        /// 设置Session超时时间
        /// </summary>
        /// <param name="timeout">超时时间（单位：分）</param>
        public static void SetTimeout(int timeout)
        {
            HttpContext.Current.Session.Timeout = timeout;
        }


        /// <summary>
        /// 获取session超时时间
        /// </summary>
        /// <returns></returns>
        public static int GetTimeout()
        {
            return HttpContext.Current.Session.Timeout;
        }
    }

    #endregion
}