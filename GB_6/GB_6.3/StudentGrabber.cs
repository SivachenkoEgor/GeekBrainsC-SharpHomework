using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GB_6._3
{
    static class StudentGrabber
    {
        static public List<Student> GetListFromFile(string path)
        {

            List <Student>list = new();
            StreamReader sr = new(path);
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                }
                catch (Exception)
                {
                    throw;
                }
            }
            sr.Close();
            return list;
            
        }


    }
}
