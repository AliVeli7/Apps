using System;
using System.Collections.Generic;

namespace GroupsApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            Student Newstudent;
            List<Group> groups = new List<Group>();
            Group Newgroup;

            for (int i = 1; i != 0; i++)
            {
                Console.WriteLine(" 1.Teni qrup Yarat\n 2.Grouplarin siyahisi\n 3.Qrup uzerinde duzelis \n 4. qrupdaki Telebelerin siyahisi \n 5.Butun telebelerin siyahisi \n 6.telebe yarat");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {       
                    case 1:
                        bool GroupisExist = true;
                        string no=null;
                        while (GroupisExist==true)
                        {
                           Console.WriteLine("Please Enter Group No");
                           no = Console.ReadLine();
                           GroupisExist = false;
                           foreach (var group in groups)
                           {
                             if (group.No == no)
                             {
                                    GroupisExist = true;
                                    Console.WriteLine("Group is Exist");
                             }
                           }
                                
                        }
                        Console.WriteLine("Please Enter Group Category");
                        string category = Console.ReadLine();
                        Console.WriteLine("Do you want to Online Group : true or false?");
                        bool isOnline = Convert.ToBoolean(Console.ReadLine());

                        Newgroup = new Group(no, category, isOnline);
                        groups.Add(Newgroup);
                        break;
                    case 2:
                        foreach (var group in groups)
                        {
                            Console.WriteLine($"No: {group.No} Category: {group.Category} Limit: {group.Limit}");
                        }
                        break;
                    case 3:
                        bool noisExist=false;
                        bool newNoisExist = true;
                        while (noisExist==false&&newNoisExist==true)
                        {
                            Console.WriteLine("Enter group No");
                            string No = Console.ReadLine();
                            foreach (var group in groups)
                            {
                                if (group.No == No)
                                {
                                    noisExist = true;
                                    while (newNoisExist == true)
                                    {
                                        newNoisExist = false;
                                        Console.WriteLine("Enter New No");
                                        string NewNo = Console.ReadLine();
                                        foreach (var checkgroup in groups)
                                        {
                                            if (checkgroup.No == NewNo)
                                            {
                                                newNoisExist = true;
                                                Console.WriteLine("There is the same No in Group list, Please Enter Other Group No");
                                            }
                                        }

                                        if (newNoisExist == false)
                                        {
                                            group.No = NewNo;
                                        }
                                    }
                                }
                            }
                            if (noisExist == false)
                            {
                                Console.WriteLine($"{No} is not Exist");
                            }
                        }
                        
                       

                        break;
                    case 4:
                        Console.WriteLine("Enter group no");
                        string GroupNo = Console.ReadLine();

                        bool isExist = false;
                        while (isExist==false)
                        {
                            foreach (var item in groups)
                            {
                                if (item.No == GroupNo)
                                {
                                    isExist = true;
                                    foreach (var student in students)
                                    {
                                        if (GroupNo == student.group.No)
                                        {
                                            Console.WriteLine($"{student.Name} {student.group.No}");
                                        }
                                        else if (student.group.No== null)
                                        {
                                            Console.WriteLine("Group is Empty");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Group is not exist");
                                }
                            }

                        }
                        
                        break;
                    case 5:
                        foreach (var student1 in students)
                        {
                            Console.WriteLine($"Name: {student1.Name} GroupNo: {student1.group.No} IsOnline: {student1.group.IsOnline}");
                        }
                        break;
                    case 6:
                        bool IsExist = false;
                        Console.WriteLine("Please Enter  Name");
                        string studentName = Console.ReadLine();
                        Console.WriteLine("Do you want to Zemanetli Group :true or false?");
                        bool Type = Convert.ToBoolean(Console.ReadLine());
                        string studentGroup = null;
                        while (IsExist==false)
                        {
                            Console.WriteLine("Enter Group No");
                            studentGroup = Console.ReadLine();
                            foreach (var group in groups)
                            {
                                if (group.No == studentGroup)
                                {
                                    IsExist = true;
                                    Newstudent = new Student(studentName, group, Type);
                                    students.Add(Newstudent);
                                    group.Students.Add(Newstudent);
                                }
                            }

                            if (IsExist==false)
                            {
                                Console.WriteLine("Group is not exist");
                            }
                        }
                        break;
                    default:
                        break;
                }

            }



        }
    }
}
