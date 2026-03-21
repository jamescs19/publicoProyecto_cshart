using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_cshart.Models
{
#nullable disable

    public class Teacher : Person
    {
        private string teacherCode;
        private string department;
        private int experienceYears;

        public static List<string> allDepartments = new List<string>
        {
            "Amazonas", "Antioquia", "Arauca", "Atlántico",
            "Bogotá", "Bolívar", "Boyacá",
            "Caldas", "Caquetá", "Casanare", "Cauca", "Cesar",
            "Chocó", "Córdoba", "Cundinamarca",
            "Guainía", "Guaviare", "Huila", "La Guajira", "Magdalena", "Meta",
            "Nariño", "Norte de Santander", "Putumayo",
            "Quindío", "Risaralda", "San Andrés y Providencia", "Santander", "Sucre", "Tolima",
            "Valle del Cauca", "Vaupés", "Vichada"
        };
        public string TeacherCode
        {
            get => teacherCode; set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4 || value.Length > 10)
                {
                    throw new ArgumentException("Error: El codigo debe tener minimo 4 y maximo 10 caracteres");
                }
                else
                {
                    teacherCode = value;
                }
            }
        }

        public string Department
        {
            get => department; set
            {
                value = value.Trim();
                if (string.IsNullOrWhiteSpace(value) ||
                !allDepartments.Contains(value, StringComparer.OrdinalIgnoreCase))
                {
                    throw new ArgumentException("Error: El departamento no existe");
                }
                else
                {
                    department = value;
                }
            }
        }

        public int ExperienceYears
        {
            get => experienceYears; set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: Sus anios de experiencia no pueden ser menor a 0");
                }
                else
                {
                    experienceYears = value;
                }
            }
        }

        public Teacher(string id, string name, string email, string teacherCode,
                         string department, int experienceYears)
                         : base(id, name, email)
        {
            TeacherCode = teacherCode;
            Department = department;
            ExperienceYears = experienceYears;
        }

        public static void showDepartments()
        {
            System.Console.WriteLine("Departametos");
            foreach (var d in allDepartments)
            {
                System.Console.WriteLine($"- {d}");
            }
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                    $"\nCode: {TeacherCode}\n" +
                    $"Departamento: {Department}\n" +
                    $"Anios de experiencia: {ExperienceYears}";
        }

        public override string ToString()
        {
            return $"{Name} - {Department}";
        }
    }
}
