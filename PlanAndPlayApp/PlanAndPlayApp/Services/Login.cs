﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace PlanAndPlayApp.Services
{
    public class Login : ILogin
    {
        public Task<LoginData[]> GetLoginData()
        {
            throw new NotImplementedException();
        }
    }
}

