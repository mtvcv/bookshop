using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YF.Model
{
    public class Cart
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// 关联图书
        /// </summary>
        private YF.Model.Books books;

        public YF.Model.Books Books
        {
          get { return books; }
          set { books = value; }
        }
        /// <summary>
        /// 关联用户
        /// </summary>
        private YF.Model.User user;

        public YF.Model.User User
        {
            get { return user; }
            set { user = value; }
        }
        /// <summary>
        /// 加购的数量
        /// </summary>
        private int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        
        private int state;

        public int State
        {
            get { return state; }
            set { state = value; }
        }
        /// <summary>
        /// 加入的时间
        /// </summary>
        private DateTime adddate;

        public DateTime Adddate
        {
            get { return adddate; }
            set { adddate = value; }
        }
      
    }
}
