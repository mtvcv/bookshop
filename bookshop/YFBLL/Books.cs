using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YF.Model;
using YF.DAL; // 数据库操作类

namespace YF.BLL // 业务层
{
    public class Books
    {
        /// <summary>
        /// 添加Book数据，传入刚刚的Book实体
        /// </summary>
        /// <param name="books"></param>
        /// <returns>返回成功传入的数量</returns>
        public static bool add(YF.Model.Books books)
        {
            return YF.DAL.Books.add(books);
        }
        /// <summary>
        /// 查询所有Book的数据
        /// </summary>
        /// <returns></returns>
        public static List<YF.Model.Books> list()
        {
            return YF.DAL.Books.list();
        }
        /// <summary>
        /// 通过图书的id查询一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static YF.Model.Books GetBooks(int id)
        {
            return YF.DAL.Books.GetBooks(id);
        }

        public static void update(int id)
        {
            YF.DAL.Books.update(id);
        }
    }
}
