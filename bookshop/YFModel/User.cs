using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YF.Model
{
    #region 用户实体对象
    public class User
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private int sex;

        public int Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string qq;

        public string Qq
        {
            get { return qq; }
            set { qq = value; }
        }

        private DateTime adddate;

        public DateTime Adddate
        {
            get { return adddate; }
            set { adddate = value; }
        }
       
        private string role;

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
    #endregion
}