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
        public void TestMethod()
        {
            var studentId = Guid.NewGuid();
            var scoreId = Guid.NewGuid();
            var student = new Student
            {
                Id = studentId,
                Name = "asdd by controller",
                Grade = Grade.MiddleSchool,
                Scores = new List<Score>
                    {
                        new Score { Id=scoreId,ScoreEnglish = 99,StudentId=studentId },
                        new Score { Id=Guid.NewGuid(),StudentId=studentId }
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
            var score = default(IEnumerable<Score>);
            var stu = default(IEnumerable<Student>);

            using (var ssaDbContext = new SSADbContext())
            {
                var ss = ssaDbContext.Scores.Find(new Guid("e3757350-471f-4203-9dbb-8b673a514ae5"));
                ssaDbContext.Students.Add(student);
                ssaDbContext.Scores.AddRange(student.Scores);
                ssaDbContext.SaveChanges();

                score = ssaDbContext.Scores.Where(s => s.Id == scoreId).ToList();
                stu = ssaDbContext.Students.Where(s => s.Id == studentId).ToList();
            }

            using (var ssaDbContext = new SSADbContext())
            {
                score = ssaDbContext.Scores.Where(s => s.Id == scoreId).ToList();
                stu = ssaDbContext.Students.Where(s => s.Id == studentId).ToList();
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
