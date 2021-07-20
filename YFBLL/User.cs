using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YF.BLL
{
    /// <summary>
    /// 此为前台访问业务层，需调用数据库（用户）访问层
    /// </summary>
    public class User
    {
        public static bool add (YF.Model.User user) 
        {
            return YF.DAL.User.add(user);
        }

        public static bool usernameSearch(string username)
        {
            return YF.DAL.User.usernameSearch(username);
        }

        public static bool loginSearch(string username, string password, string role)
        {
            return YF.DAL.User.loginSearch(username, password, role);
        }
        /// <summary>
        /// list all users' data from t_user
        /// </sum   mary>
        /// <returns></returns>
        public static List<YF.Model.User> List()
        {
            return YF.DAL.User.List();
        }
        /// <summary>
        /// delete user's data
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool delData(int id)
        {
            return YF.DAL.User.delData(id);
        }
        /// <summary>
        /// update users' data
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool updateData(YF.Model.User user)
        {
            return YF.DAL.User.updateData(user);
        }
        /// <summary>
        /// manage all users' data
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static YF.Model.User Getuser(int id)
        {
            return YF.DAL.User.Getuser(id);
        }
        /// <summary>
        /// 通过username 查询 返回一个实体对象user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static YF.Model.User GetUserbyname(string username)
        {
            return YF.DAL.User.GetUserbyname(username);
        }
    }
}
