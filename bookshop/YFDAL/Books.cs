using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YF.MsSqlHelper; // 数据库操作类
using System.Data; // datatable所在的命名空间

namespace YF.DAL // 数据库访问层
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
            bool res = false;
            // 向数据库添加，其中id是自增的，不需要写
            string strsql = "insert into t_book(isbn,price,num,img,detail,state,adddate,bookname) values('" + books.Isbn + "'," + books.Price + "," + books.Num + ",'" + books.Img + "','" + books.Detail + "'," + books.State + ",'" + books.Adddate + "', '" + books.Bookname + "')";
            int i = 0;
            i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql); // 如果sql语句执行成功的话，会返回影响行数，因为是插入一行，所以会返回1
            if (i > 0)
            {
                res = true;
            }
            return res;
        }
        /// <summary>
        /// 查询全部Book的信息
        /// </summary>
        /// <returns></returns>
        public static List<YF.Model.Books> list() //泛型
        {
            string strsql = "select * from t_book";//查询所有图书的数据
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];//获得第一张表的数据
            return Dotolist(dt);//转换成list
        }
        /// <summary>
        /// 此方法把datatable转化成List<YF.Model.Books>范型
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<YF.Model.Books> Dotolist(DataTable dt)
        {
            List<YF.Model.Books> list = new List<Model.Books>();//空的泛型对象
            for (int i = 0; i < dt.Rows.Count; i++) // 做个循环把传入的dt表对象转化为Books对象
            {
                YF.Model.Books books = new Model.Books();//空对象

                books.Id = int.Parse(dt.Rows[i]["id"].ToString());
                books.Isbn = dt.Rows[i]["isbn"].ToString();
                books.Price = float.Parse(dt.Rows[i]["price"].ToString());
                books.Num = int.Parse(dt.Rows[i]["num"].ToString());
                books.Img = dt.Rows[i]["img"].ToString();
                books.Detail = dt.Rows[i]["detail"].ToString();
                books.State = int.Parse(dt.Rows[i]["state"].ToString());
                books.Adddate = DateTime.Parse(dt.Rows[i]["adddate"].ToString());
                books.Bookname = dt.Rows[i]["bookname"].ToString();

                list.Add(books); //把Book对象加入list中

            }
            return list;
        }
        /// <summary>
        /// 具体返回某一个商品的信息，通过id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static YF.Model.Books GetBooks(int id)
        {
            string strsql = "select * from t_book where id=" + id + ""; //查询数据
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            List<YF.Model.Books> list = Dotolist(dt);
            return list[0];
        }
        /// <summary>
        /// 用户下单后，更新库存
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static void update(int id) 
        {
            string strsql = " update t_book set num=num-1 where id= " + id + " "; // 更新数据
            YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql); 
        }
    }
}
