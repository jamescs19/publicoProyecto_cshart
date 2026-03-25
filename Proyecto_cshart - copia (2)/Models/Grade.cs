using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Proyecto_cshart.Models
{
    public class Grade
    {
        public Student Student { get; set; }
        public Subject Subject { get; set; }

        private double grade1;
        private double grade2;
        private double grade3;

        public double Grade1
        {
            get => grade1;
            set
            {
                if (value < 0 || value > 5)
                    throw new ArgumentException("La nota debe estar entre 0 y 5");
                grade1 = value;
            }
        }

        public double Grade2
        {
            get => grade2;
            set
            {
                if (value < 0 || value > 5)
                    throw new ArgumentException("La nota debe estar entre 0 y 5");
                grade2 = value;
            }
        }

        public double Grade3
        {
            get => grade3;
            set
            {
                if (value < 0 || value > 5)
                    throw new ArgumentException("La nota debe estar entre 0 y 5");
                grade3 = value;
            }
        }

        public double FinalAverage => (Grade1 + Grade2 + Grade3) / 3;

        public string Status => FinalAverage >= 3 ? "Aprobado" : "Desaprobado";

        public Grade(Student student, Subject subject, double g1, double g2, double g3)
        {
            Student = student ?? throw new ArgumentException("Se requiere un estudiante");
            Subject = subject ?? throw new ArgumentException("Se requiere un estudiante");

            Grade1 = g1;
            Grade2 = g2;
            Grade3 = g3;
        }

        public override string ToString()
        {
            return $"{Student.Name} - {Subject.Name} | Promedio: {FinalAverage:F2} | {Status}";
        }
    }
}
    





