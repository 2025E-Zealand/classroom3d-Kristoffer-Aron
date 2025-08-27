using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        private string Name { get; set; }
        private int BirthMonth { get; set; }
        private int Birthday { get; set; }

        public Student(string name, int birthmonth, int birthday)
        {
            Name = name;
            BirthMonth = birthmonth;
            Birthday = birthday;
        }
    }
}
