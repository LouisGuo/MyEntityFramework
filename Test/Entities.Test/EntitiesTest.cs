using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Entities.Test
{
    [TestClass]
    public class EntitiesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var ssaDbContext = new SSADbContext())
            {
                var ss = from s in ssaDbContext.Students select s;
                var ssCount = ss.Count();
                var student = new Student
                {
                    Id = Guid.Empty,
                    Name = "asdd by controller",
                    Grade = Grade.MiddleSchool,
                    Scores = new List<Score>
                    {
                        new Score { Id=Guid.NewGuid(),ScoreEnglish = 99 },
                        new Score { Id=Guid.NewGuid() }
                    },
                    StudentSchools = new List<StudentSchool>
                    {
                        new StudentSchool
                        {
                            School=new School
                        {
                                Id=Guid.NewGuid(),
                            Name="ECNU",
                            Address="SH"
                        }
                        },
                        new StudentSchool
                        {
                            School=new School
                        {
                                Id=Guid.NewGuid(),
                            Name="JD",
                            Address="AnHui"
                        }
                        }
                    }
                };


                ssaDbContext.Students.Add(student);
                ssaDbContext.SaveChanges();
            }
        }

        [TestMethod]
        public void GetTest()
        {
            var ss = default(Student);
            var score = default(Score);
            using (var ssaDbContext = new SSADbContext())
            {
                score = ssaDbContext.Scores.Find(1);
                var students = ssaDbContext.Students;
                var school = ssaDbContext.Schools;
                foreach (var s in students)
                {
                    ss = s;
                }
            }
            var sid = ss.Id;
        }
    }
}
