using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using studentdatabase2.Context;
using studentdatabase2.DAL;
using studentdatabase2.DBA;
using studentdatabase2.Model;

namespace studentdatabase2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class StudentController : ControllerBase
    {
        DBStudent dbClassObj = new DBStudent();
        StudentDAL dbobj = new StudentDAL();
        List<Student> allstudents = new List<Student>();
        readonly StudentContext StuDetails;
        //readonly StudentContext StuDetails;
        public List<Student> stList;

        public StudentController()
        {
            //StuDetails = studentContext;
        }
        [HttpGet("GetStudentDetails")]
        public string GetStudentDetails()
        {
            //StuDetails.Student.ToList();
            return JsonConvert.SerializeObject("HI");

        }
        //[HttpGet]
        ////[Route("api/Student/Index")]
        //public IEnumerable<Student> GetStudents()
        //{
        //    return dbClassObj.GetStudents();
        //}
        [HttpGet("GetStudentsfromdb")]
        public List<Student> GetStudentsfromdb()
        {


            //return dbobj.GetStudents();
            var allstudents = dbobj.GetStudents();
            return allstudents;

            //string sJSONResponse = JsonConvert.SerializeObject(allstudents);

            //string std = JsonConvert.SerializeObject(allstudents);
            //return std;
            //allstudents = dbobj.GetStudents();
            //var StudentContext = JsonConvert.SerializeObject(allstudents);
            //return StudentContext;

        }


        [HttpPost("PostStudentstodb")]
        public string PostStudentstodb([FromBody] Student obj)
        {
            //return dbobj.PostStudents(obj);
            return JsonConvert.SerializeObject(dbobj.PostStudents(obj));


            //StuDetails.Student.Add(obj);
            //StuDetails.SaveChanges();
            //return Ok();
        }
        [HttpPost("DeleteDtudentfromdb")]
        public string DeleteDtudentfromdb([FromBody] int id)
        {
            return JsonConvert.SerializeObject( dbobj.DeleteStudents(id));
        }

    }
};