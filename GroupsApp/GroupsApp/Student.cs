using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupsApp
{
    class Student
    {
        public string Name;

        public Group group;

        public string Type;



        public Student(string name, Group _group, bool type)
        {
            group = _group;
            Name = name;
            if (type==true)
            {
                Type = "Zemanetli";
            }
            else
            {
                Type = "Zemanetsiz";
            } 
        }

       

    }
}
