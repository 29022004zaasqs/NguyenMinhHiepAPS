using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NmhLesson08.Models
{
    public class NmhBookStore : DbContext
    {
        public NmhBookStore():base("NmhBookStoreConnectionString")
        {
        
        }

        //Tạo các tên bảng
        public DbSet<NmhCategory> NmhCategories { get; set; }
        public DbSet<NmhBook> NmhBooks { get; set; }

    }
}