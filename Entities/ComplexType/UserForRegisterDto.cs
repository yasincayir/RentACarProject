﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ComplexType
{
    public class UserForRegisterDto : IComplexType
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
