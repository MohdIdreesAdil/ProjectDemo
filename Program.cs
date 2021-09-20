using System;
using System.IO;
using System.Data.SqlClient;
using ConnectDemo;


namespace ProjectDemo
{
    class Program
    {
        public void Colored()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public void mixcolor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public void Coloblue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        static void Main(string[] args)
        {
            //object for coloring
            Program ob = new Program();
            //for while loop to continue choice
            char choice = 'y';
            //for switch case 
            int sw;
            int th;
            int up;
            // To read char wise from a file 
            int  ch;
            FileStream fs = new FileStream(@"D:\C#\Welcome.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (true)
            {
                ch = Convert.ToInt32(sr.Read());
                if (ch == -1)
                {
                    break;
                }
               else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(Convert.ToChar(ch));
                }

            }
            //login by Admin 
            String s1 = "",s2="";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t Enter Admin User Name = "+s1);
            s1 = Console.ReadLine();
            Console.Write("\t Enter Admin Password = " + s2);
            s2 = Console.ReadLine();
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            if(s1.Equals("idrees786")&&s2.Equals("adil786"))
            {
                while (choice != 'N')
                {
                    Console.WriteLine();
                    Console.WriteLine("\t *************Welcome TO HUMAN RESOURSE MANAGEMENET SYSTEM***************");
                    Console.WriteLine(" Enter 1 For Add Employee. \n Enter 2 For Delete Employee. \n Enter 3 For Update Details Of Employee. \n Enter 4 For Show Whole Table. \n Enter 5 For Show List Of Employee For Given Department. \n Enter 6 For Department Wise Count.  \n Enter 7 For Search Employees By Name/Id/Department.");
                    Console.WriteLine("\t ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                    Console.Write(" \n \t \t \t  Enter Your Choice Here = ");
                    sw = Convert.ToInt32(Console.ReadLine());
                    switch (sw)
                    {
                        case 1:
                            Console.WriteLine("Add Employee ");
                            break;
                        case 2:
                            Console.WriteLine();
                            ob.Colored();
                            Connectme.CreateConnection();
                            Connectme.ShowTable();
                            ob.mixcolor();
                            Console.WriteLine("   Enter The Employee Id To Delete From Table = ");
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.Write(" To Update Name Press         1 \n To Update Department Press   2 \n To Update Salary Press       3 \n To update Email Press        4 \n To Update City Press         5 \n To Update Age Press          6 \n To Update Phone no Press     7 \n Enter Your Choice = ");
                            up = Convert.ToInt32(Console.ReadLine());
                            switch(up)
                            {
                                case 1:
                                    Console.WriteLine(" Name = ");
                                    break;
                                case 2:
                                    Console.WriteLine(" Department = ");
                                    break;
                                case 3:
                                    Console.WriteLine(" Salary = ");
                                    break;
                                case 4:
                                    Console.WriteLine(" Email = ");
                                    break;
                                case 5:
                                    Console.WriteLine(" City = ");
                                    break;
                                case 6:
                                    Console.WriteLine(" Age = ");
                                    break;
                                case 7:
                                    Console.WriteLine(" Phone No = ");
                                    break;
                            }
                            break;
                        case 4:
                            Console.WriteLine();
                            ob.Colored();
                            Connectme.CreateConnection();
                            Connectme.ShowTable();
                            ob.mixcolor();
                            break;
                        case 5:
                            Console.WriteLine();
                            Connectme.CreateConnection();
                            ob.Coloblue();
                            Console.Write(" Enter Department Of Employee = ");
                            string list = Console.ReadLine();
                            ob.Colored();
                            Connectme.searchByDepartment(list);
                            ob.mixcolor();
                            break;
                        case 6:
                            Console.WriteLine();
                            Connectme.CreateConnection();
                            ob.Coloblue();
                            Console.Write(" Enter The Department Of Employees You Want To Count = ");
                            string c = Console.ReadLine();
                            ob.Colored();
                            Connectme.DCount(c);
                            ob.mixcolor();
                            break;
                        case 7:
                            Console.WriteLine("\t <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                            Console.Write(" Enter 1 for Searching Employees by NAME \n Enter 2 for Searching Employees by ID \n Enter 3 for Searching Employees by DEPARTMENT \n Enter Your choice = ");
                            th = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            switch (th)
                            {

                                case 1:
                                    Connectme.CreateConnection();
                                    ob.Coloblue();
                                    Console.Write(" Enter Name Of Employee = ");
                                    string name = Console.ReadLine();
                                    ob.Colored();
                                    Console.WriteLine();
                                    Connectme.searchByName(name);
                                    ob.mixcolor();
                                    break;
                                case 2:
                                    ob.Coloblue();
                                    Console.Write(" Enter The Id Of Employee = ");
                                    Connectme.CreateConnection();
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    ob.Colored();
                                    Console.WriteLine();
                                    Connectme.searchById(id);
                                    ob.mixcolor();
                                    break;
                                case 3:
                                    Connectme.CreateConnection();
                                    ob.Coloblue();
                                    Console.Write(" Enter Department Of Employee = ");
                                    string dept = Console.ReadLine();
                                    ob.Colored();
                                    Console.WriteLine();
                                    Connectme.searchByDepartment(dept);
                                    ob.mixcolor();
                                    break;
                                default:
                                    Console.WriteLine("Invalid Entry Please check again");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Choice Entered");
                            break;
                    }
                    Console.Write("******************************************************************************************");
                    Console.Write(" \n Do You Want To Continue Then Press Y To Stop Press N = ");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n \n *******************************YOU ARE LOGGED OUT FROM THE SYSTEM*****************************");
            }
            else
            {
                    Console.WriteLine("Wrong Password Try Again");
            }

        }
    }
}
