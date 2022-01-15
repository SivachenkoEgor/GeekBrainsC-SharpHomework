using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_6._3
{
    class Student
    {
        public string firstName;
        public string lastName;
        public string university;
        public string faculty;
        
        public string department;
        public int course;
        public int age;
        public int group;
        
        
        public string city;
        // Создаем конструктор
        public Student(string firstName, string lastName, string university, string faculty, string department, int course,  int group, int age, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }

}
