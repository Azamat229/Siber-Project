﻿using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
        public bool IsActive { get; set; }

        public virtual List<Arrival> Arrivals { get; set; }
    }
}