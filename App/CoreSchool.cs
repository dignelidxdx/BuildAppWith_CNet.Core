using System;
using System.Collections.Generic;
using System.Linq;
using NETCORE.Entidades;


namespace CoreSchool
{
    public class SchoolEngine
    {
        private School School { get; set; }

        public SchoolEngine()
        {
      
        }
        

        public void Initing()
        {
            School = new School("DigAcademy", 2012, SchoolType.Primary,
            city: "Punto Fijo", country: "Venezuela"
            );

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in School.Courses)
            {
                var listaAsignaturas = new List<Asignature>(){
                            new Asignature{Name="Matemáticas"} ,
                            new Asignature{Name="Educación Física"},
                            new Asignature{Name="Castellano"},
                            new Asignature{Name="Ciencias Naturales"}
                };
                curso.Asignatures = listaAsignaturas;
            }
        }

        private List<Student> GenerarAlumnosAlAzar( int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Student{ Name=$"{n1} {n2} {a1}" };
            
            return listaAlumnos.OrderBy( (al)=> al.UniqueId ).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            School.Courses = new List<Course>(){
                        new Course(){ Name = "101", WorkingType = WorkingType.Morning },
                        new Course() {Name = "201", WorkingType = WorkingType.Morning},
                        new Course{Name = "301", WorkingType = WorkingType.Morning},
                        new Course(){ Name = "401", WorkingType = WorkingType.Afternoon },
                        new Course() {Name = "501", WorkingType = WorkingType.Afternoon},
            };
            
            Random rnd = new Random();
            foreach(var c in School.Courses)
            {
                int cantRandom = rnd.Next(5, 20);
                c.Students = GenerarAlumnosAlAzar(cantRandom);
            }
        }
    }
}