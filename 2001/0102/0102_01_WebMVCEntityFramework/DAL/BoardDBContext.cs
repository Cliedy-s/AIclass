using _0102_01_WebMVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _0102_01_WebMVCEntityFramework.DAL
{
    public class BoardDBContext : DbContext
    {
        public BoardDBContext() : base("MyDB")
        {

        }
        public DbSet<Board> Boards { get; set; }
    }
}