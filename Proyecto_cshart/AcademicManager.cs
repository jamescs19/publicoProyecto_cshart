using Proyecto_cshart.Models;

using System.Text.Json;

namespace Proyecto_cshart
{
    public class AcademicManager
    {

        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();
        private List<Subject> subjects = new List<Subject>();
        private List<Grade> grades = new List<Grade>();
        public IReadOnlyList<Student> Students => students;
        public IReadOnlyList<Teacher> Teachers => teachers;
        public IReadOnlyList<Subject> Subjects => subjects;
        public IReadOnlyList<Grade> Grades => grades;

        public void AddTeacher(Teacher teacher)
        {
            if (teacher == null)
                throw new ArgumentException("Error: profesor vacío");

            if (string.IsNullOrWhiteSpace(teacher.Id) || string.IsNullOrWhiteSpace(teacher.Email))
                throw new ArgumentException("Error: datos incompletos");

            // validar id repetido
            if (teachers.Any(t => t.Id == teacher.Id))
                throw new ArgumentException("Ya existe un profesor con ese ID");

            // Validar email repetido
            string email = teacher.Email.ToLower();

            if (teachers.Any(t => t.Email.ToLower() == email) ||
                students.Any(s => s.Email.ToLower() == email))
            {
                throw new ArgumentException("El correo ya está en uso");
            }

            teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            if (student == null)
                throw new ArgumentException("Error: estudiante vacío");

            if (string.IsNullOrWhiteSpace(student.Id) || string.IsNullOrWhiteSpace(student.Email))
                throw new ArgumentException("Error: datos incompletos");

            //  Validar id repetdo
            if (students.Any(s => s.Id == student.Id))
                throw new ArgumentException("Ya existe un estudiante con ese ID");

            // Validar email
            string email = student.Email.ToLower();

            if (students.Any(s => s.Email.ToLower() == email) ||
                teachers.Any(t => t.Email.ToLower() == email))
            {
                throw new ArgumentException("El correo ya está en uso");
            }

            students.Add(student);
        }

        public void AddSubject(Subject subject)
        {
            if (subject == null)
            {
                throw new ArgumentException("Error: esta opcion no puede estar vacia");
            }

            if (subjects.Contains(subject))
            {
                throw new ArgumentException("Esta materia ya esta registrada");
            }

            subjects.Add(subject);
        }

        public void AddGrade(Grade grade)
        {
            if (grade == null)
                throw new ArgumentException("Nota invalida");

            if (grades.Any(g =>
                g.Student.Id == grade.Student.Id &&
                g.Subject.Code == grade.Subject.Code))
            {
                throw new ArgumentException("Este estudiante ya tiene notas en esta materia");
            }

            grades.Add(grade);
        }

        public void EnrollStudentInSubject(Student student, Subject subject)
        {
            if (student == null)
            {
                throw new ArgumentException("Error: Esta opcion esta vacia");
            }

            if (subject == null)
            {
                throw new ArgumentException("Error: esta opcion no puede estar vacia");
            }

            if (!students.Contains(student))
            {
                throw new ArgumentException("Error: Este estudiante No esta registrado");
            }

            if (!subjects.Contains(subject))
            {
                throw new ArgumentException("Esta materia No esta registrada");
            }

            subject.AddStudent(student);
        }


        public Student FindStudent(string Id)
        {
            var lookStudent = students.FirstOrDefault(s => s.Id == Id);

            if (lookStudent == null)
            {
                throw new ArgumentException("No se encontro ningun estudiante con ese codigo");
            }
            return lookStudent;
        }
        public Subject FindSubject(string code)
        {
            var lookSubject = subjects.FirstOrDefault(s => s.Code == code);

            if (lookSubject == null)
            {
                throw new ArgumentException("No se encontro ninguna materia con ese codigo");
            }
            return lookSubject;
        }


        public IReadOnlyList<Student> GetStudentsInSubject(string code)
        {
            var validate = FindSubject(code);

            return validate.Students;
        }

        public IReadOnlyList<Subject> GetSubjectsInStudents(string id)
        {
            var student = FindStudent(id);
            var result = subjects
                .Where(s => s.Students.Contains(student)).ToList();
            return result;
        }

        public void SaveData()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            File.WriteAllText("students.json", JsonSerializer.Serialize(students, options));
            File.WriteAllText("teachers.json", JsonSerializer.Serialize(teachers, options));
            File.WriteAllText("subjects.json", JsonSerializer.Serialize(subjects, options));


        }

        public void LoadData()
        {
            // Estudiantes
            if (File.Exists("students.json"))
            {
                students = JsonSerializer.Deserialize<List<Student>>(
                    File.ReadAllText("students.json")
                ) ?? new List<Student>();
            }

            // Docentes
            if (File.Exists("teachers.json"))
            {
                teachers = JsonSerializer.Deserialize<List<Teacher>>(
                    File.ReadAllText("teachers.json")
                ) ?? new List<Teacher>();
            }

            // Materias
            if (File.Exists("subjects.json"))
            {
                subjects = JsonSerializer.Deserialize<List<Subject>>(
                    File.ReadAllText("subjects.json")
                ) ?? new List<Subject>();
            }

            foreach (var subject in subjects)
            {
                subject.Students.Clear();

                if (subject.StudentIds != null)
                {
                    foreach (var id in subject.StudentIds)
                    {
                        var student = students.FirstOrDefault(s => s.Id == id);

                        if (student != null)
                        {
                            subject.Students.Add(student);
                        }
                    }
                }
            }
        }
    }
}

