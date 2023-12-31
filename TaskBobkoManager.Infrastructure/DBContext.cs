﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBobkoManager.Core;

namespace TaskBobkoManager.Infrastructure
{
    public class DBContext : DbContext
    {
        public DBContext() : base()
        { 
        }
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }

       
    }


}
