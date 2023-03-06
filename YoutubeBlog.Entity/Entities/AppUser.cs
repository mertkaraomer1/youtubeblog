﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeBlog.Entity.Entities
{
    public class AppUser:IdentityUser<Guid>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
