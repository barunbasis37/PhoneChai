using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace PhoneChai.Model
{
    public class BusinessDbContex : DbContext
    {
        public BusinessDbContex(): base("DefaultConnection")
        {
            
        }
        public DbSet<Phone> Phones { get; set; } 
    }
}
