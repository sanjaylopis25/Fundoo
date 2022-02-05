using CommonLayer.User;
using RepositoryLayer.Interface;
using RepositoryLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Class
{
    

    public class UserRL : IUserRL
    {
        FundooDBContext dbContext;
        public UserRL(FundooDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void RegisterUser(UserPostModel userPostModel)
        {
            try
            {
                User user = new User();
                user.userId = new User().userId;
                user.fname = userPostModel.fname;
                user.lname = userPostModel.lname;
                user.phno = userPostModel.phno;
                user.address = userPostModel.address;
                user.email = userPostModel.email;
                user.password = userPostModel.password;
                user.cpassword = userPostModel.cpassword;
                user.registeredDate = DateTime.Now;
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
