using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_cshart.Models
{
#nullable disable

    public class Subject

    {
        private string code;
        public string Code
        {
            get => code; set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4 || value.Length > 10)
                {
                    throw new ArgumentException("Error: El codigo no puede ser menor a 4 ni mayor a 10");
                }
                else
                {
                    code = value;
                }
            }
        }
        private string name;
        public string Name
        {
            get => name; set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Error: El nombre debe tener al menos 1 caracter");
                }
                else
                {
                    name = value;
                }
            }
        }
        private int credits;
        public int Credits
        {
            get => credits; set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentException("Error: La materia debe valer al menos 1 credito");
                }
                else
                {
                    credits = value;
                }
            }
        }
        private Teacher teachers;
        public Teacher Teachers
        {
            get => teachers; set
            {
                if (value == null)
                {
                    throw new ArgumentException("Error: Esta opcion no puede estar vacia");
                }
                else
                {
                    teachers = value;
                }
            }
        }
        private List<Student> students = new List<Student>();
        public List<Student> Students => students;
        public List<string> StudentIds { get; set; } = new List<string>();


        public Subject(string code, string name, Teacher teachers, int credits)
        {
            Code = code;
            Name = name;
            Teachers = teachers;
            Credits = credits;
        }


        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentException("Error: Esta opcion puede estar vacia");
            }
            if (students.Contains(student))
            {
                throw new ArgumentException("Error: Este estudiante ya esta registrado");
            }

            students.Add(student);
            StudentIds.Add(student.Id);
        }


        public string ShowStudents()
        {

            if (students.Count == 0)
            {
                return "No hay estudiantes registrados";
            }
            string result = "";
            foreach (var s in students)
            {
                result += "- " + s.GetInfo() + "\n";
            }
            return result;
        }



        public string GetInfo()
        {

            return $"Codigo: {Code}\n" +
            $"Nombre: {Name}\n" +
            $"Profesor: {Teachers.Name}\n" +
            $"Creditos: {Credits}\n" +
            $"Numero de estudiantes: {students.Count}";
        }

        public override string ToString()
        {
            return $"{Code} - {Name}";
        }
    }
}
