﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace YF.DAL
{
    /// <summary>
    /// 数据库（用户）访问层YFDAL
    /// </summary>
    public class User
    {
        /// <summary>
        /// (添加用户)类
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool add(YF.Model.User user) 
        {
            bool result = false;

            string strsql = "insert into t_user (username, password, name, address, sex, mobile, email, qq, adddate,role) values('" + user.Username + "', '" + user.Password + "', '" + user.Name + "', '" + user.Address + "', " + user.Sex + ", '" + user.Mobile + "', '" + user.Email + "', '" + user.Qq + "', '" + user.Adddate + "', '" + user.Role + "')";
            // 返回执行成功的数量，执行成功1返回1，成功2条返回2
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql); 
            if (i > 0)
            {
                result = true;
            }

            return result;
        }
        /// <summary>
        /// make sure username is unique确保用户名是唯一的
        /// </summary>
        /// <returns></returns>
        public static bool usernameSearch(string username) 
        {
            bool res = false;
            string strsql = "select * from t_user where username='" + username + "'";
            // 返回内存中的一个表，存储所有的用户信息
            DataTable datatable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            if (datatable.Rows.Count == 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
        /// <summary>
        /// find username\password\role登陆的时候确保登录的用户名、密码、角色正确
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool loginSearch(string username, string password, string role)
        {
            bool res = false;
            string strsql = "select * from t_user where username = '" + username + "' and password = '" + password + "' and role = '" + role + "'";
            DataTable datatable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            if (datatable.Rows.Count != 0)
            {
                res =  true;
            }
            else
            {
                res = false; 
            }
            return res;
        }
        
        /// <summary>
        /// 通过username查询 
        /// </summary>
        /// <param name="username"></param>
        /// <returns>返回一个用户实体对象</returns>
        public static YF.Model.User GetUserbyname(string username)
        {
            YF.Model.User user = new YF.Model.User();
            string strsql = "select * from t_user where username='" + username + "'";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];//一张表
            if (dataTable.Rows.Count != 0)
            {
                user.Id = int.Parse(dataTable.Rows[0]["id"].ToString());
                user.Username = dataTable.Rows[0]["Username"].ToString();
                user.Password = dataTable.Rows[0]["Password"].ToString();
                user.Name = dataTable.Rows[0]["Name"].ToString();
                user.Address = dataTable.Rows[0]["Address"].ToString();
                user.Sex = int.Parse(dataTable.Rows[0]["Sex"].ToString());
                user.Mobile = dataTable.Rows[0]["Mobile"].ToString();
                user.Email = dataTable.Rows[0]["Email"].ToString();
                user.Qq = dataTable.Rows[0]["Qq"].ToString();
                //user.State = int.Parse(dataTable.Rows[0]["State"].ToString()); 已经删除
                user.Adddate = DateTime.Parse(dataTable.Rows[0]["Adddate"].ToString());
                user.Role = dataTable.Rows[0]["Role"].ToString();
            }
            return user;
        }
        /// <summary>
        /// list all users' data from t_user从t_user表中列出所有的用户数据
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public static List<YF.Model.User> List()
        {
            string strsql = "select * from t_user order by id desc";
            // 此时返回的是DataTable类型，所以需要一步转化把DataTable转化为<YF.Model.User>类型
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            return Dottolist(dt);
        }
        /// <summary>
        /// 把DataTable转化为<YF.Model.User>类型
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<YF.Model.User> Dottolist(DataTable dt)
        {
            List<YF.Model.User> list = new List<Model.User>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                YF.Model.User user = new Model.User();
                user = Getuser(int.Parse(dt.Rows[i]["id"].ToString()));
                // 与上面那个List不同
                list.Add(user);
            }
            return list;
        }
        /// <summary>
        /// manage all users' data 通过id 查询用户数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回一个实体对象user</returns>
        public static YF.Model.User Getuser(int id)
        {
            // 实体类把它的数据展示给前台界面
            YF.Model.User user = new Model.User();
            // search all users' data from t_user
            string strsql = "select * from t_user where id = " + id + "";
            DataTable datatable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            if (datatable.Rows.Count != 0)
            {
                user.Id = int.Parse(datatable.Rows[0]["id"].ToString());
                user.Username = datatable.Rows[0]["username"].ToString();
                user.Password = datatable.Rows[0]["password"].ToString();
                user.Name = datatable.Rows[0]["Name"].ToString();
                user.Address = datatable.Rows[0]["Address"].ToString();
                user.Sex = int.Parse(datatable.Rows[0]["Sex"].ToString());
                user.Mobile = datatable.Rows[0]["Mobile"].ToString();
                user.Email = datatable.Rows[0]["Email"].ToString();
                user.Qq = datatable.Rows[0]["Qq"].ToString();
                user.Adddate = DateTime.Parse(datatable.Rows[0]["Adddate"].ToString());
                user.Role = datatable.Rows[0]["Role"].ToString();
            }
            return user;
        }
        /// <summary>
        /// delete user's data删除用户的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回bool表示是否成功</returns>
        public static bool delData(int id)
        {
            bool res = false;
            string strsql = "delete from t_user where id = " + id + "";
            // 执行数据库删除操作，返回值大于零说明删除成功
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
        /// <summary>
        /// update users' data
        /// </summary>
        /// <returns>返回bool表示是否成功</returns>
        public static bool updateData(YF.Model.User user)
        {
            bool res = false;
            string strsql = "update t_user set password ='" + user.Password + "', name = '" + user.Name + "', address = '" + user.Address + "', sex = " + user.Sex + ", mobile='" + user.Mobile + "', email='" + user.Email + "', qq='" + user.Qq + "' , role='" + user.Role + "'where id=" + user.Id + "";

            // 执行数据库更新操作，返回值大于零说明删除成功
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
