using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupsApp
{
    class Group
    {
        
        public string No { get; set; }

        public string Category { get; set; }

        public bool IsOnline { get; set; }

        public  List<Student> Students = new List<Student>();
        public int Limit
        {
            get
            {
                if (IsOnline == true)
                {
                    return 15;
                }
                else
                {
                    return 10;
                }

            }
        }

        public Group(string no, string category, bool isOnline)
        {
            No = no;
            Category = category;
            IsOnline = isOnline;

        }   
    }
}
