﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace MoviProject.Models
{
    public class MoviesCustomer : DbContext
    {

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}