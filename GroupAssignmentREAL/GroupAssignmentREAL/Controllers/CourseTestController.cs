using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupAssignmentREAL.Models;

namespace GroupAssignmentREAL.Controllers
{
    public class CourseTestController : Controller
    {
        [NonAction]
        public List<Course> GetCourseList()
        {
            return new List<Course>
            {      new Course
                {
                    CourseId = "8101",
                    CourseName = "A study of John Smith",
                    Topic = "Party planning",
                    Description = "Very boring and needless",
                    Year = 1,
                    Semester = "2",
                    Prerequisites ="I102",
                    Compulsory = "N",


                },
                new Course
                {
                     CourseId = "8102",
                    CourseName = "A study of Jane Smith",
                    Topic = "Sleep ",
                    Description = "The best thing ever",
                    Year = 2,
                    Semester = "1/2",
                    Prerequisites ="I103",
                    Compulsory = "Y",
                },
            };
        }



        public IActionResult Index()
        {
            var course = from s in GetCourseList() select s;
            return View(course);
        }

        public IActionResult Course()
        {
            var course = from e in GetCourseList()
                           orderby e.CourseId
                           select e;
            return View(course);
        }
    }
}
