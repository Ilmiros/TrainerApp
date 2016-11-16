using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrainerApp.Entities;

namespace TrainerApp.HelpDB
{
    public class EFDBContext:DbContext
    {
        private DbSet<User> Users { get; set; }
    }
}