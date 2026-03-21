using Proyecto_cshart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Proyecto_cshart
{
    public class AcademicManager
    {

        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();
        private List<Subject> subjects = new List<Subject>();

        public IReadOnlyList<Student> Students => students;
        public IReadOnlyList<Teacher> Teachers => teachers;
        public IReadOnlyList<Subject> Subjects => subjects;

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentException("Error: Esta opcion esta vacia");
            }

            if (students.Contains(student))
            {
                throw new ArgumentException("Error: Este estudiante ya esta registrado");
            }

            students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            if (teacher == null)
            {
                throw new ArgumentException("Error: Esta opcion esta vacia");
            }

            if (teachers.Contains(teacher))
            {
                throw new ArgumentException("Error: Este profesor ya esta registrado");
            }

            teachers.Add(teacher);
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
            if (File.Exists("students.json"))
            {
                students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("students.json"));
            }

            if (File.Exists("teachers.json"))
            {
                teachers = JsonSerializer.Deserialize<List<Teacher>>(File.ReadAllText("teachers.json"));
            }

            if (File.Exists("subjects.json"))
            {
                subjects = JsonSerializer.Deserialize<List<Subject>>(File.ReadAllText("subjects.json"));
            }

            foreach (var subject in subjects)
            {
                subject.Students.Clear();

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
