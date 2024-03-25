using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerLibrary.UserClasses
{
    public class AnonUser
    {
        [Key]
        public int AnonId { get; set; }
        public string AnonName { get; set; }
    }
}
