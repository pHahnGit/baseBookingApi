﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class UserModel
    {
        public Guid id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    

    }
}
