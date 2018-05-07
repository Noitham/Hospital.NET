﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class User
    {
        //Properties
        #region Properties
        private int id_user;
        private String nickname;
        private String password;
        private String rol;

        #endregion
        //Constructors
        #region Constructors

        public User(String nickname, String password)
        {
            this.nickname = nickname;
            this.password = password;
        }

        #endregion
        //Accessors
        #region Accessors
        public int Id_user
        {
            get { return id_user; }
            set { id_user = value; }
        }
        public String Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public String Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        #endregion
    }
}
