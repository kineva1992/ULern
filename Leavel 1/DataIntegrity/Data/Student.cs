using System;
using System.Collections.Generic;
using System.Text;

namespace DataIntegrity.Data
{
    class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null) throw new ArgumentException($"{Name} does not support null");
                name = value;
            }
        }

        private static void WriteStudent()
        {
            // ReadName считает неизвестно откуда имя очередного студента
            var student = new Student { Name = ReadName() };
            Console.WriteLine("student " + FormatStudent(student));
        }

        private static string FormatStudent(Student student)
        {
            return student.Name.ToUpper();
        }

        private static string ReadName()
        {
            return "John Daniel";
        }
    }
}
