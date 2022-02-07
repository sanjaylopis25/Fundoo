using BusinessLayer.Interface;
using CommonLayer.User;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Class
{
    public class UserBL : IUserBL
    {
        IUserRL userRL;
        public UserBL(IUserRL userRL)
        {
            this.userRL = userRL;
        }
        public void RegisterUser(UserPostModel userPostModel)
        {
            try
            {
                userRL.RegisterUser(userPostModel);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public string Login(UserLogin userlogin)
        {
            try
            {
                return userRL.Login(userlogin);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ResetPassword(string email, string password, string cpassword)
        {
            try
            {
                userRL.ResetPassword(email, password, cpassword);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ForgetPassword(string email)
        {
            try
            {
                userRL.Equals(email);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
    }
}
