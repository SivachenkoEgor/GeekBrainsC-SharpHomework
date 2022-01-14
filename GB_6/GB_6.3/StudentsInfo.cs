using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_6._3
{
    public delegate void StudentStatStateHandler(string message);
    class StudentsInfo
    {
        private StudentStatStateHandler stateHandler;
        public void RegisterHandler(StudentStatStateHandler stateHandler)
        {
            this.stateHandler += stateHandler;
        }
        public int StudentCount(List<Student> students)
        {
            stateHandler?.Invoke($"Количество студентов: {students.Count}");
            return students.Count;
        }
        public int GetBachelorsFromList(List<Student> students)
        {
            int bachelorCount = 0;
            foreach (var student in students)
                if (student.course < 5) bachelorCount++;
            stateHandler?.Invoke($"Количество бакалавров: {bachelorCount}");
            return bachelorCount;
        }
        public int GetMastersFromList(List<Student> students)
        {
            int masterCount = 0;
            foreach (var student in students)
                if (student.course >= 5) masterCount++;
            stateHandler?.Invoke($"Количество магистров: {masterCount}");
            return masterCount;
        }
        public string[] GetStudentsFirstNames(List<Student> students)
        {
            string[] firstNames = new string[students.Count];
            for (int i = 0; i < students.Count; i++)
            {
                firstNames[i] = students[i].firstName;
                stateHandler?.Invoke($"{firstNames[i]}");
            }
            return firstNames;

        }

    }
}
