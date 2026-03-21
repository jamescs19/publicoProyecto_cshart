using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_cshart.Models
{
#nullable disable
    using System.Data.Common;

    public class Student : Person
    {
        private string studentCode;
        private string career;
        private int semester;

        public static List<string> typeCareers = new List<string>
    {
      "Ingenieria en sistemas",
      "Arquitectura",
      "Derecho",
      "Ingenieria industrial",
      "Contaduria",
      "Ingenieria civil",
      "Comunicacion social",
      "Ingenieria mecanica",
      "Administracion de empresas"
    };

        public string StudentCode
        {
            get => studentCode;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4 || value.Length > 10)
                {
                    throw new ArgumentException("Error: El codigo no puede ser menor a 4 ni mayor a 10");
                }
                else
                {
                    studentCode = value;
                }
            }
        }

        public string Career
        {
            get => career;
            set
            {
                value = value.Trim();
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Error: Esta opcion no puede estar vacia");
                }
                else if (!typeCareers.Contains(value, StringComparer.OrdinalIgnoreCase))
                {
                    throw new ArgumentException("Error: Carrera no valida");
                }
                else
                {
                    career = value;
                }
            }
        }

        public int Semester
        {
            get => semester;
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException("Error: El semestre debe estar entre 1 y 10");
                }
                else
                {
                    semester = value;
                }
            }
        }

        public Student(string id, string name, string email, string studentCode,
                        string career, int semester)
                        : base(id, name, email)
        {
            StudentCode = studentCode;
            Career = career;
            Semester = semester;
        }


        public static void ShowCareers()
        {
            System.Console.WriteLine("Carreras disponibles");

            foreach (var n in typeCareers)
            {
                System.Console.WriteLine($"- {n}");
            }
        }
        public override string GetInfo()
        {
            return base.GetInfo() +
                    $"\nCodigo: {StudentCode}\n" +
                    $"Carrera: {Career}\n" +
                    $"Semestre: {Semester}";
        }

        public override string ToString()
        {
            return $"{Name} - {Career} - Semestre {Semester}";
        }
    }
}
