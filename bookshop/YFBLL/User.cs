using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YF.BLL
{
    /// <summary>
    /// 此YDBLL为业务层，需调用数据库（用户）访问层YFDAL
    /// </summary>
    public class User
    {
        /// <summary>
        /// (添加用户)类
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool add (YF.Model.User user) 
        {
            return YF.DAL.User.add(user);
        }
        /// <summary>
        /// make sure username is unique确保用户名是唯一的
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool usernameSearch(string username)
        {
            return YF.DAL.User.usernameSearch(username);
        }
        /// <summary>
        /// find username\password\role登陆的时候确保登录的用户名、密码、角色正确
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public static bool loginSearch(string username, string password, string role)
        {
            return YF.DAL.User.loginSearch(username, password, role);
        }
        /// <summary>
        /// list all users' data from t_user从t_user表中列出所有的用户数据
        /// </summary>
        /// <returns></returns>
        public static List<YF.Model.User> List()
        {
            return YF.DAL.User.List();
        }
        /// <summary>
        /// delete user's data删除用户的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回bool表示是否成功</returns>
        public static bool delData(int id)
        {
            return YF.DAL.User.delData(id);
        }
        /// <summary>
        /// update users' data
        /// </summary>
        /// <param name="user"></param>
        /// <returns>返回bool表示是否成功</returns>
        public static bool updateData(YF.Model.User user)
        {
            return YF.DAL.User.updateData(user);
        }
        /// <summary>
        /// manage all users' data 通过id 查询用户数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回一个实体对象user</returns>
        public static YF.Model.User Getuser(int id)
        {
            return YF.DAL.User.Getuser(id);
        }
        /// <summary>
        /// 通过username 查询 
        /// </summary>
        /// <param name="username"></param>
        /// <returns>返回一个实体对象user</returns>
        public static YF.Model.User GetUserbyname(string username)
        {
            return YF.DAL.User.GetUserbyname(username);
        }
    }
}
