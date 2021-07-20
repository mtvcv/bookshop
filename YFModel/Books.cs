using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.Model
{
    public class Books
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string isbn;

        public string Isbn
        {
          get { return isbn; }
          set { isbn = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        private string img;

        public string Img
        {
            get { return img; }
            set { img = value; }
        }
        private string detail;

        public string Detail
        {
            get { return detail; }
            set { detail = value; }
        }
        private int state;

        public int State
        {
            get { return state; }
            set { state = value; }
        }
        private DateTime adddate;

        public DateTime Adddate
        {
            get { return adddate; }
            set { adddate = value; }
        }

        private string bookname;

        public string Bookname
        {
            get { return bookname; }
            set { bookname = value; }
        }
    }
}
