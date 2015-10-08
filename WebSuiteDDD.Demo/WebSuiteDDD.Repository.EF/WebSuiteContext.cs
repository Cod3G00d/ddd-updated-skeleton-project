﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSuiteDDD.Repository.EF.DataModel;

namespace WebSuiteDDD.Repository.EF
{
	public class WebSuiteContext : DbContext
	{
		public WebSuiteContext() : base("WebSuiteContext")
		{}

		public DbSet<Agent> Agents { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Engineer> Engineers { get; set; }
		public DbSet<Loadtest> Loadtests { get; set; }
		public DbSet<LoadtestType> LoadtestTypes { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<Scenario> Scenarios { get; set; }

	}
}
