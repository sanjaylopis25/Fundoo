﻿using CommonLayer.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IUserBL
    {
        void RegisterUser(UserPostModel userPostModel);
    }
}
