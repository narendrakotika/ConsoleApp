﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SignIn
    {
        public string Authenticate(string userName, string password)
        {
            string msg;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                msg = "user name and password required";
            }
            else
            {
                if ((userName == "admin") && (password == "admin@123"))
                {
                    msg = "Authentication Pass";
                }
                else
                {
                    msg = "Authentication Fail";
                }
            }
            return msg;
        }
    }

}

