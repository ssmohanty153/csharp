using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProgram.Models;

namespace WebApiProgram.Controllers
{
    public class StudentsController : ApiController
    {
         IList<Students> Students = new List<Students>()  
        {  
            new Students()  
                {  
                    StudentId = 1, StudentName = "Subhransu Sekhar Mohanty", Address = "Usa", Course = "dev"  
                },  
                new Students()  
                {  
                    StudentId = 2, StudentName = "Krishna Babu", Address = "Japan", Course = "md"  
                },  
                new Students()  
                {  
                    StudentId = 3, StudentName = "Hari Hara", Address = "India", Course = "Tst"  
                },  
                new Students()  
                {  
                    StudentId = 4, StudentName = "Rama Babu", Address = "Newzland", Course = "Sales Exeutive"  
                },  
                new Students()  
                {  
                    StudentId = 5, StudentName = "Mukesh Abmani", Address = "India", Course = "Busines analyst"  
                },  
        };  
        public IList<Students> GetAllStudents()  
        {  
            
            return Students;  
        }  

        public Students GetStudentDetails(int id)  
        {  
            
            var Student = Students.FirstOrDefault(e => e.StudentId == id);  
            if (Student == null)  
            {  
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));  
            }  
            return Student;  
        }  
    }
}
