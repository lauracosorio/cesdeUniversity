using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CesdeUniversity.Models;

namespace CesdeUniversity.DAL
{
    public class InicializadorUniversidad : System.Data.Entity.DropCreateDatabaseIfModelChanges<ContextoUniversidad>
    {
        protected override void Seed(ContextoUniversidad context)
        {
            var students = new List<Estudiante>
            {
            new Estudiante{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Estudiante{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Estudiante{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Estudiante{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Estudiante{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Estudiante{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Estudiante{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Estudiante{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Estudiantes.Add(s));
            context.SaveChanges();
            var courses = new List<Curso>
            {
            new Curso{CursoID=1050,Title="Chemistry",Credits=3,},
            new Curso{CursoID=4022,Title="Microeconomics",Credits=3,},
            new Curso{CursoID=4041,Title="Macroeconomics",Credits=3,},
            new Curso{CursoID=1045,Title="Calculus",Credits=4,},
            new Curso{CursoID=3141,Title="Trigonometry",Credits=4,},
            new Curso{CursoID=2021,Title="Composition",Credits=3,},
            new Curso{CursoID=2042,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{EstudianteID=1,CursoID=1050,Grade=Grade.A},
            new Enrollment{EstudianteID=1,CursoID=4022,Grade=Grade.C},
            new Enrollment{EstudianteID=1,CursoID=4041,Grade=Grade.B},
            new Enrollment{EstudianteID=2,CursoID=1045,Grade=Grade.B},
            new Enrollment{EstudianteID=2,CursoID=3141,Grade=Grade.F},
            new Enrollment{EstudianteID=2,CursoID=2021,Grade=Grade.F},
            new Enrollment{EstudianteID=3,CursoID=1050},
            new Enrollment{EstudianteID=4,CursoID=1050,},
            new Enrollment{EstudianteID=4,CursoID=4022,Grade=Grade.F},
            new Enrollment{EstudianteID=5,CursoID=4041,Grade=Grade.C},
            new Enrollment{EstudianteID=6,CursoID=1045},
            new Enrollment{EstudianteID=7,CursoID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}