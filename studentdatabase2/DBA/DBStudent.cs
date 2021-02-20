using studentdatabase2.Context;
using studentdatabase2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentdatabase2.DBA
{
    public class DBStudent
    {
        StudentContext dbContext = new StudentContext();
        public IEnumerable<Student> GetStudents()
        {
            try
            {
                return dbContext.Student.ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
