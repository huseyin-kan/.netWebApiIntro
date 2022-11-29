using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string ProductsListed = "Products listed";
        public static string AuthorizationDenied= "You havent a  authority";
        public static string UserNotFound="User not found";
        public static string PasswordError="Password is incorrect";
        public static string SuccessfulLogin="Logined successfully";
        public static string UserAlreadyExists="This user is already exist";
        public static string AccessTokenCreated="Access Token Created";
        public static string UserRegistered="User registered";
        public static string SoManyCategory="Categories are full right now";
        public static string CategoryIsFull="This category cant take any data";
        public static string NameAlreadyExist="This product name already exist";
    }
}
