﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infinite.TaxiBookingSystem.API.Models
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

        //Add the table references
        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeRoster> EmployeeRosters { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Taxi> Taxis { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<TaxiModel> TaxiModels { get; set; }
        public DbSet<TaxiType> TaxiTypes { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

    }
}
