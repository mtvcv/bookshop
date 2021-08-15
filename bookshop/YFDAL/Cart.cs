using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using YF;
namespace YF.DAL
{
    public class Cart
    {
        /// <summary>
        /// 添加图书
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        public static bool addbooks(YF.Model.Cart cart)
        {
            bool res = false;
            string strsql = "insert into t_cart(bookid,userid,num,state,adddate) values(" + cart.Books.Id + "," + cart.User.Id + "," + cart.Num + "," + cart.State + ",'" + cart.Adddate + "')";
            int i = 0;
            i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                res = true;
            }
            return res;
        }
        /// <summary>
        /// 判断图书是否是第一次购买
        /// </summary>
        /// <param name="bookid"></param>
        /// <param name="userid"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static List<YF.Model.Cart> list(int bookid, int userid, int state)
        {
            string strsql = "select * from t_cart where bookid=" + bookid + " and userid=" + userid + " and state="+state+" ";//查询数据 查询当前用户，并且没有下单.state=0
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];//获得一张表
            return Dotolist(dt);//转换成list
        }
        /// <summary>
        /// 只是增加数量
        /// </summary>
        /// <param name="goodsid"></param>
        /// <param name="user"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static bool updatenum(int bookid, int userid, int state)
        {
            bool result = false;
            string strsql = "update t_cart set num=num+1 where bookid=" + bookid + " and userid=" + userid + " and state= " + state + "";//每点击购物一次，同样商品+1
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result = true;
            }
            return result;

        }
        /// <summary>
        /// 通过id删除图书
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool delete(int id)
        {
            bool result = false;
            string strsql = "delete from t_cart where id= " + id + "";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// 通过用户id,查询此用户购物车信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static List<YF.Model.Cart> list(int userid) //泛型   
        {
            string strsql = "select * from t_cart where userid=" + userid + " and state=" + 0 +" ";//查询数据//查询当前用户，并且没有下单.state=0
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];//获得一张表
            return Dotolist(dt);//转换成list
        }
        public static List<YF.Model.Cart> Dotolist(DataTable dt)
        {
            List<YF.Model.Cart> list = new List<Model.Cart>();//空的泛型对象  转换

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                YF.Model.Cart cart = new Model.Cart(); // 购物车空对象
                cart.Id = int.Parse(dt.Rows[i]["id"].ToString());

                //当前商品
                YF.Model.Books books = YF.DAL.Books.GetBooks(int.Parse(dt.Rows[i]["bookid"].ToString()));//通过id 得到商品实列对象
                //当前用户
                YF.Model.User user = YF.DAL.User.Getuser(int.Parse(dt.Rows[i]["userid"].ToString()));//通过id 得到用户实列对象

                cart.Books = books;//商品赋值=上面的books
                cart.User = user;//商品赋值=上面的user              
                cart.Num = int.Parse(dt.Rows[i]["num"].ToString());
                cart.State = int.Parse(dt.Rows[i]["state"].ToString());
                cart.Adddate = DateTime.Parse(dt.Rows[i]["adddate"].ToString());

                list.Add(cart); //空的泛型对象+数据
            }
            return list;
        }

    }
}
