using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YF;

namespace YF.BLL
{
    public class Cart
    { 
        /// <summary>
        /// 添加图书，
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        public static bool addbooks(YF.Model.Cart cart)
        {
            return YF.DAL.Cart.addbooks(cart);
        }
        /// <summary>
        /// 判断图书是否已经买了
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public static List<YF.Model.Cart> list(int bookid, int userid, int state)
        {
            return YF.DAL.Cart.list(bookid, userid, state);
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
            return YF.DAL.Cart.updatenum(bookid, userid, state);
        }
        /// <summary>
        /// 通过id删除图书
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        public static bool delete(int id)
        {
            return YF.DAL.Cart.delete(id);
        }
        /// <summary>
        /// 通过用户id,查询此用户购物车信息
        /// </summary>
        /// <returns></returns>
        public static List<YF.Model.Cart> list(int userid)
        { 
            return YF.DAL.Cart.list(userid);
        }
    }
}
