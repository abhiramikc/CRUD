using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace studentdatabase2.Model
{
    public class Student
    {
        internal string name;

        [Key]
            public int? Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }


    }
}
