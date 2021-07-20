using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YF.DAL;

namespace YF.BLL // 业务层
{
    public class Order
    {
        /// <summary>
        /// 把订单对象，调用数据库访问层，插入数据
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static bool add(YF.Model.Order order)
        {
            return YF.DAL.Order.add(order);
        }
        /// <summary>
        /// 更改订单状态
        /// </summary>
        /// <param name="orderid">订单编号</param>
        /// <param name="state">状态值</param>
        /// <returns></returns>
        public static bool update(string orderid, int userid, int state)
        {
            return YF.DAL.Order.update(orderid, userid, state);
        }
        /// <summary>
        /// 查询 过用户查询的id其订单信息
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public static List<YF.Model.Order> list(int userid)
        {
            return YF.DAL.Order.list(userid);
        }

    }
}
