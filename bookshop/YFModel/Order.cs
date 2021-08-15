using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YF.Model
{
    #region 订单实体
    public class Order
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private YF.Model.User user;

        public YF.Model.User User
        {
            get { return user; }
            set { user = value; }
        }

        private float amount;

        public float Amount
        {
            get { return amount; }
            set { amount = value; }
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
    }
    #endregion
}
