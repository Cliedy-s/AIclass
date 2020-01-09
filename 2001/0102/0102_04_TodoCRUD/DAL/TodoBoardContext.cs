
using _0102_04_TodoCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _0102_04_TodoCRUD.DAL
{
    public class TodoBoardContext:DbContext
    {
        public TodoBoardContext() : base("connstr")
        {

        }
        public DbSet<TodoBoard> TodoBoard { get; set; }
    }
}