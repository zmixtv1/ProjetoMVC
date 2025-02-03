﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }
        Departments teste = new Departments() { Id = 1, Name = "teste"};

        public DbSet<SalesWebMvc.Models.Departments> Departments { get; set; } = default!;
    }
}
