using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using YF;

namespace YF.DAL
{
    public class Order
    {
        /// <summary>
        /// 把订单对象，调用数据库访问层，插入数据
        /// </summary>
        /// <param name="order">订单实体</param>
        /// <returns></returns>
        public static bool add(YF.Model.Order order)//添加订单数据
        {
            bool result = false;
            //插入
            string strsql = "insert into t_order (id,userid,amount,state,adddate) values(" + order.Id + "," + order.User.Id + "," + order.Amount + "," + order.State + ",'" + order.Adddate + "')";
            //执行
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// 更改订单状态
        /// </summary>
        /// <param name="orderid">订单编号</param>
        /// <param name="state">状态值</param>
        /// <returns></returns>
        public static bool update(string orderid, int userid, int state)
        {
            bool result = false;
            string strsql = "update t_cart set orderid='" + orderid + "', state=1 where userid = " + userid + " and state="+state+" ";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result = true;
            }
            return result;

        }
        /// <summary>
        /// 查询 过用户查询的id其订单信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static List<YF.Model.Order> list(int userid)
        {
            string strsql = "select * from t_order where userid=" + userid + "  order by adddate desc";//查询数据
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];//获得一张表
            return Dotolist(dt);//转换成list

        }
        public static List<YF.Model.Order> Dotolist(DataTable dt)
        {
            List<YF.Model.Order> list = new List<Model.Order>();//空的泛型对象  转换
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                YF.Model.Order order = new Model.Order();//空对象

                order.Id = dt.Rows[i]["id"].ToString();

                //当前用户
                YF.Model.User user = YF.DAL.User.Getuser(int.Parse(dt.Rows[i]["userid"].ToString()));//通过id 得到用户实列对象
                order.User = user;//商品赋值=上面的user
                order.Amount = float.Parse(dt.Rows[i]["amount"].ToString());
                order.State = int.Parse(dt.Rows[i]["state"].ToString());
                order.Adddate = DateTime.Parse(dt.Rows[i]["adddate"].ToString());
                list.Add(order); //空的泛型对象+数据
            }
            return list;
        } 
    }
}
